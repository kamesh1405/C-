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
    public partial class QBS : Form
    {
        public QBS()
        {
            InitializeComponent();
        }

        private void Go_To_Next_Page_Button_Click(object sender, EventArgs e)
        {
            Login_Portal open = new Login_Portal();
            open.Show();
            this.Hide();
        }
    }
}
