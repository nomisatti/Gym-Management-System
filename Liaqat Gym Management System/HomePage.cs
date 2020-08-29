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
using System.Media;
using System.IO;

namespace Liaqat_Gym_Management_System
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemaningFeeMembers remaningFeeMembers = new RemaningFeeMembers();
            remaningFeeMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(remaningFeeMembers);

            MainForm.Instance.PnlContainer.Controls["RemaningFeeMembers"].BringToFront();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            int totalRamaningFeeMembers = 0;
            int feeExpired = 0;
            int thismonthmembers = 0;
            GymDatabase gymDatabase = new GymDatabase();
            DataTable dataTable = gymDatabase.GetRemaningFeeMembers();
            totalRamaningFeeMembers = dataTable.Rows.Count;
            lblRemaning.Text = totalRamaningFeeMembers.ToString();
            dataTable = gymDatabase.GetFeeExpiredMembers();
            feeExpired = dataTable.Rows.Count;
            lblFeeExpired.Text = feeExpired.ToString();
            dataTable = gymDatabase.GetJoinThisMonthMembers();
            thismonthmembers = dataTable.Rows.Count;
            lblthismonth.Text = thismonthmembers.ToString();

         

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            FeeExpiredMembers feeExpiredMembers = new FeeExpiredMembers();
            feeExpiredMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(feeExpiredMembers);

            MainForm.Instance.PnlContainer.Controls["FeeExpiredMembers"].BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThisMonthMember thisMonthMember = new ThisMonthMember();
            thisMonthMember.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(thisMonthMember);

            MainForm.Instance.PnlContainer.Controls["ThisMonthMember"].BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

       



        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        checkBox1.Text = "Stop";
        //        foreach (string file in files)
        //        {
        //            soundPlayer = new SoundPlayer(file);
        //            soundPlayer.Play();
        //        }
        //    }
        //    else
        //    {
        //        checkBox1.Text = "Play";
        //        soundPlayer.Stop();
        //    }

        //}
    }
}
