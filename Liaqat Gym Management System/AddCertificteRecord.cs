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
    public partial class AddCertificteRecord : UserControl
    {
        public AddCertificteRecord()
        {
            InitializeComponent();
        }

        private void AddCertificteRecord_Load(object sender, EventArgs e)
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
                clubCertificates.Rank = cmbRank.SelectedItem.ToString();
                clubCertificates.Amount = txtAmount.Text.ToString().Trim();
                clubCertificates.SerialNumber = Convert.ToInt32(txtQuantity.Text.Trim().ToString());
                clubCertificates.IsseDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                clubCertificates.Clubid = Convert.ToInt32(cmbClubs.SelectedValue);

                ClubDatabase clubDatabase = new ClubDatabase();
                clubDatabase.AddClubCertificationRecord(clubCertificates);

                cmbRank.SelectedIndex = -1;
                cmbClubs.SelectedIndex = -1;
                txtAmount.Clear();
                txtQuantity.Clear();
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
