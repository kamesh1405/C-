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

namespace Network_Programming
{
    public partial class Server : Form
    {
        ServerClass sc; 
        public Server()
        {
            InitializeComponent();
            send.Enabled = false;
            end.Enabled = false;
            accept.Enabled = false;
            sendbox.Enabled = false;
            listBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string txt = sc.Recieve();
            if (txt == "exit" || txt == "Exit")
            {
                listBox1.Items.Clear();
                timer1.Stop();
            }
            else if(txt != "N")
            {
                recvbox.Text = txt;
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            int check = sc.Accept();
            if (check == 1)
            {
                listBox1.Items.Add(sc.info());
                timer1.Start();
                send.Enabled = true;
                sendbox.Enabled = true;
            }
            else
            {
                MessageBox.Show("No incoming connection");
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void start_Click(object sender, EventArgs e)
        {
            IPHostEntry ipentry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] ip = ipentry.AddressList;
            label1.Text = label1.Text+ip[1].ToString();
            label2.Text = label2.Text+"7880";
            sc = new ServerClass(IPAddress.Parse(ip[1].ToString()), int.Parse("7880"));
            accept.Enabled = true;
            end.Enabled = true;
            start.Enabled = false;
        }

        private void send_Click(object sender, EventArgs e)
        {
            sc.Send(sendbox.Text);
        }

       
    }
}
