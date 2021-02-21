using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
namespace DATASTRUCTURES
{
    public partial class Form1 : Form
    {
        // WinForms Media Player Class instance Created
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        
        public Form1()
        {
            InitializeComponent();
            player.URL = "AUD-20190321-WA0000.mp3";//Music File Name which is stored in its Debug Folder.
            player.controls.stop();
        }

        private void AddanewMovie_Click(object sender, EventArgs e)
        {
            //Show Add Movie Form
            AddmovieForm open = new AddmovieForm();
            open.Show();
            this.Hide();//The Welcome Form Will Hide
        }

        private void musicononeclick_Click(object sender, EventArgs e)
        {
            player.controls.play();//Music Will Play
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
