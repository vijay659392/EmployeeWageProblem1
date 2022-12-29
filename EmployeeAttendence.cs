using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{

    public class EmployeeAttendence
    {

        public static void CheckAttendance()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 3;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {

                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case 0:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;

                //totalEmpWage = totalEmpWage + empWage;

                console.WriteLine("The Employee Wage " + empWage);
            }
            Console.WriteLine("Total Employee Wage " + totalempWage);
        }
    }
}
