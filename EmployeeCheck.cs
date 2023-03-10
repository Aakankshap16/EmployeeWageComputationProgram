using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    internal class EmployeeCheck
    {
        public static void EmployeeAttendence()
        {
            int is_Full_Time = 1;
            int empSal = 20;
            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empSal;
            Console.WriteLine("wages of employee is :" + empWage);
        }
    }
}
