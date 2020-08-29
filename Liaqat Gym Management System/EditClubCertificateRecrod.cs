using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liaqat_Gym_Management_System
{
    public partial class EditClubCertificateRecrod : UserControl
    {
        public EditClubCertificateRecrod()
        {
            InitializeComponent();
        }

        public int Type = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clubs clubs = new Clubs();
            clubs.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(clubs);
            clubs.CheckType(Type);
            MainForm.Instance.PnlContainer.Controls["Clubs"].BringToFront();
        }

        private void EditClubCertificateRecrod_Load(object sender, EventArgs e)
        {

            cmbClubs.DataSource = ClubList.Clubs;
            foreach (var Item in ClubList.Clubs)
            {
                cmbClubs.DisplayMember = "name";
                cmbClubs.ValueMember = "id";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRank.Text))
            {
                MessageBox.Show("Please Select Rank ", "Rank is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Enter Quantity ", "Quantity is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cmbClubs.Text))
            {
                MessageBox.Show("Please Select Club ", "Club is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClubCertificates clubCertificates = new ClubCertificates();
                clubCertificates.Id = Convert.ToInt32(lblId.Text.ToString());
                clubCertificates.Rank = cmbRank.SelectedItem.ToString();
                clubCertificates.Amount = txtAmount.Text.ToString().Trim();
                clubCertificates.SerialNumber = Convert.ToInt32(txtQuantity.Text.Trim().ToString());
                clubCertificates.IsseDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                clubCertificates.Clubid = Convert.ToInt32(cmbClubs.SelectedValue);

                ClubDatabase clubDatabase = new ClubDatabase();
                clubDatabase.UpdateCertificateRecord(clubCertificates);

            }
        }

        public void GetCertificateInfo(ClubCertificates clubCertificates,  int type)
        {
            lblId.Text = clubCertificates.Id.ToString(); ;
            txtAmount.Text = clubCertificates.Amount;
            txtQuantity.Text = clubCertificates.SerialNumber.ToString();
            cmbClubs.SelectedItem = clubCertificates.ClubName.ToString();
            cmbRank.SelectedItem = clubCertificates.Rank;
            dateTimePicker1.Value = Convert.ToDateTime(clubCertificates.IsseDate.ToString());
            Type = type;
        }
    }
}
