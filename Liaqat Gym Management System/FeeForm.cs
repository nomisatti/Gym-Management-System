using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Liaqat_Gym_Management_System
{
    public partial class FeeForm : UserControl
    {
        public FeeForm()
        {
            InitializeComponent();
        }
        GymMembersInformation gymMembersInformation = new GymMembersInformation();

        string search;
        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            GymMembersInformation gymMembersInformation = new GymMembersInformation();

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
                        cmbClass.SelectedItem = dataGridViewRow.Cells["class"].Value.ToString().Trim() ;
                       

                    }

                    //      MessageBox.Show(dataGridViewRow.Cells["regno"].Value.ToString());
                    //DataRow row = dataTable.Rows[0];
                    //txtRegNo.Text = row["regno"].ToString();
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member Registration number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtFee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Add Fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFee.Focus();
            }
            else if (txtRecieptNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Reciept number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRecieptNo.Focus();
            }
            
            else if (cmbClass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select Member's Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                gymMembersInformation.RegNO = txtRegNo.Text.ToString();
                gymMembersInformation.RecipetNo = txtRecieptNo.Text.ToString();
                gymMembersInformation.Fee = Convert.ToInt32(txtFee.Text.ToString());
                if (string.IsNullOrEmpty(txtRemaning.Text.Trim()))
                {
                    gymMembersInformation.Remaning = 0;
                }
                else
                {
                    gymMembersInformation.Remaning = Convert.ToInt32(txtRemaning.Text.ToString().Trim());
                }
                gymMembersInformation.CLASS_ = cmbClass.SelectedItem.ToString();
                gymMembersInformation.FeeDate = dtpfeedate.Value;


                CalculateRemaningFee();
                GymDatabase gymDatabase = new GymDatabase();
                gymDatabase.AddMemberFee(gymMembersInformation);
                DataTable dataTable = gymDatabase.GetMemberFeeForm(gymMembersInformation);

                dgvFeeForm.DataSource = dataTable;
                dgvFeeForm.Refresh();

                txtFee.Clear();
                txtRecieptNo.Clear();
                txtRegNo.Clear();
                txtRemaning.Clear();
                
            }

        }

        public void CalculateRemaningFee()
        {
            SqlConnection conection = Connection.Sql_Connection();
            SqlCommand sqlCommand = new SqlCommand("Select Months from  Packeges as p  Inner Join [user] as u On p.packege = u.packege Where regno = @regno", conection);
            sqlCommand.Parameters.AddWithValue("@regno", gymMembersInformation.RegNO);
            conection.Open();
            using (conection)
            {
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    gymMembersInformation.Months = Convert.ToInt32(dr["Months"].ToString());
                }

                dr.Close();
            }

            gymMembersInformation.ExpireDate = gymMembersInformation.FeeDate.AddMonths(gymMembersInformation.Months);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(showMembers);

            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecieptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRecieptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemaning_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpfeedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
