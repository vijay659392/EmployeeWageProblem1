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
         int IS_FULL_TIME = 1;
         int IS_PART_TIME = 2;
         int EMP_RATE_PER_HOUR = 20;

         int empHrs = 0;
         int empWage = 0;

         Random random = new Random();
         int empCheck = random.Next(3);

         if(empCheck== IS_FULL_TIME)
         {
             Console.WriteLine("Employee is Present");
             empHrs = 8;
         }
         else if(empCheck==IS_FULL_TIME)
         {
             Console.WriteLine("Employee is Part time");
             empHrs = 4;
         }
         else
         {
             Console.WriteLine("Employee is Absent");
             empHrs = 0; 
         }
         empWage = empHrs * EMP_RATE_PER_HOUR;
       }     
        Console.WriteLine("Emp Wage: " + empWage);
    }
}
