using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Hospital_Management_System
{
    public partial class HMS : Form
    {
        public HMS()
        {
            InitializeComponent();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            AdminLogin open = new AdminLogin();
            open.Show();
            this.Hide();
        }

        private void DoctorLoginButton_Click(object sender, EventArgs e)
        {
            DoctorLogin open = new DoctorLogin();
            open.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Sign_Up open= new Sign_Up();
            open.Show();
            this.Hide();
        }

        private void ExitButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
