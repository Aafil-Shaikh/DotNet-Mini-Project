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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seproject
{
    public partial class bookingform : Form
    {
        public bookingform()
        {
            InitializeComponent();
        }

        private void bbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d2 = new Dashboard();
            d2.Show();
        }

        private void bproceedbtn_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = aafil; Password = abc; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string cid = loginform.cid;
            cmd.CommandText = "insert into ASSIGNS (CID,TID,SEATCOUNT) values('" + cid + "','" + tablecodebox.Text + "','" + bnumericUpDown1.Value + "')";

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
                menuform l11 = new menuform();
                l11.Show();
            }
            conn.Dispose();
            /*this.Hide();
            menuform m1 = new menuform();
            m1.Show();*/
        }

        private void bbackbtn_MouseEnter(object sender, EventArgs e)
        {
            bbackbtn.ForeColor = Color.Black;
            bbackbtn.BackColor = Color.Transparent;
        }

        private void bbackbtn_MouseLeave(object sender, EventArgs e)
        {
            bbackbtn.ForeColor = Color.Gainsboro;
            bbackbtn.BackColor = Color.Transparent;
        }

        private void bproceedbtn_MouseEnter(object sender, EventArgs e)
        {
            bproceedbtn.ForeColor = Color.Black;
            bproceedbtn.BackColor = Color.Transparent;
        }

        private void bproceedbtn_MouseLeave(object sender, EventArgs e)
        {
            bproceedbtn.ForeColor = Color.SteelBlue;
            bproceedbtn.BackColor = Color.Transparent;
        }
       
        private void prefsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablecodebox.Items.Clear();
            tablecodebox.Text = "";
            if (prefsbox.Text == "Centre Table")
            {
                C1tablebtn.BackColor = Color.Wheat;
                C1tablebtn.Show();
                C2tablebtn.BackColor = Color.Wheat;
                C2tablebtn.Show();
                C3tablebtn.BackColor = Color.Wheat;
                C3tablebtn.Show();
                R1tablebtn.Hide();
                R2tablebtn.Hide();
                R3tablebtn.Hide();
                R4tablebtn.Hide();
                R5tablebtn.Hide();
                R6tablebtn.Hide();
                R7tablebtn.Hide();
                R8tablebtn.Hide();
                R9tablebtn.Hide();
                R10tablebtn.Hide();
                R11tablebtn.Hide();
                R12tablebtn.Hide();
                F1tablebtn.Hide();
                F2tablebtn.Hide();
                F3tablebtn.Hide();
                F4tablebtn.Hide();
                F5tablebtn.Hide();
                F6tablebtn.Hide();
                F7tablebtn.Hide();
                F8tablebtn.Hide();

                tablecodebox.Items.Add("CT1");
                tablecodebox.Items.Add("CT2");
                tablecodebox.Items.Add("CT3");


            }
            
            else if(prefsbox.Text == "Regular Table")
            {
                C1tablebtn.Hide();
                C2tablebtn.Hide();
                C3tablebtn.Hide();
                R1tablebtn.BackColor = Color.Wheat;
                R1tablebtn.Show();
                R2tablebtn.BackColor = Color.Wheat;
                R2tablebtn.Show();
                R3tablebtn.BackColor = Color.Wheat;
                R3tablebtn.Show();
                R4tablebtn.BackColor = Color.Wheat;
                R4tablebtn.Show();
                R5tablebtn.BackColor = Color.Wheat;
                R5tablebtn.Show();
                R6tablebtn.BackColor = Color.Wheat;
                R6tablebtn.Show();
                R7tablebtn.BackColor = Color.Wheat;
                R7tablebtn.Show();
                R8tablebtn.BackColor = Color.Wheat;
                R8tablebtn.Show();
                R9tablebtn.BackColor = Color.Wheat;
                R9tablebtn.Show();
                R10tablebtn.BackColor = Color.Wheat;
                R10tablebtn.Show();
                R11tablebtn.BackColor = Color.Wheat;
                R11tablebtn.Show();
                R12tablebtn.BackColor = Color.Wheat;
                R12tablebtn.Show();
                F1tablebtn.Hide();
                F2tablebtn.Hide();
                F3tablebtn.Hide();
                F4tablebtn.Hide();
                F5tablebtn.Hide();
                F6tablebtn.Hide();
                F7tablebtn.Hide();
                F8tablebtn.Hide();

                tablecodebox.Items.Add("RT1");
                tablecodebox.Items.Add("RT2");
                tablecodebox.Items.Add("RT3");
                tablecodebox.Items.Add("RT4");
                tablecodebox.Items.Add("RT5");
                tablecodebox.Items.Add("RT6");
                tablecodebox.Items.Add("RT7");
                tablecodebox.Items.Add("RT8");
                tablecodebox.Items.Add("RT9");
                tablecodebox.Items.Add("RT10");
                tablecodebox.Items.Add("RT11");
                tablecodebox.Items.Add("RT12");


            }
             else
             {
                C1tablebtn.Hide();
                C2tablebtn.Hide();
                C3tablebtn.Hide();
                R1tablebtn.Hide();
                R2tablebtn.Hide();
                R3tablebtn.Hide();
                R4tablebtn.Hide();
                R5tablebtn.Hide();
                R6tablebtn.Hide();
                R7tablebtn.Hide();
                R8tablebtn.Hide();
                R9tablebtn.Hide();
                R10tablebtn.Hide();
                R11tablebtn.Hide();
                R12tablebtn.Hide();
                F1tablebtn.BackColor = Color.Wheat;
                F1tablebtn.Show();
                F2tablebtn.BackColor = Color.Wheat;
                F2tablebtn.Show();
                F3tablebtn.BackColor = Color.Wheat;
                F3tablebtn.Show();
                F4tablebtn.BackColor = Color.Wheat;
                F4tablebtn.Show();
                F5tablebtn.BackColor = Color.Wheat;
                F5tablebtn.Show();
                F6tablebtn.BackColor = Color.Wheat;
                F6tablebtn.Show();
                F7tablebtn.BackColor = Color.Wheat;
                F7tablebtn.Show();
                F8tablebtn.BackColor = Color.Wheat;
                F8tablebtn.Show();

                tablecodebox.Items.Add("FT1");
                tablecodebox.Items.Add("FT2");
                tablecodebox.Items.Add("FT3");
                tablecodebox.Items.Add("FT4");
                tablecodebox.Items.Add("FT5");
                tablecodebox.Items.Add("FT6");
                tablecodebox.Items.Add("FT7");
                tablecodebox.Items.Add("FT8");
                
            }         
        }
    }
}
