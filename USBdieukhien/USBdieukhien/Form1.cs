using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HIDLib;
using System.Threading;
using System.Data.SqlClient;

namespace USBdieukhien
{
    public partial class Form1 : Form
    {
        HIDDevice dev = new HIDDevice();
        public Thread eh;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");//Chuỗi kết nối CSDL
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        string statusS = string.Empty;
        static int i = 0;
        // Boolean startread = true;
        byte[] data = new byte[9];
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTVTDataSet.USBdieukhien' table. You can move, or remove it, as needed.
            this.uSBdieukhienTableAdapter.Fill(this.dTVTDataSet.USBdieukhien);


            try
            {
                dev.vid = 0x1234;
                dev.pid = 0x0001;
                dev.in_size = 64;
                dev.out_size = 64;
                dev.Initialize();
            }
            catch
            {
                MessageBox.Show("PID & VID Error");
            }
            
            KetNoiCSDL();
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                //dữ liệu được chèn tiếp theo
                i = Int32.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                //trừ 2 vì k tính hàng đầu ID= 0 và hàng cuối để trống trong datagridview
                data = Encoding.ASCII.GetBytes(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value.ToString());
                i++;
            }
            else i = 1; //nếu chưa có dữ liệu thì thêm từ đầu 
            //=============check trạng thái dữ liệu từ CSDL=========
            if (data[1] == '1') btled1.ForeColor = Color.Green;
            else btled1.ForeColor = Color.Red;

            if (data[2] == '1') btled2.ForeColor = Color.Green;
            else btled2.ForeColor = Color.Red;

            if (data[3] == '1') btled3.ForeColor = Color.Green;
            else btled3.ForeColor = Color.Red;

            if (data[4] == '1') btled4.ForeColor = Color.Green;
            else btled4.ForeColor = Color.Red;

            if (data[5] == '1') btled5.ForeColor = Color.Green;
            else btled5.ForeColor = Color.Red;

            if (data[6] == '1') btled6.ForeColor = Color.Green;
            else btled6.ForeColor = Color.Red;

            if (data[7] == '1') btled7.ForeColor = Color.Green;
            else btled7.ForeColor = Color.Red;

