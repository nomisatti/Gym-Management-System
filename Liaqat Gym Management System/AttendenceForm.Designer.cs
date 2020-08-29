namespace Liaqat_Gym_Management_System
{
    partial class AttendenceForm
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
            this.lbltodaypresence = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReciptNo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRemaning = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFeeExpiry = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFeeDate = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltodaypresence
            // 
            this.lbltodaypresence.AutoSize = true;
            this.lbltodaypresence.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltodaypresence.Location = new System.Drawing.Point(599, 27);
            this.lbltodaypresence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltodaypresence.Name = "lbltodaypresence";
            this.lbltodaypresence.Size = new System.Drawing.Size(0, 23);
            this.lbltodaypresence.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(393, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Today Presence";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbltodaypresence);
            this.panel2.Controls.Add(this.txtReg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblReciptNo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblRemaning);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblFeeExpiry);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.lblFeeDate);
            this.panel2.Controls.Add(this.lblReg);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 451);
            this.panel2.TabIndex = 88;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtReg
            // 
            this.txtReg.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReg.Location = new System.Drawing.Point(189, 407);
            this.txtReg.Mask = "000000";
            this.txtReg.MinimumSize = new System.Drawing.Size(4, 25);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(140, 22);
            this.txtReg.TabIndex = 86;
            this.txtReg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtReg_MaskInputRejected);
            this.txtReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReg_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Reg No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Name";
            // 
            // lblReciptNo
            // 
            this.lblReciptNo.AutoSize = true;
            this.lblReciptNo.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciptNo.Location = new System.Drawing.Point(208, 343);
            this.lblReciptNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReciptNo.Name = "lblReciptNo";
            this.lblReciptNo.Size = new System.Drawing.Size(0, 15);
            this.lblReciptNo.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 343);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 82;
            this.label13.Text = "ReceiptNo";
            // 
            // lblRemaning
            // 
            this.lblRemaning.AutoSize = true;
            this.lblRemaning.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaning.Location = new System.Drawing.Point(208, 302);
            this.lblRemaning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemaning.Name = "lblRemaning";
            this.lblRemaning.Size = new System.Drawing.Size(0, 15);
            this.lblRemaning.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(66, 302);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 80;
            this.label16.Text = "Remaning";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(208, 251);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 15);
            this.lblClass.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(66, 251);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 78;
            this.label18.Text = "Class";
            // 
            // lblFeeExpiry
            // 
            this.lblFeeExpiry.AutoSize = true;
            this.lblFeeExpiry.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeExpiry.Location = new System.Drawing.Point(208, 200);
            this.lblFeeExpiry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeeExpiry.Name = "lblFeeExpiry";
            this.lblFeeExpiry.Size = new System.Drawing.Size(0, 15);
            this.lblFeeExpiry.TabIndex = 77;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(62, 200);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 15);
            this.label20.TabIndex = 76;
            this.label20.Text = "Fee Expiry";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(62, 152);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 15);
            this.label21.TabIndex = 75;
            this.label21.Text = "Fee Date";
            // 
            // lblFeeDate
            // 
            this.lblFeeDate.AutoSize = true;
            this.lblFeeDate.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeDate.Location = new System.Drawing.Point(208, 152);
            this.lblFeeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeeDate.Name = "lblFeeDate";
            this.lblFeeDate.Size = new System.Drawing.Size(0, 15);
            this.lblFeeDate.TabIndex = 74;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(208, 101);
            this.lblReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 15);
            this.lblReg.TabIndex = 73;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(66, 101);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 15);
            this.label24.TabIndex = 72;
            this.label24.Text = "Reg No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(208, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 71;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label26.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkRed;
            this.label26.Location = new System.Drawing.Point(12, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 23);
            this.label26.TabIndex = 70;
            this.label26.Text = "Attendence";
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 451);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendenceForm";
            this.Text = "AttendenceForm";
            this.Load += new System.EventHandler(this.AttendenceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbltodaypresence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReciptNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRemaning;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFeeExpiry;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFeeDate;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MaskedTextBox txtReg;
        private System.Windows.Forms.Label label1;
    }
}