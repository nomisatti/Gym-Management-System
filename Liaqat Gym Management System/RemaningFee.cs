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
    public partial class RemaningFee : UserControl
    {
        public RemaningFee()
        {
            InitializeComponent();
        }
        GymMembersInformation gymMembersInformation = new GymMembersInformation();
        string search;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member Registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtRecieptNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Reciept number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRecieptNo.Focus();
            }


            else
            {
                gymMembersInformation.Id = Convert.ToInt32(lblId.Text.ToString());
                gymMembersInformation.RegNO = txtRegNo.Text.ToString();
                gymMembersInformation.RecipetNo = txtRecieptNo.Text.ToString();
                gymMembersInformation.Remaning = Convert.ToInt32(txtRemaning.Text.ToString());
                if (string.IsNullOrEmpty(txtRemaning.Text.Trim()))
                {
                    gymMembersInformation.Remaning = 0;
                }
                else
                {
                    gymMembersInformation.Remaning = Convert.ToInt32(txtRemaning.Text.ToString().Trim());
                }

                GymDatabase gymDatabase = new GymDatabase();
                gymDatabase.RemaningFee(gymMembersInformation);
                DataTable dataTable = gymDatabase.GetMemberFeeForm(gymMembersInformation);

                dgvFeeForm.DataSource = dataTable;
                dgvFeeForm.Refresh();

            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dataTable = new DataTable();
                if (txtsearch.Text.Trim() != search)
                {
                    gymMembersInformation.RegNO = txtsearch.Text.ToString();

                    GymDatabase gymDatabase = new GymDatabase();
                    dataTable = gymDatabase.GetMemberFeeForm(gymMembersInformation);

                    dgvFeeForm.DataSource = dataTable;

                    dgvFeeForm.Refresh();
                    search = txtsearch.Text.Trim();

                }
                else if (txtsearch.Text.Trim() == search)

                {
                    if (dgvFeeForm.Rows.Count > 1)
                    {
                        dgvFeeForm.Rows[0].Selected = true;
                        DataGridViewRow dataGridViewRow = dgvFeeForm.SelectedRows[0];
                        txtRegNo.Text = dataGridViewRow.Cells["regno"].Value.ToString();
                       // txtRemaning.Text = dataGridViewRow.Cells["prevusFee"].Value.ToString();
                        lblId.Text = dataGridViewRow.Cells["id"].Value.ToString();

                    }

                    //      MessageBox.Show(dataGridViewRow.Cells["regno"].Value.ToString());
                    //DataRow row = dataTable.Rows[0];
                    //txtRegNo.Text = row["regno"].ToString();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(showMembers);

            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();
        }
    }
}
