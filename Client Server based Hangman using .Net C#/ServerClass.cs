using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Network_Programming
{
    class ServerClass
    {
        int recv;
        byte[] data = new byte[1024];
        IPEndPoint iep;
        Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket client;
        IPEndPoint clientip;
        Stream stream;
        StreamWriter writer;
        GetWord gw = new GetWord();
        string msg = "";

        public ServerClass(IPAddress ip, int port)
        {
            iep = new IPEndPoint(ip, port);
            newsock.Bind(iep);
        }

        public int Accept()
        {
            newsock.Listen(5);
            client = newsock.Accept();
            client.ReceiveTimeout = 50;
            stream = new NetworkStream(client);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            if (client != null)
            {
                clientip = (IPEndPoint)client.RemoteEndPoint;
                string welcome = "Welcome to my test server";
                writer.Write(welcome);
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public string info()
        {
            return "Connected Client IP: " + clientip.Address + " and port is: " + clientip.Port;
        }
        public string Recieve()
        {
            data = new byte[1024];
            try
            {
                recv = client.Receive(data);
                return Encoding.ASCII.GetString(data, 0, recv);
            }
            catch (SocketException)
            {
                return "N";
            }
        }
        public void Send(string msg)
        {
            data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length, SocketFlags.None);
        }

        public void sendWord()
        {
            msg = gw.sendword();
            data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length, SocketFlags.None);
        }
        public void exitCon()
        {
            client.Close();
            newsock.Close();
        }
        public void dcClient()
        {
            client.Close();
        }
    }
}
