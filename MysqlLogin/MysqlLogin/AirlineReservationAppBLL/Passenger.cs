using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlLogin.AirlineReservationAppDAL
{
    public class Passenger
    {      
        public string name { get; set; }
        public string emailId { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int phoneNumber { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

        string userInputName = String.Empty;
        string userEmail = String.Empty;
        string userGender = String.Empty;
        string userAge = String.Empty;
        string userPhoneNumber = String.Empty;
        string userEnteredUserName = String.Empty;
        string userPassword = String.Empty;
        string userConfirmPassword = String.Empty;

        }  

}
    

