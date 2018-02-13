namespace TCPClient01
{
    partial class frmTcpClient
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
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.cbIpSelect = new System.Windows.Forms.ComboBox();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.lblPayload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(13, 13);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.Size = new System.Drawing.Size(761, 396);
            this.tbConsoleOutput.TabIndex = 0;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(87, 415);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(125, 20);
            this.tbServerIP.TabIndex = 1;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(87, 439);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(62, 20);
            this.tbServerPort.TabIndex = 2;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(12, 418);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(72, 13);
            this.lblServerIP.TabIndex = 3;
            this.lblServerIP.Text = "Server Name:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(218, 415);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(62, 44);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(543, 416);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(231, 20);
            this.tbPayload.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(543, 442);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(233, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(12, 442);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 13);
            this.lblServerPort.TabIndex = 8;
            this.lblServerPort.Text = "Server Port:";
            // 
            // cbIpSelect
            // 
            this.cbIpSelect.FormattingEnabled = true;
            this.cbIpSelect.Location = new System.Drawing.Point(155, 439);
            this.cbIpSelect.Name = "cbIpSelect";
            this.cbIpSelect.Size = new System.Drawing.Size(57, 21);
            this.cbIpSelect.TabIndex = 9;
            this.cbIpSelect.SelectedIndexChanged += new System.EventHandler(this.cbIpSelect_SelectedIndexChanged);
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(780, 35);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(213, 355);
            this.lbClients.TabIndex = 12;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(780, 18);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(41, 13);
            this.lblClients.TabIndex = 11;
            this.lblClients.Text = "Clients:";
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(493, 420);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(48, 13);
            this.lblPayload.TabIndex = 7;
            this.lblPayload.Text = "Payload:";
            // 
            // frmTcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 478);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.cbIpSelect);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.lblPayload);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPayload);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.tbServerPort);
            this.Controls.Add(this.tbServerIP);
            this.Controls.Add(this.tbConsoleOutput);
            this.Name = "frmTcpClient";
            this.Text = "TCP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsoleOutput;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.ComboBox cbIpSelect;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblPayload;
    }
}

