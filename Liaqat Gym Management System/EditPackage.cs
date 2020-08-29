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
    public partial class EditPackage : UserControl
    {
        public EditPackage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Package Name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMonths.Text == "")
            {
                MessageBox.Show("Number of Months is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PackagesInformation gymPackages = new PackagesInformation();
                gymPackages.Id = Convert.ToInt32(lblId.Text.ToString());
                gymPackages.Name = txtName.Text.ToString();
                gymPackages.StartDate = dtpstart.Value;
                gymPackages.EndDate = dtpend.Value;
                gymPackages.Months = Convert.ToInt32(txtMonths.Text.Trim());

                if (checkBox1.Checked)
                {
                    gymPackages.IsDefault = true;
                }
                else
                {
                    gymPackages.IsDefault = false;
                }
                if (!string.IsNullOrEmpty(txtFreeMonths.Text.Trim()))
                {
                    gymPackages.FreeMonths = Convert.ToInt32(txtFreeMonths.Text.ToString());
                }

                if (!string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    gymPackages.Price = Convert.ToInt32(txtPrice.Text.ToString());
                }

                if (!string.IsNullOrEmpty(txtPayFor.Text.Trim()))
                {
                    gymPackages.PayFor = Convert.ToInt32(txtPayFor.Text.ToString());
                }

                GymDatabase gymDatabase = new GymDatabase();
                gymDatabase.UpdatePackage(gymPackages);
            }
        }

        public void GetPackageInformaation(PackagesInformation packagesInformation)
        {
            lblId.Text = packagesInformation.Id.ToString();
            txtName.Text = packagesInformation.Name.ToString();
            txtPayFor.Text = packagesInformation.PayFor.ToString();
            txtPrice.Text = packagesInformation.Price.ToString();
            txtFreeMonths.Text = packagesInformation.FreeMonths.ToString();
            txtMonths.Text = packagesInformation.Months.ToString();
            if (packagesInformation.IsDefault == true)
            {
                checkBox1.Checked = true;
            }
            else
            {

                checkBox1.Checked = false;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GymPackages gymPackages = new GymPackages();
            gymPackages.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();

            MainForm.Instance.PnlContainer.Controls.Add(gymPackages);

            MainForm.Instance.PnlContainer.Controls["GymPackages"].BringToFront();
        }
    }
}
