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
    public partial class FeeExpiredMembers : UserControl
    {
        public FeeExpiredMembers()
        {
            InitializeComponent();
        }
        DataTable datatable = new DataTable();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Dock = DockStyle.Fill;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(home);

            MainForm.Instance.PnlContainer.Controls["HomePage"].BringToFront();
        }

        private void FeeExpiredMembers_Load(object sender, EventArgs e)
        {
            GymDatabase gymDatabase = new GymDatabase();
            datatable = gymDatabase.GetFeeExpiredMembers();
            dgvFeeExpired.DataSource = datatable;


        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtsearch.Text.Trim();
                int intsearch;
                if (int.TryParse(txtsearch.Text, out intsearch))
                {
                    datatable.DefaultView.RowFilter = string.Format(" [Reg #] = {0}  ", intsearch);

                }

                else
                {
                    //DataView dataView = datatable.DefaultView;

                    datatable.DefaultView.RowFilter = string.Format("Name like '%{0}%'  ", txtsearch.Text);
                    //dataView.RowFilter = 
                    //dgvRemaingMembers.DataSource = dataView.ToTable();
                }



            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Empty;

        }
    }
}
