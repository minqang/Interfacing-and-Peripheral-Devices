using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Data.SqlClient;

namespace DieuKhien
{
    public partial class abc : Form
    {
        public abc()
        {
            InitializeComponent();
            timer1.Start();
            getAvailblePort();
            try
            {
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            }
            catch { }
            

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");
        SqlCommand com;
        
        SqlDataAdapter da;
        DataTable dt;

        void getAvailblePort()
        {
            getCOM.Items.Clear();
            getBaudRate.Items.Clear();
            string[] portsCOM = SerialPort.GetPortNames();
            getCOM.Items.AddRange(portsCOM);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            getBaudRate.Items.AddRange(BaudRate);
        }

        private void KetNoiCSDL()
        {

            string sql = "SELECT * FROM DieuKhien ";
            com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt; ;//Gán dữ liệu vào DatagridView
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTVTDataSet.DieuKhien' table. You can move, or remove it, as needed.
            this.dieuKhienTableAdapter.Fill(this.dTVTDataSet.DieuKhien);

        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                String InputData = serialPort1.ReadLine();
                
                if (textBox.InvokeRequired)
                {
                    textBox.Invoke((MethodInvoker)
                        delegate
                        {
                            textBox.AppendText(InputData + "\n");
                            
                        });
                }
                else textBox.AppendText(InputData + Environment.NewLine);
            }
            catch
            {
                return;
            }
        }

        private void SendData(String data)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(data + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");  
        }

        private void KetNoi_Click(object sender, EventArgs e)
        {
            con.Open();
            KetNoiCSDL();
            con.Close();
            dataGridView1.Enabled = true;

            if (!serialPort1.IsOpen)
            {
                if (getBaudRate.Text.Length != 0)
                {
                    if (getCOM.Text.Length != 0)
                    {
                        try
                        {
                            serialPort1.PortName = getCOM.Text;
                            serialPort1.BaudRate = Convert.ToInt32(getBaudRate.Text);
                            serialPort1.Parity = Parity.None;
                            serialPort1.DataBits = 8;
                            serialPort1.StopBits = StopBits.One;
                            serialPort1.Open();
                        }
                        catch
                        {
                            MessageBox.Show(getCOM.Text + " is denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (serialPort1.IsOpen)
                        {
                            KetNoi.Text = ("Ngat Ket Noi");
                            label.Text = ("Da Ket Noi");
                            label.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access to the port " + getCOM.Text + " is denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay chon BaudRate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
                KetNoi.Text = ("Ket Noi");
                label.Text = ("Ngat Ket Noi");
                label.ForeColor = Color.Red;
            }
        }

        private void ON1_Click(object sender, EventArgs e)
        {
            SendData("ON1");
        }

        private void ON2_Click(object sender, EventArgs e)
        {
            SendData("ON2");
        }

        private void ONALL_Click(object sender, EventArgs e)
        {
            SendData("AllON");
        }

        private void OFF1_Click(object sender, EventArgs e)
        {
            SendData("OFF1");
        }

        private void OFF2_Click(object sender, EventArgs e)
        {
            SendData("OFF2");
        }

        private void OFFALL_Click(object sender, EventArgs e)
        {
            SendData("OFFAll");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = getSearch.Text;

                if (!string.IsNullOrWhiteSpace(query))
                {
                    com = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    DataTable resultsTable = new DataTable();
                    adapter.Fill(resultsTable);

                    dataGridView2.DataSource = resultsTable;
                    dataGridView2.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please enter a valid SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = getUpdate.Text.Trim();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    if (query.StartsWith("UPDATE", StringComparison.OrdinalIgnoreCase))
                    {
                        com = new SqlCommand(query, con);
                        int rowsAffected = com.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            com = new SqlCommand("SELECT * FROM COM", con);
                            SqlDataAdapter adapter = new SqlDataAdapter(com);
                            DataTable resultsTable = new DataTable();
                            adapter.Fill(resultsTable);

                            dataGridView2.DataSource = resultsTable;
                            dataGridView2.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected by the update query.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid UPDATE SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = getDel.Text.Trim();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    if (query.StartsWith("DELETE", StringComparison.OrdinalIgnoreCase))
                    {
                        com = new SqlCommand(query, con);
                        int rowsAffected = com.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            com = new SqlCommand("SELECT * FROM COM", con);
                            SqlDataAdapter adapter = new SqlDataAdapter(com);
                            DataTable resultsTable = new DataTable();
                            adapter.Fill(resultsTable);

                            dataGridView2.DataSource = resultsTable;
                            dataGridView2.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected by the update query.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid DELETE SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = getAdd.Text.Trim();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    if (query.StartsWith("INSERT", StringComparison.OrdinalIgnoreCase))
                    {
                        com = new SqlCommand(query, con);
                        int rowsAffected = com.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            com = new SqlCommand("SELECT * FROM COM", con);
                            SqlDataAdapter adapter = new SqlDataAdapter(com);
                            DataTable resultsTable = new DataTable();
                            adapter.Fill(resultsTable);

                            dataGridView2.DataSource = resultsTable;
                            dataGridView2.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected by the update query.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid INSERT SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
