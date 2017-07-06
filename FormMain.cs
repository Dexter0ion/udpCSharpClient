using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace udpCSharpClient
{
    public partial class Form1 : Form
    {
        static Socket client;
        string serverIp = null;
        int serverPort = 0;
        string clientIp = null;
        int clientPort = 0;
        IPAddress remoteIP;
        IPEndPoint remotePoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnecTest_Click(object sender, EventArgs e)
        {
            string serverIp = tbxServerIp.Text;
            int serverPort = int.Parse(tbxServerPort.Text);
            string clientIp = tbxClientIp.Text;
            int clientPort = int.Parse(tbxClientPort.Text);

            IPAddress remoteIP = IPAddress.Parse(serverIp); //假设发送给这个IP
            int remotePort = serverPort;
            IPEndPoint remotePoint = new IPEndPoint(remoteIP, remotePort);//实例化一个远程端点
            if (tbxClientSend.Text != null)
            {
                string sendString = null;//要发送的字符串
                byte[] sendData = null;//要发送的字节数组 
                sendString = tbxClientSend.Text;
                sendData = Encoding.Default.GetBytes(sendString);
                UdpClient client = null;
                client = new UdpClient();
                client.Send(sendData, sendData.Length, remotePoint);//将数据发送到远程端点 
                client.Close();//关闭连接 
            }

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
 
        }
    }
}
