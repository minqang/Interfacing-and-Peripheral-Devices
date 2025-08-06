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

namespace USB
{
    public partial class Form1 : Form
    {
        HIDDevice dev = new HIDDevice();
        static int countChar = 0;
        string InputDataTime = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        public Thread eh;
        float temp, light;
        delegate void SetTextCallback(string text); //Khai bao delegate SetTextCallBack voi tham so string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");//Chuỗi kết nối CSDL
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        static int i = 0;
        Boolean startread = true;
        byte[] data = new byte[9];
        string statusS = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            chart1.ChartAreas[0].AxisX.Minimum = 0;//số Giá trị hiển thị nhỏ nhất của x là 0
            chart1.ChartAreas[0].AxisX.Interval = 5;//Đơn vị hiển thị là trục x la 10 đơn vị
            // chart1.ChartAreas[0].AxisX.Maximum = 20;//số Giá trị hiển thị lớn nhất của x là 10
            //==========kiểm tra dữ liệu trong csdl
            KetNoiCSDL();
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                //dữ liệu được chèn tiếp theo
                i = Int32.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                i++;
            }
            else i = 1; //nếu chưa có dữ liệu thì thêm từ đầu
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTVTDataSet1.USBdieukhien' table. You can move, or remove it, as needed.
            this.uSBdieukhienTableAdapter.Fill(this.dTVTDataSet1.USBdieukhien);
            // TODO: This line of code loads data into the 'dTVTDataSet.COM' table. You can move, or remove it, as needed.
            this.cOMTableAdapter.Fill(this.dTVTDataSet.COM);

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
            if (dataGridView2.Rows.Count - 1 > 0)
            {
                //dữ liệu được chèn tiếp theo
                i = Int32.Parse(dataGridView1.Rows[dataGridView2.Rows.Count - 2].Cells[0].Value.ToString());
                //trừ 2 vì k tính hàng đầu ID= 0 và hàng cuối để trống trong datagridview
                data = Encoding.ASCII.GetBytes(dataGridView2.Rows[dataGridView2.Rows.Count - 2].Cells[1].Value.ToString());
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

        private void getUSB_Click(object sender, EventArgs e)
        {
            startread = true;
            KetNoiCSDL();
            Thread.Sleep(100);
            eh = new Thread(new ThreadStart(ReceiveTEMP));//Khởi tạo thread chạy hàm nhận dữ liêu từ USB
            eh.Start();//chạy thread

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Nếu ấn thoát…Thoát chương trình
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Design by Quang", "Tác giả");
        }

        private void BTStop_Click(object sender, EventArgs e)
        {
            startread = false;
            try
            {
                eh.Abort();//chạy thread
                Thread.Sleep(100);
            }
            catch
            {
                eh = new Thread(new ThreadStart(ReceiveTEMP));//Khởi tạo thread chạy hàm nhận dữ liêu từ USB
                eh.Start();//chạy thread
                Thread.Sleep(100);
                eh.Abort();//chạy thread
            }
        }

        private void BTDelAll_Click(object sender, EventArgs e)
        {
            getData.Text = string.Empty;
            con.Open();
            cmd = new SqlCommand("DELETE FROM COM", con); // xoá hết dữ liệu Table
            cmd.ExecuteNonQuery();
            KetNoiCSDL();
            i = 0;//Nếu xoá sạch database thì lưu dữ liệu với STT từ đầu
            //  while (chart1.Series.Count > 0) { chart1.Series.RemoveAt(0); }
            //  countChar = 0;
        }

        protected override void WndProc(ref Message m)
        {
            dev.DeviceChange(ref m);
            base.WndProc(ref m);
            if (!dev.AttachedState)
            {
                status.Text = "Disconnected!"; status.ForeColor = Color.Red;
            }
            else
            {
                status.Text = "Connected!"; status.ForeColor = Color.Green;
            }

        }

        public void ReceiveTEMP()
        {
            do
            {
                try
                {
                    dev.Initialize();
                    byte[] reData = new byte[64];
                    string var1, var2;

                    reData = dev.Receive();
                    InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    System.Text.Encoding enc = System.Text.Encoding.ASCII;
                    string stringReData = enc.GetString(reData);
                    SetText(stringReData);
                    SetText("\r\n");
                    if ((stringReData.IndexOf('@') != -1) && (stringReData.IndexOf('#') != -1))//Kiểm tra định dạng dữ liệu có @ và $ không
                    {
                        //================tách giá trị thứ nhất==========
                        if ((stringReData.IndexOf('$') != -1) && (stringReData.IndexOf('@') < (stringReData.IndexOf('$') - 1)))
                        { //neu co ký tự '#' và vị trí ký tự '#' ko liền kề sau @ thi doc value1
                            var1 = stringReData.Substring(stringReData.IndexOf('@') + 1, stringReData.IndexOf('$') - 1);
                            //  chuoiNumber1 = Convert.ToUInt64(var1); //chuyen sang so nguyen kieu int
                            temp = float.Parse(var1);//chuyen sang so nguyen
                            //hien thi len textbox
                            if (getTemp.InvokeRequired)
                            {
                                getTemp.Invoke((MethodInvoker)delegate { getTemp.Text = temp.ToString(); });
                            }
                            else getTemp.Text = temp.ToString();
                        }

                        if (stringReData.IndexOf('$') < (stringReData.IndexOf('#') - 1))
                        { //neu co ký tự '#' và vị trí ký tự '#' ko liền kề sau @ thi doc value1
                            var2 = stringReData.Substring(stringReData.IndexOf('$') + 1, stringReData.IndexOf('#') - stringReData.IndexOf('$') - 1);
                            //  chuoiNumber1 = Convert.ToUInt64(var1); //chuyen sang so nguyen kieu int
                            light = float.Parse(var2);//chuyen sang so nguyen
                            //hien thi len textbox
                            if (getLight.InvokeRequired)
                            {
                                getLight.Invoke((MethodInvoker)delegate { getLight.Text = light.ToString(); });
                            }
                            else getLight.Text = light.ToString();
                        }

                    }
                    countChar++;//Điếm số dữ liệu được vẽ lên char1
                    drawChar();
                    AutoUpdateDatabases(i, temp.ToString(), light.ToString(), InputDataTime);
                    i++;
                }
                catch
                { }
            }
            while (startread == true);
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

        private void Form1_Activated(object sender, EventArgs e)
        {
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
        }

        private void SetText(string text)// hàm hiển thị dữ liệu temp tránh lỗi cross threading
        {

            if (this.getData.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else
            {
                getData.Text += text;//hien thi list du lieu
                //===============tu dong cuon du lieu textbox
                getData.SelectionStart = getData.Text.Length;
                getData.ScrollToCaret();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private delegate void dlgdrawChar();
        private void drawChar()
        {
            if (this.chart1.InvokeRequired)
            {
                this.Invoke(new dlgdrawChar(drawChar));
            }
            else
            {
                try
                {
                    //=========================
                    this.chart1.Series["Temp"].Points.AddXY(countChar, temp);
                    this.chart1.Series["Light"].Points.AddXY(countChar, light);
                }
                catch { }
            }
        }

        private void KetNoiCSDL()
        {
            //Tạo chuỗi kết nối
            string sql = "select * from COM";//lấy dữ liệu từ table ValueStatus
            SqlCommand com = new SqlCommand(sql, con);//truy vấn cơ sở dữ liệu
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);//Tải dữ liệu về
            dt = new DataTable();//Tạo không gian ảo lưu trữ dữ liệu
            da.Fill(dt);//Lưu dữ liệu vào không gian lưu trữ
            con.Close();//Đóng kết nối
            dataGridView1.DataSource = dt;//Gán dữ liệu vào DatagridView
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;//autoscroll datagridview to end point
        }


        private delegate void dlgAutoUpdateDatabases(long stt, string intTemp, string intLight, string TimeCreated);
        private void AutoUpdateDatabases(long stt, string intTemp, string intLight, string TimeCreated)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabases), stt, intTemp, intLight, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO COM (ID,Temp, Light,TimeCreate VALUES (@ID,@Temp , @Light,@TimeCreate)", con);
                //nhóm lệnh truy xuất SQL
                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@Light", intLight);
                cmd.Parameters.Add("@Temp", intTemp);
                cmd.Parameters.Add("@TimeCreate", TimeCreated);
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

        private delegate void dlgAutoUpdateDatabase(long stt, string DataS, string statusS, string TimeCreated);
        private void AutoUpdateDatabase(long stt, string DataS, string statusS, string TimeCreated)
        {
            if (this.dataGridView2.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabase(AutoUpdateDatabase), stt, DataS, statusS, TimeCreated);
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
