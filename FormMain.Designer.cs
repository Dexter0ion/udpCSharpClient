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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnClientListen = new System.Windows.Forms.Button();
            this.tbxChatClient = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerMsgPort = new System.Windows.Forms.TextBox();
            this.tbxClientMsgPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnecTestClient
            // 
            this.btnConnecTestClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConnecTestClient.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnecTestClient.Location = new System.Drawing.Point(3, 351);
            this.btnConnecTestClient.Name = "btnConnecTestClient";
            this.btnConnecTestClient.Size = new System.Drawing.Size(367, 40);
            this.btnConnecTestClient.TabIndex = 0;
            this.btnConnecTestClient.Text = "发送";
            this.btnConnecTestClient.UseVisualStyleBackColor = false;
            this.btnConnecTestClient.Click += new System.EventHandler(this.btnConnecTest_Click);
            // 
            // tbxServerIp
            // 
            this.tbxServerIp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxServerIp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerIp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxServerIp.Location = new System.Drawing.Point(14, 51);
            this.tbxServerIp.Name = "tbxServerIp";
            this.tbxServerIp.Size = new System.Drawing.Size(232, 31);
            this.tbxServerIp.TabIndex = 1;
            this.tbxServerIp.Text = "127.0.0.1";
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServerIp.Location = new System.Drawing.Point(8, 17);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(133, 31);
            this.lblServerIp.TabIndex = 2;
            this.lblServerIp.Text = "Server端IP";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServerPort.Location = new System.Drawing.Point(8, 79);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(159, 31);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Server端Port";
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxServerPort.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerPort.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxServerPort.Location = new System.Drawing.Point(14, 113);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(232, 31);
            this.tbxServerPort.TabIndex = 4;
            this.tbxServerPort.Text = "11000";
            // 
            // tbxClientPort
            // 
            this.tbxClientPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxClientPort.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientPort.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxClientPort.Location = new System.Drawing.Point(14, 329);
            this.tbxClientPort.Name = "tbxClientPort";
            this.tbxClientPort.Size = new System.Drawing.Size(232, 31);
            this.tbxClientPort.TabIndex = 8;
            this.tbxClientPort.Text = "11001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "本客户端Port";
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClientPort.Location = new System.Drawing.Point(11, 216);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(137, 32);
            this.lblClientPort.TabIndex = 6;
            this.lblClientPort.Text = "本客户端IP";
            // 
            // tbxClientIp
            // 
            this.tbxClientIp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxClientIp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientIp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxClientIp.Location = new System.Drawing.Point(14, 251);
            this.tbxClientIp.Name = "tbxClientIp";
            this.tbxClientIp.Size = new System.Drawing.Size(232, 31);
            this.tbxClientIp.TabIndex = 5;
            this.tbxClientIp.Text = "127.0.0.1";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.LightBlue;
            this.btnSaveInfo.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveInfo.Location = new System.Drawing.Point(14, 455);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(232, 44);
            this.btnSaveInfo.TabIndex = 9;
            this.btnSaveInfo.Text = "保存连接信息";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tbxClientSend
            // 
            this.tbxClientSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxClientSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxClientSend.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientSend.Location = new System.Drawing.Point(3, 315);
            this.tbxClientSend.Multiline = true;
            this.tbxClientSend.Name = "tbxClientSend";
            this.tbxClientSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxClientSend.Size = new System.Drawing.Size(367, 30);
            this.tbxClientSend.TabIndex = 10;
            // 
            // btnClientListen
            // 
            this.btnClientListen.BackColor = System.Drawing.Color.LightBlue;
            this.btnClientListen.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClientListen.Location = new System.Drawing.Point(6, 468);
            this.btnClientListen.Name = "btnClientListen";
            this.btnClientListen.Size = new System.Drawing.Size(160, 47);
            this.btnClientListen.TabIndex = 13;
            this.btnClientListen.Text = "Client开始监听";
            this.btnClientListen.UseVisualStyleBackColor = false;
            this.btnClientListen.Click += new System.EventHandler(this.btnClientListen_Click);
            // 
            // tbxChatClient
            // 
            this.tbxChatClient.AcceptsTab = true;
            this.tbxChatClient.BackColor = System.Drawing.Color.Black;
            this.tbxChatClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxChatClient.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxChatClient.ForeColor = System.Drawing.Color.White;
            this.tbxChatClient.Location = new System.Drawing.Point(3, 6);
            this.tbxChatClient.Multiline = true;
            this.tbxChatClient.Name = "tbxChatClient";
            this.tbxChatClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxChatClient.Size = new System.Drawing.Size(367, 294);
            this.tbxChatClient.TabIndex = 14;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenFile.Location = new System.Drawing.Point(6, 397);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(364, 37);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "打开接收文件夹";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Server端文件Port";
            // 
            // tbxServerMsgPort
            // 
            this.tbxServerMsgPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxServerMsgPort.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServerMsgPort.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxServerMsgPort.Location = new System.Drawing.Point(14, 175);
            this.tbxServerMsgPort.Name = "tbxServerMsgPort";
            this.tbxServerMsgPort.Size = new System.Drawing.Size(232, 31);
            this.tbxServerMsgPort.TabIndex = 17;
            this.tbxServerMsgPort.Text = "11002";
            // 
            // tbxClientMsgPort
            // 
            this.tbxClientMsgPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxClientMsgPort.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxClientMsgPort.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxClientMsgPort.Location = new System.Drawing.Point(14, 404);
            this.tbxClientMsgPort.Name = "tbxClientMsgPort";
            this.tbxClientMsgPort.Size = new System.Drawing.Size(232, 31);
            this.tbxClientMsgPort.TabIndex = 19;
            this.tbxClientMsgPort.Text = "11003";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "本客户端文件Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 550);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(380, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "开始";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 540);
            this.panel1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.lblServerIp);
            this.tabPage1.Controls.Add(this.tbxServerIp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblServerPort);
            this.tabPage1.Controls.Add(this.tbxClientMsgPort);
            this.tabPage1.Controls.Add(this.btnSaveInfo);
            this.tabPage1.Controls.Add(this.tbxServerPort);
            this.tabPage1.Controls.Add(this.tbxServerMsgPort);
            this.tabPage1.Controls.Add(this.tbxClientIp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblClientPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxClientPort);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置连接信息";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxChatClient);
            this.tabPage2.Controls.Add(this.btnOpenFile);
            this.tabPage2.Controls.Add(this.tbxClientSend);
            this.tabPage2.Controls.Add(this.btnClientListen);
            this.tabPage2.Controls.Add(this.btnConnecTestClient);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通信";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(380, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "制作小组信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(13, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 295);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "UDP 一班二组 计算机科学与技术1班\r\n\r\n负责人：\r\n邵博超 2016110131 \r\n\r\n组员：\r\n\r\n朱利佳 2016110163\r\n王艳琴 201611" +
    "0138\r\n邓偲易 2016110106";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(407, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "UDP-Client端-邵博超";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnClientListen;
        private System.Windows.Forms.TextBox tbxChatClient;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerMsgPort;
        private System.Windows.Forms.TextBox tbxClientMsgPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
    }
}

