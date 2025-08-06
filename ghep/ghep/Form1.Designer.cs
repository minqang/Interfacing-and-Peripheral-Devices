namespace ghep
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_light = new System.Windows.Forms.TextBox();
            this.tb_temp = new System.Windows.Forms.TextBox();
            this.ipc = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t_port = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.TextBox();
            this.lanip = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.btalloff = new System.Windows.Forms.Button();
            this.btoff2 = new System.Windows.Forms.Button();
            this.btoff1 = new System.Windows.Forms.Button();
            this.btallon = new System.Windows.Forms.Button();
            this.bton2 = new System.Windows.Forms.Button();
            this.bton1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Light (0-255)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Temp (*C)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "IP Client";
            // 
            // tb_light
            // 
            this.tb_light.Location = new System.Drawing.Point(185, 330);
            this.tb_light.Name = "tb_light";
            this.tb_light.Size = new System.Drawing.Size(100, 20);
            this.tb_light.TabIndex = 28;
            // 
            // tb_temp
            // 
            this.tb_temp.Location = new System.Drawing.Point(185, 304);
            this.tb_temp.Name = "tb_temp";
            this.tb_temp.Size = new System.Drawing.Size(100, 20);
            this.tb_temp.TabIndex = 27;
            // 
            // ipc
            // 
            this.ipc.Location = new System.Drawing.Point(185, 278);
            this.ipc.Name = "ipc";
            this.ipc.Size = new System.Drawing.Size(131, 20);
            this.ipc.TabIndex = 26;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(210, 220);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 25;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Port";
            // 
            // t_port
            // 
            this.t_port.Location = new System.Drawing.Point(185, 252);
            this.t_port.Name = "t_port";
            this.t_port.Size = new System.Drawing.Size(100, 20);
            this.t_port.TabIndex = 23;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(65, 100);
            this.getData.Multiline = true;
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(272, 99);
            this.getData.TabIndex = 22;
            // 
            // lanip
            // 
            this.lanip.Location = new System.Drawing.Point(171, 64);
            this.lanip.Name = "lanip";
            this.lanip.Size = new System.Drawing.Size(166, 20);
            this.lanip.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 368);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(512, 18);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(223, 20);
            this.getTime.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "LAN IP Address";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(89, 220);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(95, 23);
            this.open.TabIndex = 17;
            this.open.Text = "Open Socket";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(1347, 24);
            this.exitToolStripMenuItem.TabIndex = 32;
            this.exitToolStripMenuItem.Text = "menuStrip1";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btalloff
            // 
            this.btalloff.Location = new System.Drawing.Point(255, 406);
            this.btalloff.Name = "btalloff";
            this.btalloff.Size = new System.Drawing.Size(75, 23);
            this.btalloff.TabIndex = 39;
            this.btalloff.Text = "All OFF";
            this.btalloff.UseVisualStyleBackColor = true;
            this.btalloff.Click += new System.EventHandler(this.btalloff_Click);
            // 
            // btoff2
            // 
            this.btoff2.Location = new System.Drawing.Point(174, 406);
            this.btoff2.Name = "btoff2";
            this.btoff2.Size = new System.Drawing.Size(75, 23);
            this.btoff2.TabIndex = 38;
            this.btoff2.Text = "OFF2";
            this.btoff2.UseVisualStyleBackColor = true;
            this.btoff2.Click += new System.EventHandler(this.btoff2_Click);
            // 
            // btoff1
            // 
            this.btoff1.Location = new System.Drawing.Point(93, 406);
            this.btoff1.Name = "btoff1";
            this.btoff1.Size = new System.Drawing.Size(75, 23);
            this.btoff1.TabIndex = 37;
            this.btoff1.Text = "OFF1";
            this.btoff1.UseVisualStyleBackColor = true;
            this.btoff1.Click += new System.EventHandler(this.btoff1_Click);
            // 
            // btallon
            // 
            this.btallon.Location = new System.Drawing.Point(255, 377);
            this.btallon.Name = "btallon";
            this.btallon.Size = new System.Drawing.Size(75, 23);
            this.btallon.TabIndex = 36;
            this.btallon.Text = "All ON";
            this.btallon.UseVisualStyleBackColor = true;
            this.btallon.Click += new System.EventHandler(this.btallon_Click);
            // 
            // bton2
            // 
            this.bton2.Location = new System.Drawing.Point(174, 377);
            this.bton2.Name = "bton2";
            this.bton2.Size = new System.Drawing.Size(75, 23);
            this.bton2.TabIndex = 35;
            this.bton2.Text = "ON2";
            this.bton2.UseVisualStyleBackColor = true;
            this.bton2.Click += new System.EventHandler(this.bton2_Click);
            // 
            // bton1
            // 
            this.bton1.Location = new System.Drawing.Point(93, 377);
            this.bton1.Name = "bton1";
            this.bton1.Size = new System.Drawing.Size(75, 23);
            this.bton1.TabIndex = 34;
            this.bton1.Text = "ON1";
            this.bton1.UseVisualStyleBackColor = true;
            this.bton1.Click += new System.EventHandler(this.bton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(870, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 368);
            this.dataGridView2.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 460);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btalloff);
            this.Controls.Add(this.btoff2);
            this.Controls.Add(this.btoff1);
            this.Controls.Add(this.btallon);
            this.Controls.Add(this.bton2);
            this.Controls.Add(this.bton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_light);
            this.Controls.Add(this.tb_temp);
            this.Controls.Add(this.ipc);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_port);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.lanip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.exitToolStripMenuItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_light;
        private System.Windows.Forms.TextBox tb_temp;
        private System.Windows.Forms.TextBox ipc;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_port;
        private System.Windows.Forms.TextBox getData;
        private System.Windows.Forms.TextBox lanip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.MenuStrip exitToolStripMenuItem;
        private System.Windows.Forms.Button btalloff;
        private System.Windows.Forms.Button btoff2;
        private System.Windows.Forms.Button btoff1;
        private System.Windows.Forms.Button btallon;
        private System.Windows.Forms.Button bton2;
        private System.Windows.Forms.Button bton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer timer1;
    }
}

