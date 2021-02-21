using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Hospital_Management_System
{
    public partial class Doctor_Patient_Information : Form
    {
        public Doctor_Patient_Information()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HMS open = new HMS();
            open.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Doctor_Portal open = new Doctor_Portal();
            open.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
