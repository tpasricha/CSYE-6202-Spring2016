using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class SalaryBasedCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;
           public double BaseSalary
        {
            get{ return baseSalary;}
            set { baseSalary=value;
                if (baseSalary < 0.0)
                {
                    throw new ArgumentException("Base salary cannot be less than zero.");
                }
            }
        }
           
        public SalaryBasedCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate, double baseSalary) : base(firstName,lastName,socialSecurityNumber,grossSales,commissionRate)
        {
            if(baseSalary<0.0)
            {
                throw new ArgumentException("Base salary cannot be less than zero.");   
            }
            this.baseSalary = baseSalary;
        }
        public override double calculateEarnings()
        {
            return baseSalary + base.calculateEarnings();
        }
        public override String ToString()
        {
            return String.Format("Base Salaried commission employee:{0}", "base salary: {1:C}",base.ToString(), baseSalary);
        }
    }
}
