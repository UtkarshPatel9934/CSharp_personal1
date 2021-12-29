// Program name: Payroll Statement
// Program purpose: Create payroll statement from pay data 
// Program author: Andrew Steele
// Date last modified: 2021-05-20
using System;

namespace PrintPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Payroll Statement Program!"); // added the initial welcome message
            // Get input from the user
            // add inputs for name, hours worked, wage rate, total deductions
            Console.Write("Enter the employee's family name: ");
            string famName = Console.ReadLine();
            Console.Write("Enter the employee's given name: ");
            string givName = Console.ReadLine();
            Console.Write("Enter the number of hours worked: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine()); // explicit convert to integer
            Console.Write("Enter the wage rate: ");
            decimal wageRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the total deductions for this employee: ");
            decimal totDeduct = Convert.ToDecimal(Console.ReadLine());

            // Calculate gross and net pay
            decimal grossPay = hoursWorked * wageRate;
            decimal netPay = grossPay - totDeduct;

            // Display payroll information
            Console.WriteLine("Payroll statement for " + givName + " " + famName);
            Console.WriteLine("Hours worked: " + hoursWorked);
            Console.WriteLine("Wage rate: $" + wageRate); // unicode for rupee U20A3?
            Console.WriteLine("Gross pay: $" + grossPay);
            Console.WriteLine("Total deductions: $" + totDeduct);
            Console.WriteLine("Net pay: $" + netPay);

            // Close the program
            Console.WriteLine("Thank you for using this program!");
        }
    }
}
