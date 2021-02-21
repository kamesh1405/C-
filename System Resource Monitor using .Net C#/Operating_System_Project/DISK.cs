using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Operating_System_Project
{
    public partial class DISK : MetroFramework.Forms.MetroForm
    {
        public DISK()
        {
            InitializeComponent();
        }

        private void DISK_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fdisk = pDisk.NextValue();
            progressBarDisk.Value = (int)fdisk;
            lblDisk.Text = string.Format("{0:0.00}MB", fdisk);
            chartDisk.Series["Disk"].Points.AddY(fdisk);
            
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                listBox1.Items.Add("DRIVE NAME =  "+drive.Name);
                if (drive.IsReady) listBox1.Items.Add("DRIVE TOTAL SIZE = "+drive.TotalSize);
            }
        }

        private void progressBarDisk_Click(object sender, EventArgs e)
        {

        }
    }
}
