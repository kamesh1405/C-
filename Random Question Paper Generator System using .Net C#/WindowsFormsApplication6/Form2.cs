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
    public partial class Admin_Login_Portal : Form
    {
        public Admin_Login_Portal()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Login_Portal open = new Login_Portal();
            open.Show();
            this.Hide();
        }
    }
}
