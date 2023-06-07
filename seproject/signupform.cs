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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void ssignupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform l1 = new loginform();
            l1.Show();
        }

        private void passwordshowbtn1_MouseDown(object sender, MouseEventArgs e)
        {
            createpasswordbox.UseSystemPasswordChar = false;
        }

        private void passwordshowbtn2_MouseUp(object sender, MouseEventArgs e)
        {
            confirmpasswordbox.UseSystemPasswordChar = true;
        }

        private void passwordshowbtn1_MouseUp(object sender, MouseEventArgs e)
        {
            createpasswordbox.UseSystemPasswordChar = true;
        }

        private void passwordshowbtn2_MouseDown(object sender, MouseEventArgs e)
        {
            confirmpasswordbox.UseSystemPasswordChar = false;
        }

        private void sclosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void sloginbtn_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            
            cmd.CommandText = "insert into CUSTOMER (CID,PASSWORD,NAME,EMAIL) " +
                "values('" + creatusernamebox.Text + "','" + createpasswordbox.Text + 
                "','" + namebox.Text + "','" + emailbox.Text + "')";

            cmd.Connection = conn;

            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Success!");
                this.Close();
                loginform l11 = new loginform();
                l11.Show();
            }
            conn.Dispose();
        }

        
    }
}
