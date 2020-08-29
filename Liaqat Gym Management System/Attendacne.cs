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
    public partial class Attendacne : UserControl
    {
        GymDatabase gymDataBase = new GymDatabase();
        int count = 0;
        public Attendacne()
        {
            InitializeComponent();
        }

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
                    gymMembersInformation.RegNO = txtReg.Text.ToString();

                    gymMembersInformation = gymDataBase.AttendanceData(count);
                    lblName.Text = gymMembersInformation.Name;
                    lblReg.Text = gymMembersInformation.RegNO;
                    lblFeeDate.Text = gymMembersInformation.FeeDate.ToLongDateString();
                    lblFeeExpiry.Text = gymMembersInformation.ExpireDate.ToLongDateString();
                    lblClass.Text = gymMembersInformation.CLASS_;
                    lblRemaning.Text = gymMembersInformation.Remaning.ToString();
                    lblReciptNo.Text = gymMembersInformation.RecipetNo;

                    gymDataBase.AddAttendence(count);
                    count = gymDataBase.TodayPresence();
                    lbltodaypresence.Text = count.ToString();
                }



            }
        }

        private void Attendacne_Load(object sender, EventArgs e)
        {
            count = gymDataBase.TodayPresence();
            lbltodaypresence.Text = count.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
