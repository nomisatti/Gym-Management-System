using Liaqat_Gym_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liaqat_Gym_Management_System
{
    public static class Connection
    {
        public static SqlConnection Sql_Connection()
        {
            //SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-75F694L;Initial Catalog=Gym;Integrated Security=True");
              SqlConnection sqlConnection = new SqlConnection(@"Data Source=SARDAR-PC;Initial Catalog=Gym;Integrated Security=True");
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-8JV4MC9 ;Initial Catalog=Gym;Integrated Security=True");
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-E7QJS2H\SQLEXPRESS ;Initial Catalog=Gym;Integrated Security=True");

            return sqlConnection;
        }
    }

}

public class GymDatabase
{


    public DataTable GetMembers()
    {
        SqlConnection connection = Connection.Sql_Connection();

        connection.Open();
        using (connection)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from [dbo].[user] order by id desc", connection);
            DataTable dataTable = new DataTable();
            cmd.Fill(dataTable);

            return dataTable;
        }
    }

    public DataTable GetJoinThisMonthMembers()
    {
        SqlConnection connection = Connection.Sql_Connection();
        DataTable dataTable = new DataTable();
        connection.Open();
        using (connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select regno as 'Reg #', name as Name , packege as Package , paid as Paid from [user] Where Month(joindate) = Month(GetDate()) And Year(joindate) = Year(GetDate())", connection);
            sqlDataAdapter.Fill(dataTable);
        }

        return dataTable;
    }

    public DataTable GetRemaningFeeMembers()
    {
        SqlConnection connection = Connection.Sql_Connection();
        DataTable dataTable = new DataTable();
        connection.Open();
        using (connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select u.regno as 'Reg #' ,Name , class as Type , prevusFee as Remaning, Fee as 'Last Payment' , date as 'Last Payment Date' from [user] as u Left Join Payments as p On u.regno = p.regno Where prevusFee >0 AND prevusFee Is Not Null Order by date desc", connection);
            sqlDataAdapter.Fill(dataTable);
        }

        return dataTable;
    }


    public DataTable GetFeeExpiredMembers()
    {
        SqlConnection connection = Connection.Sql_Connection();
        DataTable dataTable = new DataTable();
        connection.Open();
        using (connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select u.regno  as 'Reg #',Name , Packege as Package  , date as 'Last Payment Date' , NextDate as 'Fee Expired Date' from [user] as u Left Join Payments as p On u.regno = p.regno Where GETDATE() >= NextDate Order by date desc", connection);
            sqlDataAdapter.Fill(dataTable);
        }

        return dataTable;
    }

    public bool AddAttendence(int Regno)
    {
        bool count = false;
        int checkuser = 0;
        bool checkpayment = false;
        SqlConnection connection = Connection.Sql_Connection();
        SqlCommand sqlCommandCheck = new SqlCommand("select count(*) present from attendence where Convert([date],date) = Convert(date,GetDate()) And regno = @regno", connection);
        SqlCommand PaymentCheck = new SqlCommand("Select * from Payments where regno = @regno", connection);
        SqlCommand cmd = new SqlCommand("Insert into Attendence Values(@regno,@date,@time)", connection);
        sqlCommandCheck.Parameters.AddWithValue("@regno", Regno);
        PaymentCheck.Parameters.AddWithValue("@regno", Regno);
        cmd.Parameters.AddWithValue("@regno", Regno);
        cmd.Parameters.AddWithValue("@date", DateTime.Now);
        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("t"));
        connection.Open();
        using (connection)
        {
            try
            {
                SqlDataReader paymentcheck = PaymentCheck.ExecuteReader();
                while (paymentcheck.Read())
                {
                    if (paymentcheck.HasRows)
                    {
                        count = true;
                    }

                }
                paymentcheck.Close();

                SqlDataReader dr = sqlCommandCheck.ExecuteReader();

                while (dr.Read())
                {
                    checkuser = Convert.ToInt32(dr["present"].ToString());
                }
                dr.Close();
                if (checkuser == 0)
                {
                    cmd.ExecuteNonQuery();
                    count = true;
                }
                else
                {
                    MessageBox.Show("Your Attendance is already entered  for today", "Already Entered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count = false;
            }


        }
        return count;


    }

    public int TodayPresence()
    {
        int count = 0;

        SqlConnection connection = Connection.Sql_Connection();
        SqlCommand sqlCommand = new SqlCommand("select count(*) present from attendence where Convert([date],date) = Convert(date,GetDate())", connection);
        connection.Open();
        using (connection)
        {
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                count = Convert.ToInt32(dr["present"].ToString());
            }
        }

        return count;
    }

    public GymMembersInformation AttendanceData(int Regno)
    {
        SqlConnection connection = Connection.Sql_Connection();
        GymMembersInformation gymMembersInformation = new GymMembersInformation();

        connection.Open();
        using (connection)
        {
            SqlCommand cmd = new SqlCommand("Select Top 1 b.regno,name,date,NextDate,class,packege,prevusFee, ReciptNo from[user] as b Left Join Payments as a On a.regno = b.regno where b.regno = @regno Order by a.date desc", connection);
            cmd.Parameters.AddWithValue("@regno", Regno);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gymMembersInformation.Name = dr["name"].ToString();
                gymMembersInformation.RegNO = dr["regno"].ToString();
                if (dr["date"].ToString().Trim() != "")
                    gymMembersInformation.FeeDate = Convert.ToDateTime(dr["date"].ToString());

                if (dr["NextDate"].ToString() != "")
                    gymMembersInformation.ExpireDate = Convert.ToDateTime(dr["NextDate"].ToString());
                gymMembersInformation.CLASS_ = dr["class"].ToString();
                gymMembersInformation.Package = dr["packege"].ToString();
                if (dr["prevusFee"].ToString() != "")
                    gymMembersInformation.Remaning = Convert.ToInt32(dr["prevusFee"].ToString());
                gymMembersInformation.RecipetNo = dr["ReciptNo"].ToString();
            }
        }

        return gymMembersInformation;
    }

    public void GetPackages()
    {
        SqlConnection connection = Connection.Sql_Connection();
        Packages.pkg.Clear();
        connection.Open();
        using (connection)
        {
            SqlCommand cmd = new SqlCommand("Select packege from Packeges where isdefault = 1 Order by id", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string pkg = dr["packege"].ToString();
                Packages.pkg.Add(pkg);
            }

        }
    }

    public DataTable GetAllPackages()
    {
        SqlConnection connection = Connection.Sql_Connection();

        connection.Open();
        using (connection)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Packeges Order by id", connection);


            DataTable dataTable = new DataTable();
            cmd.Fill(dataTable);

            return dataTable;
        }
    }

    public void UpdatePackage(PackagesInformation packagesInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();

        SqlCommand cmd = new SqlCommand("Update Packeges set packege=@name,startdate = @startdate, enddate=@enddate, Months= @months ,payfor =@payfor, freemonths = @freemonths, price = @price, isdefault = @isdefault Where id = @id", connection);
        cmd.Parameters.AddWithValue("@id", packagesInformation.Id);

        cmd.Parameters.AddWithValue("@name", packagesInformation.Name);
        cmd.Parameters.AddWithValue("@startdate", packagesInformation.StartDate);
        cmd.Parameters.AddWithValue("@enddate", packagesInformation.EndDate);
        cmd.Parameters.AddWithValue("@months", packagesInformation.Months);
        if (packagesInformation.PayFor != null)
        {
            cmd.Parameters.AddWithValue("@payfor", packagesInformation.PayFor);
        }
        else
        {
            SqlParameter p = new SqlParameter("@payfor", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }

        if (packagesInformation.FreeMonths != null)
        {
            cmd.Parameters.AddWithValue("@freemonths", packagesInformation.FreeMonths);

        }
        else
        {
            SqlParameter p = new SqlParameter("@freemonths", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }

        if (packagesInformation.Price != null)
        {
            cmd.Parameters.AddWithValue("@price", packagesInformation.Price);

        }
        else
        {
            SqlParameter p = new SqlParameter("@price", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }


        cmd.Parameters.AddWithValue("@isdefault", packagesInformation.IsDefault);

        connection.Open();
        using (connection)
        {
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package is added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }

    public void AddPackage(PackagesInformation packagesInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();

        SqlCommand cmd = new SqlCommand("Insert into Packeges Values(@name,@startdate,@enddate,@months,@payfor,@freemonths,@price,@isdefault)", connection);
        cmd.Parameters.AddWithValue("@name", packagesInformation.Name);
        cmd.Parameters.AddWithValue("@startdate", packagesInformation.StartDate);
        cmd.Parameters.AddWithValue("@enddate", packagesInformation.EndDate);
        cmd.Parameters.AddWithValue("@months", packagesInformation.Months);
        if (packagesInformation.PayFor != null)
        {
            cmd.Parameters.AddWithValue("@payfor", packagesInformation.PayFor);
        }
        else
        {
            SqlParameter p = new SqlParameter("@payfor", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }

        if (packagesInformation.FreeMonths != null)
        {
            cmd.Parameters.AddWithValue("@freemonths", packagesInformation.FreeMonths);

        }
        else
        {
            SqlParameter p = new SqlParameter("@freemonths", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }

        if (packagesInformation.Price != null)
        {
            cmd.Parameters.AddWithValue("@price", packagesInformation.Price);

        }
        else
        {
            SqlParameter p = new SqlParameter("@price", SqlDbType.Int);
            p.Value = DBNull.Value;
            cmd.Parameters.Add(p);
        }


        cmd.Parameters.AddWithValue("@isdefault", packagesInformation.IsDefault);

        connection.Open();
        using (connection)
        {
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package is added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }

    public DataTable GetMember(string search)
    {
        SqlConnection connection = Connection.Sql_Connection();

        connection.Open();
        using (connection)
        {
            string query = "Select * from [dbo].[user] Where regno like @search Or name Like @search Or Father_Name like @search Or phone like @search Or nic like @search order by id desc";
            SqlDataAdapter cmd = new SqlDataAdapter(query, connection);
            cmd.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
            DataTable dataTable = new DataTable();
            cmd.Fill(dataTable);

            return dataTable;
        }
    }

    public DataTable GetMemberFeeForm(GymMembersInformation gymMembersInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();

        connection.Open();
        using (connection)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select u.id, u.regno,u.name,u.Father_Name,u.phone, u.packege,nic,joindate,class, P.date as 'Fee Date', p.NextDate as 'Valid date' from [user]  as u left Join Payments as P on u.regno = P.regno where u.regno= @regno order by u.id desc", connection);
            cmd.SelectCommand.Parameters.AddWithValue("@regno", gymMembersInformation.RegNO);
            DataTable dataTable = new DataTable();
            cmd.Fill(dataTable);

            return dataTable;
        }
    }

    public void RemaningFee(GymMembersInformation gymMembersInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();
        connection.Open();
        using (connection)
        {

            SqlCommand sqlCommand = new SqlCommand("Update  Payments set prevusFee = @prevusFee ,  ReciptNo =@reciptNo  Where id=@id", connection);
            sqlCommand.Parameters.AddWithValue("@prevusFee", gymMembersInformation.Remaning);
            sqlCommand.Parameters.AddWithValue("@reciptNo", gymMembersInformation.RecipetNo);
            sqlCommand.Parameters.AddWithValue("@id", gymMembersInformation.Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Fee is added for Registration No:" + gymMembersInformation.RegNO, "Fee Added", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public void AddMemberFee(GymMembersInformation gymMembersInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();
        connection.Open();
        using (connection)
        {

            SqlCommand sqlCommand = new SqlCommand("Insert into Payments Values( @regno,  @fee,  @prevusFee ,  @date ,  @NextDate ,  @Type ,  @reciptNo)", connection);
            sqlCommand.Parameters.AddWithValue("@regno", gymMembersInformation.RegNO);
            sqlCommand.Parameters.AddWithValue("@fee", gymMembersInformation.Fee);
            sqlCommand.Parameters.AddWithValue("@prevusFee", gymMembersInformation.Remaning);
            sqlCommand.Parameters.AddWithValue("@date", gymMembersInformation.FeeDate);
            sqlCommand.Parameters.AddWithValue("@NextDate", gymMembersInformation.ExpireDate);
            sqlCommand.Parameters.AddWithValue("@Type", gymMembersInformation.CLASS_);
            sqlCommand.Parameters.AddWithValue("@reciptNo", gymMembersInformation.RecipetNo);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Fee is added for Registration No:" + gymMembersInformation.RegNO, "Fee Added", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
    }

    public void UpdateMember(GymMembersInformation gymMembersInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();
        SqlCommand sqlCommand = new SqlCommand("Update [dbo].[user] set name = @name, Father_Name= @Father_Name,phone = @phone, nic = @cnic,joindate = @joindate,class = @class_, packege = @package,chest = @chest,hips = @hips,weight = @weight where regno = @regno", connection);
        sqlCommand.Parameters.AddWithValue("@regno", gymMembersInformation.RegNO);
        sqlCommand.Parameters.AddWithValue("@name", gymMembersInformation.Name);
        sqlCommand.Parameters.AddWithValue("@Father_Name", gymMembersInformation.Father_Name);
        sqlCommand.Parameters.AddWithValue("@phone", gymMembersInformation.Phone);
        sqlCommand.Parameters.AddWithValue("@cnic", gymMembersInformation.CNIC);
        sqlCommand.Parameters.AddWithValue("@joindate", gymMembersInformation.DateTime);
        sqlCommand.Parameters.AddWithValue("@class_", gymMembersInformation.CLASS_);
        sqlCommand.Parameters.AddWithValue("@package", gymMembersInformation.Package);
        sqlCommand.Parameters.AddWithValue("@chest", gymMembersInformation.CHEST);
        sqlCommand.Parameters.AddWithValue("@hips", gymMembersInformation.HIPS);
        sqlCommand.Parameters.AddWithValue("@weight", gymMembersInformation.WEIGHT);

        connection.Open();
        using (connection)
        {
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Member :" + gymMembersInformation.Name + " record is Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public void DeleteMember(GymMembersInformation gymMembersInformation)
    {
        SqlConnection connection = Connection.Sql_Connection();

        SqlCommand sqlCommand = new SqlCommand("Delete from [dbo].[user] where regno = @regno", connection);
        sqlCommand.Parameters.AddWithValue("@regno", gymMembersInformation.RegNO);

        connection.Open();
        using (connection)
        {
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Member :" + gymMembersInformation.Name + " record is Removed ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public void AddNewMember(string regno, string name, string Father_Name, string phone, string cnic, DateTime joindate, string class_, string package, bool paid, float? chest, float? hips, float? weight)
    {
        SqlConnection sqlConnection = Connection.Sql_Connection();

        SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[user] Values(@regno,@name ,@Father_Name,@phone,@cnic,@joindate,@class_, @package, @paid,@chest,@hips,@weight)", sqlConnection);

        sqlCommand.Parameters.AddWithValue("@regno", regno);
        sqlCommand.Parameters.AddWithValue("@name", name);
        sqlCommand.Parameters.AddWithValue("@Father_Name", Father_Name);
        sqlCommand.Parameters.AddWithValue("@phone", phone);
        sqlCommand.Parameters.AddWithValue("@cnic", cnic);
        sqlCommand.Parameters.AddWithValue("@joindate", joindate);
        sqlCommand.Parameters.AddWithValue("@class_", class_);
        sqlCommand.Parameters.AddWithValue("@package", package);
        sqlCommand.Parameters.AddWithValue("@paid", paid);
        sqlCommand.Parameters.AddWithValue("@chest", chest);
        sqlCommand.Parameters.AddWithValue("@hips", hips);
        sqlCommand.Parameters.AddWithValue("@weight", weight);
        sqlConnection.Open();
        using (sqlConnection)
        {
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Member :" + name + " is added in the system");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This Reg No already Exists , Please Try another", "Reg No Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else throw;
            }
        }
    }
}
