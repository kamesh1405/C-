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
using System.IO;

namespace StartServer
{
    public partial class Form1 : Form
    {
        List<TcpClient> Clients = new List<TcpClient>();
        Thread t;
        TcpListener listener;
        List<PlayerBound> Players = new List<PlayerBound>();
        static IList<ClientIDs> ClientList = new List<ClientIDs>();
        static bool IsClientConneted(TcpClient client)
        {
            if (client.Client.Poll(10, SelectMode.SelectRead))
            {
                byte[] checkConn = new byte[1];
                if (client.Client.Receive(checkConn, SocketFlags.Peek) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class PlayerBound
        {
            public string Player1;
            public string Player2;
        }
        public class ClientIDs
        {
            public string ClientID { get; set; }
            public EndPoint Ip { get; set; }
        }

        private void ThreadProc(object obj)
        {
            var client = (TcpClient)obj;
            while (client.Connected)
            {
                if (!IsClientConneted(client))
                {
                    Invoke((MethodInvoker)(() => listBox2.Items.Add("Client disconnected :" + client.Client.RemoteEndPoint)));
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (client.Client.RemoteEndPoint.ToString() == listBox1.Items[i].ToString())
                        {
                            Invoke((MethodInvoker)(() => listBox1.Items.Remove(client.Client.RemoteEndPoint.ToString())));
                        }
                    }
                    for (int i = 0; i < ClientList.Count; i++)
                    {
                        if (client.Client.RemoteEndPoint == ClientList[i].Ip)
                        {
                            ClientList.RemoveAt(i);
                            Clients.RemoveAt(i);
                        }
                    }
                    string SendClientList = "up";
                    for (int i = 0; i < ClientList.Count; i++)
                    {
                        SendClientList += ClientList[i].ClientID + ",";
                    }
                    byte[] bufi = Encoding.UTF8.GetBytes(SendClientList);
                    for (int i = 0; i < Clients.Count; i++)
                    {
                        NetworkStream Clientsstream = Clients[i].GetStream();
                        Clientsstream.Write(bufi, 0, bufi.Length);
                    }
                    client.Close();
                    break;
                }
                else
                {
                    NetworkStream nwStream = client.GetStream();
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                    string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (dataReceived != "")
                    {
                       
                        NetworkStream p1 = nwStream;
                        NetworkStream p2 = null;
                        string RecivedCommand = dataReceived.Substring(0, 2);
                        string RecivedMessage = "";
                        if (dataReceived.Length > 2) RecivedMessage = dataReceived.Remove(0, 2);
                        if (RecivedCommand == "lo")
                        {
                            ClientList.Add(new ClientIDs { ClientID = RecivedMessage, Ip = client.Client.RemoteEndPoint });
                            Invoke((MethodInvoker)(() => listBox2.Items.Add(RecivedMessage + " Connected")));
                            List<string> ingame = new List<string>();
                            for (int i = 0; i < Players.Count; i++)
                            {
                                ingame.Add(Players[i].Player1);
                                ingame.Add(Players[i].Player2);
                            }
                            string SendClientList = "up";
                            for (int i = 0; i < ClientList.Count; i++)
                            {
                                if (!ingame.Contains(ClientList[i].ClientID))
                                {
                                    SendClientList += ClientList[i].ClientID + ",";
                                }
                            }
                            byte[] bufi = Encoding.UTF8.GetBytes(SendClientList);
                            for (int i = 0; i < Clients.Count; i++)
                            {
                                NetworkStream Clientsstream = Clients[i].GetStream();
                                Clientsstream.Write(bufi, 0, bufi.Length);
                            }
                        }
                        if (RecivedCommand == "pl")
                        {
                            string[] tmp = RecivedMessage.Split(',');
                            string Player1 = tmp[0];
                            string Player2 = tmp[1];
                            Players.Add(new PlayerBound { Player1 = Player1, Player2 = Player2 });
                            List<string> ingame = new List<string>();
                            for (int i = 0; i < Players.Count; i++)
                            {
                                ingame.Add(Players[i].Player1);
                                ingame.Add(Players[i].Player2);

                            }
                            string SendClientList = "up";
                            for (int i = 0; i < ClientList.Count; i++)
                            {
                                if (!ingame.Contains(ClientList[i].ClientID))
                                {
                                    SendClientList += ClientList[i].ClientID + ",";
                                }
                            }
                            byte[] bufi = Encoding.UTF8.GetBytes(SendClientList);
                            for (int i = 0; i < Clients.Count; i++)
                            {
                                NetworkStream Clientsstream = Clients[i].GetStream();
                                Clientsstream.Write(bufi, 0, bufi.Length);
                            }
                            EndPoint ip = null;
                            
                            byte[] bufif = Encoding.UTF8.GetBytes("pa"+Player1);
                            for (int i = 0; i < ClientList.Count; i++)
                            {
                                if (ClientList[i].ClientID == Player2)
                                {
                                    ip = ClientList[i].Ip;
                                }
                            }

                            for (int i = 0; i < Clients.Count; i++)
                            {
                                if (Clients[i].Client.RemoteEndPoint == ip)
                                {
                                    p2 = Clients[i].GetStream();
                                    p2.Write(bufif, 0, bufif.Length);
                                }
                            }
                        }
                        if(RecivedCommand == "mv")
                        {
                            string Player1 = "";
                            string Player2 = "";
                            string[] tmp = RecivedMessage.Split(',');
                            string Player = tmp[0];
                            string Step = tmp[1];
                            for (int i = 0; i < Players.Count; i++)
                            {
                                if (Players[i].Player1 == Player)
                                {
                                    Player1 = Players[i].Player1;
                                    Player2 = Players[i].Player2;
                                }
                                if(Players[i].Player2 == Player)
                                {
                                    Player1 = Players[i].Player1;
                                    Player2 = Players[i].Player2;
                                }
                               
                            }
                            EndPoint ip = null;
                            if(Player1 == Player)
                            {
                                for (int i = 0; i < ClientList.Count; i++)
                                {
                                    if (ClientList[i].ClientID == Player2)
                                    {
                                        ip = ClientList[i].Ip;
                                    }
                                }
                                for (int i = 0; i < Clients.Count; i++)
                                {
                                    if (Clients[i].Client.RemoteEndPoint == ip)
                                    {
                                        p2 = Clients[i].GetStream();
                                        string textToSend = "mv" + Step;
                                        byte[] bytesToSend = Encoding.UTF8.GetBytes(textToSend);
                                        p2.Write(bytesToSend, 0, bytesToSend.Length);
                                    }
                                }
                            }
                            if(Player2 == Player)
                            {
                                for (int i = 0; i < ClientList.Count; i++)
                                {
                                    if (ClientList[i].ClientID == Player1)
                                    {
                                        ip = ClientList[i].Ip;
                                    }
                                }
                                for (int i = 0; i < Clients.Count; i++)
                                {
                                    if (Clients[i].Client.RemoteEndPoint == ip)
                                    {
                                        p2 = Clients[i].GetStream();
                                        string textToSend = "mv" + Step;
                                        byte[] bytesToSend = Encoding.UTF8.GetBytes(textToSend);
                                        p2.Write(bytesToSend, 0, bytesToSend.Length);
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
       
        private void Listening()
        {
            Invoke((MethodInvoker)(() => label3.Text = "ON"));
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            const int PORT_NO = 12000;
            //---listen at the specified IP and port no.---
            listener = new TcpListener(ipAddress, PORT_NO);
            Invoke((MethodInvoker)(() => listBox2.Items.Add("Server Online! Listening..")));
            TcpClient client;
            listener.Start();
            while (label3.Text == "ON") // Add your exit flag here
            {
                client = listener.AcceptTcpClient();
                Clients.Add(client);
                Invoke((MethodInvoker)(() => listBox2.Items.Add("Client connected: " + client.Client.RemoteEndPoint)));
                Invoke((MethodInvoker)(() => listBox1.Items.Add(client.Client.RemoteEndPoint.ToString())));
                int ind = Clients.IndexOf(Clients.Last());
                ThreadPool.QueueUserWorkItem(ThreadProc, Clients[ind]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(() => Listening());
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "OFF";
            listener.Stop();
            t.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
                t.Abort();
            }
            catch
            {

            }
            
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //IsGame = false;
        }
    }
}
