namespace TH2
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
            this.BTViewData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getID = new System.Windows.Forms.TextBox();
            this.getTemp = new System.Windows.Forms.TextBox();
            this.getDateTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTDelAll = new System.Windows.Forms.Button();
            this.BTDel = new System.Windows.Forms.Button();
            this.BTRepair = new System.Windows.Forms.Button();
            this.BTClick = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.getRealTime = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTVTDataSet1 = new TH2.DTVTDataSet1();
            this.dTVTDataSet = new TH2.DTVTDataSet();
            this.valueTempTableAdapter = new TH2.DTVTDataSetTableAdapters.ValueTempTableAdapter();
            this.dTVTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTViewData
            // 
            this.BTViewData.Location = new System.Drawing.Point(74, 66);
            this.BTViewData.Name = "BTViewData";
            this.BTViewData.Size = new System.Drawing.Size(75, 23);
            this.BTViewData.TabIndex = 0;
            this.BTViewData.Text = "View Data";
            this.BTViewData.UseVisualStyleBackColor = true;
            this.BTViewData.Click += new System.EventHandler(this.BTViewData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Time";
            // 
            // getID
            // 
            this.getID.Location = new System.Drawing.Point(215, 82);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(136, 20);
            this.getID.TabIndex = 7;
            // 
            // getTemp
            // 
            this.getTemp.Location = new System.Drawing.Point(215, 162);
            this.getTemp.Name = "getTemp";
            this.getTemp.Size = new System.Drawing.Size(136, 20);
            this.getTemp.TabIndex = 8;
            // 
            // getDateTime
            // 
            this.getDateTime.Location = new System.Drawing.Point(215, 244);
            this.getDateTime.Name = "getDateTime";
            this.getDateTime.Size = new System.Drawing.Size(136, 20);
            this.getDateTime.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.timeCreatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(457, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 349);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.Location = new System.Drawing.Point(74, 119);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(75, 23);
            this.BTUpdate.TabIndex = 11;
            this.BTUpdate.Text = "UpDate";
            this.BTUpdate.UseVisualStyleBackColor = true;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTDelAll
            // 
            this.BTDelAll.Location = new System.Drawing.Point(74, 172);
            this.BTDelAll.Name = "BTDelAll";
            this.BTDelAll.Size = new System.Drawing.Size(75, 23);
            this.BTDelAll.TabIndex = 12;
            this.BTDelAll.Text = "DeleteAll";
            this.BTDelAll.UseVisualStyleBackColor = true;
            this.BTDelAll.Click += new System.EventHandler(this.BTDelAll_Click);
            // 
            // BTDel
            // 
            this.BTDel.Location = new System.Drawing.Point(74, 228);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(75, 23);
            this.BTDel.TabIndex = 13;
            this.BTDel.Text = "Delete";
            this.BTDel.UseVisualStyleBackColor = true;
            this.BTDel.Click += new System.EventHandler(this.BTDel_Click);
            // 
            // BTRepair
            // 
            this.BTRepair.Location = new System.Drawing.Point(155, 297);
            this.BTRepair.Name = "BTRepair";
            this.BTRepair.Size = new System.Drawing.Size(75, 23);
            this.BTRepair.TabIndex = 14;
            this.BTRepair.Text = "Repair";
            this.BTRepair.UseVisualStyleBackColor = true;
            this.BTRepair.Click += new System.EventHandler(this.BTRepair_Click);
            // 
            // BTClick
            // 
            this.BTClick.Location = new System.Drawing.Point(276, 297);
            this.BTClick.Name = "BTClick";
            this.BTClick.Size = new System.Drawing.Size(75, 23);
            this.BTClick.TabIndex = 15;
            this.BTClick.Text = "Test";
            this.BTClick.UseVisualStyleBackColor = true;
            this.BTClick.Click += new System.EventHandler(this.BTClick_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "RealTimeClock";
            // 
            // getRealTime
            // 
            this.getRealTime.Location = new System.Drawing.Point(666, 25);
            this.getRealTime.Name = "getRealTime";
            this.getRealTime.Size = new System.Drawing.Size(242, 20);
            this.getRealTime.TabIndex = 17;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ValueTemp";
            this.bindingSource1.DataSource = this.dTVTDataSet;
            // 
            // dTVTDataSet1
            // 
            this.dTVTDataSet1.DataSetName = "DTVTDataSet1";
            this.dTVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTVTDataSet
            // 
            this.dTVTDataSet.DataSetName = "DTVTDataSet";
            this.dTVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valueTempTableAdapter
            // 
            this.valueTempTableAdapter.ClearBeforeFill = true;
            // 
            // dTVTDataSetBindingSource
            // 
            this.dTVTDataSetBindingSource.DataSource = this.dTVTDataSet;
            this.dTVTDataSetBindingSource.Position = 0;
            // 
            // valueTempBindingSource
            // 
            this.valueTempBindingSource.DataMember = "ValueTemp";
            this.valueTempBindingSource.DataSource = this.dTVTDataSetBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
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
            this.ClientSize = new System.Drawing.Size(971, 472);
            this.Controls.Add(this.getRealTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTClick);
            this.Controls.Add(this.BTRepair);
            this.Controls.Add(this.BTDel);
            this.Controls.Add(this.BTDelAll);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getDateTime);
            this.Controls.Add(this.getTemp);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTViewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTempBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTViewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox getID;
        private System.Windows.Forms.TextBox getTemp;
        private System.Windows.Forms.TextBox getDateTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTDelAll;
        private System.Windows.Forms.Button BTDel;
        private System.Windows.Forms.Button BTRepair;
        private System.Windows.Forms.Button BTClick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getRealTime;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DTVTDataSet dTVTDataSet;
        private DTVTDataSet1 dTVTDataSet1;
        private DTVTDataSetTableAdapters.ValueTempTableAdapter valueTempTableAdapter;
        private System.Windows.Forms.BindingSource valueTempBindingSource;
        private System.Windows.Forms.BindingSource dTVTDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatDataGridViewTextBoxColumn;
    }
}

