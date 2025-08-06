namespace USBdieukhien
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
            this.btled1 = new System.Windows.Forms.Button();
            this.btled2 = new System.Windows.Forms.Button();
            this.btled3 = new System.Windows.Forms.Button();
            this.btled4 = new System.Windows.Forms.Button();
            this.btled5 = new System.Windows.Forms.Button();
            this.btled6 = new System.Windows.Forms.Button();
            this.btled7 = new System.Windows.Forms.Button();
            this.btled8 = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDSub = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet = new USBdieukhien.DTVTDataSet();
            this.getTime = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.uSBdieukhienTableAdapter = new USBdieukhien.DTVTDataSetTableAdapters.USBdieukhienTableAdapter();
            this.exitToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btled1
            // 
            this.btled1.Location = new System.Drawing.Point(24, 311);
            this.btled1.Name = "btled1";
            this.btled1.Size = new System.Drawing.Size(75, 23);
            this.btled1.TabIndex = 0;
            this.btled1.Text = "LED 1";
            this.btled1.UseVisualStyleBackColor = true;
            this.btled1.Click += new System.EventHandler(this.btled1_Click);
            // 
            // btled2
            // 
            this.btled2.Location = new System.Drawing.Point(104, 311);
            this.btled2.Name = "btled2";
            this.btled2.Size = new System.Drawing.Size(75, 23);
            this.btled2.TabIndex = 1;
            this.btled2.Text = "LED 2";
            this.btled2.UseVisualStyleBackColor = true;
            this.btled2.Click += new System.EventHandler(this.btled2_Click);
            // 
            // btled3
            // 
            this.btled3.Location = new System.Drawing.Point(185, 311);
            this.btled3.Name = "btled3";
            this.btled3.Size = new System.Drawing.Size(75, 23);
            this.btled3.TabIndex = 2;
            this.btled3.Text = "LED 3";
            this.btled3.UseVisualStyleBackColor = true;
            this.btled3.Click += new System.EventHandler(this.btled3_Click);
            // 
            // btled4
            // 
            this.btled4.Location = new System.Drawing.Point(23, 351);
            this.btled4.Name = "btled4";
            this.btled4.Size = new System.Drawing.Size(75, 23);
            this.btled4.TabIndex = 3;
            this.btled4.Text = "LED 4";
            this.btled4.UseVisualStyleBackColor = true;
            this.btled4.Click += new System.EventHandler(this.btled4_Click);
            // 
            // btled5
            // 
            this.btled5.Location = new System.Drawing.Point(104, 351);
            this.btled5.Name = "btled5";
            this.btled5.Size = new System.Drawing.Size(75, 23);
            this.btled5.TabIndex = 4;
            this.btled5.Text = "LED 5";
            this.btled5.UseVisualStyleBackColor = true;
            this.btled5.Click += new System.EventHandler(this.btled5_Click);
            // 
            // btled6
            // 
            this.btled6.Location = new System.Drawing.Point(185, 351);
            this.btled6.Name = "btled6";
            this.btled6.Size = new System.Drawing.Size(75, 23);
            this.btled6.TabIndex = 5;
            this.btled6.Text = "LED 6";
            this.btled6.UseVisualStyleBackColor = true;
            this.btled6.Click += new System.EventHandler(this.btled6_Click);
            // 
            // btled7
            // 
            this.btled7.Location = new System.Drawing.Point(23, 393);
            this.btled7.Name = "btled7";
            this.btled7.Size = new System.Drawing.Size(75, 23);
            this.btled7.TabIndex = 6;
            this.btled7.Text = "LED 7";
            this.btled7.UseVisualStyleBackColor = true;
            this.btled7.Click += new System.EventHandler(this.btled7_Click);
            // 
            // btled8
            // 
            this.btled8.Location = new System.Drawing.Point(104, 393);
            this.btled8.Name = "btled8";
            this.btled8.Size = new System.Drawing.Size(75, 23);
            this.btled8.TabIndex = 7;
            this.btled8.Text = "LED 8";
            this.btled8.UseVisualStyleBackColor = true;
            this.btled8.Click += new System.EventHandler(this.btled8_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(185, 393);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(75, 23);
            this.btall.TabIndex = 8;
            this.btall.Text = "All ON";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataSendDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BDSub;
            this.dataGridView1.Location = new System.Drawing.Point(288, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 354);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataSendDataGridViewTextBoxColumn
            // 
            this.dataSendDataGridViewTextBoxColumn.DataPropertyName = "DataSend";
            this.dataSendDataGridViewTextBoxColumn.HeaderText = "DataSend";
            this.dataSendDataGridViewTextBoxColumn.Name = "dataSendDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // BDSub
            // 
            this.BDSub.DataMember = "USBdieukhien";
            this.BDSub.DataSource = this.dTVTDataSet;
            // 
            // dTVTDataSet
            // 
            this.dTVTDataSet.DataSetName = "DTVTDataSet";
            this.dTVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(534, 24);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(287, 20);
            this.getTime.TabIndex = 11;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(134, 268);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(100, 20);
            this.Status.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clock";
            // 
            // uSBdieukhienTableAdapter
            // 
            this.uSBdieukhienTableAdapter.ClearBeforeFill = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(847, 24);
            this.exitToolStripMenuItem.TabIndex = 14;
            this.exitToolStripMenuItem.Text = "menuStrip1";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Check USB HID ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btled8);
            this.Controls.Add(this.btled7);
            this.Controls.Add(this.btled6);
            this.Controls.Add(this.btled5);
            this.Controls.Add(this.btled4);
            this.Controls.Add(this.btled3);
            this.Controls.Add(this.btled2);
            this.Controls.Add(this.btled1);
            this.Controls.Add(this.exitToolStripMenuItem);
            this.MainMenuStrip = this.exitToolStripMenuItem;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btled1;
        private System.Windows.Forms.Button btled2;
        private System.Windows.Forms.Button btled3;
        private System.Windows.Forms.Button btled4;
        private System.Windows.Forms.Button btled5;
        private System.Windows.Forms.Button btled6;
        private System.Windows.Forms.Button btled7;
        private System.Windows.Forms.Button btled8;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource BDSub;
        private DTVTDataSet dTVTDataSet;
        private DTVTDataSetTableAdapters.USBdieukhienTableAdapter uSBdieukhienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

