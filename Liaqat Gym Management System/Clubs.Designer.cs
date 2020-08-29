namespace Liaqat_Gym_Management_System
{
    partial class Clubs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clubs));
            this.cmbClubs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvclubmember = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.clubMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubInfo = new Liaqat_Gym_Management_System.ClubInfo();
            this.club_MembersTableAdapter = new Liaqat_Gym_Management_System.ClubInfoTableAdapters.Club_MembersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClubCertificate = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclubmember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClubs
            // 
            this.cmbClubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClubs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClubs.FormattingEnabled = true;
            this.cmbClubs.Location = new System.Drawing.Point(292, 4);
            this.cmbClubs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClubs.Name = "cmbClubs";
            this.cmbClubs.Size = new System.Drawing.Size(150, 25);
            this.cmbClubs.TabIndex = 0;
            this.cmbClubs.SelectedIndexChanged += new System.EventHandler(this.cmbClubs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clubs";
            // 
            // dgvclubmember
            // 
            this.dgvclubmember.AllowUserToAddRows = false;
            this.dgvclubmember.AllowUserToDeleteRows = false;
            this.dgvclubmember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclubmember.AutoGenerateColumns = false;
            this.dgvclubmember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclubmember.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvclubmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclubmember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.clubIdDataGridViewTextBoxColumn,
            this.JoinDate,
            this.pictureDataGridViewImageColumn});
            this.dgvclubmember.DataSource = this.clubMembersBindingSource;
            this.dgvclubmember.Location = new System.Drawing.Point(0, 144);
            this.dgvclubmember.Margin = new System.Windows.Forms.Padding(4);
            this.dgvclubmember.Name = "dgvclubmember";
            this.dgvclubmember.ReadOnly = true;
            this.dgvclubmember.RowTemplate.Height = 100;
            this.dgvclubmember.Size = new System.Drawing.Size(671, 449);
            this.dgvclubmember.TabIndex = 3;
            this.dgvclubmember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclubmember_CellClick);
            this.dgvclubmember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clubIdDataGridViewTextBoxColumn
            // 
            this.clubIdDataGridViewTextBoxColumn.DataPropertyName = "Club_Id";
            this.clubIdDataGridViewTextBoxColumn.HeaderText = "Club_Id";
            this.clubIdDataGridViewTextBoxColumn.Name = "clubIdDataGridViewTextBoxColumn";
            this.clubIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // JoinDate
            // 
            this.JoinDate.DataPropertyName = "Join Date";
            this.JoinDate.HeaderText = "JoinDate";
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // clubMembersBindingSource
            // 
            this.clubMembersBindingSource.DataMember = "Club_Members";
            this.clubMembersBindingSource.DataSource = this.clubInfo;
            // 
            // clubInfo
            // 
            this.clubInfo.DataSetName = "ClubInfo";
            this.clubInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // club_MembersTableAdapter
            // 
            this.club_MembersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(464, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit Record";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(360, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 93);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add New Record";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(266, 53);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 84);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add New Club";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.LightGray;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Location = new System.Drawing.Point(4, 113);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MaximumSize = new System.Drawing.Size(266, 100);
            this.txtsearch.MinimumSize = new System.Drawing.Size(2, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(204, 23);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // cmbType
            // 
            this.cmbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Club Members",
            "Club Certificates"});
            this.cmbType.Location = new System.Drawing.Point(48, 4);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 25);
            this.cmbType.TabIndex = 24;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type";
            // 
            // dgvClubCertificate
            // 
            this.dgvClubCertificate.AllowUserToAddRows = false;
            this.dgvClubCertificate.AllowUserToDeleteRows = false;
            this.dgvClubCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClubCertificate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClubCertificate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClubCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubCertificate.Location = new System.Drawing.Point(0, 144);
            this.dgvClubCertificate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClubCertificate.Name = "dgvClubCertificate";
            this.dgvClubCertificate.ReadOnly = true;
            this.dgvClubCertificate.RowTemplate.Height = 100;
            this.dgvClubCertificate.Size = new System.Drawing.Size(671, 449);
            this.dgvClubCertificate.TabIndex = 26;
            this.dgvClubCertificate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClubCertificate_CellClick);
            this.dgvClubCertificate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClubCertificate_CellContentClick);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(568, 53);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 80);
            this.button4.TabIndex = 27;
            this.button4.Text = "Delete Record";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvClubCertificate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvclubmember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClubs);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clubs";
            this.Size = new System.Drawing.Size(687, 597);
            this.Load += new System.EventHandler(this.Clubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclubmember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClubs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvclubmember;
        private System.Windows.Forms.BindingSource clubMembersBindingSource;
        private ClubInfo clubInfo;
        private ClubInfoTableAdapters.Club_MembersTableAdapter club_MembersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClubCertificate;
        private System.Windows.Forms.Button button4;
    }
}
