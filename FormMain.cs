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
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnecTest_Click(object sender, EventArgs e)
        {
            bool socketFlag=false;
            bool msgFlag=false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text!=null&&tbxServerPort!=null)
            {
                mySocket = new SocketConnect(tbxServerIp.Text,int.Parse(tbxServerPort.Text));
                socketFlag=true;
            }
            if(socketFlag)
            {
                mySocket.initSocketIpConnect();
            }
            if (tbxClientSend.Text != null)
            {
                msgFlag=true;
            }
            if(msgFlag)
            {
                mySocket.sentData(tbxClientSend.Text);
                tbxChatClient.Text += "Client:" + tbxClientSend.Text + "\r\n";
            }

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
 
        }



       

        private void btnClientListen_Click(object sender, EventArgs e)
        {

                Thread tRecvStr = new Thread(clientListenServer);
                Thread tRecvFile = new Thread(clientRecvFile);
                tRecvStr.Start();
                tRecvFile.Start();


        }

        private void clientListenServer()
        {
            bool socketFlag = false;
            bool fileFlag = false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text != null && tbxServerPort.Text != null && tbxClientIp.Text != null && tbxClientPort != null)
            {
                mySocket = new SocketConnect(tbxServerIp.Text, int.Parse(tbxServerPort.Text), tbxClientIp.Text, int.Parse(tbxClientPort.Text));
                socketFlag = true;
            }

            if (socketFlag)
            {
                mySocket.initSocketIpConnect();
            }

            while (true)
            {
                try
                {
                    string chatStr = mySocket.listenStr();
                    tbxChatClient.Text += "Server:" + chatStr + "\r\n";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {

                }
                
                
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string path = "d:\\udpRecv";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void btnClientRecv_Click(object sender, EventArgs e)
        {
            Thread tRecvFile = new Thread(clientRecvFile);
            tRecvFile.Start();
        }

        void clientRecvFile()
        {
            bool socketFlag = false;
            bool fileFlag = false;
            SocketConnect mySocket = new SocketConnect();
            if (tbxServerIp.Text != null && tbxServerPort.Text != null && tbxClientIp.Text != null && tbxClientPort != null&&tbxServerMsgPort.Text!=null&&tbxClientMsgPort.Text!=null)
            {
                mySocket = new SocketConnect(tbxServerIp.Text, int.Parse(tbxServerMsgPort.Text), tbxClientIp.Text, int.Parse(tbxClientMsgPort.Text));
                socketFlag = true;
            }

            if (socketFlag)
            {
                mySocket.initSocketIpConnect();
            }

            while (true)
            {
                try
                {
                    string fileMsg = mySocket.recvFile();
                    tbxChatClient.Text += "成功接收文件\r\n";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
