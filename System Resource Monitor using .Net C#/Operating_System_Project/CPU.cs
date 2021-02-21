using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Operating_System_Project
{
    public partial class CPU : MetroFramework.Forms.MetroForm
    {
        Process[] processes = Process.GetProcesses();

        public CPU()
        {
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            progressBarCPU.Value = (int)fcpu;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            chart1.Series["CPU"].Points.AddY(fcpu);

            foreach (Process process in processes)
            {
                ProcessList.Items.Add(process.ProcessName);
                PIDList.Items.Add(process.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
