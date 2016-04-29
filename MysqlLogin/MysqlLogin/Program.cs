using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlLogin
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main(String[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string userInputName = String.Empty;
            string userEmail = String.Empty;
            string userGender = String.Empty;
            string userAge = String.Empty;
            string userPhoneNumber = String.Empty;
            string userName = String.Empty;
            string userPassword = String.Empty;
            string userConfirmPassword = String.Empty;
            {
                Console.Write("Please input userName: ");
                userName = Console.ReadLine();
                Console.Write("Please enter your name: ");
                String userEnteredFullName = Console.ReadLine();
                if (!userEnteredNameValid(userEnteredFullName))
                {
                    MessageBox.Show("Please enter full name");

                }
            }
        }

        public static bool userEnteredNameValid(string selectedName)
        {
            if (String.IsNullOrEmpty(selectedName))
                return false;

            string pattern = @"^[^ ][a-zA-Z ]+[^ ]+$";
            return Regex.IsMatch(selectedName, pattern);
        }

    }

}
