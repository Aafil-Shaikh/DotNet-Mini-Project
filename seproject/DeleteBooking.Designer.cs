namespace seproject
{
    partial class DeleteBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deletebookinglabel = new System.Windows.Forms.Label();
            this.dleftpanel = new System.Windows.Forms.Panel();
            this.orderid = new System.Windows.Forms.Panel();
            this.orderidbox = new System.Windows.Forms.ComboBox();
            this.orderidtextbox = new System.Windows.Forms.Label();
            this.enterdetails = new System.Windows.Forms.Label();
            this.deletebookingbtn = new System.Windows.Forms.Button();
            this.dbackbtn = new System.Windows.Forms.Button();
            this.dleftpanel.SuspendLayout();
            this.orderid.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletebookinglabel
            // 
            this.deletebookinglabel.AutoSize = true;
            this.deletebookinglabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebookinglabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.deletebookinglabel.Location = new System.Drawing.Point(165, 26);
            this.deletebookinglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deletebookinglabel.Name = "deletebookinglabel";
            this.deletebookinglabel.Size = new System.Drawing.Size(271, 47);
            this.deletebookinglabel.TabIndex = 2;
            this.deletebookinglabel.Text = "Delete Order";
            this.deletebookinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dleftpanel
            // 
            this.dleftpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.dleftpanel.Controls.Add(this.orderid);
            this.dleftpanel.Controls.Add(this.enterdetails);
            this.dleftpanel.Controls.Add(this.deletebookingbtn);
            this.dleftpanel.Controls.Add(this.dbackbtn);
            this.dleftpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dleftpanel.Location = new System.Drawing.Point(0, 100);
            this.dleftpanel.Margin = new System.Windows.Forms.Padding(4);
            this.dleftpanel.Name = "dleftpanel";
            this.dleftpanel.Size = new System.Drawing.Size(600, 600);
            this.dleftpanel.TabIndex = 4;
            // 
            // orderid
            // 
            this.orderid.BackColor = System.Drawing.Color.White;
            this.orderid.Controls.Add(this.orderidbox);
            this.orderid.Controls.Add(this.orderidtextbox);
            this.orderid.Location = new System.Drawing.Point(101, 123);
            this.orderid.Margin = new System.Windows.Forms.Padding(4);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(389, 55);
            this.orderid.TabIndex = 8;
            // 
            // orderidbox
            // 
            this.orderidbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidbox.FormattingEnabled = true;
            this.orderidbox.ItemHeight = 31;
            this.orderidbox.Location = new System.Drawing.Point(143, 9);
            this.orderidbox.Name = "orderidbox";
            this.orderidbox.Size = new System.Drawing.Size(229, 39);
            this.orderidbox.TabIndex = 1;
            // 
            // orderidtextbox
            // 
            this.orderidtextbox.AutoSize = true;
            this.orderidtextbox.BackColor = System.Drawing.Color.Transparent;
            this.orderidtextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderidtextbox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidtextbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.orderidtextbox.Location = new System.Drawing.Point(4, 12);
            this.orderidtextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderidtextbox.Name = "orderidtextbox";
            this.orderidtextbox.Size = new System.Drawing.Size(132, 33);
            this.orderidtextbox.TabIndex = 0;
            this.orderidtextbox.Text = "Order ID:";
            // 
            // enterdetails
            // 
            this.enterdetails.AutoSize = true;
            this.enterdetails.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.enterdetails.Location = new System.Drawing.Point(128, 33);
            this.enterdetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterdetails.Name = "enterdetails";
            this.enterdetails.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.enterdetails.Size = new System.Drawing.Size(346, 40);
            this.enterdetails.TabIndex = 1;
            this.enterdetails.Text = "Enter Order Details";
            this.enterdetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deletebookingbtn
            // 
            this.deletebookingbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.deletebookingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebookingbtn.FlatAppearance.BorderSize = 0;
            this.deletebookingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebookingbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebookingbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deletebookingbtn.Location = new System.Drawing.Point(150, 324);
            this.deletebookingbtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebookingbtn.Name = "deletebookingbtn";
            this.deletebookingbtn.Size = new System.Drawing.Size(300, 49);
            this.deletebookingbtn.TabIndex = 7;
            this.deletebookingbtn.Text = "Delete Booking";
            this.deletebookingbtn.UseVisualStyleBackColor = false;
            this.deletebookingbtn.Click += new System.EventHandler(this.deletebookingbtn_Click);
            this.deletebookingbtn.MouseEnter += new System.EventHandler(this.deletebookingbtn_MouseEnter);
            this.deletebookingbtn.MouseLeave += new System.EventHandler(this.deletebookingbtn_MouseLeave);
            // 
            // dbackbtn
            // 
            this.dbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbackbtn.BackColor = System.Drawing.Color.Transparent;
            this.dbackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbackbtn.FlatAppearance.BorderSize = 0;
            this.dbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbackbtn.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbackbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.dbackbtn.Location = new System.Drawing.Point(0, 519);
            this.dbackbtn.Margin = new System.Windows.Forms.Padding(4);
            this.dbackbtn.Name = "dbackbtn";
            this.dbackbtn.Size = new System.Drawing.Size(88, 81);
            this.dbackbtn.TabIndex = 3;
            this.dbackbtn.Text = "<";
            this.dbackbtn.UseVisualStyleBackColor = false;
            this.dbackbtn.Click += new System.EventHandler(this.dbackbtn_Click);
            // 
            // DeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.deletebookinglabel);
            this.Controls.Add(this.dleftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBooking";
            this.dleftpanel.ResumeLayout(false);
            this.dleftpanel.PerformLayout();
            this.orderid.ResumeLayout(false);
            this.orderid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deletebookinglabel;
        private System.Windows.Forms.Panel dleftpanel;
        private System.Windows.Forms.Label enterdetails;
        private System.Windows.Forms.Button dbackbtn;
        private System.Windows.Forms.Panel orderid;
        private System.Windows.Forms.Label orderidtextbox;
        private System.Windows.Forms.Button deletebookingbtn;
        private System.Windows.Forms.ComboBox orderidbox;
    }
}