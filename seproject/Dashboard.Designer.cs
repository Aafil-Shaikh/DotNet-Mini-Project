namespace seproject
{
    partial class Dashboard
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
            this.dleftpanel = new System.Windows.Forms.Panel();
            this.enterdetails = new System.Windows.Forms.Label();
            this.newbookingbtn = new System.Windows.Forms.Button();
            this.deletebookingbtn = new System.Windows.Forms.Button();
            this.deleteuserbtn = new System.Windows.Forms.Button();
            this.dbackbtn = new System.Windows.Forms.Button();
            this.newbooking = new System.Windows.Forms.Label();
            this.dleftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dleftpanel
            // 
            this.dleftpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dleftpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.dleftpanel.Controls.Add(this.enterdetails);
            this.dleftpanel.Controls.Add(this.newbookingbtn);
            this.dleftpanel.Controls.Add(this.deletebookingbtn);
            this.dleftpanel.Controls.Add(this.deleteuserbtn);
            this.dleftpanel.Controls.Add(this.dbackbtn);
            this.dleftpanel.Location = new System.Drawing.Point(0, 100);
            this.dleftpanel.Margin = new System.Windows.Forms.Padding(4);
            this.dleftpanel.Name = "dleftpanel";
            this.dleftpanel.Size = new System.Drawing.Size(600, 600);
            this.dleftpanel.TabIndex = 3;
            // 
            // enterdetails
            // 
            this.enterdetails.AutoSize = true;
            this.enterdetails.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.enterdetails.Location = new System.Drawing.Point(150, 35);
            this.enterdetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterdetails.Name = "enterdetails";
            this.enterdetails.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.enterdetails.Size = new System.Drawing.Size(301, 40);
            this.enterdetails.TabIndex = 1;
            this.enterdetails.Text = "User Dashboard";
            this.enterdetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newbookingbtn
            // 
            this.newbookingbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.newbookingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbookingbtn.FlatAppearance.BorderSize = 0;
            this.newbookingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbookingbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbookingbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.newbookingbtn.Location = new System.Drawing.Point(150, 145);
            this.newbookingbtn.Margin = new System.Windows.Forms.Padding(4);
            this.newbookingbtn.Name = "newbookingbtn";
            this.newbookingbtn.Size = new System.Drawing.Size(300, 49);
            this.newbookingbtn.TabIndex = 6;
            this.newbookingbtn.Text = "New Order";
            this.newbookingbtn.UseVisualStyleBackColor = false;
            this.newbookingbtn.Click += new System.EventHandler(this.newbookingbtn_Click);
            this.newbookingbtn.MouseEnter += new System.EventHandler(this.newbookingbtn_MouseEnter);
            this.newbookingbtn.MouseLeave += new System.EventHandler(this.newbookingbtn_MouseLeave);
            // 
            // deletebookingbtn
            // 
            this.deletebookingbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.deletebookingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebookingbtn.FlatAppearance.BorderSize = 0;
            this.deletebookingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebookingbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebookingbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deletebookingbtn.Location = new System.Drawing.Point(150, 240);
            this.deletebookingbtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebookingbtn.Name = "deletebookingbtn";
            this.deletebookingbtn.Size = new System.Drawing.Size(300, 49);
            this.deletebookingbtn.TabIndex = 7;
            this.deletebookingbtn.Text = "Delete Order";
            this.deletebookingbtn.UseVisualStyleBackColor = false;
            this.deletebookingbtn.Click += new System.EventHandler(this.deletebookingbtn_Click);
            this.deletebookingbtn.MouseEnter += new System.EventHandler(this.deletebookingbtn_MouseEnter);
            this.deletebookingbtn.MouseLeave += new System.EventHandler(this.deletebookingbtn_MouseLeave);
            // 
            // deleteuserbtn
            // 
            this.deleteuserbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteuserbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteuserbtn.FlatAppearance.BorderSize = 0;
            this.deleteuserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteuserbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteuserbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteuserbtn.Location = new System.Drawing.Point(150, 335);
            this.deleteuserbtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteuserbtn.Name = "deleteuserbtn";
            this.deleteuserbtn.Size = new System.Drawing.Size(300, 49);
            this.deleteuserbtn.TabIndex = 5;
            this.deleteuserbtn.Text = "Delete Account";
            this.deleteuserbtn.UseVisualStyleBackColor = false;
            this.deleteuserbtn.Click += new System.EventHandler(this.deleteuserbtn_Click);
            this.deleteuserbtn.MouseEnter += new System.EventHandler(this.deleteuserbtn_MouseEnter);
            this.deleteuserbtn.MouseLeave += new System.EventHandler(this.deleteuserbtn_MouseLeave);
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
            this.dbackbtn.MouseEnter += new System.EventHandler(this.dbackbtn_MouseEnter);
            this.dbackbtn.MouseLeave += new System.EventHandler(this.dbackbtn_MouseLeave);
            // 
            // newbooking
            // 
            this.newbooking.AutoSize = true;
            this.newbooking.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbooking.ForeColor = System.Drawing.Color.SteelBlue;
            this.newbooking.Location = new System.Drawing.Point(62, 24);
            this.newbooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newbooking.Name = "newbooking";
            this.newbooking.Size = new System.Drawing.Size(221, 50);
            this.newbooking.TabIndex = 1;
            this.newbooking.Text = "Welcome,";
            this.newbooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.newbooking);
            this.Controls.Add(this.dleftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.dleftpanel.ResumeLayout(false);
            this.dleftpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dleftpanel;
        private System.Windows.Forms.Button dbackbtn;
        private System.Windows.Forms.Label newbooking;
        private System.Windows.Forms.Label enterdetails;
        private System.Windows.Forms.Button deleteuserbtn;
        private System.Windows.Forms.Button deletebookingbtn;
        private System.Windows.Forms.Button newbookingbtn;
    }
}