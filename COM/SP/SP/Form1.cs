using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Data.SqlClient;

namespace SP
{
    public partial class Form1 : Form
    {
        int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
            getAvailblePort();
            try
            {
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            }
            catch{}
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");
        SqlCommandBuilder UpdateCSDL;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        void getAvailblePort()
        {
            getCOM.Items.Clear();
            getBaudRate.Items.Clear();
            string[] portsCOM = SerialPort.GetPortNames();
            getCOM.Items.AddRange(portsCOM);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            getBaudRate.Items.AddRange(BaudRate);
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                String InputData = serialPort1.ReadLine();
                if (getTemp.InvokeRequired)
                {
                    getTemp.Invoke((MethodInvoker)
                        delegate { getTemp.AppendText(InputData + Environment.NewLine); });
                }
                else getTemp.AppendText(InputData + Environment.NewLine);
            }
            catch
            {
                return;
            }
        }

        private void SendData(String data)
        {
            try { 
                if(serialPort1.IsOpen)
                {
                    serialPort1.Write(data + "\r\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void loadData()
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                
                Temp.Text = dataGridView1["Temp", rowIndex].Value.ToString();
                Light.Text = dataGridView1["TimeCreat", rowIndex].Value.ToString();
            }
            else
            {
                
                Temp.Text = string.Empty;
                Light.Text = string.Empty;
            }

        }

        private void ReGetCOM_Click(object sender, EventArgs e)
        {
            getAvailblePort();
        }

        private void KetNoi_Click(object sender, EventArgs e)
        {
            string sql = "select * from COM";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            
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
                            MessageBox.Show(getCOM.Text + " is denied", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (serialPort1.IsOpen)
                        {
                            KetNoi.Text = ("Da Ket Noi");
                            KetNoi.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access to the port " + getCOM.Text + " is denied", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay chon BaudRate", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
                KetNoi.Text = ("Ket Noi");
                KetNoi.ForeColor = Color.Red;
            }
        }

        private void XoaDuLieu_Click(object sender, EventArgs e)
        {
            getTemp.Text = null;
            SendData("PC K15");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTVTDataSet.COM' table. You can move, or remove it, as needed.
            this.cOMTableAdapter.Fill(this.dTVTDataSet.COM);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        

        
    }
}
