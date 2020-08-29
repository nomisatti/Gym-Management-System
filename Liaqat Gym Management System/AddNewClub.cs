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
    public partial class AddNewClub : UserControl
    {
        public AddNewClub()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Club Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClubNames club = new ClubNames();
                club.name = txtName.Text.ToString();
                ClubDatabase clubDatabase = new ClubDatabase();
                clubDatabase.AddClub(club);

                txtName.Clear();
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
