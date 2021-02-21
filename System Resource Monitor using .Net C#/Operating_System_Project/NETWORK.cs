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
using System.Net.NetworkInformation;

namespace Operating_System_Project
{
    public partial class NETWORK : MetroFramework.Forms.MetroForm
    {
        public NETWORK()
        {
            InitializeComponent();
        }

        private void NETWORK_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        long preBytesSend = 0;
        long preBytesRecieved = 0;
        long Dspeed, USpeed = 0;
        IPv4InterfaceStatistics IFace;
        private void timer_Tick(object sender, EventArgs e)
        {
            IFace = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();
            USpeed = (IFace.BytesSent - preBytesSend) / 1024;
            Dspeed = (IFace.BytesReceived - preBytesRecieved) / 1024;
            preBytesSend = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesSent;
            preBytesRecieved = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesReceived;
            label2.Text = "DOWNLOAD"+Math.Round((double)Dspeed, 2)+" KB/S";
            label3.Text = "DOWNLOAD" + Math.Round((double)USpeed, 2) + " KB/S";

            //float frec = (pNetworkRec.RawValue)/1024;
            //progressBarRec.Value = (int)frec;
            //lblREC.Text = string.Format("{0:0.00}%", frec);
            //chartNetwork.Series["REC"].Points.AddY(frec);

            //float fsent = (pNetworkSent.RawValue)/1024;
            //progressBarSent.Value = (int)fsent;
            //lblSent.Text = string.Format("{0:0.00}%", fsent);
            //chartNetwork.Series["Sent"].Points.AddY(fsent);
        }
    }
}
