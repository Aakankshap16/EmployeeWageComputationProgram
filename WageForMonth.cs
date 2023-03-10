using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    internal class WageForMonth
    {
        public static void  EmployeeAttendence()
        {
            int is_Full_Time = 1;
            int is_Part_Time = 2;
            int empSalPerhr = 20;
            int empWage = 0;
            int empHrs = 0;
            int empWagePerMonth =0;
            int workingday = 20;

            for (int day = 0; day<= workingday; day++)
            {

                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {

                    case 1:

                        {
                            Console.WriteLine("Employee is Doing Full Time:");
                            empHrs = 8;
                            break;
                        }

                    case 2:

                        {
                            Console.WriteLine("Employee is Doing Part Time:");
                            empHrs = 4;
                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Employee is Absent:");
                            empHrs = 0;
                            break;
                        }
                }
                empWage = empHrs * empSalPerhr;
                empWagePerMonth = empWagePerMonth+empWage;
                Console.WriteLine("wages of employee per day is :" + empWage);

            }
            Console.WriteLine("wages of employee per month is " + empWagePerMonth);

        }
    
    } 
}
