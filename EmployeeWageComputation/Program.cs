using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{

    class EmpWageObjects
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int numOfWorkingDays;
        private int empRatePerHr;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageObjects(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMonth)
        {
            this.company = company;
            this.numOfWorkingDays = numOfWorkingDays;
            this.empRatePerHr = empRatePerHr;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void CalculateEmpWage()
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;
            Random random = new Random();
            while (totalWorkingDays < this.numOfWorkingDays && totalEmpHrs <= this.maxHoursPerMonth)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total Employee Wage for " + company + " is " + totalEmpWage);
        }

        public string ToString()
        {
            return ("Total wage for " + this.company + " is " + this.totalEmpWage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            EmpWageObjects TCS = new EmpWageObjects("TCS", 25, 18, 80);
            TCS.CalculateEmpWage();
            Console.WriteLine(TCS.ToString());

            EmpWageObjects Wipro = new EmpWageObjects("Wipro", 20, 25, 90);
            Wipro.CalculateEmpWage();
            Console.WriteLine(Wipro.ToString());

            Console.ReadLine();
        }
    }
}
