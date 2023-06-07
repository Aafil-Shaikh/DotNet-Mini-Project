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
    public partial class forgetpasswordform : Form
    {
        public forgetpasswordform()
        {
            InitializeComponent();
        }

        private void forgetpasswordbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform l3 = new loginform();
            l3.Show();
        }

        private void passwordshowbtn1_MouseDown(object sender, MouseEventArgs e)
        {
            createpasswordbox.UseSystemPasswordChar = false;
        }

        private void passwordshowbtn1_MouseUp(object sender, MouseEventArgs e)
        {
            createpasswordbox.UseSystemPasswordChar = true;
        }

        private void passwordshowbtn2_MouseDown(object sender, MouseEventArgs e)
        {
            confirmpasswordbox.UseSystemPasswordChar = false;
        }

        private void passwordshowbtn2_MouseUp(object sender, MouseEventArgs e)
        {
            confirmpasswordbox.UseSystemPasswordChar = true;
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

        private void resetbtn_Click(object sender, EventArgs e)
        {

            string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            
            try
            {
                string sqlQuery = "UPDATE CUSTOMER SET PASSWORD='"
                    + createpasswordbox.Text + "' where CID = '" + usernamebox.Text + "'";
                OracleCommand cma = new OracleCommand();
                cma.Connection = con;
                cma.CommandText = sqlQuery;
                cma.ExecuteNonQuery();

                MessageBox.Show("Password Updated Successfully");
                loginform lf = new loginform();
                lf.Show();
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Dispose();
        }
    }
}
