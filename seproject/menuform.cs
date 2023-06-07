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
    public partial class menuform : Form
    {
        public static double tot;
        public static double btot;
        public static DataGridView d1;
        public menuform()
        {
            InitializeComponent();
        }
        private void mEasyDine_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingform b2 = new bookingform();
            b2.Show();
        }

        private void mgeneratereceiptbtn_Click(object sender, EventArgs e)
        {
            mcalculatebtn_Click(sender, e);
            d1 = datagridviewcart;
            DialogResult generatereceipt;
            generatereceipt = MessageBox.Show("Are you sure?  Enter NO to Go Back",
                "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (generatereceipt == DialogResult.Yes)
            {
                this.Hide();
                receiptform rf1 = new receiptform();
                rf1.Show();
            }
            
           
        }

        private void mclosebtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm Exit?  You will be logged out!",
                "Menu Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mclosebtn_MouseEnter(object sender, EventArgs e)
        {
            mclosebtn.BackColor = Color.Red;
        }

        private void mclosebtn_MouseLeave(object sender, EventArgs e)
        {
            mclosebtn.BackColor = Color.Transparent;
        }

        private void mresetbtn_Click(object sender, EventArgs e)
        {
            chkpulledporktaco.Checked = false;
            chkroastmuttonboti.Checked = false;
            chksmokedduck.Checked = false;
            chksemolinapuchkas.Checked = false;
            chkmorelmusallam.Checked = false;
            chkpaneerkofta.Checked = false;
            chkricottavada.Checked = false;
            chkbraisedlamb.Checked = false;
            chkbakedseabass.Checked = false;
            chkpulledporksteak.Checked = false;
            chkmcburger.Checked = false;
            chkgcsandwich.Checked = false;
            chkcarbonara.Checked = false;
            chkfrenchbbqfries.Checked = false;
            chkmexicandream.Checked = false;
            chkbombaysapphire.Checked = false;
            chkespresso.Checked = false;
            chkmallowginger.Checked = false;
            chkdarjeelingtea.Checked = false;
            chkmanhattan.Checked = false;
            carttotalbox.Text = "0.00 /- ";
            billamountbox.Text = "0.00 /- ";
            datagridviewcart.Rows.Clear();
            datagridviewcart.Refresh();

        }

        private void chkpaneerkofta_CheckedChanged(object sender, EventArgs e)
        {
            if(qtypaneerkofta.Enabled==false)
            {
                qtypaneerkofta.Enabled = true;
                qtypaneerkofta.Value = 1;                
                AddData(chkpaneerkofta.Text, (int)qtypaneerkofta.Value, 1050.00);
            }
            else
            {
                qtypaneerkofta.Enabled = false;
                qtypaneerkofta.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if((string)r.Cells[0].Value==chkpaneerkofta.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
                

        }

        private void chkricottavada_CheckedChanged(object sender, EventArgs e)
        {
            if (qtyricottavada.Enabled == false)
            {
                qtyricottavada.Enabled = true;
                qtyricottavada.Value = 1;
                AddData(chkricottavada.Text, (int)qtyricottavada.Value, 900.00);
            }
            else
            {
                qtyricottavada.Enabled = false;
                qtyricottavada.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkricottavada.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
               
        }

        private void chkbraisedlamb_CheckedChanged(object sender, EventArgs e)
        {
            if (qtybraisedlamb.Enabled == false)
            {
                qtybraisedlamb.Enabled = true;
                qtybraisedlamb.Value = 1;
                AddData(chkbraisedlamb.Text, (int)qtybraisedlamb.Value, 1700.00);
            }
            else
            {
                qtybraisedlamb.Enabled = false;
                qtybraisedlamb.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkbraisedlamb.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkbakedseabass_CheckedChanged(object sender, EventArgs e)
        {
            if (qtybakedseabass.Enabled == false)
            {
                qtybakedseabass.Enabled = true;
                qtybakedseabass.Value = 1;
                AddData(chkbakedseabass.Text, (int)qtybakedseabass.Value, 1700.00);
            }
            else
            {
                qtybakedseabass.Enabled = false;
                qtybakedseabass.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkbakedseabass.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkpulledporksteak_CheckedChanged(object sender, EventArgs e)
        {
            if (qtypulledporksteak.Enabled == false)
            {
                qtypulledporksteak.Enabled = true;
                qtypulledporksteak.Value = 1;
                AddData(chkpulledporksteak.Text, (int)qtypulledporksteak.Value, 1550.00);
            }
            else
            {
                qtypulledporksteak.Enabled = false;
                qtypulledporksteak.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkpulledporksteak.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkpulledporktaco_CheckedChanged(object sender, EventArgs e)
        {
            if (qtypulledporktaco.Enabled == false)
            {
                qtypulledporktaco.Enabled = true;
                qtypulledporktaco.Value = 1;
                AddData(chkpulledporktaco.Text, (int)qtypulledporktaco.Value, 1100.00);
            }
            else
            {
                qtypulledporktaco.Enabled = false;
                qtypulledporktaco.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkpulledporktaco.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkroastmuttonboti_CheckedChanged(object sender, EventArgs e)
        {
            if (qtyroastmuttonboti.Enabled == false)
            {
                qtyroastmuttonboti.Enabled = true;
                qtyroastmuttonboti.Value = 1;
                AddData(chkroastmuttonboti.Text, (int)qtyroastmuttonboti.Value, 1900.00);
            }
            else
            {
                qtyroastmuttonboti.Enabled = false;
                qtyroastmuttonboti.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkroastmuttonboti.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chksmokedduck_CheckedChanged(object sender, EventArgs e)
        {
            if (qtysmokedduck.Enabled == false)
            {
                qtysmokedduck.Enabled = true;
                qtysmokedduck.Value = 1;
                AddData(chksmokedduck.Text, (int)qtysmokedduck.Value, 1450.00);
            }
            else
            {
                qtysmokedduck.Enabled = false;
                qtysmokedduck.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chksmokedduck.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chksemolinapuchkas_CheckedChanged(object sender, EventArgs e)
        {
            if (qtysemolinapuchkas.Enabled == false)
            {
                qtysemolinapuchkas.Enabled = true;
                qtysemolinapuchkas.Value = 1;
                AddData(chksemolinapuchkas.Text, (int)qtysemolinapuchkas.Value, 650.00);
            }
            else
            {
                qtysemolinapuchkas.Enabled = false;
                qtysemolinapuchkas.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chksemolinapuchkas.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkmorelmusallam_CheckedChanged(object sender, EventArgs e)
        {
            if (qtymorelmusallam.Enabled == false)
            {
                qtymorelmusallam.Enabled = true;
                qtymorelmusallam.Value = 1;
                AddData(chkmorelmusallam.Text, (int)qtymorelmusallam.Value, 1400.00);
            }
            else
            {
                qtymorelmusallam.Enabled = false;
                qtymorelmusallam.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkmorelmusallam.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkmcburger_CheckedChanged(object sender, EventArgs e)
        {
            if (qtymcburger.Enabled == false)
            {
                qtymcburger.Enabled = true;
                qtymcburger.Value = 1;
                AddData(chkmcburger.Text, (int)qtymcburger.Value, 350.00);
            }
            else
            {
                qtymcburger.Enabled = false;
                qtymcburger.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkmcburger.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkgcsandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (qtygcsandwich.Enabled == false)
            {
                qtygcsandwich.Enabled = true;
                qtygcsandwich.Value = 1;
                AddData(chkgcsandwich.Text, (int)qtygcsandwich.Value, 180.00);
            }
            else
            {
                qtygcsandwich.Enabled = false;
                qtygcsandwich.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkgcsandwich.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkcarbonara_CheckedChanged(object sender, EventArgs e)
        {
            if (qtycarbonara.Enabled == false)
            {
                qtycarbonara.Enabled = true;
                qtycarbonara.Value = 1;
                AddData(chkcarbonara.Text, (int)qtycarbonara.Value, 400.00);
            }
            else
            {
                qtycarbonara.Enabled = false;
                qtycarbonara.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkcarbonara.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkfrenchbbqfries_CheckedChanged(object sender, EventArgs e)
        {
            if (qtyfrenchbbqfries.Enabled == false)
            {
                qtyfrenchbbqfries.Enabled = true;
                qtyfrenchbbqfries.Value = 1;
                AddData(chkfrenchbbqfries.Text, (int)qtyfrenchbbqfries.Value, 250.00);
            }
            else
            {
                qtyfrenchbbqfries.Enabled = false;
                qtyfrenchbbqfries.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkfrenchbbqfries.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkmexicandream_CheckedChanged(object sender, EventArgs e)
        {
            if (qtymexicandream.Enabled == false)
            {
                qtymexicandream.Enabled = true;
                qtymexicandream.Value = 1;
                AddData(chkmexicandream.Text, (int)qtymexicandream.Value, 250.00);
            }
            else
            {
                qtymexicandream.Enabled = false;
                qtymexicandream.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkmexicandream.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkbombaysapphire_CheckedChanged(object sender, EventArgs e)
        {
            if (qtybombaysapphire.Enabled == false)
            {
                qtybombaysapphire.Enabled = true;
                qtybombaysapphire.Value = 1;
                AddData(chkbombaysapphire.Text, (int)qtybombaysapphire.Value, 650.00);
            }
            else
            {
                qtybombaysapphire.Enabled = false;
                qtybombaysapphire.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkbombaysapphire.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkespresso_CheckedChanged(object sender, EventArgs e)
        {
            if (qtyespresso.Enabled == false)
            {
                qtyespresso.Enabled = true;
                qtyespresso.Value = 1;
                AddData(chkespresso.Text, (int)qtyespresso.Value, 450.00);
            }
            else
            {
                qtyespresso.Enabled = false;
                qtyespresso.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkespresso.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkmallowginger_CheckedChanged(object sender, EventArgs e)
        {
            if (qtymallowginger.Enabled == false)
            {
                qtymallowginger.Enabled = true;
                qtymallowginger.Value = 1;
                AddData(chkmallowginger.Text, (int)qtymallowginger.Value, 280.00);
            }
            else
            {
                qtymallowginger.Enabled = false;
                qtymallowginger.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkmallowginger.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkdarjeelingtea_CheckedChanged(object sender, EventArgs e)
        {
            if (qtydarjeelingtea.Enabled == false)
            {
                qtydarjeelingtea.Enabled = true;
                qtydarjeelingtea.Value = 1;
                AddData(chkdarjeelingtea.Text, (int)qtydarjeelingtea.Value, 220.00);
            }
            else
            {
                qtydarjeelingtea.Enabled = false;
                qtydarjeelingtea.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkdarjeelingtea.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }

        private void chkmanhattan_CheckedChanged(object sender, EventArgs e)
        {
            if (qtymanhattan.Enabled == false)
            {
                qtymanhattan.Enabled = true;
                qtymanhattan.Value = 1;
                AddData(chkmanhattan.Text, (int)qtymanhattan.Value, 1200.00);
            }
            else
            {
                qtymanhattan.Enabled = false;
                qtymanhattan.Value = 1;
                foreach (DataGridViewRow r in datagridviewcart.Rows)
                {
                    if ((string)r.Cells[0].Value == chkmanhattan.Text)
                    {
                        datagridviewcart.Rows.Remove(r);
                    }
                }
            }
        }
        private void AddData(string itemname,int quanity,double itemprice)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(datagridviewcart);
            row.Cells[0].Value = itemname;
            row.Cells[1].Value = quanity;
            row.Cells[2].Value = (double)(quanity * itemprice);
            datagridviewcart.Rows.Add(row);
        }

        private void qtypaneerkofta_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkpaneerkofta.Text)
                {
                    r.Cells[1].Value = qtypaneerkofta.Value;
                    r.Cells[2].Value = (double)qtypaneerkofta.Value * 1050.00;
                }
            }
        }

        private void qtyricottavada_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkricottavada.Text)
                {
                    r.Cells[1].Value = qtyricottavada.Value;
                    r.Cells[2].Value = (double)qtyricottavada.Value * 900.00;
                }
            }
        }

        private void qtybraisedlamb_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkbraisedlamb.Text)
                {
                    r.Cells[1].Value = qtybraisedlamb.Value;
                    r.Cells[2].Value = (double)qtybraisedlamb.Value * 1700.00;
                }
            }
        }

        private void qtybakedseabass_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkbakedseabass.Text)
                {
                    r.Cells[1].Value = qtybakedseabass.Value;
                    r.Cells[2].Value = (double)qtybakedseabass.Value * 1700.00;
                }
            }
        }

        private void qtypulledporksteak_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkpulledporksteak.Text)
                {
                    r.Cells[1].Value = qtypulledporksteak.Value;
                    r.Cells[2].Value = (double)qtypulledporksteak.Value * 1550.00;
                }
            }
        }

        private void qtypulledporktaco_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkpulledporktaco.Text)
                {
                    r.Cells[1].Value = qtypulledporktaco.Value;
                    r.Cells[2].Value = (double)qtypulledporktaco.Value * 1100.00;
                }
            }
        }

        private void qtyroastmuttonboti_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkroastmuttonboti.Text)
                {
                    r.Cells[1].Value = qtyroastmuttonboti.Value;
                    r.Cells[2].Value = (double)qtyroastmuttonboti.Value * 1900.00;
                }
            }
        }

        private void qtysmokedduck_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chksmokedduck.Text)
                {
                    r.Cells[1].Value = qtysmokedduck.Value;
                    r.Cells[2].Value = (double)qtysmokedduck.Value * 1450.00;
                }
            }
        }

        private void qtysemolinapuchkas_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chksemolinapuchkas.Text)
                {
                    r.Cells[1].Value = qtysemolinapuchkas.Value;
                    r.Cells[2].Value = (double)qtysemolinapuchkas.Value * 650.00;
                }
            }
        }

        private void qtymorelmusallam_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkmorelmusallam.Text)
                {
                    r.Cells[1].Value = qtymorelmusallam.Value;
                    r.Cells[2].Value = (double)qtymorelmusallam.Value * 1400.00;
                }
            }
        }

        private void qtymcburger_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkmcburger.Text)
                {
                    r.Cells[1].Value = qtymcburger.Value;
                    r.Cells[2].Value = (double)qtymcburger.Value * 350.00;
                }
            }
        }

        private void qtygcsandwich_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkgcsandwich.Text)
                {
                    r.Cells[1].Value = qtygcsandwich.Value;
                    r.Cells[2].Value = (double)qtygcsandwich.Value * 180.00;
                }
            }
        }

        private void qtycarbonara_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkcarbonara.Text)
                {
                    r.Cells[1].Value = qtycarbonara.Value;
                    r.Cells[2].Value = (double)qtycarbonara.Value * 400.00;
                }
            }
        }

        private void qtyfrenchbbqfries_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkfrenchbbqfries.Text)
                {
                    r.Cells[1].Value = qtyfrenchbbqfries.Value;
                    r.Cells[2].Value = (double)qtyfrenchbbqfries.Value * 250.00;
                }
            }
        }

        private void qtymexicandream_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkmexicandream.Text)
                {
                    r.Cells[1].Value = qtymexicandream.Value;
                    r.Cells[2].Value = (double)qtymexicandream.Value * 250.00;
                }
            }
        }

        private void qtybombaysapphire_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkbombaysapphire.Text)
                {
                    r.Cells[1].Value = qtybombaysapphire.Value;
                    r.Cells[2].Value = (double)qtybombaysapphire.Value * 650.00;
                }
            }
        }

        private void qtyespresso_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkespresso.Text)
                {
                    r.Cells[1].Value = qtyespresso.Value;
                    r.Cells[2].Value = (double)qtyespresso.Value * 450.00;
                }
            }
        }

        private void qtymallowginger_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkmallowginger.Text)
                {
                    r.Cells[1].Value = qtymallowginger.Value;
                    r.Cells[2].Value = (double)qtymallowginger.Value * 280.00;
                }
            }
        }

        private void qtydarjeelingtea_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkdarjeelingtea.Text)
                {
                    r.Cells[1].Value = qtydarjeelingtea.Value;
                    r.Cells[2].Value = (double)qtydarjeelingtea.Value * 220.00;
                }
            }
        }

        private void qtymanhattan_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewcart.Rows)
            {
                if ((string)r.Cells[0].Value == chkmanhattan.Text)
                {
                    r.Cells[1].Value = qtymanhattan.Value;
                    r.Cells[2].Value = (double)qtymanhattan.Value * 1200.00;
                }
            }
        }

        private void mcalculatebtn_Click(object sender, EventArgs e)
        {
            double carttotal = 0.0;
            double billtotal =0.0;
            double x=0.0;
            double mtax = 0.18;
            foreach(DataGridViewRow r in datagridviewcart.Rows)
            {
                x=Convert.ToDouble(r.Cells[2].Value);
                carttotal += x;
            }            
            string cartamt = string.Format("{0,0:F2} /- ",carttotal);
            carttotalbox.Text = cartamt;
            billtotal = carttotal + (carttotal * mtax);
            string billamt = string.Format("{0,0:F2} /- ", billtotal);
            billamountbox.Text = billamt;
            tot = carttotal;
            btot = billtotal; 



        }

        private void mEasyDine_MouseEnter(object sender, EventArgs e)
        {
            mEasyDine.ForeColor = Color.Black;
            mEasyDine.BackColor = Color.Transparent;
        }

        private void mEasyDine_MouseLeave(object sender, EventArgs e)
        {
            mEasyDine.ForeColor = Color.White;
            mEasyDine.BackColor = Color.Transparent;
        }

        private void chkveg_CheckedChanged(object sender, EventArgs e)
        {
            if(chkveg.Checked==true)
            {
                chkveg.ForeColor = Color.Black;
                chkveg.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                chkveg.ForeColor = Color.White;
                chkveg.BackColor = Color.Teal;
            }
            if(chkpulledporktaco.Visible==true)
            {
                chkpulledporktaco.Visible=false;
                chkpulledporktaco.Checked = false;
            }
            else
            {
                chkpulledporktaco.Visible = true;
            }
            if (chkroastmuttonboti.Visible == true)
            {
                chkroastmuttonboti.Visible = false;
                chkroastmuttonboti.Checked = false;
            }
            else
            {
                chkroastmuttonboti.Visible = true;
            }
            if (chksmokedduck.Visible == true)
            {
                chksmokedduck.Visible = false;
                chksmokedduck.Checked = false;
            }
            else
            {
                chksmokedduck.Visible = true;
            }
            if (chkbraisedlamb.Visible == true)
            {
                chkbraisedlamb.Visible = false;
                chkbraisedlamb.Checked = false;
            }
            else
            {
                chkbraisedlamb.Visible = true;
            }
            if (chkbakedseabass.Visible == true)
            {
                chkbakedseabass.Visible = false;
                chkbakedseabass.Checked = false;
            }
            else
            {
                chkbakedseabass.Visible = true;
            }
            if (chkpulledporksteak.Visible == true)
            {
                chkpulledporksteak.Visible = false;
                chkpulledporksteak.Checked = false;
            }
            else
            {
                chkpulledporksteak.Visible = true;
            }
            if (chkmexicandream.Visible == true)
            {
                chkmexicandream.Visible = false;
                chkmexicandream.Checked = false;
            }
            else
            {
                chkmexicandream.Visible = true;
            }
        }
        
    }
}
