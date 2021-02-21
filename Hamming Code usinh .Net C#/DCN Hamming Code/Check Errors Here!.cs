using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCN_Hamming_Code
{
    public partial class Error_Checker : Form
    {
        public Hamming_Code hammingobj;
        public Error_Checker()
        {
            InitializeComponent();
            hammingobj = new Hamming_Code(this);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            int a1 = int.Parse(Sendertext1.Text);
            int a2 = int.Parse(Sendertext2.Text);
            int a3 = int.Parse(Sendertext3.Text);
            int a4 = int.Parse(Sendertext4.Text);
            int a5 = int.Parse(Sendertext5.Text);
            int a6 = int.Parse(Sendertext6.Text);
            int a7 = int.Parse(Sendertext7.Text);

            if (a1 < 0 || a1 > 1 || a2 < 0 || a2 > 1 || a3 < 0 || a3 > 1 || a4 < 0 || a4 > 1 || a5 < 0 || a5 > 1 || a6 < 0 || a6 > 1 || a7 < 0 || a7 > 1)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                displaysendingBits.Clear();
                hammingobj.HammingSender(a1, a2, a3, a4,a5,a6,a7);
            }
            
            
        }

        private void Reciever_Click(object sender, EventArgs e)
        {
            int b1 = int.Parse(Recievertext1.Text);
            int b2 = int.Parse(Recievertext2.Text);
            int b3 = int.Parse(Recievertext3.Text);
            int b4 = int.Parse(Recievertext4.Text);
            int b5 = int.Parse(Recievertext5.Text);
            int b6 = int.Parse(Recievertext6.Text);
            int b7 = int.Parse(Recievertext7.Text);
            int b8 = int.Parse(Recievertext8.Text);
            int b9 = int.Parse(Recievertext9.Text);
            int b10 = int.Parse(Recievertext10.Text); 
            int b11 = int.Parse(Recievertext11.Text);

            if (b1 < 0 || b1 > 1 || b2 < 0 || b2 > 1 || b3 < 0 || b3 > 1 || b4 < 0 || b4 > 1 || b5 < 0 || b5 > 1 || b6 < 0 || b6 > 1 || b7 < 0 || b7 > 1 || b8 < 0 || b8 > 1 || b9 < 0 || b9 > 1 || b10 < 0 || b10 > 1 || b11 < 0 || b11 > 1)
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                displayRecievingBits.Clear();
                hammingobj.HammingReciever(b1, b2, b3, b4, b5, b6, b7,b8,b9,b10,b11);
            }
        }
    }
}
