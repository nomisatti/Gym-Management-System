using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liaqat_Gym_Management_System
{
    public partial class AttendenceForm : Form
    {
        public AttendenceForm()
        {
            InitializeComponent();
        }
        GymDatabase gymDataBase = new GymDatabase();
        int count = 0;
        private void txtReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtReg.Text))
                {
                    MessageBox.Show("Please Enter Reg No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GymMembersInformation gymMembersInformation = new GymMembersInformation();


                    bool check = gymDataBase.AddAttendence(Convert.ToInt32(txtReg.Text.ToString()));

                    if (check)
                    {
                        count = gymDataBase.TodayPresence();
                        gymMembersInformation = gymDataBase.AttendanceData(Convert.ToInt32(txtReg.Text.ToString()));
                        lblName.Text = gymMembersInformation.Name;
                        lblReg.Text = gymMembersInformation.RegNO;
                        if (gymMembersInformation.FeeDate > Convert.ToDateTime("1/1/2000"))
                            lblFeeDate.Text = gymMembersInformation.FeeDate.ToLongDateString();
                        else
                            lblFeeDate.Text = "Fee Record Not Found";

                        if (gymMembersInformation.ExpireDate > Convert.ToDateTime("1/1/2000"))
                        {
                            lblFeeExpiry.Text = gymMembersInformation.ExpireDate.ToLongDateString();

                            if (gymMembersInformation.ExpireDate < DateTime.Now)
                                lblFeeExpiry.ForeColor = System.Drawing.Color.Red;
                            else
                                lblFeeExpiry.ForeColor = Color.Green;
                        }
                        else
                            lblFeeExpiry.Text = "Fee Record Not Found";


                        lblClass.Text = gymMembersInformation.CLASS_;
                        lblRemaning.Text = gymMembersInformation.Remaning.ToString();
                        lblReciptNo.Text = gymMembersInformation.RecipetNo;

                        lbltodaypresence.Text = count.ToString();

                    }


                }

                txtReg.Clear();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Club_Click(object sender, EventArgs e)
        {

        }

        private void AttendenceForm_Load(object sender, EventArgs e)
        {
            count = gymDataBase.TodayPresence();
            lbltodaypresence.Text = count.ToString();
            this.ActiveControl = txtReg;
            this.Focus();
            this.CenterToScreen();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
