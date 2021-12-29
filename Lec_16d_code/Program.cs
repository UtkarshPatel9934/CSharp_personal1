using System;

namespace Lec_16d_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            try{
                    double miles;
                    double gallons;
                    double mpg;
                    System.Console.WriteLine("Please enter miles\n");
                    miles = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Please enter the gallons\n");
                    gallons = double.Parse(Console.ReadLine());
                    if(gallons == 0)
                        throw new  System.InvalidOperationException("You can't divide by 0");
                    mpg = miles / gallons;
                    System.Console.WriteLine("The miles per gallon is: {0:N2} miles/gallon",mpg);
            }
            catch(Exception ex)
            {
                    System.Console.WriteLine("Please enter a number value next time\n{0}",ex.Message);
                    System.Console.WriteLine(ex.Message);
            }
            // finally // finally block is completely optional
            // {
            //     System.Console.WriteLine("Hope you enjoyed our program");
            // }
        }
    }
}
