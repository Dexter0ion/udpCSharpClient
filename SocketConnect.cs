using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
namespace udpCSharpClient
{
    class SocketConnect
    {
        private string serverIp;
        private int serverPort;
        private string clientIp;
        private int clientPort;
        private IPAddress remoteIP;
        private IPEndPoint remotePoint;
        private string sendString;
        private byte[] sendData;
        string receiveString;
        byte[] receiveData;

        /*
            Port 20, FTP Data
            Port 21, FTP Control
            Port 25, SMTP (email and outgoing)
            Port 53, DNS
            Port 80, HTTP (Web)
            Port 110, POP3 (email, incoming)
            Port 143, IMAP (email, incoming)
        */
        public SocketConnect()
        {
            serverIp = null;
            serverPort = 0;
            clientIp = null;
            clientPort = 0;
        }
        public SocketConnect(string serverIp_, int serverPort_)
        {
            serverIp = serverIp_;
            serverPort = serverPort_;
            clientIp = null;
            clientPort = 0;
        }
        public SocketConnect(string serverIp_, int serverPort_, string clientIp_, int clientPort_)
        {
            serverIp = serverIp_;
            serverPort = serverPort_;
            clientIp = clientIp_;
            clientPort = clientPort_;
        }

        public void initSocketIpConnect()
        {
            //client
            remoteIP = IPAddress.Parse(serverIp);
            int remotePort = serverPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
        }

        public void sentData(string msg)
        {
            sendString = msg;
            sendData = Encoding.Default.GetBytes(sendString);

            UdpClient client = null;
            client = new UdpClient();
            client.Send(sendData, sendData.Length, remotePoint); //发送数据至远程端口
            client.Close();
        }

        public string listenStr()
        {
            remoteIP = IPAddress.Parse(clientIp);
            int remotePort = clientPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
            UdpClient client = new UdpClient(clientPort);
            receiveData = client.Receive(ref remotePoint);
            receiveString = Encoding.Default.GetString(receiveData);
            string msgListen = receiveString;
            client.Close();
            return msgListen;
        }

        public void sendFile(string filePath)
        {
            remoteIP = IPAddress.Parse(clientIp);
            int remotePort = clientPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fileData = br.ReadBytes(Convert.ToInt16(fs.Length));

            UdpClient client = null;
            client = new UdpClient();

            client.Send(fileData, fileData.Length, remotePoint);
        }

        public string recvFile()
        {
            remoteIP = IPAddress.Parse(serverIp);
            int remotePort = serverPort;
            remotePoint = new IPEndPoint(remoteIP, remotePort);
            UdpClient client = new UdpClient(clientPort);
            receiveData = client.Receive(ref remotePoint);
            File.WriteAllBytes(@"d:\udpRecv\RecvPic.jpg", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvTxt.txt", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvPng.png", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvExe.exe", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvCpp.cpp", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvWord.word", receiveData);
            File.WriteAllBytes(@"d:\udpRecv\RecvExcel.excel", receiveData);
            string FILE_NAME = "Test.jpg";
            if (!File.Exists(FILE_NAME))
            {

                //Create new file
                FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
                //creat writer for data
                BinaryWriter w = new BinaryWriter(fs);
                for (int i = 0; i < receiveData.Length; i++)
                {
                    w.Write(receiveData[i]);
                }
                w.Close();
                fs.Close();
            }
           

            
 
            
            receiveString = Encoding.Default.GetString(receiveData);
            string fileListen = receiveString;
            client.Close();
            return fileListen;
        }
    }
}
