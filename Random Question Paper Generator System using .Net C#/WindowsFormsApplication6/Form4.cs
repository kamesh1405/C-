using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class User_Choose_Subjects : Form
    {
        public User_Choose_Subjects()
        {
            InitializeComponent();
        }

        private void Zoology_Click(object sender, EventArgs e)
        {
            Zoology open = new Zoology();
            open.Show();
            this.Hide();
        }

        private void Chemistry_Click(object sender, EventArgs e)
        {
            Chemistry open = new Chemistry();
            open.Show();
            this.Hide();
        }

        private void Botany_Click(object sender, EventArgs e)
        {
            Botany open = new Botany();
            open.Show();
            this.Hide();
        }

        private void Physics_Click(object sender, EventArgs e)
        {
            Physics open = new Physics();
            open.Show();
            this.Hide();
        }

        private void Computer_Click(object sender, EventArgs e)
        {
            Computer open = new Computer();
            open.Show();
            this.Hide();
        }
    }
}
