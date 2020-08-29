using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liaqat_Gym_Management_System
{
    public static class ClubList
    {
        public static List<ClubNames> Clubs = new List<ClubNames>();

    }

    public class ClubCertificates
    {
        public int Id { get; set; }
        public string Rank { get; set; }
        public DateTime IsseDate { get; set; }
        public string Amount { get; set; }
        public int Clubid { get; set; }
        public long SerialNumber { get; set; }
       public string ClubName { get; set; }
    }

    public class ClubNames
    {
        public int id { get; set; }
        public string name { get; set; }


    }
    public class ClubMembersInformation
    {
        private int id;
        private string name;
        private string rank;
        private DateTime joindate;
        private int club;
        private byte[] picture; 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public byte[] Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public DateTime JoinDate
        {
            get { return joindate; }
            set { joindate = value; }
        }

        public int Club
        {
            get { return club; }
            set { club = value; }
        }
    }
}
