using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentRegistration
{
    public static class RandomGenerator
    {
        static Random random = new Random();
        public static string RandomStudentId()
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            int firstPart = random.Next(0, 1000);
            int secondPart = random.Next(0, 100);
            int thirdPart = random.Next(0, 10000);
            string studentId = firstPart.ToString("d3") + "-" + secondPart.ToString("d2") + "-" + thirdPart.ToString("d4");
            Match match = Regex.Match(studentId, pattern);
            while (match.Success)
            {
                match = match.NextMatch();
            }
            return studentId;
        }
        
        public static string randomFirstName()
        {
            string[] firstName = { "Tasleen", "Jessica", "Ray", "Rayhaan", "Ripin", "Amrit", "Bal", "Chinky", "Charu", "Sovin", "Avin", "Karan", "Gia", "Rima", "Noor" };
            int fn = random.Next(0, 15);
            return firstName[fn];
        }

        public static string randomLastName()
        {
           
            string[] lastName = { "Pasricha", "Joe", "Gardner", "Arora", "Joy", "Yanmaz", "Kumar", "Pulikonda", "Narkar", "Kothari", "Bhagat", "Kulkarni", "Chheda", "Verma", "Sharma" };
            int ln =  random.Next(lastName.Length);
            return lastName[ln];
        }
     
        public static string randomDepartment()
        {
            string[] departmentName = { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            int deptt = random.Next(departmentName.Length);
            return departmentName[deptt];
        }

        public static string enrollmentType()
        {
            string[] enrollmentType = { "Full Time", "Part Time" };
            int et = random.Next(enrollmentType.Length);
            return enrollmentType[et];
        }
    }

}
