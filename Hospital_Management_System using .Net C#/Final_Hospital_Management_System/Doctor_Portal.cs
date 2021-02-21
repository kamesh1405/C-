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
    public partial class Doctor_Portal : Form
    {
        public Doctor_Portal()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           DoctorLogin open = new DoctorLogin();
            open.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HMS open = new HMS();
            open.Show();
            this.Hide();
        }

        private void DoctorMyProfile_Click(object sender, EventArgs e)
        {
            Doctor_My_Profile open = new Doctor_My_Profile();
            open.Show();
            this.Hide();

        }

        private void DoctorAttendence_Click(object sender, EventArgs e)
        {
            Attendence open = new Attendence();
            open.Show();
            this.Hide();
        }

        private void DoctorPatientDetail_Click(object sender, EventArgs e)
        {
            Doctor_Patient_Information open = new Doctor_Patient_Information();
            open.Show();
            this.Hide();
        }
    }
}
