namespace DieuKhien
{
    partial class abc
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
            this.OFFALL = new System.Windows.Forms.Button();
            this.OFF2 = new System.Windows.Forms.Button();
            this.OFF1 = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.getRefresh = new System.Windows.Forms.Button();
            this.KetNoi = new System.Windows.Forms.Button();
            this.ONALL = new System.Windows.Forms.Button();
            this.ON2 = new System.Windows.Forms.Button();
            this.ON1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet = new DieuKhien.DTVTDataSet();
            this.textBox = new System.Windows.Forms.TextBox();
            this.getCOM = new System.Windows.Forms.ComboBox();
            this.getBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dieuKhienTableAdapter = new DieuKhien.DTVTDataSetTableAdapters.DieuKhienTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.getSearch = new System.Windows.Forms.TextBox();
            this.getDel = new System.Windows.Forms.TextBox();
            this.getUpdate = new System.Windows.Forms.TextBox();
            this.getTime = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.getAdd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // OFFALL
            // 
            this.OFFALL.Location = new System.Drawing.Point(294, 333);
            this.OFFALL.Name = "OFFALL";
            this.OFFALL.Size = new System.Drawing.Size(75, 23);
            this.OFFALL.TabIndex = 0;
            this.OFFALL.Text = "Tat het";
            this.OFFALL.UseVisualStyleBackColor = true;
            this.OFFALL.Click += new System.EventHandler(this.OFFALL_Click);
            // 
            // OFF2
            // 
            this.OFF2.Location = new System.Drawing.Point(294, 293);
            this.OFF2.Name = "OFF2";
            this.OFF2.Size = new System.Drawing.Size(75, 23);
            this.OFF2.TabIndex = 1;
            this.OFF2.Text = "Tat role";
            this.OFF2.UseVisualStyleBackColor = true;
            this.OFF2.Click += new System.EventHandler(this.OFF2_Click);
            // 
            // OFF1
            // 
            this.OFF1.Location = new System.Drawing.Point(294, 251);
            this.OFF1.Name = "OFF1";
            this.OFF1.Size = new System.Drawing.Size(75, 23);
            this.OFF1.TabIndex = 2;
            this.OFF1.Text = "Tat coi";
            this.OFF1.UseVisualStyleBackColor = true;
            this.OFF1.Click += new System.EventHandler(this.OFF1_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(29, 86);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 3;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // getRefresh
            // 
            this.getRefresh.Location = new System.Drawing.Point(221, 203);
            this.getRefresh.Name = "getRefresh";
            this.getRefresh.Size = new System.Drawing.Size(75, 23);
            this.getRefresh.TabIndex = 4;
            this.getRefresh.Text = "Lam moi";
            this.getRefresh.UseVisualStyleBackColor = true;
            // 
            // KetNoi
            // 
            this.KetNoi.Location = new System.Drawing.Point(221, 159);
            this.KetNoi.Name = "KetNoi";
            this.KetNoi.Size = new System.Drawing.Size(75, 23);
            this.KetNoi.TabIndex = 5;
            this.KetNoi.Text = "Ket Noi";
            this.KetNoi.UseVisualStyleBackColor = true;
            this.KetNoi.Click += new System.EventHandler(this.KetNoi_Click);
            // 
            // ONALL
            // 
            this.ONALL.Location = new System.Drawing.Point(198, 333);
            this.ONALL.Name = "ONALL";
            this.ONALL.Size = new System.Drawing.Size(75, 23);
            this.ONALL.TabIndex = 6;
            this.ONALL.Text = "Bat het";
            this.ONALL.UseVisualStyleBackColor = true;
            this.ONALL.Click += new System.EventHandler(this.ONALL_Click);
            // 
            // ON2
            // 
            this.ON2.Location = new System.Drawing.Point(198, 293);
            this.ON2.Name = "ON2";
            this.ON2.Size = new System.Drawing.Size(75, 23);
            this.ON2.TabIndex = 7;
            this.ON2.Text = "Bat role";
            this.ON2.UseVisualStyleBackColor = true;
            this.ON2.Click += new System.EventHandler(this.ON2_Click);
            // 
            // ON1
            // 
            this.ON1.AutoEllipsis = true;
            this.ON1.Location = new System.Drawing.Point(198, 251);
            this.ON1.Name = "ON1";
            this.ON1.Size = new System.Drawing.Size(75, 23);
            this.ON1.TabIndex = 8;
            this.ON1.Text = "Bat coi";
            this.ON1.UseVisualStyleBackColor = true;
            this.ON1.Click += new System.EventHandler(this.ON1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.timeCreatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(408, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 173);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // timeCreatDataGridViewTextBoxColumn
            // 
            this.timeCreatDataGridViewTextBoxColumn.DataPropertyName = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.HeaderText = "TimeCreat";
            this.timeCreatDataGridViewTextBoxColumn.Name = "timeCreatDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DieuKhien";
            this.bindingSource1.DataSource = this.dTVTDataSet;
            // 
            // dTVTDataSet
            // 
            this.dTVTDataSet.DataSetName = "DTVTDataSet";
            this.dTVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 248);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(176, 113);
            this.textBox.TabIndex = 11;
            // 
            // getCOM
            // 
            this.getCOM.FormattingEnabled = true;
            this.getCOM.Location = new System.Drawing.Point(76, 183);
            this.getCOM.Name = "getCOM";
            this.getCOM.Size = new System.Drawing.Size(121, 21);
            this.getCOM.TabIndex = 13;
            // 
            // getBaudRate
            // 
            this.getBaudRate.FormattingEnabled = true;
            this.getBaudRate.Location = new System.Drawing.Point(76, 156);
            this.getBaudRate.Name = "getBaudRate";
            this.getBaudRate.Size = new System.Drawing.Size(121, 21);
            this.getBaudRate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "BaudRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trang thai";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label.Location = new System.Drawing.Point(76, 210);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 20);
            this.label.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dieuKhienTableAdapter
            // 
            this.dieuKhienTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(29, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.Location = new System.Drawing.Point(29, 56);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(75, 23);
            this.UpdateData.TabIndex = 21;
            this.UpdateData.Text = "Update";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(29, 114);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 23;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // getSearch
            // 
            this.getSearch.Location = new System.Drawing.Point(110, 29);
            this.getSearch.Name = "getSearch";
            this.getSearch.Size = new System.Drawing.Size(241, 20);
            this.getSearch.TabIndex = 24;
            // 
            // getDel
            // 
            this.getDel.Location = new System.Drawing.Point(110, 88);
            this.getDel.Name = "getDel";
            this.getDel.Size = new System.Drawing.Size(241, 20);
            this.getDel.TabIndex = 26;
            // 
            // getUpdate
            // 
            this.getUpdate.Location = new System.Drawing.Point(110, 59);
            this.getUpdate.Name = "getUpdate";
            this.getUpdate.Size = new System.Drawing.Size(241, 20);
            this.getUpdate.TabIndex = 27;
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(29, 4);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(363, 20);
            this.getTime.TabIndex = 28;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(408, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(511, 173);
            this.dataGridView2.TabIndex = 29;
            // 
            // getAdd
            // 
            this.getAdd.Location = new System.Drawing.Point(110, 117);
            this.getAdd.Name = "getAdd";
            this.getAdd.Size = new System.Drawing.Size(241, 20);
            this.getAdd.TabIndex = 30;
            // 
            // abc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 372);
            this.Controls.Add(this.getAdd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.getUpdate);
            this.Controls.Add(this.getDel);
            this.Controls.Add(this.getSearch);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getBaudRate);
            this.Controls.Add(this.getCOM);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ON1);
            this.Controls.Add(this.ON2);
            this.Controls.Add(this.ONALL);
            this.Controls.Add(this.KetNoi);
            this.Controls.Add(this.getRefresh);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.OFF1);
            this.Controls.Add(this.OFF2);
            this.Controls.Add(this.OFFALL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "abc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OFFALL;
        private System.Windows.Forms.Button OFF2;
        private System.Windows.Forms.Button OFF1;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button getRefresh;
        private System.Windows.Forms.Button KetNoi;
        private System.Windows.Forms.Button ONALL;
        private System.Windows.Forms.Button ON2;
        private System.Windows.Forms.Button ON1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox getCOM;
        private System.Windows.Forms.ComboBox getBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox label;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DTVTDataSet dTVTDataSet;
        private DTVTDataSetTableAdapters.DieuKhienTableAdapter dieuKhienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox getSearch;
        private System.Windows.Forms.TextBox getDel;
        private System.Windows.Forms.TextBox getUpdate;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox getAdd;
    }
}

