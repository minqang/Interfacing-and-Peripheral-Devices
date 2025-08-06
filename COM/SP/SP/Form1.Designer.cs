namespace SP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.getCOM = new System.Windows.Forms.ComboBox();
            this.getBaudRate = new System.Windows.Forms.ComboBox();
            this.a = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReGetCOM = new System.Windows.Forms.Button();
            this.XoaDuLieu = new System.Windows.Forms.Button();
            this.KetNoi = new System.Windows.Forms.Button();
            this.getTemp = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Light = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet = new SP.DTVTDataSet();
            this.cOMTableAdapter = new SP.DTVTDataSetTableAdapters.COMTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getCOM
            // 
            this.getCOM.FormattingEnabled = true;
            this.getCOM.Location = new System.Drawing.Point(115, 168);
            this.getCOM.Name = "getCOM";
            this.getCOM.Size = new System.Drawing.Size(121, 21);
            this.getCOM.TabIndex = 0;
            // 
            // getBaudRate
            // 
            this.getBaudRate.FormattingEnabled = true;
            this.getBaudRate.Location = new System.Drawing.Point(115, 215);
            this.getBaudRate.Name = "getBaudRate";
            this.getBaudRate.Size = new System.Drawing.Size(121, 21);
            this.getBaudRate.TabIndex = 1;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(45, 168);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(31, 13);
            this.a.TabIndex = 2;
            this.a.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // ReGetCOM
            // 
            this.ReGetCOM.Location = new System.Drawing.Point(48, 264);
            this.ReGetCOM.Name = "ReGetCOM";
            this.ReGetCOM.Size = new System.Drawing.Size(75, 23);
            this.ReGetCOM.TabIndex = 4;
            this.ReGetCOM.Text = "Lam moi";
            this.ReGetCOM.UseVisualStyleBackColor = true;
            this.ReGetCOM.Click += new System.EventHandler(this.ReGetCOM_Click);
            // 
            // XoaDuLieu
            // 
            this.XoaDuLieu.Location = new System.Drawing.Point(48, 312);
            this.XoaDuLieu.Name = "XoaDuLieu";
            this.XoaDuLieu.Size = new System.Drawing.Size(75, 23);
            this.XoaDuLieu.TabIndex = 5;
            this.XoaDuLieu.Text = "Xoa";
            this.XoaDuLieu.UseVisualStyleBackColor = true;
            this.XoaDuLieu.Click += new System.EventHandler(this.XoaDuLieu_Click);
            // 
            // KetNoi
            // 
            this.KetNoi.Location = new System.Drawing.Point(129, 262);
            this.KetNoi.Name = "KetNoi";
            this.KetNoi.Size = new System.Drawing.Size(75, 23);
            this.KetNoi.TabIndex = 6;
            this.KetNoi.Text = "Ket Noi";
            this.KetNoi.UseVisualStyleBackColor = true;
            this.KetNoi.Click += new System.EventHandler(this.KetNoi_Click);
            // 
            // getTemp
            // 
            this.getTemp.AcceptsReturn = true;
            this.getTemp.AcceptsTab = true;
            this.getTemp.AllowDrop = true;
            this.getTemp.BackColor = System.Drawing.SystemColors.Info;
            this.getTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.getTemp.Location = new System.Drawing.Point(48, 24);
            this.getTemp.Multiline = true;
            this.getTemp.Name = "getTemp";
            this.getTemp.Size = new System.Drawing.Size(188, 116);
            this.getTemp.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lightDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.timeCreatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(298, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 261);
            this.dataGridView1.TabIndex = 8;
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(371, 24);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(269, 20);
            this.getTime.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(330, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(308, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Light";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(308, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temp";
            // 
            // Light
            // 
            this.Light.Location = new System.Drawing.Point(371, 336);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(116, 20);
            this.Light.TabIndex = 10;
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(371, 375);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(116, 20);
            this.Temp.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "COM";
            this.bindingSource1.DataSource = this.dTVTDataSet;
            // 
            // dTVTDataSet
            // 
            this.dTVTDataSet.DataSetName = "DTVTDataSet";
            this.dTVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMTableAdapter
            // 
            this.cOMTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // lightDataGridViewTextBoxColumn
            // 
            this.lightDataGridViewTextBoxColumn.DataPropertyName = "Light";
            this.lightDataGridViewTextBoxColumn.HeaderText = "Light";
            this.lightDataGridViewTextBoxColumn.Name = "lightDataGridViewTextBoxColumn";
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // timeCreatDataGridViewTextBoxColumn
            // 
            this.timeCreatDataGridViewTextBoxColumn.DataPropertyName = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.HeaderText = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.Name = "timeCreatDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getTemp);
            this.Controls.Add(this.KetNoi);
            this.Controls.Add(this.XoaDuLieu);
            this.Controls.Add(this.ReGetCOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.getBaudRate);
            this.Controls.Add(this.getCOM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox getCOM;
        private System.Windows.Forms.ComboBox getBaudRate;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReGetCOM;
        private System.Windows.Forms.Button XoaDuLieu;
        private System.Windows.Forms.Button KetNoi;
        private System.Windows.Forms.TextBox getTemp;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Light;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DTVTDataSet dTVTDataSet;
        private DTVTDataSetTableAdapters.COMTableAdapter cOMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatDataGridViewTextBoxColumn;
    }
}

