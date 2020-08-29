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
    public partial class AddMember : UserControl
    {
        public AddMember()
        {
            InitializeComponent();
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

            else
            {
                string regno = txtRegNo.Text.Trim();
                string name = txtName.Text.Trim();
                string fathername = txtFatherName.Text.Trim();
                string phoneno = txtPhone.Text.Trim();
                string cnic = txtCNIC.Text.Trim();
                DateTime dateTime = dtpJoinDate.Value;
                string class_ = cmbClass.SelectedItem.ToString().Trim();
                string package = cmbPackage.SelectedItem.ToString().Trim();
                bool paid = false;
                float? chest;
                if (string.IsNullOrEmpty(txtChest.Text))
                {
                    chest = 0;
                }
                else
                {
                    chest = float.Parse(txtChest.Text);
                }

                float? hips;
                if (string.IsNullOrEmpty(txtWaist.Text))
                {
                    hips = 0;
                }
                else
                {
                    hips = float.Parse(txtWaist.Text);
                }
                float? weight;
                if (string.IsNullOrEmpty(txtWeight.Text))
                {
                    weight = 0;
                }
                else
                {
                    weight = float.Parse(txtWeight.Text);
                }


                GymDatabase gymDatabase = new GymDatabase();
                gymDatabase.AddNewMember(regno, name, fathername, phoneno, cnic, dateTime, class_, package, paid, chest, hips, weight);

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
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            cmbPackage.Items.Clear();
            foreach (string Package in Packages.pkg)
            {
                cmbPackage.Items.Add(Package);

            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(showMembers);

            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(showMembers);

            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();
            showMembers.GetMembers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpJoinDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtWaist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;
            //if (!Char.IsDigit(ch) && (ch != 46 || ch!= 189))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
