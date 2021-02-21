using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        private void Splashform_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = TictactoeLauncher.Properties.Resources.singshadow;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            single sifrom = new single();
            sifrom.Show();

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = TictactoeLauncher.Properties.Resources.singnoshadow;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = TictactoeLauncher.Properties.Resources.multshadow;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = TictactoeLauncher.Properties.Resources.multnoshadow;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            game form = new game();
            form.Show();
        }

        private void Splashform_Load_1(object sender, EventArgs e)
        {
            /*Process[] processes = Process.GetProcessesByName("TictactoeLauncher");
            if (processes.Length > 1)
            {
                MessageBox.Show("Application allready running..");
                Application.Exit();
            }*/
        }
    }
}
