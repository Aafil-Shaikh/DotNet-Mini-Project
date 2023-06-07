using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace seproject
{
    public partial class DeleteBooking : Form
    {
        public DeleteBooking()
        {
            InitializeComponent();
            fillcombo();
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
        void fillcombo()
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
            OracleConnection con = new OracleConnection(oradb);
            string cid = loginform.cid;
            string sqlQuery = "SELECT * FROM MAKES where CID = '" + cid + "'";
            OracleCommand cma = new OracleCommand();
            cma.Connection = con;
            cma.CommandText = sqlQuery;
            try
            {
                con.Open();
                OracleDataReader myreader = cma.ExecuteReader();

                while(myreader.Read())
                {
                    int order_id = (System.Int16)myreader["OID"];
                    orderidbox.Items.Add(order_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Dispose();


        }
        private void deletebookingbtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteorder;
            deleteorder = MessageBox.Show("Are you sure?  Enter NO to Go Back",
                "User will be deleted permanently!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteorder == DialogResult.Yes)
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
                OracleConnection con = new OracleConnection(oradb);
                con.Open();
                string cid = loginform.cid;
                try
                {
                    int oid = int.Parse(orderidbox.Text);
                    string sqlQuery = "DELETE FROM MAKES where CID = '" + cid + "' AND OID = '" + oid + "'";
                    OracleCommand cma = new OracleCommand();
                    cma.Connection = con;
                    cma.CommandText = sqlQuery;
                    cma.ExecuteNonQuery();

                    MessageBox.Show("Order Deleted Successfully");
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                    this.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                con.Dispose();
            }
        }

        private void dbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}
