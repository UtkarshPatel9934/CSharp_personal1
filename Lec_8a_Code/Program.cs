//Program name: Branches and loops 2
//Program Purpose: Practical exercises for complex conditions
//Program Author: Utkarsh patel
//Date Created: 2021-06-03
using System;

namespace Lec_8a_Code
{
    class Program
    {
        static void Main(string [ ] args)
        {
            // Console.WriteLine("Hello World!");
            // int counter = 0; // start the counter at 0
           /*  while (counter < 10) // Here's is our while loop
            {
                System.Console.WriteLine($"Hello World! the counter is {counter}");
                System.Console.WriteLine("Hello World! the counter is: " + counter);
                counter++; // the increment operator (++) will add to the value of the counter or "Counter = counter + 1"
            } */

            /* do // Here's i sour do/While Loop
            {
                System.Console.WriteLine("Hello World! the counter is: " + counter);
                counter = counter + 1;
                counter ++;
            }
            while (counter < 10); */

            //Let's use the "for" loop to do the same think as the while & do while
            // for (int index = 0; index < 10 ; index ++)
            // {
            //     System.Console.WriteLine("Hello World! the index is: " + index);
            // }

            // for (int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            // for (int x = 2; x <=20; x = x + 2) //Print the table of 2
            // {
            //     System.Console.WriteLine(x);
            // }


            //C# Foreach loop
            // string[] weather = {"Sun", "Rain", "Cloud", "Snow", "Fog"};

            // foreach (string i in weather)
            // {
                // System.Console.WriteLine(i);
                // System.Console.WriteLine("\n" + i);
            // }

            // string[] Cars = {"Toyota", "BMW", "Kia", "MG", "Ford"};
            // foreach (string i in Cars)
            // {
            //     System.Console.WriteLine(i);
            // }

            //C# Break and Continue
            // for (int i  = 0; i < 10; i++)
            // {
            //     if(i==4)
            //     {
            //         break;
            //     }
            //     System.Console.WriteLine(i);
            // }

            // for (int i  = 0; i < 10; i++)
            // {
            //     if(i==4)
            //     {
            //         continue;
            //     }
            //     System.Console.WriteLine(i);
            // }

            //C# Break and Continue with a while loop
            int x = 0;
            while (x < 10)
            {
                if (x==4)
                {
                    break;
                }
                System.Console.WriteLine(x);
                x++;
            }

            int y = 0;
            while (y<10)
            {
                if(y==4)
                {
                    y++;
                    continue;
                }
                System.Console.WriteLine(y);
                y++;
            }

        }
    }
}
