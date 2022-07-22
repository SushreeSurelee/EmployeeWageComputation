using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine(empCheck);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }

            Console.ReadLine();
        }
    }
}
