using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Liaqat_Gym_Management_System
{
    public partial class EditClubMember : UserControl
    {
        public EditClubMember()
        {
            InitializeComponent();
        }
       public int type = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            if (!string.IsNullOrEmpty(lblImage.Text.ToString()))
            {
                Image img = Image.FromFile(lblImage.Text.ToString());
                Image thumb = img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                string path = Directory.GetCurrentDirectory() + "\\ClubMembers\\" + txtName.Text.ToString() + ".jpg";
                thumb.Save(path);
                FileStream fileStream = new FileStream(path.ToString(), FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                images = binaryReader.ReadBytes((int)fileStream.Length);

            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter Name ", "Name is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(cmbRank.Text))
            {
                MessageBox.Show("Please Enter Name ", "Name is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(cmbClubs.Text))
            {
                MessageBox.Show("Please Enter Name ", "Name is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClubMembersInformation clubMembersInformation = new ClubMembersInformation();
            clubMembersInformation.Id = Convert.ToInt32(lblId.Text.ToString());
            clubMembersInformation.Name = txtName.Text;
            clubMembersInformation.JoinDate = dateTimePicker1.Value;
            clubMembersInformation.Rank = cmbRank.SelectedItem.ToString();
            clubMembersInformation.Picture = images;
            clubMembersInformation.Club = Convert.ToInt32(cmbClubs.SelectedValue.ToString());

            ClubDatabase clubDatabase = new ClubDatabase();
            clubDatabase.EditClubMember(clubMembersInformation);
        }

        public void ClubMemberInfo(ClubMembersInformation clubMembersInformation , int type )
        {

            lblId.Text = clubMembersInformation.Id.ToString();
            txtName.Text = clubMembersInformation.Name;
            cmbRank.SelectedItem = clubMembersInformation.Rank;
            dateTimePicker1.Value = clubMembersInformation.JoinDate;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditClubMember_Load(object sender, EventArgs e)
        {
            cmbClubs.DataSource = ClubList.Clubs;
            foreach (var Item in ClubList.Clubs)
            {
                cmbClubs.DisplayMember = "name";
                cmbClubs.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*.png| jpg files(*.jpg)|*.jpg|All files(*.)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                lblImage.Text = imageLocation;
                btnRemoveImage.Visible = true;

            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblImage.Text.ToString()))
            {
                lblImage.Text = string.Empty;
                btnRemoveImage.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clubs clubs = new Clubs();
            clubs.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();
            clubs.CheckType(type);
            MainForm.Instance.PnlContainer.Controls.Add(clubs);
            MainForm.Instance.PnlContainer.Controls["Clubs"].BringToFront();
        }
    }
}
