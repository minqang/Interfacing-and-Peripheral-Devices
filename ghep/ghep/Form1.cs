using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ghep
{
    public partial class Form1 : Form
    {
        string dataReceive = string.Empty;
        float temp, light;
        long countData;
        int PORT = 0;
        public delegate void logCallback(string logLine);
        Socket clientsock, serversock;
        public Thread th, eh, controlClient;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        static int i = 1;
        int rowIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (open.Text.Equals("Open Socket"))
            {
                OpenSocket();
            }
            else
            {
                CloseSocket();
            }
        }

        private void OpenSocket()
        {
            try
            {
                open.Enabled = true;
                String strHostName = Dns.GetHostName();
                IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
                foreach (IPAddress ipaddress in iphostentry.AddressList)
                {
                    if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        lanip.Text = ipaddress.ToString();
                        break;
                    }
                }

                open.Text = "Close Socket";
                open.Enabled = true;
                t_port.Enabled = false;

                eh = new Thread(new ThreadStart(acceptClient));
                eh.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening socket: " + ex.Message);
            }
        }

        private void CloseSocket()
        {
            open.Enabled = false;

            if (eh != null && eh.IsAlive) eh.Abort();
            if (th != null && th.IsAlive) th.Abort();

            try
            {
                clientsock.Close();
            }
            catch { }

            serversock.Close();

            ipc.Text = string.Empty;
            open.Text = "Open Socket";
            open.Enabled = true;
            t_port.Enabled = true;
        }

        public void Reconnect()
        {
            try
            {
                String strHostName = Dns.GetHostName();
                IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
                foreach (IPAddress ipaddress in iphostentry.AddressList)
                {
                    if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        lanip.Text = ipaddress.ToString();
                        break;
                    }
                }

                open.Text = "Close Socket";
                open.Enabled = true;

                eh = new Thread(new ThreadStart(acceptClient));
                eh.Start();
            }
            catch (Exception ex)
            {
                ipc.Invoke((MethodInvoker)delegate { ipc.Text = "Socket error: " + ex.Message; });
            }
        }

        public void acceptClient()
        {
            try
            {
                if (string.IsNullOrEmpty(t_port.Text))
                {
                    if (t_port.InvokeRequired)
                    {
                        t_port.Invoke((MethodInvoker)delegate { t_port.Text = "1234"; });
                    }
                    else
                    {
                        t_port.Text = "1234";
                    }
                }

                PORT = int.Parse(t_port.Text);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);
                
                serversock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serversock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                serversock.Bind(ipep);
                serversock.Listen(1);


                while (true)
                {
                    clientsock = serversock.Accept();

                    if (th != null && th.IsAlive) th.Abort();
                    th = new Thread(new ThreadStart(server));
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }

        }

        private void SetText(string text)
        {

            if (InvokeRequired) this.Invoke(new logCallback(SetText), new object[] { text });
            else getData.AppendText(text + Environment.NewLine);
        }

        public void server()
        {

            if (open.Text.Equals("Close Socket"))
            {
                try
                {
                    IPEndPoint clientep = (IPEndPoint)clientsock.RemoteEndPoint;
                    string ipclient = Convert.ToString(clientep.Address);
                    Int16 portclient = Convert.ToInt16(clientep.Port);
                    ipc.Invoke((MethodInvoker)delegate { ipc.Text = ipclient; });
                }
                catch (Exception ex)
                {
                    ipc.Invoke((MethodInvoker)delegate { ipc.Text = "Cannot receive IP: " + ex.Message; });
                    serversock.Close();
                    Reconnect();
                }

                while (clientsock.Available < 100)
                {
                    clientsock.ReceiveBufferSize = 10000;
                    byte[] data = new byte[10000];
                    string var1, var2;
                    string InputDataTime = String.Empty;

                    clientsock.Receive(data);

                    dataReceive = Encoding.ASCII.GetString(data);

                    if (dataReceive != string.Empty)
                    {
                        SetText(dataReceive);
                        InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        if ((dataReceive.IndexOf('@') != -1) && (dataReceive.IndexOf('#') != -1) && (dataReceive.IndexOf('@') < (dataReceive.IndexOf('t') - 1)) && (dataReceive.IndexOf('t') < (dataReceive.IndexOf('#') - 1)))//Kiểm tra định dạng dữ liệu có @ và % không
                        {
                            countData++;
                            SetText(" >>Count Data =" + countData);
                            if ((dataReceive.IndexOf('t') != -1) && (dataReceive.IndexOf('@') < (dataReceive.IndexOf('t') - 1)))
                            {
                                var1 = dataReceive.Substring(dataReceive.IndexOf('@') + 1, dataReceive.IndexOf('t') - 1);
                                temp = float.Parse(var1);
                                if (tb_temp.InvokeRequired)
                                {
                                    tb_temp.Invoke((MethodInvoker)delegate { tb_temp.Text = temp.ToString(); });
                                }
                                else tb_temp.Text = temp.ToString();
                            }

                            if ((dataReceive.IndexOf('#') != -1) && (dataReceive.IndexOf('t') < (dataReceive.IndexOf('#') - 1)))
                            {
                                var2 = dataReceive.Substring(dataReceive.IndexOf('t') + 1, dataReceive.IndexOf('#') - dataReceive.IndexOf('t') - 1);

                                light = float.Parse(var2);
                                if (tb_light.InvokeRequired)
                                {
                                    tb_light.Invoke((MethodInvoker)delegate { tb_light.Text = light.ToString(); });
                                }
                                else tb_light.Text = light.ToString();
                            }
                            IPEndPoint clientep = (IPEndPoint)clientsock.RemoteEndPoint;
                            string ipclient = Convert.ToString(clientep.Address);
                            AutoUpdateDatabases(i, ipclient, temp.ToString(), light.ToString(), InputDataTime);
                            i++;
                        }
                    }

                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            getData.Text = string.Empty;
            con.Open();
            cmd = new SqlCommand("DELETE FROM LAN", con);
            cmd.ExecuteNonQuery();
            KetNoiCSDL();
            i = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            KetNoiCSDL();
            if (dataGridView1.Rows.Count > 1)
            {
                i = Int32.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                i++;
            }
            else i = 1;
        }

        private void KetNoiCSDL()
        {
            string sql = "select * from LAN";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private delegate void dlgAutoUpdateDatabases(long stt, string vaIPClient, string vaTemp, string vaLight, string TimeCreated);
        private void AutoUpdateDatabases(long stt, string vaIPClient, string vaTemp, string vaLight, string TimeCreated)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabase), stt, vaIPClient, vaTemp, vaLight, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO LAN (ID,IPClient,Light,Temp,TimeCreat) VALUES (@ID,@IPClient,@Light,@Temp,@TimeCreat)", con);
                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@IPClient", vaIPClient);
                cmd.Parameters.Add("@Light", vaLight);
                cmd.Parameters.Add("@Temp", vaTemp);
                cmd.Parameters.Add("@TimeCreat", TimeCreated);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KetNoiCSDL();
            }
        }

        private delegate void dlgAutoUpdateDatabases(long stt, string vaIPClient, string vaCommand, string vaStatus, string TimeCreated);
        private void AutoUpdateDatabase(long stt, string vaIPClient, string vaCommand, string vaStatus, string TimeCreated)
        {
            if (this.dataGridView2.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabases), stt, vaIPClient, vaCommand, vaStatus, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO LANcontrol (ID,IPClient,Command,Status,TimeCreat) VALUES (@ID,@IPClient,@Command,@Status,@TimeCreat)", con);

                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@IPClient", vaIPClient);
                cmd.Parameters.Add("@Command", vaCommand);
                cmd.Parameters.Add("@Status", vaStatus);
                cmd.Parameters.Add("@TimeCreat", TimeCreated);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Close();
                KetNoiCSDL();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.CurrentCell.RowIndex;//chọn hàng được click
            if (open.Text.Equals("Open Socket"))
            {
                ipc.Text = dataGridView1["iPClientDataGridViewTextBoxColumn", rowIndex].Value.ToString();
                tb_temp.Text = dataGridView1["tempDataGridViewTextBoxColumn", rowIndex].Value.ToString();
                tb_light.Text = dataGridView1["lightDataGridViewTextBoxColumn", rowIndex].Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bton1_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@1$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();

            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);

            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Bật TB1", InputDataTime);
            i++;
        }

        private void bton2_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@2$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();

            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);

            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Bật TB2", InputDataTime);
            i++;
        }

        private void btallon_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@4$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();
            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);
            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Bật hết", InputDataTime);
            i++;
        }

        private void btoff1_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@0$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();
            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);
            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Tắt TB1", InputDataTime);
            i++;
        }

        private void btoff2_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@3$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();
            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);
            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Tắt TB2", InputDataTime);
            i++;
        }

        private void btalloff_Click(object sender, EventArgs e)
        {
            byte[] command = Encoding.UTF8.GetBytes("@5$\n");
            SetText(System.Text.Encoding.UTF8.GetString(command));
            server();
            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);
            }
            else ipc.Text = "Loi socket";
            string InputDataTime = String.Empty;
            InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            AutoUpdateDatabases(i, ipc.Text, System.Text.Encoding.UTF8.GetString(command), "Tắt hết", InputDataTime);
            i++;
        }

        

        

    }
}
