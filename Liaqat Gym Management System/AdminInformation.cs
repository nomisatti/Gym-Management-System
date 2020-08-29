using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liaqat_Gym_Management_System
{
    public class AdminInformation
    {
        private string password;
        private string passwordOf;
        private byte[] logo;

        public string PassowrdOf
        {
            get { return passwordOf; }
            set { passwordOf = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }
    }
}
