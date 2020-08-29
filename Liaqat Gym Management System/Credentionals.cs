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
    public partial class Credentionals : Form
    {
        public Credentionals()
        {
            InitializeComponent();
        }

        public static string passwordOf;
        AdminInformation adminInformation = new AdminInformation();
        AdminDatabase adminDatabase = new AdminDatabase();

        private void button1_Click(object sender, EventArgs e)
        {
            adminInformation = adminDatabase.GetPassword(passwordOf);

            if (txtpassword.Text.Trim() == adminInformation.Password.Trim())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        public void PasswordOf(string password)
        {
            passwordOf = password;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Credentionals_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Credentionals_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminInformation = adminDatabase.GetPassword(passwordOf);

                if (txtpassword.Text.Trim() == adminInformation.Password.Trim())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
    }
}
