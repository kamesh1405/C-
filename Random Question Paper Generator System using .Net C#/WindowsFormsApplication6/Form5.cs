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
    public partial class Login_Portal : Form
    {
        public Login_Portal()
        {
            InitializeComponent();
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            Admin_Login_Portal open = new Admin_Login_Portal();
            open.Show();
            this.Hide();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            User_Login_Portal open = new User_Login_Portal();
            open.Show();
            this.Hide();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Sign_Up open = new Sign_Up();
            open.Show();
            this.Hide();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
