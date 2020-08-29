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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int colorOne = random.Next(0, 255);
            //int ColorTw0 = random.Next(0, 255);
            //int ColorThree = random.Next(0, 255);
            //int colorFour = random.Next(0, 255);
            //label1.ForeColor = Color.FromArgb(colorOne, ColorTw0, ColorThree, colorFour);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

            timer2.Start();
            timer2.Enabled = true;

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("ddd");
        }

        private void lblSec_Click(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
