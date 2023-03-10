namespace Employee_Wage_Computation_Problem 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the employee wage computation problem!");
           // EmployeeCheck.EmployeeAttendence();
            int empSalPerhr = 20;
            //int empWageValue = EmployeeCheckExtension.EmployeeAttendence(empSalPerhr);
            int empWageValue = usingSwitchCase.EmployeeAttendence(empSalPerhr);
            Console.WriteLine("wages of employee is :" + empWageValue);
        }
    }

}