using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageObjectsArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageObjectsArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company, int numOfWorkingDays, int empRatePerHr, int maxHoursPerMont)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, numOfWorkingDays, empRatePerHr, maxHoursPerMont);
            numOfCompany++;
        }

        public void CalculateEmpWage()
        {
            for (int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.CalculateEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int CalculateEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;
            Random random = new Random();
            while (totalWorkingDays < companyEmpWage.numOfWorkingDays && totalEmpHrs <= companyEmpWage.maxHoursPerMonth)
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
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

        
    
}
}
