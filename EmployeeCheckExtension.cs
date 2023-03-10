using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    internal class EmployeeCheckExtension
    {
        public static int EmployeeAttendence(int empSalPerhr)
        {
            int is_Full_Time = 1;
            int is_Part_Time = 2;

            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            if (empCheck == is_Full_Time)
            {
                empHrs = 8;
            }
            else if (empCheck == is_Part_Time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empSalPerhr;
            return empWage;

        }
    }
}
