using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace Network_Programming
{
    public partial class Client : Form
    {
        ClientClass cc;
        public Client()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            cc = new ClientClass(IPAddress.Parse(textBox1.Text),int.Parse(textBox2.Text));
            string msg = cc.connect();
            if (msg != "Connection failed.")
            {
                MessageBox.Show(msg);
                timer1.Start();
                connect.Enabled = false;
                disconnected.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void disconnected_Click(object sender, EventArgs e)
        {
            string msg = cc.send("exit");
            MessageBox.Show("Disconnected");
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = cc.send("exit");
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = cc.recieve();
            if (text != "N")
            {
                MessageBox.Show(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game g = new Game();
            g.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            disconnected.Enabled = false;
        }
    }
}
