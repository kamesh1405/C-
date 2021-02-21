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
    public partial class Admin_Check_Attendence : Form

    {
        string Connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data
       Source=C:\Users\hammad\Documents\Hospital_Management_System.accdb";
        public Admin_Check_Attendence()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Admin_Portal open = new Admin_Portal();
            open.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HMS open = new HMS();
            open.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OleDbConnection Con = new OleDbConnection(Connection);
            string query = "Select * from Attendence";
            OleDbCommand cmd = new OleDbCommand(query,Con);
            Con.Open();
            
        }
    }
}
