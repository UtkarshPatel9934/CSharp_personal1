//Program Name: iteration stataments
//Program Purpose: Try statements that repeatedly executes or block of ststement 
//Program author: Utkarsh Patel
//Date:
using System;

namespace Lec_9b_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //the for statement

            /* for (int i = 0; i < 9; i++)
            {
                System.Console.Write(i);
            } */
            //OutPut : 012


            /* //the foreach statement
            var fibNumbers = new List<int> { 0,1,1,2,3,5,8,13};
            foreach (int element in fibNumbers)
            {
                System.Console.Write($"{element}");
            }

            output
            0 1 1 2 3 5 8 13 */


            //the do statement executes a statement or a block of statement while a specified BOolean
            int n = 0;
            do 
            {
                System.Console.Write(n);
                n++;
            }
            while(n < 5);

            //output 
            //01234
            int x =0;
            while (x<5)
            {
                System.Console.WriteLine(x);
                x++;
            }


        }
    }
}
