using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;
        
        public SalariedEmployee(string firstName,string lastName, string socialSecurityNumber, double weeklySalary) : base(firstName,lastName,socialSecurityNumber)
        {
           
            if(weeklySalary<0.0)
            {
                throw new ArgumentException("Salary cannot be less than zero.");
            }
            this.weeklySalary = weeklySalary;
        }
        public double WeeklySalary
        {
            get { return weeklySalary;
               
            }
            set { weeklySalary = value;
                if (weeklySalary < 0.0)
                {
                    throw new ArgumentException("Weekly salary cannot be less than zero.");
                }
            }
        }
        
        public override String ToString()
        {
            return String.Format("Salaried employee: {0}\n{1}:{2,C}", base.ToString(), "weekly salary:", weeklySalary);
        }

        public override double calculateEarnings()
        {
            return weeklySalary;
        }
    }

}
