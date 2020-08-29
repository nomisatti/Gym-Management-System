using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liaqat_Gym_Management_System
{
    
    public class AdminDatabase
    {
        public AdminInformation UpdateLogo(AdminInformation adminInformation)
        {
            SqlConnection connection = Connection.Sql_Connection();
            SqlCommand command = new SqlCommand("Update Admin set Gym_Logo = @logo", connection);
            SqlCommand getlogoCommamd = new SqlCommand("Select top 1 Gym_Logo from Admin", connection);
            command.Parameters.AddWithValue("@logo", adminInformation.Logo);
            connection.Open();
            using (connection)
            {
                try
                {
                    command.ExecuteNonQuery();

                    SqlDataReader dr = getlogoCommamd.ExecuteReader();
                    while (dr.Read())
                    {
                        adminInformation.Logo = (Byte[])(dr["Gym_Logo"]);
                    }
                    dr.Close();

                    MessageBox.Show("Gym Logo is Updated Successfully", "Logo Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            return adminInformation; 


        }

        public AdminInformation GetPassword(string passwordOf)
        {
            AdminInformation adminInformation = new AdminInformation();
            SqlConnection connection = Connection.Sql_Connection();
            SqlCommand cmd = new SqlCommand("Select "+passwordOf+"Passowrd from Admin", connection);
            connection.Open();
            using (connection)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    adminInformation.Password = dr[passwordOf+"Passowrd"].ToString();
                }
            }
            return adminInformation;

        }

        public void ChangePassword(AdminInformation adminInformation)
        {
            SqlConnection connection = Connection.Sql_Connection();
            SqlCommand cmd = new SqlCommand("Update Admin set "+adminInformation.PassowrdOf+"Passowrd = @pass", connection);
            cmd.Parameters.AddWithValue("@pass", adminInformation.Password);
            connection.Open();
            using(connection)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(adminInformation.PassowrdOf +" Passowrd is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public AdminInformation GymPhoto()
        {
            SqlConnection connection = Connection.Sql_Connection();
            AdminInformation adminInformation = new AdminInformation();
            SqlCommand getlogoCommamd = new SqlCommand("Select top 1 Gym_Logo from Admin", connection);
            connection.Open();
            using (connection)
            {
                try
                {

                    SqlDataReader dr = getlogoCommamd.ExecuteReader();
                    while (dr.Read())
                    {
                        adminInformation.Logo = (Byte[])(dr["Gym_Logo"]);
                    }
                    dr.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Logo Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return adminInformation;
        }
    }
   
}
