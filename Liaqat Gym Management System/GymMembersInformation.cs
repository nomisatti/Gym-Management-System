using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liaqat_Gym_Management_System
{
    public static class Packages
    {
        public static List<string> pkg = new List<string>();

    }

    public class PackagesInformation
    {
        private int id;
        private string name;
        private int? price;
        private DateTime? startdate = null;
        private DateTime? enddate = null;
        private int? payfor = null;
        private int? freemonths = null;
        private bool isdefault;
        private int months;


        public int Months
        {
            get { return months; }
            set { months = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public DateTime? StartDate
        {
            get { return startdate; }

            set { startdate = value; }
        }

        public DateTime? EndDate
        {
            get { return enddate; }

            set { enddate = value; }
        }

        public int? FreeMonths
        {
            get { return freemonths; }

            set { freemonths = value; }
        }

        public int? PayFor
        {
            get { return payfor; }

            set { payfor = value; }
        }
        public int? Price
        {
            get { return price; }

            set { price = value; }
        }

        public bool IsDefault
        {
            get { return isdefault; }

            set { isdefault = value; }
        }
    }


    public class GymMembersInformation
    {

        private int id;
        private string regno;
        private string name;
        private string fathername;
        private string phoneno;
        private string cnic;
        private DateTime dateTime;
        private string class_;
        private string package;
        private bool paid;
        private float? chest;
        private float? hips;
        private float? weight;

        private int fee;
        private int remaning;
        private DateTime feedate;
        private DateTime expiredate;
        private string recieptno;
        private int months;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Months
        {
            get { return months; }
            set { months = value; }
        }
        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public int Remaning
        {
            get { return remaning; }
            set { remaning = value; }
        }

        public DateTime FeeDate
        {
            get { return feedate; }
            set { feedate = value; }
        }

        public DateTime ExpireDate
        {
            get { return expiredate; }
            set { expiredate = value; }
        }

        public string RecipetNo
        {
            get { return recieptno; }
            set { recieptno = value; }
        }

        public string RegNO
        {
            get { return regno; }
            set { regno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Father_Name
        {
            get { return fathername; }
            set { fathername = value; }

        }
        public string Phone
        {

            get { return phoneno; }
            set { phoneno = value; }
        }
        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }

        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }
        public string CLASS_
        {
            get { return class_; }
            set { class_ = value; }

        }
        public string Package
        {
            get { return package; }
            set { package = value; }

        }
        public bool Paid
        {
            get { return paid; }
            set { paid = value; }

        }
        public float? CHEST
        {
            get { return chest; }
            set { chest = value; }

        }
        public float? HIPS
        {
            get { return hips; }
            set { hips = value; }

        }
        public float? WEIGHT
        {
            get { return weight; }
            set { weight = value; }

        }
    }

}

