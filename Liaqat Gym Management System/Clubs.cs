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
    public partial class Clubs : UserControl
    {
        public Clubs()
        {
            InitializeComponent();



        }
        int SelectedRow;
        private void Clubs_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            ClubDatabase clubDatabase = new ClubDatabase();
            clubDatabase.Club_Names();
            cmbClubs.DataSource = ClubList.Clubs;
            foreach (var Item in ClubList.Clubs)
            {
                cmbClubs.DisplayMember = "name";
                cmbClubs.ValueMember = "id";
            }


        }

        private void cmbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                ClubNames Clubs = cmbClubs.SelectedItem as ClubNames;
                ClubDatabase club = new ClubDatabase();
                DataTable dataTable = club.GetCludMembers(Clubs);


                dgvclubmember.DataSource = dataTable;

                dgvclubmember.Refresh();
            }
            else
            {
                ClubCertificates clubCertificates = new ClubCertificates();

                ClubDatabase clubDatabase = new ClubDatabase();
                clubCertificates.Clubid = Convert.ToInt32(cmbClubs.SelectedValue.ToString());
                DataTable datatable = clubDatabase.GetCLubCertifactesDate(clubCertificates);
                dgvClubCertificate.DataSource = datatable;
                dgvClubCertificate.Refresh();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewClub addNewClub = new AddNewClub();
            addNewClub.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(addNewClub);

            MainForm.Instance.PnlContainer.Controls["AddNewClub"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                AddClubMember addClubMember = new AddClubMember();
                addClubMember.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainForm.Instance.PnlContainer.Controls.Add(addClubMember);

                MainForm.Instance.PnlContainer.Controls["AddClubMember"].BringToFront();
            }
            else
            {

                AddCertificteRecord addCertificteRecord = new AddCertificteRecord();
                addCertificteRecord.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainForm.Instance.PnlContainer.Controls.Add(addCertificteRecord);

                MainForm.Instance.PnlContainer.Controls["AddCertificteRecord"].BringToFront();
            }

        }

        public void CheckType(int type)
        {
            cmbType.SelectedIndex = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                if (dgvclubmember.Rows.Count > 0)
                {
                    DataGridViewRow dataGridViewRow = dgvclubmember.Rows[SelectedRow];
                    ClubMembersInformation clubMembersInformation = new ClubMembersInformation();
                    clubMembersInformation.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                    clubMembersInformation.Name = dataGridViewRow.Cells[1].Value.ToString();
                    clubMembersInformation.Rank = dataGridViewRow.Cells[2].Value.ToString();
                    clubMembersInformation.JoinDate = Convert.ToDateTime(dataGridViewRow.Cells[4].Value.ToString());
                    EditClubMember editClubMember = new EditClubMember();
                    editClubMember.ResetText();
                    editClubMember.ClubMemberInfo(clubMembersInformation, cmbType.SelectedIndex);
                    editClubMember.Dock = DockStyle.Fill;
                    MainForm.Instance.PnlContainer.Controls.Clear();
                    MainForm.Instance.PnlContainer.Controls.Add(editClubMember);

                    MainForm.Instance.PnlContainer.Controls["EditClubMember"].BringToFront();

                }

            }
            else
            {
                if (dgvClubCertificate.Rows.Count > 0)
                {
                    DataGridViewRow dataGridViewRow = dgvClubCertificate.Rows[SelectedRow];
                    ClubCertificates clubMembersInformation = new ClubCertificates();
                    clubMembersInformation.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                    clubMembersInformation.Rank = dataGridViewRow.Cells[1].Value.ToString();
                    clubMembersInformation.SerialNumber = Convert.ToInt32(dataGridViewRow.Cells[2].Value.ToString());

                    clubMembersInformation.IsseDate = Convert.ToDateTime(dataGridViewRow.Cells[3].Value.ToString());
                    clubMembersInformation.Amount = dataGridViewRow.Cells[4].Value.ToString();
                    clubMembersInformation.ClubName = dataGridViewRow.Cells[5].Value.ToString();


                    EditClubCertificateRecrod editClubCertificateRecrod = new EditClubCertificateRecrod();
                    editClubCertificateRecrod.ResetText();
                    editClubCertificateRecrod.GetCertificateInfo(clubMembersInformation, cmbType.SelectedIndex);
                    editClubCertificateRecrod.Dock = DockStyle.Fill;
                    MainForm.Instance.PnlContainer.Controls.Clear();
                    MainForm.Instance.PnlContainer.Controls.Add(editClubCertificateRecrod);

                    MainForm.Instance.PnlContainer.Controls["EditClubCertificateRecrod"].BringToFront();
                }

            }

        }

        private void dgvclubmember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (SelectedRow < 0)
            {
                SelectedRow = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClubNames Clubs = cmbClubs.SelectedItem as ClubNames;
            ClubDatabase club = new ClubDatabase();
            DataTable dataTable = club.GetCludMembers(Clubs);


            dgvclubmember.DataSource = dataTable;

            dgvclubmember.Refresh();


            txtsearch.Text = "";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable Table = new DataTable();
                if (cmbType.SelectedIndex == 0)
                {
                    GymMembersInformation gymMembersInformation = new GymMembersInformation();
                    gymMembersInformation.RegNO = txtsearch.Text;
                    string search = txtsearch.Text.Trim();
                    ClubDatabase clubDatabase = new ClubDatabase();
                    Table = clubDatabase.GetCludMembersSearch(txtsearch.Text);

                    dgvclubmember.DataSource = Table;
                    dgvclubmember.Refresh();
                }
                //else
                //{
                //    Table = dgvClubCertificate.DataSource as DataTable;
                //    DataView dataView = Table.DefaultView;


                //    dataView.RowFilter = string.Format("Club_Name like '%{0}%'  ", txtsearch.Text);
                //    dgvClubCertificate.DataSource = dataView.ToTable();
                //}
            }


        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex > 0)
            {
                ClubCertificates clubCertificates = new ClubCertificates();
                dgvclubmember.Hide();
                label2.Hide();
                dgvClubCertificate.Show();
                ClubDatabase clubDatabase = new ClubDatabase();
                if (cmbClubs.Items.Count > 0)
                {
                    cmbClubs.SelectedIndex = 0;
                    clubCertificates.Clubid = Convert.ToInt32(cmbClubs.SelectedValue.ToString());
                }
                DataTable datatable = clubDatabase.GetCLubCertifactesDate(clubCertificates);
                dgvClubCertificate.DataSource = datatable;
                dgvClubCertificate.Refresh();
            }
            else
            {
                label2.Show();
                dgvclubmember.Show();
                dgvClubCertificate.Hide();
            }
        }

        private void dgvClubCertificate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClubCertificate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (SelectedRow < 0)
            {
                SelectedRow = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectedRow < 0)
            {
                SelectedRow = 0;
            }
            int id;
            string table = string.Empty;
            ClubDatabase clubDatabase = new ClubDatabase();

            DialogResult dialogResult = MessageBox.Show("Are you Sure ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (cmbType.SelectedIndex == 0)
                {
                    if (dgvclubmember.Rows.Count > 0)
                    {
                        ClubNames Clubs = cmbClubs.SelectedItem as ClubNames;

                        DataGridViewRow dataGridViewRow = dgvclubmember.Rows[SelectedRow];
                        id = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                        table = "Club_Members";
                        clubDatabase.DeleteRecord(id, table);
                        DataTable dataTable = clubDatabase.GetCludMembers(Clubs);
                        dgvclubmember.DataSource = dataTable;
                        dgvclubmember.Refresh();
                    }
                }
                else
                {
                    if (dgvClubCertificate.Rows.Count > 0)
                    {
                        ClubCertificates clubCertificates = new ClubCertificates();
                        DataGridViewRow dataGridViewRow = dgvClubCertificate.Rows[SelectedRow];
                        id = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                        table = "ClubCertification";
                        clubDatabase.DeleteRecord(id, table);
                        clubCertificates.Clubid = Convert.ToInt32(cmbClubs.SelectedValue.ToString());
                        DataTable datatable = clubDatabase.GetCLubCertifactesDate(clubCertificates);
                        dgvClubCertificate.DataSource = datatable;
                        dgvClubCertificate.Refresh();
                    }
                }
            }
        }
    }
}
