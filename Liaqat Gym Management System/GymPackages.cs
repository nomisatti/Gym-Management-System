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
    public partial class GymPackages : UserControl
    {
        public GymPackages()
        {
            InitializeComponent();
        }
        int SelectedRow;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GymPackages_Load(object sender, EventArgs e)
        {
            GymDatabase gymDatabase = new GymDatabase();
            DataTable dataTable = gymDatabase.GetAllPackages();

            dgvPackages.DataSource = dataTable;
            dgvPackages.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPackage addPackage = new AddPackage();
            addPackage.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(addPackage);

            MainForm.Instance.PnlContainer.Controls["AddPackage"].BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GymDatabase gymDatabase = new GymDatabase();
            DataTable dataTable = new DataTable();
            dataTable = gymDatabase.GetAllPackages();

            dgvPackages.DataSource = dataTable;
            dgvPackages.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvPackages.Rows[SelectedRow];
            PackagesInformation packagesInformation = new PackagesInformation();
            packagesInformation.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
            packagesInformation.Name = dataGridViewRow.Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridViewRow.Cells[4].Value.ToString()))
            {
                packagesInformation.Months = Convert.ToInt32(dataGridViewRow.Cells[4].Value.ToString());
            }
           

            if (!string.IsNullOrEmpty(dataGridViewRow.Cells[5].Value.ToString()))
            {
                packagesInformation.PayFor = Convert.ToInt32(dataGridViewRow.Cells[5].Value.ToString());

            }
            if (!string.IsNullOrEmpty(dataGridViewRow.Cells[6].Value.ToString()))
            {
                packagesInformation.FreeMonths = Convert.ToInt32(dataGridViewRow.Cells[6].Value.ToString());

            }
            if (!string.IsNullOrEmpty(dataGridViewRow.Cells[7].Value.ToString()))
            {
                packagesInformation.Price = Convert.ToInt32(dataGridViewRow.Cells[7].Value.ToString());

            }
            packagesInformation.IsDefault = Convert.ToBoolean(dataGridViewRow.Cells[8].Value.ToString());

            EditPackage editPackage = new EditPackage();
            editPackage.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(editPackage);

            MainForm.Instance.PnlContainer.Controls["EditPackage"].BringToFront();

            editPackage.GetPackageInformaation(packagesInformation);

        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if(SelectedRow < 0)
            {
                SelectedRow = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();
            showMembers.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Add(showMembers);

            MainForm.Instance.PnlContainer.Controls["ShowMembers"].BringToFront();
        }
    }
}
