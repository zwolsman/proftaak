using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSysteem
{
    class MediaAccount
    {
        public int ID { get; set; } = -1;

        private string _username = "";

        public string Username
        {
            get
            {
                if (_username == "")
                    return _username;
                return _username.ToUpper()[0] + _username.ToLower().Substring(1);
            }
            set { _username = value; }
        }

        public string Password { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; } = string.Empty;
    }
}
