using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;

        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value;
                if (grossSales <= 0.0)
                {
                    throw new ArgumentException("Gross sales cannot be less than zero and greater than one.");
                }
            }
        }
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
                if (commissionRate <= 0.0 || commissionRate >= 1.0)
                {
                    throw new ArgumentException("Commission rate cannot be less than zero and greater than one.");
                }
            }
        }

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate) : base(firstName, lastName, socialSecurityNumber)
        {
            
            if (commissionRate <= 0.0 || commissionRate>=1.0)
            {
                throw new ArgumentException("Commission rate cannot be less than zero and greater than one.");
            }
            if (grossSales <= 0.0)
            {
                throw new ArgumentException("Gross sales cannot be less than zero and greater than one.");
            }
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }
        public override double calculateEarnings()
        {
            return commissionRate * grossSales;
        }
        public override String ToString()
        {
            return String.Format("Commission employee:{0}\n{1} :{2:F2};{3:F2}", base.ToString(), "gross sales:",grossSales,"commission rate:", commissionRate);
        }
    }
}
