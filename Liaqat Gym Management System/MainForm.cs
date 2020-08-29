using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liaqat_Gym_Management_System
{
    public partial class MainForm : Form
    {

        public static MainForm _obj;
        AttendenceForm attendenceForm = new AttendenceForm();

        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }

                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return MainPanel; }
            set { MainPanel = value; }
        }


        public void ChangeLogo(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            this.pictureBox1.Image = new Bitmap(ms);


        }
        public void AddMembers()
        {
            //    addMember1.Show();
            //    showMembers1.Hide();
        }
        public MainForm()
        {
            InitializeComponent();

            //addMember1.Hide();
            //showMembers1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _obj = this;
            //MainPanel.Controls.Clear();
            Attendacne feeForm = new Attendacne();
            feeForm.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(feeForm);

            MainForm.Instance.PnlContainer.Controls["Attendacne"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MainPanel.Controls.Clear();
            _obj = this;
            MainPanel.Controls.Clear();
            Credentionals credentionals = new Credentionals();
            credentionals.PasswordOf("Users");
            if (credentionals.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MainPanel.Controls.Clear();
                ShowMembers showMembers = new ShowMembers();
                showMembers.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainPanel.Controls.Add(showMembers);

                MainPanel.Controls["ShowMembers"].BringToFront();

              
            }
            else
            {
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            AdminInformation adminInformation = new AdminInformation();
            _obj = this;
            //MainPanel.Controls.Clear();
            //Attendacne feeForm = new Attendacne();
            //feeForm.Dock = DockStyle.Fill;
            //MainForm.Instance.PnlContainer.Controls.Add(feeForm);

            //MainForm.Instance.PnlContainer.Controls["Attendacne"].BringToFront();

            GymDatabase gymDatabase = new GymDatabase();
            gymDatabase.GetPackages();
            AdminDatabase adminDatabase = new AdminDatabase();
            adminInformation = adminDatabase.GymPhoto();
            ChangeLogo(adminInformation.Logo);

            _obj = this;
            MainPanel.Controls.Clear();

            Home home = new Home();
            home.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(home);

            MainForm.Instance.PnlContainer.Controls["Home"].BringToFront();


            this.WindowState = FormWindowState.Maximized;
          
            //_obj = this;
            //AddMember addMember = new AddMember();
            //addMember.Dock = DockStyle.Fill;

            //MainPanel.Controls.Add(addMember);

        }

        private void showMembers1_Load(object sender, EventArgs e)
        {

        }

        private void showMembers1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _obj = this;
            MainPanel.Controls.Clear();
            Credentionals credentionals = new Credentionals();
            credentionals.PasswordOf("Club");
            if (credentionals.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Clubs clubs = new Clubs();
                clubs.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainForm.Instance.PnlContainer.Controls.Add(clubs);

                MainForm.Instance.PnlContainer.Controls["Clubs"].BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AttendenceForm attendence = new AttendenceForm();
            attendence.ShowDialog();
           
            //bool isformOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "AttendenceForm")
            //    {
            //        isformOpen = true;
            //        f.BringToFront();
            //        break;
            //    }


            //}

            //if (isformOpen == false)
            //{
            //    AttendenceForm attendenceForm = new AttendenceForm();
            //    attendenceForm.Show();
            //}



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _obj = this;
            MainPanel.Controls.Clear();
            Credentionals credentionals = new Credentionals();
            credentionals.PasswordOf("Setting");
            if (credentionals.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings settings = new Settings();
                settings.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainForm.Instance.PnlContainer.Controls.Add(settings);

                MainForm.Instance.PnlContainer.Controls["Settings"].BringToFront();
            }
        }



        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
            _obj = this;
            MainPanel.Controls.Clear();

            Home home = new Home();
            home.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(home);


          


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _obj = this;
            MainPanel.Controls.Clear();
            Credentionals credentionals = new Credentionals();
            credentionals.PasswordOf("Club");
            if (credentionals.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Report report = new Report();
                report.Dock = DockStyle.Fill;
                MainForm.Instance.PnlContainer.Controls.Clear();

                MainForm.Instance.PnlContainer.Controls.Add(report);

                MainForm.Instance.PnlContainer.Controls["Report"].BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(home);

            MainForm.Instance.PnlContainer.Controls["HomePage"].BringToFront();

        }
    }
}
