using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seproject
{
    public partial class dataanalysisform : Form
    {
        public dataanalysisform()
        {
            InitializeComponent();
        }

        private void daclosebtn_Click(object sender, EventArgs e)
        {
            DialogResult adminExit;
            adminExit = MessageBox.Show("Confirm Exit?  You will be logged out!",
                "Menu Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (adminExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void daclosebtn_MouseEnter(object sender, EventArgs e)
        {
            daclosebtn.BackColor = Color.Red;
        }

        private void daclosebtn_MouseLeave(object sender, EventArgs e)
        {
            daclosebtn.BackColor = Color.Transparent;
        }

        private void dabackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform l4 = new loginform();
            l4.Show();
        }

        private void dabackbtn_MouseEnter(object sender, EventArgs e)
        {
            dabackbtn.ForeColor = Color.FromArgb(50, 226, 128);
        }

        private void dabackbtn_MouseLeave(object sender, EventArgs e)
        {
            dabackbtn.ForeColor = Color.White;
        }
    }
}
