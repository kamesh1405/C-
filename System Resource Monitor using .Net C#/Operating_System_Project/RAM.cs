using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace Operating_System_Project
{
    public partial class RAM : MetroFramework.Forms.MetroForm
    {
        Process[] processes = Process.GetProcesses();
        public RAM()
        {
            InitializeComponent();
        }

        private void RAM_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fram = pRAM.NextValue();
            progressBarRAM.Value = (int)fram;
            lblRAM.Text = string.Format("{0:0.00}MB", fram);
            chartRAM.Series["RAM"].Points.AddY(fram);

            foreach (Process process in processes)
            {
                // MemoryInfrormationList.Items.Add(process.VirtualMemorySize64);
            }
          
        }
    }

    internal class ManagementObjectSearcher
    {
    }
}
