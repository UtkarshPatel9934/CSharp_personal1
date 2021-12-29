//Program name: IfElse and switch statement
//Program Purpose: To evaluate the condition of if, ifElse, switch
//Program Author: Utkarsh Patel
//Date: 2021-05-27
using System;

namespace IfElse_and_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           //Syntax
            // if (condition)
            // {
                //block of code to be executed if the condition is True.
            // }

            if (100 > 99)
            {
                System.Console.WriteLine("yes 100 is greater than 99");
            }

            // Test two variables
            int x = 100, y = 99;
            if(x > y)
            {
                System.Console.WriteLine("X is greater than Y");
            }


            // use the else statement to specify the block of code to be executed if the condion becomes false
            //syntax
            // if(condition)
            // {
               //block of code to execute if the condition is true
            // }
            // else
            // {
              //block of code if condition becomes false
            // }

            int time = 17;
            if(time < 18)
            {
                System.Console.WriteLine("Good Afternoon!");
            }
            else
            {
                System.Console.WriteLine("Good Evening");
            }
            //output should be "Good Evening"

            //Use of if...elseif
            int time2 = 14;
            if(time2 < 10)
            {
                System.Console.WriteLine("Good Morning!");
            }
            else if (time2 < 20)
            {
                System.Console.WriteLine("Good Afternoon");
            }
            else
            {
                System.Console.WriteLine("Good Evening");
            }
            //output: Good Evening

            // Let's try it in "short-hand"
            int time3 = 20;
            string result = (time3 < 18) ? "Good Afternoon!" : "Good Evening";
            System.Console.WriteLine(result);

            // Now we're going to try another kind of evaluation "switch"
            // Create a weekday number ro calc a weekday name
            int day= 8;
           //if(day <= 7)
           //{
            switch(day)
            {
                case 1:
                     System.Console.WriteLine("Monday");
                     break;
                case 2:
                     System.Console.WriteLine("Tuesday");
                     break;
                case 3:
                     System.Console.WriteLine("Wednesday");
                     break;
                case 4:
                     System.Console.WriteLine("Thursday");
                     break;
                case 5:
                     System.Console.WriteLine("Friday");
                     break;
                case 6:
                     System.Console.WriteLine("Saturday");
                     break;
                case 7:
                     System.Console.WriteLine("Sunday");
                     break;
                default : System.Console.WriteLine("Not Weekday");
                break;
           // }
            }
        }
    }
}
