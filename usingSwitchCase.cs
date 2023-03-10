using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    internal class usingSwitchCase
    {
        public static int EmployeeAttendence(int empSalperhr)
        {
            int is_Full_Time = 1;
            int is_Part_Time = 2;

            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {

                case 1:

                    {
                        empHrs = 8;
                        break;
                    }

                case 2:

                    {
                        empHrs = 4;
                        break;
                    }

                default:

                    {
                        empHrs = 0;
                        break;
                    }
            }
            empWage = empHrs * empSalperhr;
            return empWage;
        }
    }
}
