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
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminLogin open = new AdminLogin();
            open.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HMS open = new HMS();
            open.Show();
            this.Hide();
        }

        private void AdminMyProfile_Click(object sender, EventArgs e)
        {
            Admin_My_Profile open = new Admin_My_Profile();
            open.Show();
            this.Hide();
        }

        private void AdminDoctorDetails_Click(object sender, EventArgs e)
        {
            Doctor_Details open = new Doctor_Details();
            open.Show();
            this.Hide();
        }

        private void AdminPatientDetail_Click(object sender, EventArgs e)
        {
            Admin_Patient_Information open = new Admin_Patient_Information();
            open.Show();
            this.Hide();
          
        }

        private void AdminCheckDoctorAttendence_Click(object sender, EventArgs e)
        {
            Admin_Check_Attendence open = new Admin_Check_Attendence();
            open.Show();
            this.Hide();
            
        }
    }
}
