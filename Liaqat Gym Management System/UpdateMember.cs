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
    public partial class UpdateMember : UserControl
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            cmbPackage.Items.Clear();
            foreach (string Package in Packages.pkg)
            {
                cmbPackage.Items.Add(Package);

            }
        }

        public void GetMemberInfo(GymMembersInformation MembersInformation)
        {


            txtRegNo.Text = MembersInformation.RegNO;
            txtName.Text = MembersInformation.Name;
            txtFatherName.Text = MembersInformation.Father_Name;
            txtPhone.Text = MembersInformation.Phone;
            txtCNIC.Text = MembersInformation.CNIC;
            dtpJoinDate.Value = MembersInformation.DateTime;
            cmbClass.Text = MembersInformation.CLASS_;
            cmbPackage.Text = MembersInformation.Package;
            //paid = MembersInformation.Paid;
            txtChest.Text = MembersInformation.CHEST.ToString();
            txtWaist.Text = MembersInformation.HIPS.ToString();
            txtWeight.Text = MembersInformation.WEIGHT.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (txtRegNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member Registration number");
            }
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member Name");
            }

            else if (txtFatherName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member's Father Name");
            }

            else if (txtCNIC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member's CNIC number");
            }

            else if (txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Member's Phone number");
            }
            else if (cmbClass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select Member's Class");
            }
            else if (cmbPackage.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select Member's Package");
            }
            GymMembersInformation MembersInformation = new GymMembersInformation();

            GymDatabase gymDatabase = new GymDatabase();
            MembersInformation.RegNO = txtRegNo.Text.ToString(); ;
            MembersInformation.Name = txtName.Text.ToString();
            MembersInformation.Father_Name = txtFatherName.Text.ToString(); ;
            MembersInformation.Phone = txtPhone.Text.ToString();
            MembersInformation.CNIC = txtCNIC.Text.ToString();
            MembersInformation.DateTime = dtpJoinDate.Value;
            MembersInformation.CLASS_ = cmbClass.SelectedItem.ToString().Trim();
            MembersInformation.Package = cmbPackage.SelectedItem.ToString().Trim();
            //paid = MembersInformation.Paid;
            if (string.IsNullOrEmpty(txtChest.Text))
            {
                MembersInformation.CHEST = 0;
            }
            else
            {
                MembersInformation.CHEST = float.Parse(txtChest.Text);
            }

            if (string.IsNullOrEmpty(txtWaist.Text))
            {
                MembersInformation.HIPS = 0;
            }
            else
            {
                MembersInformation.HIPS = float.Parse(txtWaist.Text);
            }

            if (string.IsNullOrEmpty(txtWeight.Text))
            {
                MembersInformation.WEIGHT = 0;
            }
            else
            {
                MembersInformation.WEIGHT = float.Parse(txtWeight.Text);
            }

            gymDatabase.UpdateMember(MembersInformation);
            txtRegNo.Clear();
            txtName.Clear();
            txtFatherName.Clear();
            txtCNIC.Clear();
            txtPhone.Clear();
            cmbClass.SelectedIndex = -1;
            cmbPackage.SelectedIndex = -1;
            txtChest.Text = "0";
            txtWeight.Text = "0";
            txtWaist.Text = "0";

            txtRegNo.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(showMembers);
            
            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();
            showMembers.GetMembers();
        }

        private void txtRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;
            //if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            //{
            //    e.Handled = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
