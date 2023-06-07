using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace seproject
{
    public partial class loginform : Form
    {
        public loginform()
        {

            InitializeComponent();
        }
        public static string cid = "";
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordbox.UseSystemPasswordChar = false;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupform s1 = new signupform();
            s1.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = AAFIL; Password = abc; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cid = usernamebox.Text;
            string password = passwordbox.Text;
            if (usernamebox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Please Enter your User Name and Passowrd");
            }
            else
            {
                cmd.CommandText = "select CID from CUSTOMER where CID='" + cid + "' and PASSWORD = '" + password + "'";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                    MessageBox.Show("Login Successful!");

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }

            }
            conn.Dispose();
        }

        private void forgetpasswordbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgetpasswordform fp1 = new forgetpasswordform();
            fp1.Show();
        }

        private void sclosebtn_MouseEnter(object sender, EventArgs e)
        {
            sclosebtn.BackColor = Color.Red;
            sclosebtn.ForeColor = Color.White;
        }

        private void sclosebtn_MouseLeave(object sender, EventArgs e)
        {
            sclosebtn.BackColor = Color.Transparent;
            sclosebtn.ForeColor = Color.Teal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = clyden; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string userid = usernamebox.Text;
            string password = passwordbox.Text;
            if (usernamebox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Please Enter your User Name and Passowrd");
            }
            else
            {
                cmd.CommandText = "select ID_NO from LOGIN_FORM where USERNAME='" + userid + "' and PASSWORD = '" + password + "'";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Form3 frm3 = new Form3();
                    // frm3.Show();
                    MessageBox.Show(dr["ID_NO"].ToString());

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }

            }
            conn.Dispose();
        }
    }
}
