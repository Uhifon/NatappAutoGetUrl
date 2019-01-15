namespace NatappDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAuthtokenWeb = new System.Windows.Forms.TextBox();
            this.tbNatappAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartWeb = new System.Windows.Forms.Button();
            this.btnNatappAddress = new System.Windows.Forms.Button();
            this.tbAuthtokenTCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAuthtokenUDP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartTCP = new System.Windows.Forms.Button();
            this.btnStartUDP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProtocol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLocalIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbServerUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAuthtokenWeb
            // 
            this.tbAuthtokenWeb.Location = new System.Drawing.Point(132, 53);
            this.tbAuthtokenWeb.Name = "tbAuthtokenWeb";
            this.tbAuthtokenWeb.Size = new System.Drawing.Size(153, 21);
            this.tbAuthtokenWeb.TabIndex = 10;
            // 
            // tbNatappAddress
            // 
            this.tbNatappAddress.Location = new System.Drawing.Point(132, 26);
            this.tbNatappAddress.Name = "tbNatappAddress";
            this.tbNatappAddress.Size = new System.Drawing.Size(271, 21);
            this.tbNatappAddress.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Natapp.exe文件地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Authtoken值(Web)：";
            // 
            // btnStartWeb
            // 
            this.btnStartWeb.Location = new System.Drawing.Point(291, 53);
            this.btnStartWeb.Name = "btnStartWeb";
            this.btnStartWeb.Size = new System.Drawing.Size(65, 21);
            this.btnStartWeb.TabIndex = 6;
            this.btnStartWeb.Tag = "f0391da3b55e4f49";
            this.btnStartWeb.Text = "解析";
            this.btnStartWeb.UseVisualStyleBackColor = true;
            this.btnStartWeb.Click += new System.EventHandler(this.btnStartWeb_Click);
            // 
            // btnNatappAddress
            // 
            this.btnNatappAddress.Location = new System.Drawing.Point(409, 25);
            this.btnNatappAddress.Name = "btnNatappAddress";
            this.btnNatappAddress.Size = new System.Drawing.Size(37, 23);
            this.btnNatappAddress.TabIndex = 5;
            this.btnNatappAddress.Text = "...";
            this.btnNatappAddress.UseVisualStyleBackColor = true;
            this.btnNatappAddress.Click += new System.EventHandler(this.btnNatappAddress_Click);
            // 
            // tbAuthtokenTCP
            // 
            this.tbAuthtokenTCP.Location = new System.Drawing.Point(132, 80);
            this.tbAuthtokenTCP.Name = "tbAuthtokenTCP";
            this.tbAuthtokenTCP.Size = new System.Drawing.Size(153, 21);
            this.tbAuthtokenTCP.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Authtoken值(TCP)：";
            // 
            // tbAuthtokenUDP
            // 
            this.tbAuthtokenUDP.Location = new System.Drawing.Point(132, 107);
            this.tbAuthtokenUDP.Name = "tbAuthtokenUDP";
            this.tbAuthtokenUDP.Size = new System.Drawing.Size(153, 21);
            this.tbAuthtokenUDP.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "Authtoken值(UDP)：";
            // 
            // btnStartTCP
            // 
            this.btnStartTCP.Location = new System.Drawing.Point(291, 80);
            this.btnStartTCP.Name = "btnStartTCP";
            this.btnStartTCP.Size = new System.Drawing.Size(65, 21);
            this.btnStartTCP.TabIndex = 21;
            this.btnStartTCP.Tag = "f0391da3b55e4f49";
            this.btnStartTCP.Text = "解析";
            this.btnStartTCP.UseVisualStyleBackColor = true;
            this.btnStartTCP.Click += new System.EventHandler(this.btnStartTCP_Click);
            // 
            // btnStartUDP
            // 
            this.btnStartUDP.Location = new System.Drawing.Point(291, 107);
            this.btnStartUDP.Name = "btnStartUDP";
            this.btnStartUDP.Size = new System.Drawing.Size(65, 21);
            this.btnStartUDP.TabIndex = 22;
            this.btnStartUDP.Tag = "f0391da3b55e4f49";
            this.btnStartUDP.Text = "解析";
            this.btnStartUDP.UseVisualStyleBackColor = true;
            this.btnStartUDP.Click += new System.EventHandler(this.btnStartUDP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProtocol);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbLocalIP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLocalPort);
            this.groupBox1.Controls.Add(this.tbServerPort);
            this.groupBox1.Controls.Add(this.tbServerUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 166);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果";
            // 
            // tbProtocol
            // 
            this.tbProtocol.Location = new System.Drawing.Point(120, 20);
            this.tbProtocol.Name = "tbProtocol";
            this.tbProtocol.ReadOnly = true;
            this.tbProtocol.Size = new System.Drawing.Size(62, 21);
            this.tbProtocol.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "协议：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "本地IP：";
            // 
            // tbLocalIP
            // 
            this.tbLocalIP.Location = new System.Drawing.Point(120, 101);
            this.tbLocalIP.Name = "tbLocalIP";
            this.tbLocalIP.ReadOnly = true;
            this.tbLocalIP.Size = new System.Drawing.Size(198, 21);
            this.tbLocalIP.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "本地端口：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "服务器端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "服务器域名：";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(120, 128);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.ReadOnly = true;
            this.tbLocalPort.Size = new System.Drawing.Size(82, 21);
            this.tbLocalPort.TabIndex = 19;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(120, 74);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.ReadOnly = true;
            this.tbServerPort.Size = new System.Drawing.Size(82, 21);
            this.tbServerPort.TabIndex = 18;
            // 
            // tbServerUrl
            // 
            this.tbServerUrl.Location = new System.Drawing.Point(120, 47);
            this.tbServerUrl.Name = "tbServerUrl";
            this.tbServerUrl.ReadOnly = true;
            this.tbServerUrl.Size = new System.Drawing.Size(198, 21);
            this.tbServerUrl.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartUDP);
            this.Controls.Add(this.btnStartTCP);
            this.Controls.Add(this.tbAuthtokenUDP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAuthtokenTCP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAuthtokenWeb);
            this.Controls.Add(this.tbNatappAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartWeb);
            this.Controls.Add(this.btnNatappAddress);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natapp动态域名端口获取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAuthtokenWeb;
        private System.Windows.Forms.TextBox tbNatappAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartWeb;
        private System.Windows.Forms.Button btnNatappAddress;
        private System.Windows.Forms.TextBox tbAuthtokenTCP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAuthtokenUDP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartTCP;
        private System.Windows.Forms.Button btnStartUDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLocalIP;
        private System.Windows.Forms.TextBox tbProtocol;
        private System.Windows.Forms.Label label10;
    }
}

