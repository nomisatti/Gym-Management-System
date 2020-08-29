namespace Liaqat_Gym_Management_System
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlCertificateFields = new System.Windows.Forms.Panel();
            this.chkAmount = new System.Windows.Forms.CheckBox();
            this.chkSerialNumber = new System.Windows.Forms.CheckBox();
            this.chkRank = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIssueDate = new System.Windows.Forms.CheckBox();
            this.chkclub = new System.Windows.Forms.CheckBox();
            this.pnlAttendenceSearch = new System.Windows.Forms.Panel();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.pnlCertificateSearch = new System.Windows.Forms.Panel();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAttendecneFields = new System.Windows.Forms.Panel();
            this.chbPhone = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.chbReg = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCertificateFields.SuspendLayout();
            this.pnlAttendenceSearch.SuspendLayout();
            this.pnlCertificateSearch.SuspendLayout();
            this.pnlAttendecneFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlCertificateFields);
            this.panel1.Controls.Add(this.pnlAttendenceSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbReport);
            this.panel1.Controls.Add(this.pnlCertificateSearch);
            this.panel1.Controls.Add(this.pnlAttendecneFields);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.todate);
            this.panel1.Controls.Add(this.fromdate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 429);
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.myReportViewer);
            this.panel2.Location = new System.Drawing.Point(6, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 275);
            this.panel2.TabIndex = 102;
            // 
            // myReportViewer
            // 
            this.myReportViewer.ActiveViewIndex = -1;
            this.myReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.myReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myReportViewer.Location = new System.Drawing.Point(0, 0);
            this.myReportViewer.Name = "myReportViewer";
            this.myReportViewer.Size = new System.Drawing.Size(768, 275);
            this.myReportViewer.TabIndex = 88;
            // 
            // pnlCertificateFields
            // 
            this.pnlCertificateFields.Controls.Add(this.chkAmount);
            this.pnlCertificateFields.Controls.Add(this.chkSerialNumber);
            this.pnlCertificateFields.Controls.Add(this.chkRank);
            this.pnlCertificateFields.Controls.Add(this.label6);
            this.pnlCertificateFields.Controls.Add(this.chkIssueDate);
            this.pnlCertificateFields.Controls.Add(this.chkclub);
            this.pnlCertificateFields.Location = new System.Drawing.Point(6, 72);
            this.pnlCertificateFields.Name = "pnlCertificateFields";
            this.pnlCertificateFields.Size = new System.Drawing.Size(234, 75);
            this.pnlCertificateFields.TabIndex = 101;
            // 
            // chkAmount
            // 
            this.chkAmount.AutoSize = true;
            this.chkAmount.Location = new System.Drawing.Point(141, 20);
            this.chkAmount.Name = "chkAmount";
            this.chkAmount.Size = new System.Drawing.Size(74, 21);
            this.chkAmount.TabIndex = 100;
            this.chkAmount.Text = "Amount";
            this.chkAmount.UseVisualStyleBackColor = true;
            // 
            // chkSerialNumber
            // 
            this.chkSerialNumber.AutoSize = true;
            this.chkSerialNumber.Location = new System.Drawing.Point(17, 51);
            this.chkSerialNumber.Name = "chkSerialNumber";
            this.chkSerialNumber.Size = new System.Drawing.Size(80, 21);
            this.chkSerialNumber.TabIndex = 99;
            this.chkSerialNumber.Text = "Serial No";
            this.chkSerialNumber.UseVisualStyleBackColor = true;
            // 
            // chkRank
            // 
            this.chkRank.AutoSize = true;
            this.chkRank.Location = new System.Drawing.Point(80, 20);
            this.chkRank.Name = "chkRank";
            this.chkRank.Size = new System.Drawing.Size(55, 21);
            this.chkRank.TabIndex = 98;
            this.chkRank.Text = "Rank";
            this.chkRank.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(16, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "Fields to Add";
            // 
            // chkIssueDate
            // 
            this.chkIssueDate.AutoSize = true;
            this.chkIssueDate.Location = new System.Drawing.Point(101, 51);
            this.chkIssueDate.Name = "chkIssueDate";
            this.chkIssueDate.Size = new System.Drawing.Size(88, 21);
            this.chkIssueDate.TabIndex = 96;
            this.chkIssueDate.Text = "Issue Date";
            this.chkIssueDate.UseVisualStyleBackColor = true;
            // 
            // chkclub
            // 
            this.chkclub.AutoSize = true;
            this.chkclub.Location = new System.Drawing.Point(17, 20);
            this.chkclub.Name = "chkclub";
            this.chkclub.Size = new System.Drawing.Size(57, 21);
            this.chkclub.TabIndex = 95;
            this.chkclub.Text = "Club ";
            this.chkclub.UseVisualStyleBackColor = true;
            // 
            // pnlAttendenceSearch
            // 
            this.pnlAttendenceSearch.Controls.Add(this.txtMember);
            this.pnlAttendenceSearch.Controls.Add(this.label7);
            this.pnlAttendenceSearch.Location = new System.Drawing.Point(262, 72);
            this.pnlAttendenceSearch.Name = "pnlAttendenceSearch";
            this.pnlAttendenceSearch.Size = new System.Drawing.Size(294, 75);
            this.pnlAttendenceSearch.TabIndex = 99;
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(6, 35);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(268, 22);
            this.txtMember.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(16, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Search By Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Report";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbReport
            // 
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Items.AddRange(new object[] {
            "Attendence",
            "Certificates"});
            this.cmbReport.Location = new System.Drawing.Point(55, 1);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(153, 25);
            this.cmbReport.TabIndex = 99;
            this.cmbReport.SelectedIndexChanged += new System.EventHandler(this.cmbReport_SelectedIndexChanged);
            // 
            // pnlCertificateSearch
            // 
            this.pnlCertificateSearch.Controls.Add(this.txtClub);
            this.pnlCertificateSearch.Controls.Add(this.label4);
            this.pnlCertificateSearch.Location = new System.Drawing.Point(265, 72);
            this.pnlCertificateSearch.Name = "pnlCertificateSearch";
            this.pnlCertificateSearch.Size = new System.Drawing.Size(294, 75);
            this.pnlCertificateSearch.TabIndex = 98;
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(6, 34);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(268, 22);
            this.txtClub.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(16, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Search By Club";
            // 
            // pnlAttendecneFields
            // 
            this.pnlAttendecneFields.Controls.Add(this.chbPhone);
            this.pnlAttendecneFields.Controls.Add(this.chbName);
            this.pnlAttendecneFields.Controls.Add(this.label3);
            this.pnlAttendecneFields.Controls.Add(this.chbDate);
            this.pnlAttendecneFields.Controls.Add(this.chbReg);
            this.pnlAttendecneFields.Location = new System.Drawing.Point(14, 72);
            this.pnlAttendecneFields.Name = "pnlAttendecneFields";
            this.pnlAttendecneFields.Size = new System.Drawing.Size(204, 75);
            this.pnlAttendecneFields.TabIndex = 97;
            // 
            // chbPhone
            // 
            this.chbPhone.AutoSize = true;
            this.chbPhone.Location = new System.Drawing.Point(17, 51);
            this.chbPhone.Name = "chbPhone";
            this.chbPhone.Size = new System.Drawing.Size(64, 21);
            this.chbPhone.TabIndex = 99;
            this.chbPhone.Text = "Phone";
            this.chbPhone.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(104, 20);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(63, 21);
            this.chbName.TabIndex = 98;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "Fields to Add";
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(104, 51);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(90, 21);
            this.chbDate.TabIndex = 96;
            this.chbDate.Text = "Date & Time";
            this.chbDate.UseVisualStyleBackColor = true;
            // 
            // chbReg
            // 
            this.chbReg.AutoSize = true;
            this.chbReg.Location = new System.Drawing.Point(19, 20);
            this.chbReg.Name = "chbReg";
            this.chbReg.Size = new System.Drawing.Size(62, 21);
            this.chbReg.TabIndex = 95;
            this.chbReg.Text = "Reg #";
            this.chbReg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "From Date";
            // 
            // todate
            // 
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todate.Location = new System.Drawing.Point(524, 5);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(125, 22);
            this.todate.TabIndex = 91;
            // 
            // fromdate
            // 
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdate.Location = new System.Drawing.Point(308, 4);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(129, 22);
            this.fromdate.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(599, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 89;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(781, 429);
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlCertificateFields.ResumeLayout(false);
            this.pnlCertificateFields.PerformLayout();
            this.pnlAttendenceSearch.ResumeLayout(false);
            this.pnlAttendenceSearch.PerformLayout();
            this.pnlCertificateSearch.ResumeLayout(false);
            this.pnlCertificateSearch.PerformLayout();
            this.pnlAttendecneFields.ResumeLayout(false);
            this.pnlAttendecneFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.CheckBox chbReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer myReportViewer;
        private System.Windows.Forms.Panel pnlAttendecneFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox chbPhone;
        private System.Windows.Forms.Panel pnlCertificateSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Panel pnlCertificateFields;
        private System.Windows.Forms.CheckBox chkAmount;
        private System.Windows.Forms.CheckBox chkSerialNumber;
        private System.Windows.Forms.CheckBox chkRank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIssueDate;
        private System.Windows.Forms.CheckBox chkclub;
        private System.Windows.Forms.Panel pnlAttendenceSearch;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}
