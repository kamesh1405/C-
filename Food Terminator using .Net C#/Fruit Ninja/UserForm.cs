﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public partial class UserForm : Form
    {
        public Timer timer;

        public UserForm()
        {
            InitializeComponent();
            fillUsers();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "")
            {
                if (tbName.Text.Length > 3 && tbName.Text.Length < 11)
                {
                    User user = new User(tbName.Text);
                    if (!Main.users.ContainsKey(tbName.Text.ToUpper()))
                    {
                        Main.users.Add(tbName.Text.ToUpper(), user);
                        fillUsers();
                    }
                    else
                        MessageBox.Show("User already exists!");
                }
                else
                    MessageBox.Show("Username must be between 4 and 10 characters.");
            }
            else
            {
                MessageBox.Show("Please enter a name!");
            }
            tbName.Text = "";
            btnSelect.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Main.currentUser = lbUsers.SelectedItem as User;
            lblInfo.ForeColor = Color.White;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(lblInfo.ForeColor == Color.White)
            {
                lblInfo.ForeColor = Color.Black;
                timer.Stop();
            }
        }

        private void lbUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Red);

            e.DrawBackground();
            e.Graphics.DrawString(lbUsers.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex != -1)
                btnSelect.Enabled = true;
            else
                btnSelect.Enabled = false;
        }

        private void fillUsers()
        {
            lbUsers.Items.Clear();
            foreach (User user in Main.users.Values)
                lbUsers.Items.Add(user);
        }
    }
}
