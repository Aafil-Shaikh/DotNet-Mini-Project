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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            newbooking.Text = "Welcome, "+loginform.cid;
        }

        private void newbookingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingform b1 = new bookingform();
            b1.Show();
        }

        private void dbackbtn_MouseEnter(object sender, EventArgs e)
        {
            dbackbtn.ForeColor = Color.Black;
            dbackbtn.BackColor = Color.Transparent;
        }

        private void dbackbtn_MouseLeave(object sender, EventArgs e)
        {
            
            dbackbtn.ForeColor = Color.Gainsboro;
            dbackbtn.BackColor = Color.Transparent;
        }

        private void dbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform l1 = new loginform();
            l1.Show();
        }

        private void newbookingbtn_MouseEnter(object sender, EventArgs e)
        {
            newbookingbtn.ForeColor = Color.Black;
            newbookingbtn.BackColor = Color.White;
        }

        private void newbookingbtn_MouseLeave(object sender, EventArgs e)
        {
            newbookingbtn.ForeColor = Color.SteelBlue;
            newbookingbtn.BackColor = Color.Gainsboro;
        }

        private void deletebookingbtn_MouseEnter(object sender, EventArgs e)
        {
            deletebookingbtn.ForeColor = Color.Black;
            deletebookingbtn.BackColor = Color.White;
        }

        private void deletebookingbtn_MouseLeave(object sender, EventArgs e)
        {
            deletebookingbtn.ForeColor = Color.SteelBlue;
            deletebookingbtn.BackColor = Color.Gainsboro;
        }

        private void deleteuserbtn_MouseEnter(object sender, EventArgs e)
        {
            deleteuserbtn.ForeColor = Color.Black;
            deleteuserbtn.BackColor = Color.White;
        }

        private void deleteuserbtn_MouseLeave(object sender, EventArgs e)
        {
            deleteuserbtn.ForeColor = Color.SteelBlue;
            deleteuserbtn.BackColor = Color.Gainsboro;
        }

        private void deleteuserbtn_Click(object sender, EventArgs e)
        {

            DialogResult deleteuser;
            deleteuser = MessageBox.Show("Are you sure?  Enter NO to Go Back",
                "User will be deleted permanently!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteuser == DialogResult.Yes)
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
                OracleConnection con = new OracleConnection(oradb);
                con.Open();
                string cid = loginform.cid;
                try
                {
                    string sqlQuery = "DELETE FROM CUSTOMER where CID = '" + cid + "'";
                    OracleCommand cma = new OracleCommand();
                    cma.Connection = con;
                    cma.CommandText = sqlQuery;
                    cma.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted Successfully");
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

        private void deletebookingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBooking db1 = new DeleteBooking();
            db1.Show();
        }
    }
}
