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
    public partial class ShowMembers : UserControl
    {
        DataTable dataTable = new DataTable();
        GymMembersInformation MembersInformation = new GymMembersInformation();
        public ShowMembers()
        {
            InitializeComponent();
        }

        int SelectedRow;
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillBy(this.gymDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void ShowMembers_Load(object sender, EventArgs e)
        {

            GetMembers();
        }

        public void GetMembers()
        {
            GymDatabase gymDatabase = new GymDatabase();
            dataTable.Clear();
            dataTable = gymDatabase.GetMembers();

            dgvShowMembers.DataSource = dataTable;
            dgvShowMembers.Refresh();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddMember addMember = new AddMember();
            addMember.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(addMember);

            MainForm.Instance.PnlContainer.Controls["AddMember"].BringToFront();

        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string search = txtsearch.Text.Trim();
            search = search;
            GymDatabase gymDatabase = new GymDatabase();
            dataTable = gymDatabase.GetMember(search);

            dgvShowMembers.DataSource = dataTable;
            dgvShowMembers.Refresh();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ////textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow dataGridViewRow = dgvShowMembers.Rows[SelectedRow];
            MembersInformation.RegNO = dataGridViewRow.Cells[0].Value.ToString();
            MembersInformation.Name = dataGridViewRow.Cells[1].Value.ToString();
            MembersInformation.Father_Name = dataGridViewRow.Cells[2].Value.ToString();
            MembersInformation.Phone = dataGridViewRow.Cells[3].Value.ToString();
            MembersInformation.CNIC = dataGridViewRow.Cells[4].Value.ToString();
            MembersInformation.DateTime = Convert.ToDateTime(dataGridViewRow.Cells[5].Value);
            MembersInformation.CLASS_ = dataGridViewRow.Cells[6].Value.ToString();
            MembersInformation.Package = dataGridViewRow.Cells[7].Value.ToString(); ;
            MembersInformation.Paid = Convert.ToBoolean(dataGridViewRow.Cells[8].Value.ToString());
            if (string.IsNullOrEmpty(dataGridViewRow.Cells[9].Value.ToString()))
            {
                MembersInformation.CHEST = 0;
            }
            else
            {
                MembersInformation.CHEST = float.Parse(dataGridViewRow.Cells[9].Value.ToString());
            }

            if (string.IsNullOrEmpty(dataGridViewRow.Cells[10].Value.ToString()))
            {
                MembersInformation.HIPS = 0;
            }
            else
            {
                MembersInformation.HIPS = float.Parse(dataGridViewRow.Cells[10].Value.ToString());
            }

            if (string.IsNullOrEmpty(dataGridViewRow.Cells[11].Value.ToString()))
            {
                MembersInformation.WEIGHT = 0;
            }
            else
            {
                MembersInformation.WEIGHT = float.Parse(dataGridViewRow.Cells[11].Value.ToString());
            }
            UpdateMember updateMember = new UpdateMember();
            updateMember.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(updateMember);

            MainForm.Instance.PnlContainer.Controls["UpdateMember"].BringToFront();

            updateMember.GetMemberInfo(MembersInformation);
        }

        private void dgvShowMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if(SelectedRow < 0)
            {
                SelectedRow = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GymDatabase gymDatabase = new GymDatabase();
            dataTable = gymDatabase.GetMembers();

            dgvShowMembers.DataSource = dataTable;
            dgvShowMembers.Refresh();

            txtsearch.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FeeForm feeForm = new FeeForm();
            feeForm.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(feeForm);

            MainForm.Instance.PnlContainer.Controls["FeeForm"].BringToFront();
        }

        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtsearch.Text.Trim();
                GymDatabase gymDatabase = new GymDatabase();
                DataTable Table = gymDatabase.GetMember(txtsearch.Text);

                dgvShowMembers.DataSource = Table;
                dgvShowMembers.Refresh();

                //DataView dataView = dataTable.DefaultView;


                //dataView.RowFilter = string.Format("regno = {0} Or name like '%{0}%' Or Father_Name like '%{0}%' Or phone like '%{0}%' Or nic like '%{0}%' ", txtsearch.Text);
                //dgvShowMembers.DataSource = dataView.ToTable();



            }
        }

        private void dgvShowMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GymPackages gymPackages = new GymPackages();
            gymPackages.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(gymPackages);

            MainForm.Instance.PnlContainer.Controls["GymPackages"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemaningFee remaningFee = new RemaningFee();
            remaningFee.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(remaningFee);

            MainForm.Instance.PnlContainer.Controls["RemaningFee"].BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure ?","Delete User", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                DataGridViewRow dataGridViewRow = dgvShowMembers.Rows[SelectedRow];
                MembersInformation.RegNO = dataGridViewRow.Cells[0].Value.ToString();
                MembersInformation.Name = dataGridViewRow.Cells[1].Value.ToString();

                GymDatabase gymDatabase = new GymDatabase();
                gymDatabase.DeleteMember(MembersInformation);
                dataTable = gymDatabase.GetMembers();


                dgvShowMembers.DataSource = dataTable;
                dgvShowMembers.Refresh();

            }
                
         
            
            

        }
    }
}
