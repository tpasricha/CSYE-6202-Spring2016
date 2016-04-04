using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Student
    {
        public string studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string departmentName { get; set; }
        public string enrollmentType { get; set; }

        public Student(string studentid, string firstname, string lastname, string departmentname, string enrollmenttype)
        {
            studentId = studentid;
            firstName = firstname;
            lastName = lastname;
            departmentName = departmentname;
            enrollmentType = enrollmenttype;    
        }
    }
}
