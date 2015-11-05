using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveer_Systeem
{
    public class Account
    {
        private string _rawPassword = "";
        public int ID { get; set; }
        public string Username { get; set; }

        public string Password
        {
            get { return DatabaseLibrary.Helper.MD5(_rawPassword); }
            set { _rawPassword = value; }
        }

        public string Address { get; set; }

        public string Zipcode { get; set; }

        public string Country
        {
            get { return "Netherlands"; }
        }

        public string Phonenumber { get; set; }
        public string Bankaccount { get; set; }
    }
}
