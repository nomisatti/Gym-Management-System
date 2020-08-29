using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Liaqat_Gym_Management_System
{
    public partial class Settings : UserControl
    {
        MainForm mainForm;

        public MainForm MainForm 
        {
            get { return mainForm; }
            set { mainForm = value; }
        }
        public Settings()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*.png| jpg files(*.jpg)|*.jpg|All files(*.)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                lblImage.Text = imageLocation;
                btnRemoveImage.Visible = true;


            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblImage.Text.ToString()))
            {
                lblImage.Text = string.Empty;
                btnRemoveImage.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            if (!string.IsNullOrEmpty(lblImage.Text.ToString()))
            {
                Image img = Image.FromFile(lblImage.Text.ToString());
               // Image thumb = img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                string path = Directory.GetCurrentDirectory() + "\\Gym\\GymLogo_" +DateTime.Now.ToString("YY-MM-DD-HH-mm-ss")  + ".jpg";
                img.Save(path);
                FileStream fileStream = new FileStream(path.ToString(), FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                images = binaryReader.ReadBytes((int)fileStream.Length);

                AdminInformation adminInformation = new AdminInformation();
                AdminDatabase adminDatabase = new AdminDatabase();

                adminInformation.Logo = images;
                adminInformation = adminDatabase.UpdateLogo(adminInformation);

                MemoryStream ms = new MemoryStream(adminInformation.Logo);
               
                MainForm mainForm = new MainForm();
                mainForm.ChangeLogo(adminInformation.Logo);

            }


        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confrim Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdminInformation adminInformation = new AdminInformation();
                adminInformation.Password = txtPassword.Text.ToString().Trim();
                adminInformation.PassowrdOf = "Users";
                AdminDatabase adminDatabase = new AdminDatabase();
                adminDatabase.ChangePassword(adminInformation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClubPassword.Text))
            {
                MessageBox.Show("Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtClubPassword.Text != txtClubConfirm.Text)
            {
                MessageBox.Show("Password and Confrim Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdminInformation adminInformation = new AdminInformation();
                adminInformation.Password = txtClubPassword.Text.ToString().Trim();
                adminInformation.PassowrdOf = "Club";
                AdminDatabase adminDatabase = new AdminDatabase();
                adminDatabase.ChangePassword(adminInformation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSettingPassword.Text))
            {
                MessageBox.Show("Password is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSettingPassword.Text != txtSettingConfirm.Text)
            {
                MessageBox.Show("Password and Confrim Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdminInformation adminInformation = new AdminInformation();
                adminInformation.Password = txtSettingPassword.Text.ToString().Trim();
                adminInformation.PassowrdOf = "Setting";
                AdminDatabase adminDatabase = new AdminDatabase();
                adminDatabase.ChangePassword(adminInformation);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
