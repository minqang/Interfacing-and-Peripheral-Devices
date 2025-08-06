using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH2
{
    public partial class Form1 : Form
    {
        int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGDM6GR\SQLEXPRESS;Initial Catalog=DTVT;Integrated Security=True");
        SqlCommandBuilder UpdateCSDL;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTVTDataSet.ValueTemp' table. You can move, or remove it, as needed.
            this.valueTempTableAdapter.Fill(this.dTVTDataSet.ValueTemp);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            getRealTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private void KetNoiCSDL()
        {
            string sql = "select * from ValueTemp";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void BTClick_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO ValueTemp (ID,Value,TimeCreat) VALUES (@ID,@Value,@TimeCreat)", con);
                cmd.Parameters.Add("@ID", getID.Text);
                cmd.Parameters.Add("@Value", getTemp.Text);
                cmd.Parameters.Add("@TimeCreat", getDateTime.Text);
                //cmd.Parameters.Add("@TimeCreat", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff"));
                cmd.ExecuteNonQuery();
                KetNoiCSDL();
                con.Close();
            }
            catch
            {
                MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            BTRepair.Enabled = true;
            BTUpdate.Enabled = true;
            BTDel.Enabled = true;
            loadData();
    
        }

        private void loadData()
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                BTDel.Enabled = true;
                BTUpdate.Enabled = true;
                BTDelAll.Enabled = true;
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                getID.Text = dataGridView1["ID", rowIndex].Value.ToString();
                getTemp.Text = dataGridView1["Value", rowIndex].Value.ToString();
                getDateTime.Text = dataGridView1["TimeCreat", rowIndex].Value.ToString();
            }
            else
            {
                getID.Text = string.Empty;
                getTemp.Text = string.Empty;
                getDateTime.Text = string.Empty;
            }

        }

        private void BTViewData_Click(object sender, EventArgs e)
        {
            con.Open();
            KetNoiCSDL();
            loadData();
            con.Close();
            dataGridView1.Enabled = true;

        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            UpdateCSDL = new SqlCommandBuilder(da);//Cập nhập CSDL moi
            try
            { 
                da.Update(dt);//Update dữ liệu vào bảng
                con.Close();
                BTUpdate.Enabled = false;
                MessageBox.Show("Sucess", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch{
                MessageBox.Show("Value is Fail", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return; }
            loadData();

        }

        private void BTDelAll_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM ValueTemp", con);
            cmd.ExecuteNonQuery();
            KetNoiCSDL();
            loadData();
            MessageBox.Show("Delete All Data Sucess", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            BTDel.Enabled = false;
            BTDelAll.Enabled = false;
            BTRepair.Enabled = false;
            BTUpdate.Enabled = false;

        }

        private void BTDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex;//chọn hàng được click
                dataGridView1.Rows.RemoveAt(rowIndex);//xoá hàng
                BTUpdate.Enabled = true;
                MessageBox.Show("Sucess", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                BTUpdate.Enabled = false;
                BTDel.Enabled = false;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch{}

        }

        private void BTRepair_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1[0, rowIndex].Value = getID.Text;
            dataGridView1[1, rowIndex].Value = getTemp.Text;
            dataGridView1[2, rowIndex].Value = getDateTime.Text;
            this.BindingContext[this.dataGridView1.DataSource].EndCurrentEdit();
            // this.dataGridView1.Refresh(); 
            //this.dataGridView1.Parent.Refresh();
            BTUpdate.Enabled = true;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getID.Enabled = true;
            getTemp.Enabled = true;
            getDateTime.Enabled = true;
            dataGridView1.Enabled = true;
            BTClick.Enabled = true;

            if (dataGridView1.Rows.Count - 1 > 0)
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex;//chọn hàng được click
                getID.Text = dataGridView1["ID", rowIndex].Value.ToString();
                getTemp.Text = dataGridView1["Value", rowIndex].Value.ToString();
                getDateTime.Text = dataGridView1["TimeCreat", rowIndex].Value.ToString();
                if (getID.Text == string.Empty)
                {
                    BTClick.Enabled = true;
                    BTRepair.Enabled = false;
                    BTDel.Enabled = false;
                }
                else
                {
                    BTRepair.Enabled = true;
                    BTClick.Enabled = false;
                    BTDel.Enabled = true;
                    BTRepair.Enabled = true;
                }
            }

        }

        

        
       
    }
}
