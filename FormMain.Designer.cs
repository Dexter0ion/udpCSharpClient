namespace udpCSharpClient
{
    partial class Form1
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
            this.btnConnecTestClient = new System.Windows.Forms.Button();
            this.tbxServerIp = new System.Windows.Forms.TextBox();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.tbxServerPort = new System.Windows.Forms.TextBox();
            this.tbxClientPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.tbxClientIp = new System.Windows.Forms.TextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tbxClientSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnecTestClient
            // 
            this.btnConnecTestClient.Location = new System.Drawing.Point(33, 374);
            this.btnConnecTestClient.Name = "btnConnecTestClient";
            this.btnConnecTestClient.Size = new System.Drawing.Size(232, 83);
            this.btnConnecTestClient.TabIndex = 0;
            this.btnConnecTestClient.Text = "Client测试连接";
            this.btnConnecTestClient.UseVisualStyleBackColor = true;
            this.btnConnecTestClient.Click += new System.EventHandler(this.btnConnecTest_Click);
            // 
            // tbxServerIp
            // 
            this.tbxServerIp.Location = new System.Drawing.Point(33, 54);
            this.tbxServerIp.Name = "tbxServerIp";
            this.tbxServerIp.Size = new System.Drawing.Size(232, 25);
            this.tbxServerIp.TabIndex = 1;
            this.tbxServerIp.Text = "127.0.0.1";
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(33, 33);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(86, 15);
            this.lblServerIp.TabIndex = 2;
            this.lblServerIp.Text = "Server端IP";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(33, 92);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(102, 15);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Server端Port";
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.Location = new System.Drawing.Point(33, 119);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(232, 25);
            this.tbxServerPort.TabIndex = 4;
            this.tbxServerPort.Text = "11000";
            // 
            // tbxClientPort
            // 
            this.tbxClientPort.Location = new System.Drawing.Point(36, 240);
            this.tbxClientPort.Name = "tbxClientPort";
            this.tbxClientPort.Size = new System.Drawing.Size(232, 25);
            this.tbxClientPort.TabIndex = 8;
            this.tbxClientPort.Text = "11001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "本客户端Port";
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(36, 162);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(83, 15);
            this.lblClientPort.TabIndex = 6;
            this.lblClientPort.Text = "本客户端IP";
            // 
            // tbxClientIp
            // 
            this.tbxClientIp.Location = new System.Drawing.Point(33, 180);
            this.tbxClientIp.Name = "tbxClientIp";
            this.tbxClientIp.Size = new System.Drawing.Size(232, 25);
            this.tbxClientIp.TabIndex = 5;
            this.tbxClientIp.Text = "127.0.0.1";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(33, 281);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(232, 74);
            this.btnSaveInfo.TabIndex = 9;
            this.btnSaveInfo.Text = "保存连接信息";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tbxClientSend
            // 
            this.tbxClientSend.BackColor = System.Drawing.SystemColors.Window;
            this.tbxClientSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxClientSend.Location = new System.Drawing.Point(286, 54);
            this.tbxClientSend.Multiline = true;
            this.tbxClientSend.Name = "tbxClientSend";
            this.tbxClientSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxClientSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxClientSend.Size = new System.Drawing.Size(444, 151);
            this.tbxClientSend.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 492);
            this.Controls.Add(this.tbxClientSend);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.tbxClientPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientPort);
            this.Controls.Add(this.tbxClientIp);
            this.Controls.Add(this.tbxServerPort);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.lblServerIp);
            this.Controls.Add(this.tbxServerIp);
            this.Controls.Add(this.btnConnecTestClient);
            this.Name = "Form1";
            this.Text = "UDP-Client端-邵博超";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecTestClient;
        private System.Windows.Forms.TextBox tbxServerIp;
        private System.Windows.Forms.Label lblServerIp;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tbxServerPort;
        private System.Windows.Forms.TextBox tbxClientPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.TextBox tbxClientIp;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox tbxClientSend;
    }
}

