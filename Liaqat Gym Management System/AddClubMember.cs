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
using System.Runtime.InteropServices.ComTypes;
using System.Data.SqlClient;

namespace Liaqat_Gym_Management_System
{
    public partial class AddClubMember : UserControl
    {
        public AddClubMember()
        {
            InitializeComponent();
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

        private void Save_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrEmpty(cmbRank.Text))
            {
                MessageBox.Show("Please Select Rank ", "Rank is Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cmbClubs.Text))
            {
                MessageBox.Show("Please Select Club ", "Club is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                ClubMembersInformation clubMembersInformation = new ClubMembersInformation();
                clubMembersInformation.Name = txtName.Text;
                clubMembersInformation.JoinDate = dateTimePicker1.Value;
                clubMembersInformation.Rank = cmbRank.SelectedItem.ToString();
                clubMembersInformation.Picture = images;
                clubMembersInformation.Club = Convert.ToInt32(cmbClubs.SelectedValue.ToString());

                ClubDatabase clubDatabase = new ClubDatabase();
                clubDatabase.AddClubMemeber(clubMembersInformation);
                txtName.Clear();
                cmbRank.SelectedIndex = -1;
                cmbClubs.SelectedIndex = -1;
                lblImage.Text = string.Empty;
            }

        }

        private void AddClubMember_Load(object sender, EventArgs e)
        {
            cmbClubs.DataSource = ClubList.Clubs;
            foreach (var Item in ClubList.Clubs)
            {
                cmbClubs.DisplayMember = "name";
                cmbClubs.ValueMember = "id";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

            MainForm.Instance.PnlContainer.Controls.Add(clubs);

            MainForm.Instance.PnlContainer.Controls["Clubs"].BringToFront();

        }
    }
}
