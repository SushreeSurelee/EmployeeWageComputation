using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int CalculateEmpWage(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMonth)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;
            Random random = new Random();
            while (totalWorkingDays < numOfWorkingDays && totalEmpHrs <= maxHoursPerMonth)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day number = " + totalWorkingDays + " Working hours = " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Employee Wage for " +company+ " is " +totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            CalculateEmpWage("TCS",25,18,80);
            CalculateEmpWage("Wipro", 20, 25, 90);
            Console.ReadLine();   
        }
    }
}
