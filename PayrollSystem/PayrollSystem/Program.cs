using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PayrollSystem
{
    public class Program
    {
        public enum EmployeeType
        {
            None,
            SalariedEmployee,
            HourlyEmployee,
            CommissionEmployee,
            SalaryBasedCommissionEmployee
        }

        public static void Main(string[] args)
        {
            // For salaried-employee
            string userFirstName = String.Empty;
            string userLastName = String.Empty;
            string userFullName = userFirstName + userLastName;
            string userSSN = String.Empty;
            string userEmployeeType = String.Empty;
                {
                Console.Write("Please input employee type: ");
                userEmployeeType = Console.ReadLine();
                Console.Write("Please enter your full name: ");
                String userEnteredFullName = Console.ReadLine();
                if (!userEnteredNameValid(userEnteredFullName))
                {
                    Console.WriteLine("Invalid Name!! Please try again later...");
                    Console.ReadKey();
                }
                else
                {
                    userFullName = userEnteredFullName;
                    Console.Write("Social security number: ");
                    String userEnteredSSN = Console.ReadLine();
                    if (!userEnteredSSNValid(userEnteredSSN))
                    {
                        Console.WriteLine("Invalid SSN!!");
                    }
                    else
                    {
                        userSSN = userEnteredSSN;
                        if (SelectedEmployeeTypeValid(userEmployeeType))
                        {

                            EmployeeType employeeType = EmployeeType.None;
                            switch (userEmployeeType)
                            {
                                case "Salaried employee":
                                    employeeType = EmployeeType.SalariedEmployee;
                                    Console.Write("weekly salary: $");
                                    Double userWeeklySalary = Double.Parse(Console.ReadLine());
                                    if (userWeeklySalary > 0)
                                    {
                                        SalariedEmployee se = new SalariedEmployee(userFirstName, userLastName, userSSN, userWeeklySalary);
                                        Console.Write("Earnings: $");
                                        Double userEarnings = se.calculateEarnings();
                                        Console.Write(userEarnings);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Salary not valid!!");
                                        Console.WriteLine("Please try again later!!");
                                        Console.ReadKey();
                                    }
                                    break;

                                case "Hourly employee":
                                    employeeType = EmployeeType.HourlyEmployee;
                                    Console.Write("Hourly wage: $");
                                    Double userHourlyWage = Double.Parse(Console.ReadLine());
                                    Console.Write("Hours worked: ");
                                    Double userHoursWorked = Double.Parse(Console.ReadLine());
                                    if (userHourlyWage > 0 && userHoursWorked > 0 && userHoursWorked < 168.0)
                                    {
                                        HourlyEmployee he = new HourlyEmployee(userFirstName, userLastName, userSSN, userHourlyWage, userHoursWorked);
                                        Console.Write("Earned: $");
                                        Double userEarnings = he.calculateEarnings();
                                        Console.Write(userEarnings);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wage or number of hours not valid");
                                        Console.WriteLine("Please try again later");
                                    }
                                    break;

                                case "Commission employee":
                                    employeeType = EmployeeType.CommissionEmployee;
                                    Console.Write("Gross sales: $");
                                    String selectedGrossSales = Console.ReadLine();
                                    double grossSales = SelectedDoubleValueValid(selectedGrossSales);
                                    if (grossSales < 0.0)
                                    {
                                        Console.Write("Gross sales can be less than zero.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.Write("Commission rate: ");
                                        String selectedCommissionRate = Console.ReadLine();
                                        double commissionRate = SelectedDoubleValueValid(selectedCommissionRate);
                                        if (commissionRate < 0.0)
                                        {
                                            Console.WriteLine("Commission rate cannot be less than zero.");
                                            Console.ReadLine();
                                        }
                                        else {
                                            CommissionEmployee ce = new CommissionEmployee(userFirstName, userLastName, userSSN, grossSales, commissionRate);
                                            Console.Write("Earned: $");
                                            Double userEarnings = ce.calculateEarnings();
                                            Console.WriteLine(userEarnings);
                                            Console.ReadLine();
                                        }
                                    }
                                    break;

                                case "Base salaried commission employee":
                                    employeeType = EmployeeType.SalaryBasedCommissionEmployee;
                                    Console.Write("Gross sales: $");
                                    String selectedGrossSalesSalaryBased = Console.ReadLine();
                                    double grossSalesSalaryBased = SelectedDoubleValueValid(selectedGrossSalesSalaryBased);
                                    if (grossSalesSalaryBased < 0.0)
                                    {
                                        Console.WriteLine("Gross sales cannot be less than zero.");
                                    }
                                    else {
                                        Console.Write("Commission rate: ");
                                        String selectedCommissionRate = Console.ReadLine();
                                        double commissionRate = SelectedDoubleValueValid(selectedCommissionRate);
                                        if (commissionRate < 0.0)
                                        {
                                            Console.WriteLine("Commission rate cannot be less than zero.");
                                            Console.ReadKey();
                                        }
                                        else {
                                            Console.Write("Base salary: $");
                                            Double baseSalary = Double.Parse(Console.ReadLine());
                                            if (baseSalary < 0.0)
                                            {
                                                Console.WriteLine("Base Salary cannot be zero.");
                                            }
                                            else {
                                                SalaryBasedCommissionEmployee sbce = new SalaryBasedCommissionEmployee(userFirstName, userLastName, userSSN, grossSalesSalaryBased, commissionRate, baseSalary);
                                                Console.Write("Earned: $");
                                                Double userEarnings = sbce.calculateEarnings();
                                                Console.Write(userEarnings);
                                                Console.ReadLine();
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("User type is invalid!! Please try the following types next time... ");
                            Console.WriteLine("Salaried employee");
                            Console.WriteLine("Hourly employee");
                            Console.WriteLine("Commission employee");
                            Console.WriteLine("Base salaried commission employee");
                            Console.ReadKey();
                        }
                    }
                }
                Console.WriteLine("Application Terminated!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
         }
        public static bool SelectedEmployeeTypeValid(string UserSelectedEmployeeType)
        {
            var result = false;


            if (UserSelectedEmployeeType.Equals("Salaried employee") || UserSelectedEmployeeType.Equals("Hourly employee") || UserSelectedEmployeeType.Equals("Commission employee") ||
               UserSelectedEmployeeType.Equals("Base salaried commission employee"))
            {
                result = true;
            }

            return result;
        }

            public static double SelectedDoubleValueValid(string SelectedDoubleValue)
        {
            double value;
            if (Double.TryParse(SelectedDoubleValue, out value))
            {

                return value;
            }
            else
                return -1;
           }

        public static bool userEnteredNameValid(string selectedName)
        {
            if (String.IsNullOrEmpty(selectedName))
                return false;

            string pattern = @"^[^ ][a-zA-Z ]+[^ ]+$";
            return Regex.IsMatch(selectedName, pattern);
        }

        public static bool userEnteredSSNValid(string socialSecurityNumber)
        {
            if (String.IsNullOrEmpty(socialSecurityNumber))
                return false;
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(socialSecurityNumber, pattern);
        }
    }
    }


    

