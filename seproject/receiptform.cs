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
    public partial class receiptform : Form
    {
        public receiptform()
        {
            InitializeComponent();
            rreceipt.Text = "                EasyDine Restaurant               \n";
            rreceipt.Text = rreceipt.Text + "               Indian Cuisine Dining              \n";
            rreceipt.Text = rreceipt.Text + "                 Verna Goa, 403722                \n";
            rreceipt.Text = rreceipt.Text + "  Receipt Invoice ID:                             \n";
            rreceipt.Text = rreceipt.Text + "  Customer ID:                                    \n";
            rreceipt.Text = rreceipt.Text + "  Customer Name:                                  \n";
            rreceipt.Text = rreceipt.Text + "  Table ID:                              Seats:   \n";
            rreceipt.Text = rreceipt.Text + " Bill Details:                                    \n";
            rreceipt.Text = rreceipt.Text + "==================================================\n";
            rreceipt.Text = rreceipt.Text + "SrNo. Item name\t\t\t   Qty    Item Total\n";
            rreceipt.Text = rreceipt.Text + "==================================================\n";
            
            for (int i=0;i< menuform.d1.Rows.Count;i++)
            {
                
                rreceipt.Text = rreceipt.Text + (i+1)+".";
                
                    if(i<9)
                    {
                        rreceipt.Text = rreceipt.Text + "    " + menuform.d1.Rows[i].Cells[0].Value.ToString() +"          "+ menuform.d1.Rows[i].Cells[1].Value.ToString() + "      "+ menuform.d1.Rows[i].Cells[2].Value.ToString();
                    }
                    else
                    {
                        rreceipt.Text = rreceipt.Text + "   " + menuform.d1.Rows[i].Cells[0].Value.ToString() + "          " + menuform.d1.Rows[i].Cells[1].Value.ToString() + "      " + menuform.d1.Rows[i].Cells[2].Value.ToString();
                }

                
                rreceipt.Text = rreceipt.Text + "\n";
                rreceipt.Text = rreceipt.Text + "--------------------------------------------------";
                rreceipt.Text = rreceipt.Text + "\n";
                
            }
            rreceipt.Text = rreceipt.Text + "==================================================\n";
            rreceipt.Text = rreceipt.Text + "                                 Total: "+menuform.tot+" \n";
            rreceipt.Text = rreceipt.Text + "                                Tax:    18%       \n";
            rreceipt.Text = rreceipt.Text + "                                Amount: "+menuform.btot+" \n";
            rreceipt.Text = rreceipt.Text + "==================================================\n";
            rreceipt.Text = rreceipt.Text + "                  T H A N K Y O U                 \n";
            rreceipt.Text = rreceipt.Text + "                    VISIT AGAIN                   \n";
            rreceipt.Text = rreceipt.Text + "==================================================\n\n\n\n\n";
            rreceipt.Text = rreceipt.Text + " clydenpacheco@gmail.com|aafilshaikh1043@gmail.com\n";
        }

        private void rexitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rsubmitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataanalysisform d1 = new dataanalysisform();
            d1.Show();
        }

        private void rating1_CheckedChanged(object sender, EventArgs e)
        {
            if(rating1.Checked==true)
            {
                rating2.Checked = false;
                rating3.Checked = false;
                rating4.Checked = false;
                rating5.Checked = false;
            }
        }

        private void rating2_CheckedChanged(object sender, EventArgs e)
        {
            if (rating2.Checked == true)
            {
                rating1.Checked = false;
                rating3.Checked = false;
                rating4.Checked = false;
                rating5.Checked = false;
            }
        }

        private void rating3_CheckedChanged(object sender, EventArgs e)
        {
            if (rating3.Checked == true)
            {
                rating1.Checked = false;
                rating2.Checked = false;
                rating4.Checked = false;
                rating5.Checked = false;
            }
        }

        private void rating4_CheckedChanged(object sender, EventArgs e)
        {
            if (rating4.Checked == true)
            {
                rating1.Checked = false;
                rating2.Checked = false;
                rating3.Checked = false;
                rating5.Checked = false;
            }
        }

        private void rating5_CheckedChanged(object sender, EventArgs e)
        {
            if (rating5.Checked == true)
            {
                rating1.Checked = false;
                rating2.Checked = false;
                rating3.Checked = false;
                rating4.Checked = false;
            }
        }
    }
}
