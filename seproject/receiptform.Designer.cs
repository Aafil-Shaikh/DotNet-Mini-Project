namespace seproject
{
    partial class receiptform
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
            this.rtop = new System.Windows.Forms.Panel();
            this.rreceipt = new System.Windows.Forms.RichTextBox();
            this.rbottom = new System.Windows.Forms.Panel();
            this.rsubmitbtn = new System.Windows.Forms.Button();
            this.rexitbtn = new System.Windows.Forms.Button();
            this.suggestionscomments = new System.Windows.Forms.RichTextBox();
            this.rating3 = new System.Windows.Forms.CheckBox();
            this.rating4 = new System.Windows.Forms.CheckBox();
            this.rating5 = new System.Windows.Forms.CheckBox();
            this.rating2 = new System.Windows.Forms.CheckBox();
            this.rating1 = new System.Windows.Forms.CheckBox();
            this.rsuggestionscoments = new System.Windows.Forms.Label();
            this.feedbaclquestion = new System.Windows.Forms.Label();
            this.rfeedback = new System.Windows.Forms.Label();
            this.rtop.SuspendLayout();
            this.rbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtop
            // 
            this.rtop.BackColor = System.Drawing.Color.Gainsboro;
            this.rtop.Controls.Add(this.rreceipt);
            this.rtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtop.Location = new System.Drawing.Point(0, 0);
            this.rtop.Name = "rtop";
            this.rtop.Size = new System.Drawing.Size(470, 400);
            this.rtop.TabIndex = 0;
            // 
            // rreceipt
            // 
            this.rreceipt.BackColor = System.Drawing.Color.Wheat;
            this.rreceipt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rreceipt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rreceipt.ForeColor = System.Drawing.Color.Black;
            this.rreceipt.Location = new System.Drawing.Point(18, 20);
            this.rreceipt.Name = "rreceipt";
            this.rreceipt.ReadOnly = true;
            this.rreceipt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rreceipt.Size = new System.Drawing.Size(432, 360);
            this.rreceipt.TabIndex = 0;
            this.rreceipt.Text = "";
            // 
            // rbottom
            // 
            this.rbottom.BackColor = System.Drawing.Color.Teal;
            this.rbottom.Controls.Add(this.rsubmitbtn);
            this.rbottom.Controls.Add(this.rexitbtn);
            this.rbottom.Controls.Add(this.suggestionscomments);
            this.rbottom.Controls.Add(this.rating3);
            this.rbottom.Controls.Add(this.rating4);
            this.rbottom.Controls.Add(this.rating5);
            this.rbottom.Controls.Add(this.rating2);
            this.rbottom.Controls.Add(this.rating1);
            this.rbottom.Controls.Add(this.rsuggestionscoments);
            this.rbottom.Controls.Add(this.feedbaclquestion);
            this.rbottom.Controls.Add(this.rfeedback);
            this.rbottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbottom.Location = new System.Drawing.Point(0, 400);
            this.rbottom.Name = "rbottom";
            this.rbottom.Size = new System.Drawing.Size(470, 300);
            this.rbottom.TabIndex = 1;
            // 
            // rsubmitbtn
            // 
            this.rsubmitbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.rsubmitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsubmitbtn.FlatAppearance.BorderSize = 0;
            this.rsubmitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rsubmitbtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsubmitbtn.ForeColor = System.Drawing.Color.Teal;
            this.rsubmitbtn.Location = new System.Drawing.Point(118, 253);
            this.rsubmitbtn.Name = "rsubmitbtn";
            this.rsubmitbtn.Size = new System.Drawing.Size(94, 33);
            this.rsubmitbtn.TabIndex = 5;
            this.rsubmitbtn.Text = "SUBMIT";
            this.rsubmitbtn.UseVisualStyleBackColor = false;
            this.rsubmitbtn.Click += new System.EventHandler(this.rsubmitbtn_Click);
            // 
            // rexitbtn
            // 
            this.rexitbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.rexitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rexitbtn.FlatAppearance.BorderSize = 0;
            this.rexitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rexitbtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rexitbtn.ForeColor = System.Drawing.Color.Teal;
            this.rexitbtn.Location = new System.Drawing.Point(250, 253);
            this.rexitbtn.Name = "rexitbtn";
            this.rexitbtn.Size = new System.Drawing.Size(61, 33);
            this.rexitbtn.TabIndex = 5;
            this.rexitbtn.Text = "EXIT";
            this.rexitbtn.UseVisualStyleBackColor = false;
            this.rexitbtn.Click += new System.EventHandler(this.rexitbtn_Click);
            // 
            // suggestionscomments
            // 
            this.suggestionscomments.BackColor = System.Drawing.Color.Wheat;
            this.suggestionscomments.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionscomments.ForeColor = System.Drawing.Color.Black;
            this.suggestionscomments.Location = new System.Drawing.Point(20, 138);
            this.suggestionscomments.MaxLength = 220;
            this.suggestionscomments.Name = "suggestionscomments";
            this.suggestionscomments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.suggestionscomments.Size = new System.Drawing.Size(430, 101);
            this.suggestionscomments.TabIndex = 4;
            this.suggestionscomments.Text = "";
            // 
            // rating3
            // 
            this.rating3.AutoSize = true;
            this.rating3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating3.ForeColor = System.Drawing.Color.White;
            this.rating3.Location = new System.Drawing.Point(194, 69);
            this.rating3.Name = "rating3";
            this.rating3.Size = new System.Drawing.Size(78, 23);
            this.rating3.TabIndex = 3;
            this.rating3.Text = "Neutral";
            this.rating3.UseVisualStyleBackColor = true;
            this.rating3.CheckedChanged += new System.EventHandler(this.rating3_CheckedChanged);
            // 
            // rating4
            // 
            this.rating4.AutoSize = true;
            this.rating4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating4.ForeColor = System.Drawing.Color.White;
            this.rating4.Location = new System.Drawing.Point(280, 69);
            this.rating4.Name = "rating4";
            this.rating4.Size = new System.Drawing.Size(112, 23);
            this.rating4.TabIndex = 3;
            this.rating4.Text = "Inadequate";
            this.rating4.UseVisualStyleBackColor = true;
            this.rating4.CheckedChanged += new System.EventHandler(this.rating4_CheckedChanged);
            // 
            // rating5
            // 
            this.rating5.AutoSize = true;
            this.rating5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating5.ForeColor = System.Drawing.Color.White;
            this.rating5.Location = new System.Drawing.Point(400, 69);
            this.rating5.Name = "rating5";
            this.rating5.Size = new System.Drawing.Size(56, 23);
            this.rating5.TabIndex = 3;
            this.rating5.Text = "Bad";
            this.rating5.UseVisualStyleBackColor = true;
            this.rating5.CheckedChanged += new System.EventHandler(this.rating5_CheckedChanged);
            // 
            // rating2
            // 
            this.rating2.AutoSize = true;
            this.rating2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating2.ForeColor = System.Drawing.Color.White;
            this.rating2.Location = new System.Drawing.Point(118, 69);
            this.rating2.Name = "rating2";
            this.rating2.Size = new System.Drawing.Size(68, 23);
            this.rating2.TabIndex = 3;
            this.rating2.Text = "Good";
            this.rating2.UseVisualStyleBackColor = true;
            this.rating2.CheckedChanged += new System.EventHandler(this.rating2_CheckedChanged);
            // 
            // rating1
            // 
            this.rating1.AutoSize = true;
            this.rating1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating1.ForeColor = System.Drawing.Color.White;
            this.rating1.Location = new System.Drawing.Point(20, 69);
            this.rating1.Name = "rating1";
            this.rating1.Size = new System.Drawing.Size(90, 23);
            this.rating1.TabIndex = 3;
            this.rating1.Text = "Excellent";
            this.rating1.UseVisualStyleBackColor = true;
            this.rating1.CheckedChanged += new System.EventHandler(this.rating1_CheckedChanged);
            // 
            // rsuggestionscoments
            // 
            this.rsuggestionscoments.AutoSize = true;
            this.rsuggestionscoments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsuggestionscoments.ForeColor = System.Drawing.Color.White;
            this.rsuggestionscoments.Location = new System.Drawing.Point(16, 109);
            this.rsuggestionscoments.Name = "rsuggestionscoments";
            this.rsuggestionscoments.Size = new System.Drawing.Size(232, 21);
            this.rsuggestionscoments.TabIndex = 2;
            this.rsuggestionscoments.Text = "Suggestions and Comments:";
            this.rsuggestionscoments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feedbaclquestion
            // 
            this.feedbaclquestion.AutoSize = true;
            this.feedbaclquestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbaclquestion.ForeColor = System.Drawing.Color.White;
            this.feedbaclquestion.Location = new System.Drawing.Point(16, 45);
            this.feedbaclquestion.Name = "feedbaclquestion";
            this.feedbaclquestion.Size = new System.Drawing.Size(253, 21);
            this.feedbaclquestion.TabIndex = 2;
            this.feedbaclquestion.Text = "Rate your EasyDine experience:";
            this.feedbaclquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rfeedback
            // 
            this.rfeedback.AutoSize = true;
            this.rfeedback.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfeedback.ForeColor = System.Drawing.Color.White;
            this.rfeedback.Location = new System.Drawing.Point(95, 3);
            this.rfeedback.Name = "rfeedback";
            this.rfeedback.Size = new System.Drawing.Size(285, 33);
            this.rfeedback.TabIndex = 2;
            this.rfeedback.Text = "Customer Feedback";
            this.rfeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 700);
            this.Controls.Add(this.rbottom);
            this.Controls.Add(this.rtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "receiptform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receiptform";
            this.rtop.ResumeLayout(false);
            this.rbottom.ResumeLayout(false);
            this.rbottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rtop;
        private System.Windows.Forms.RichTextBox rreceipt;
        private System.Windows.Forms.Panel rbottom;
        private System.Windows.Forms.Label rfeedback;
        private System.Windows.Forms.Label feedbaclquestion;
        private System.Windows.Forms.CheckBox rating5;
        private System.Windows.Forms.CheckBox rating1;
        private System.Windows.Forms.RichTextBox suggestionscomments;
        private System.Windows.Forms.CheckBox rating4;
        private System.Windows.Forms.CheckBox rating2;
        private System.Windows.Forms.Label rsuggestionscoments;
        private System.Windows.Forms.Button rexitbtn;
        private System.Windows.Forms.Button rsubmitbtn;
        private System.Windows.Forms.CheckBox rating3;
    }
}