            if (data[8] == '1') btled8.ForeColor = Color.Green;
            else btled8.ForeColor = Color.Red;
        }

        protected override void WndProc(ref Message m)
        {
            dev.DeviceChange(ref m);
            base.WndProc(ref m);
            if (!dev.AttachedState)
            {
                Status.Text = "Disconnected!"; Status.ForeColor = Color.Red;
            }
            else
            {
                Status.Text = "Connected!"; Status.ForeColor = Color.Green;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Receivetemp()
        {
            try
            {
                dev.Initialize();
                byte[] reData = new byte[9];//tạo buffer để lưu trữ dữ liệu tạm thời
                reData = dev.Receive();//lưu trữ dữ liệu vào buffer
                //chuyển đổi dữ liệu sang mã ASCII
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                string stringReData = enc.GetString(reData);
                //Cắt chuỗi chỉ nhận tối đa 9 bit dữ liệu gồm byte đầu tiên (byte bắt đầu khoá dữ liệu) + 8 byte điều khiển 08 LED
                string FixReData = stringReData.Substring(0, 9);
                //luu vao csdl
                AutoUpdateDatabases(i, FixReData, statusS, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                i++;
                //Kiem tra trang thai LED
                if (reData[1] == '1') btled1.ForeColor = Color.Green;
                else btled1.ForeColor = Color.Red;

                if (reData[2] == '1') btled2.ForeColor = Color.Green;
                else btled2.ForeColor = Color.Red;

                if (reData[3] == '1') btled3.ForeColor = Color.Green;
                else btled3.ForeColor = Color.Red;

                if (reData[4] == '1') btled4.ForeColor = Color.Green;
                else btled4.ForeColor = Color.Red;

                if (reData[5] == '1') btled5.ForeColor = Color.Green;
                else btled5.ForeColor = Color.Red;

                if (reData[6] == '1') btled6.ForeColor = Color.Green;
                else btled6.ForeColor = Color.Red;

                if (reData[7] == '1') btled7.ForeColor = Color.Green;
                else btled7.ForeColor = Color.Red;

                if (reData[8] == '1') btled8.ForeColor = Color.Green;
                else btled8.ForeColor = Color.Red;
            }
            catch
            { }
        }

        private void KetNoiCSDL()
        {
            //Tạo chuỗi kết nối
            string sql = "select * from USBdieukhien";//lấy dữ liệu từ table ValuegetUSB
            SqlCommand com = new SqlCommand(sql, con);//truy vấn cơ sở dữ liệu
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);//Tải dữ liệu về
            dt = new DataTable();//Tạo không gian ảo lưu trữ dữ liệu
            da.Fill(dt);//Lưu dữ liệu vào không gian lưu trữ
            con.Close();//Đóng kết nối
            dataGridView1.DataSource = dt;//Gán dữ liệu vào DatagridView
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;//autoscroll datagridview to end point
        }

        //==hàm tự động lưu dữ liệu vào csdl==============
        private delegate void dlgAutoUpdateDatabases(long stt, string DataS, string statusS, string TimeCreated);
        private void AutoUpdateDatabases(long stt, string DataS, string statusS, string TimeCreated)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabases), stt, DataS, statusS, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO USBdieukhien (ID, DataSend, Status ,Time) VALUES (@ID, @DataSend, @Status, @Time)", con);
                //nhóm lệnh truy xuất SQL
                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@DataSend", DataS);
                cmd.Parameters.Add("@Status", statusS);
                cmd.Parameters.Add("@Time", TimeCreated);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    con.Close();
                    // MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KetNoiCSDL();
            }
        }

        private void btled1_Click(object sender, EventArgs e)
        {
            if (btled1.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[1] = Convert.ToByte('1');
                btled1.ForeColor = Color.Green;
                statusS = "LED1 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[1] = Convert.ToByte('0');
                btled1.ForeColor = Color.Red;
                statusS = "LED1 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled2_Click(object sender, EventArgs e)
        {
            if (btled2.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[2] = Convert.ToByte('1');
                btled2.ForeColor = Color.Green;
                statusS = "LED2 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[2] = Convert.ToByte('0');
                btled2.ForeColor = Color.Red;
                statusS = "LED2 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();

        }

        private void btled3_Click(object sender, EventArgs e)
        {
            if (btled3.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[3] = Convert.ToByte('1');
                btled3.ForeColor = Color.Green;
                statusS = "LED3 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[3] = Convert.ToByte('0');
                btled3.ForeColor = Color.Red;
                statusS = "LED3 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled4_Click(object sender, EventArgs e)
        {
            if (btled4.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[4] = Convert.ToByte('1');
                btled4.ForeColor = Color.Green;
                statusS = "LED4 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[4] = Convert.ToByte('0');
                btled4.ForeColor = Color.Red;
                statusS = "LED4 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled5_Click(object sender, EventArgs e)
        {
            if (btled5.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[5] = Convert.ToByte('1');
                btled5.ForeColor = Color.Green;
                statusS = "LED5 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[5] = Convert.ToByte('0');
                btled5.ForeColor = Color.Red;
                statusS = "LED5 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled6_Click(object sender, EventArgs e)
        {
            if (btled6.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[6] = Convert.ToByte('1');
                btled6.ForeColor = Color.Green;
                statusS = "LED6 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[6] = Convert.ToByte('0');
                btled6.ForeColor = Color.Red;
                statusS = "LED6 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled7_Click(object sender, EventArgs e)
        {
            if (btled7.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[7] = Convert.ToByte('1');
                btled7.ForeColor = Color.Green;
                statusS = "LED7 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[7] = Convert.ToByte('0');
                btled7.ForeColor = Color.Red;
                statusS = "LED7 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btled8_Click(object sender, EventArgs e)
        {
            if (btled8.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                data[8] = Convert.ToByte('1');
                btled8.ForeColor = Color.Green;
                statusS = "LED8 ON";
            }
            else
            {
                data[0] = Convert.ToByte('1');
                data[8] = Convert.ToByte('0');
                btled8.ForeColor = Color.Red;
                statusS = "LED8 OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }

        private void btall_Click(object sender, EventArgs e)
        {
            if (btall.ForeColor == Color.Red)
            {
                data[0] = Convert.ToByte('1');
                for (int i = 1; i <= 8; i++)
                {
                    data[i] = Convert.ToByte('1');
                }
                btall.Text = "All ON";
                btall.ForeColor = Color.Green;
                statusS = "ALL ON";
            }
            else
            {
                data[0] = Convert.ToByte('1'); ;
                for (int i = 1; i <= 8; i++)
                {
                    data[i] = Convert.ToByte('0'); ;
                }
                btall.Text = "All OFF";
                btall.ForeColor = Color.Red;
                statusS = "ALL OFF";
            }

            if (!dev.Transmit(data))
            {
                MessageBox.Show("Thiet bi chua san sang");
                return;
            }
            //kiem tra trang thai Bat/tat LED
            Receivetemp();
        }



    }
}
