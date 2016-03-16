using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public virtual string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber=value; }
        }

        public Employee(string firstName, string lastName, string ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = ssn;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}\nsocial security number: {2}" ,firstName, lastName, socialSecurityNumber);
        }
        public abstract double calculateEarnings();

        }
}
