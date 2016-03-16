using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class HourlyEmployee : Employee 
    {
        private double hourlyWage;
        private double hoursWorked { get; set; }
        public double HourlyWage
        {
            get
            {
                return hourlyWage;
            }
            set
            {
                hourlyWage = value;
                if(hourlyWage<0.0)
                {
                    throw new ArgumentException("Too less wage. It should be greater than zero.");
                }
            }
        }
        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
                if(HoursWorked<0.0 || hoursWorked>168.0)
                {
                    throw new ArgumentException("Hours worked should be between 0 and 168.");
                }
            }
        }
        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double hourlyWage, double hoursWorked) : base(firstName, lastName, socialSecurityNumber)
        {
           
            if(hourlyWage<0.0)
            {
                throw new ArgumentException("Wage cannot be less than zero.");
            }
            if(hoursWorked<0.0 || hourlyWage>168.0)
            {
                throw new ArgumentException("Hours worked cannot be less than zero or more than 168 ");

            }
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }
        public override double calculateEarnings()
        {
            if (hoursWorked <= 40)
                return hourlyWage * hoursWorked;
            else
                return 40 * hourlyWage + (hoursWorked - 40) * hourlyWage * 1.5;
        }
        public override String ToString()
        {
            return String.Format("Hourly employee:{0}\n{1}:{2:C};{3}:{4:F2}", base.ToString(), "hourly wage:", hourlyWage, "hours worked:" , hoursWorked);
        }
    }
}
