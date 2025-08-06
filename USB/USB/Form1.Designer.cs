namespace USB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.getTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet = new USB.DTVTDataSet();
            this.getVID = new System.Windows.Forms.TextBox();
            this.getPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.getUSB = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.getTemp = new System.Windows.Forms.TextBox();
            this.getLight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getData = new System.Windows.Forms.TextBox();
            this.cOMTableAdapter = new USB.DTVTDataSetTableAdapters.COMTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.BTStop = new System.Windows.Forms.Button();
            this.infomationToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.BTDelAll = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.btled8 = new System.Windows.Forms.Button();
            this.btled7 = new System.Windows.Forms.Button();
            this.btled6 = new System.Windows.Forms.Button();
            this.btled5 = new System.Windows.Forms.Button();
            this.btled4 = new System.Windows.Forms.Button();
            this.btled3 = new System.Windows.Forms.Button();
            this.btled2 = new System.Windows.Forms.Button();
            this.btled1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet1 = new USB.DTVTDataSet1();
            this.uSBdieukhienTableAdapter = new USB.DTVTDataSet1TableAdapters.USBdieukhienTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clock";
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(512, 69);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(251, 20);
            this.getTime.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lightDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.timeCreateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(305, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 200);
            this.dataGridView1.TabIndex = 2;
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
            // timeCreateDataGridViewTextBoxColumn
            // 
            this.timeCreateDataGridViewTextBoxColumn.DataPropertyName = "TimeCreate";
            this.timeCreateDataGridViewTextBoxColumn.HeaderText = "TimeCreate";
            this.timeCreateDataGridViewTextBoxColumn.Name = "timeCreateDataGridViewTextBoxColumn";
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
            // getVID
            // 
            this.getVID.Location = new System.Drawing.Point(96, 85);
            this.getVID.Name = "getVID";
            this.getVID.Size = new System.Drawing.Size(77, 20);
            this.getVID.TabIndex = 3;
            // 
            // getPID
            // 
            this.getPID.Location = new System.Drawing.Point(96, 133);
            this.getPID.Name = "getPID";
            this.getPID.Size = new System.Drawing.Size(77, 20);
            this.getPID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PID";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(199, 133);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(77, 20);
            this.status.TabIndex = 7;
            // 
            // getUSB
            // 
            this.getUSB.Location = new System.Drawing.Point(201, 72);
            this.getUSB.Name = "getUSB";
            this.getUSB.Size = new System.Drawing.Size(75, 23);
            this.getUSB.TabIndex = 8;
            this.getUSB.Text = "Check USB";
            this.getUSB.UseVisualStyleBackColor = true;
            this.getUSB.Click += new System.EventHandler(this.getUSB_Click);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(305, 95);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "Temp";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "Light";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Size = new System.Drawing.Size(524, 178);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "x";
            // 
            // getTemp
            // 
            this.getTemp.Location = new System.Drawing.Point(752, 143);
            this.getTemp.Name = "getTemp";
            this.getTemp.Size = new System.Drawing.Size(67, 20);
            this.getTemp.TabIndex = 10;
            // 
            // getLight
            // 
            this.getLight.Location = new System.Drawing.Point(752, 172);
            this.getLight.Name = "getLight";
            this.getLight.Size = new System.Drawing.Size(67, 20);
            this.getLight.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Light";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DataReceive";
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(96, 175);
            this.getData.Multiline = true;
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(180, 87);
            this.getData.TabIndex = 15;
            // 
            // cOMTableAdapter
            // 
            this.cOMTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(1286, 24);
            this.exitToolStripMenuItem.TabIndex = 16;
            this.exitToolStripMenuItem.Text = "menuStrip1";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BTStop
            // 
            this.BTStop.Location = new System.Drawing.Point(201, 104);
            this.BTStop.Name = "BTStop";
            this.BTStop.Size = new System.Drawing.Size(75, 23);
            this.BTStop.TabIndex = 17;
            this.BTStop.Text = "Stop";
            this.BTStop.UseVisualStyleBackColor = true;
            this.BTStop.Click += new System.EventHandler(this.BTStop_Click);
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.Location = new System.Drawing.Point(0, 24);
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(1286, 24);
            this.infomationToolStripMenuItem.TabIndex = 18;
            this.infomationToolStripMenuItem.Text = "menuStrip1";
            this.infomationToolStripMenuItem.Click += new System.EventHandler(this.infomationToolStripMenuItem_Click);
            // 
            // BTDelAll
            // 
            this.BTDelAll.Location = new System.Drawing.Point(15, 215);
            this.BTDelAll.Name = "BTDelAll";
            this.BTDelAll.Size = new System.Drawing.Size(75, 23);
            this.BTDelAll.TabIndex = 19;
            this.BTDelAll.Text = "Delete All";
            this.BTDelAll.UseVisualStyleBackColor = true;
            this.BTDelAll.Click += new System.EventHandler(this.BTDelAll_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(199, 384);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(75, 23);
            this.btall.TabIndex = 28;
            this.btall.Text = "All ON";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // btled8
            // 
            this.btled8.Location = new System.Drawing.Point(118, 384);
            this.btled8.Name = "btled8";
            this.btled8.Size = new System.Drawing.Size(75, 23);
            this.btled8.TabIndex = 27;
            this.btled8.Text = "LED 8";
            this.btled8.UseVisualStyleBackColor = true;
            this.btled8.Click += new System.EventHandler(this.btled8_Click);
            // 
            // btled7
            // 
            this.btled7.Location = new System.Drawing.Point(37, 384);
            this.btled7.Name = "btled7";
            this.btled7.Size = new System.Drawing.Size(75, 23);
            this.btled7.TabIndex = 26;
            this.btled7.Text = "LED 7";
            this.btled7.UseVisualStyleBackColor = true;
            this.btled7.Click += new System.EventHandler(this.btled7_Click);
            // 
            // btled6
            // 
            this.btled6.Location = new System.Drawing.Point(199, 342);
            this.btled6.Name = "btled6";
            this.btled6.Size = new System.Drawing.Size(75, 23);
            this.btled6.TabIndex = 25;
            this.btled6.Text = "LED 6";
            this.btled6.UseVisualStyleBackColor = true;
            this.btled6.Click += new System.EventHandler(this.btled6_Click);
            // 
            // btled5
            // 
            this.btled5.Location = new System.Drawing.Point(118, 342);
            this.btled5.Name = "btled5";
            this.btled5.Size = new System.Drawing.Size(75, 23);
            this.btled5.TabIndex = 24;
            this.btled5.Text = "LED 5";
            this.btled5.UseVisualStyleBackColor = true;
            this.btled5.Click += new System.EventHandler(this.btled5_Click);
            // 
            // btled4
            // 
            this.btled4.Location = new System.Drawing.Point(37, 342);
            this.btled4.Name = "btled4";
            this.btled4.Size = new System.Drawing.Size(75, 23);
            this.btled4.TabIndex = 23;
            this.btled4.Text = "LED 4";
            this.btled4.UseVisualStyleBackColor = true;
            this.btled4.Click += new System.EventHandler(this.btled4_Click);
            // 
            // btled3
            // 
            this.btled3.Location = new System.Drawing.Point(199, 302);
            this.btled3.Name = "btled3";
            this.btled3.Size = new System.Drawing.Size(75, 23);
            this.btled3.TabIndex = 22;
            this.btled3.Text = "LED 3";
            this.btled3.UseVisualStyleBackColor = true;
            this.btled3.Click += new System.EventHandler(this.btled3_Click);
            // 
            // btled2
            // 
            this.btled2.Location = new System.Drawing.Point(118, 302);
            this.btled2.Name = "btled2";
            this.btled2.Size = new System.Drawing.Size(75, 23);
            this.btled2.TabIndex = 21;
            this.btled2.Text = "LED 2";
            this.btled2.UseVisualStyleBackColor = true;
            this.btled2.Click += new System.EventHandler(this.btled2_Click);
            // 
            // btled1
            // 
            this.btled1.Location = new System.Drawing.Point(38, 302);
            this.btled1.Name = "btled1";
            this.btled1.Size = new System.Drawing.Size(75, 23);
            this.btled1.TabIndex = 20;
            this.btled1.Text = "LED 1";
            this.btled1.UseVisualStyleBackColor = true;
            this.btled1.Click += new System.EventHandler(this.btled1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.dataSendDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(853, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 384);
            this.dataGridView2.TabIndex = 29;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "USBdieukhien";
            this.bindingSource2.DataSource = this.dTVTDataSet1;
            // 
            // dTVTDataSet1
            // 
            this.dTVTDataSet1.DataSetName = "DTVTDataSet1";
            this.dTVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSBdieukhienTableAdapter
            // 
            this.uSBdieukhienTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 493);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btled8);
            this.Controls.Add(this.btled7);
            this.Controls.Add(this.btled6);
            this.Controls.Add(this.btled5);
            this.Controls.Add(this.btled4);
            this.Controls.Add(this.btled3);
            this.Controls.Add(this.btled2);
            this.Controls.Add(this.btled1);
            this.Controls.Add(this.BTDelAll);
            this.Controls.Add(this.infomationToolStripMenuItem);
            this.Controls.Add(this.BTStop);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getLight);
            this.Controls.Add(this.getTemp);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.getUSB);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getPID);
            this.Controls.Add(this.getVID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitToolStripMenuItem);
            this.MainMenuStrip = this.exitToolStripMenuItem;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getLight;
        private System.Windows.Forms.TextBox getTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button getUSB;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getPID;
        private System.Windows.Forms.TextBox getVID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox getData;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DTVTDataSet dTVTDataSet;
        private DTVTDataSetTableAdapters.COMTableAdapter cOMTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip exitToolStripMenuItem;
        private System.Windows.Forms.Button BTStop;
        private System.Windows.Forms.MenuStrip infomationToolStripMenuItem;
        private System.Windows.Forms.Button BTDelAll;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.Button btled8;
        private System.Windows.Forms.Button btled7;
        private System.Windows.Forms.Button btled6;
        private System.Windows.Forms.Button btled5;
        private System.Windows.Forms.Button btled4;
        private System.Windows.Forms.Button btled3;
        private System.Windows.Forms.Button btled2;
        private System.Windows.Forms.Button btled1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DTVTDataSet1 dTVTDataSet1;
        private DTVTDataSet1TableAdapters.USBdieukhienTableAdapter uSBdieukhienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
    }
}

