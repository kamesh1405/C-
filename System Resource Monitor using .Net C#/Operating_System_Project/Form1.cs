using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operating_System_Project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPU cpu = new CPU();
            cpu.Show();
        }

        private void rAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAM ram = new RAM();
            ram.Show();
        }

        private void nETWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NETWORK net = new NETWORK();
            net.Show();
        }

        private void dISKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DISK disk = new DISK();
            disk.Show();
        }
    }
}
