using System;

namespace Lec_7b_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            ExploreIf(); //calling a method outside from the Main.
        }
        static void ExploreIf()
        {
            // Console.WriteLine("Hello World!");
            // Try some easy complex conditions
            int a = 5, b = 3;
            int c = 4; // declare variable
            if ((a + b + c > 10) && (a != b) )
            {
                System.Console.WriteLine("The answer is greater than 10");
                System.Console.WriteLine("The first number is equal to second number");
            }
            else
            {
                System.Console.WriteLine("The answer is greater than 10");
                System.Console.WriteLine("the first number is not equal to the second");
            }

            if ((a+b+c > 10) || (a == b))
            {
                System.Console.WriteLine("The answer is greater than 10");
                System.Console.WriteLine("or the first number is equal to second number");

            }
            else{
                System.Console.WriteLine("The answer is not greater than 10");
                System.Console.WriteLine("and the first is equal to the second number");
            }

       }
    }
}
