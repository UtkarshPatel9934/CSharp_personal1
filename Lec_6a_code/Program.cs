// Program name: Booleans
//Program Purpose: Booleans Example
// Author: Utkarsh Patel
// Date: 2021-05-27

using System;

namespace Lec_6a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            bool isCSharpFum = true;
            bool isFishTasty = false;
            System.Console.WriteLine(isCSharpFum); //output: Ture
            System.Console.WriteLine(isFishTasty); //output: False

            //Evaluate a logical condition
            int x = 10;
            int y = 9;
            System.Console.WriteLine(x > y); // output: True
            System.Console.WriteLine(10 > 9); // output: True

            //An example of using "equal to" operator
            int a = 10;
            System.Console.WriteLine(a == 10); //return True : value of x is 10

            // Let's evaluate the condition in only one line without declaring variable
            System.Console.WriteLine(10 == 15); //returns False
            
        }
    }
}
