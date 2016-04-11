using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationWPFApp
{
    class Admin
    {
        public string userName { get; set; }
        public string passWord { get; set; }

        public Admin(string username, string password)
        {
            userName = username;
            passWord = password;
        }
    }
}
