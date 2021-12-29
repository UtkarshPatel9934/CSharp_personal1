using System;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Payroll statement Program!"); //added the initial: a welcome message.
            //get input from user
            //add inputs for name , hours worked , wage rate, total deduction
            System.Console.Write("Enter the employee's family name: ");
            string famName = Console.ReadLine();
            System.Console.Write("Enter the employee's given name: ");
            string givName = Console.ReadLine();
            System.Console.Write("Enters the numbers of hours worked: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());//explicit convert to integer: int
            System.Console.Write("Enter the wage rate: ");
            decimal wageRate = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("Enter the total deductions for this employee: ");
            decimal totDeduct = Convert.ToDecimal(Console.ReadLine());


            //calculate the gross net pay
            decimal grossPay = hoursWorked * wageRate;
            decimal neetPay = grossPay - totDeduct;

            // Display payroll information
            System.Console.Write("Payroll statement for" + givName + " " + famName);
            System.Console.WriteLine("Hours worked: " + hoursWorked);
            System.Console.WriteLine("Wage rate: $" + wageRate);
            System.Console.WriteLine("Gross pay: $" + grossPay);
            System.Console.WriteLine("Total deductions: $" + totDeduct);
            System.Console.WriteLine("Net pay: $" + neetPay);

            // closs the program
            System.Console.WriteLine("Thank you for using the program");

        }
    }
}
