namespace TCPprotocol
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
            this.label1 = new System.Windows.Forms.Label();
            this.lanip = new System.Windows.Forms.TextBox();
            this.t_port = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ipc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAN IP Address";
            // 
            // lanip
            // 
            this.lanip.Location = new System.Drawing.Point(270, 24);
            this.lanip.Name = "lanip";
            this.lanip.Size = new System.Drawing.Size(100, 20);
            this.lanip.TabIndex = 1;
            // 
            // t_port
            // 
            this.t_port.Location = new System.Drawing.Point(270, 187);
            this.t_port.Name = "t_port";
            this.t_port.Size = new System.Drawing.Size(100, 20);
            this.t_port.TabIndex = 2;
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(337, 245);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(100, 20);
            this.tbSend.TabIndex = 3;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(94, 243);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(175, 243);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(256, 243);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // ipc
            // 
            this.ipc.Location = new System.Drawing.Point(270, 305);
            this.ipc.Name = "ipc";
            this.ipc.Size = new System.Drawing.Size(100, 20);
            this.ipc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP CLient";
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(69, 62);
            this.getData.Multiline = true;
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(390, 99);
            this.getData.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 400);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.t_port);
            this.Controls.Add(this.lanip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lanip;
        private System.Windows.Forms.TextBox t_port;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox getData;
    }
}

