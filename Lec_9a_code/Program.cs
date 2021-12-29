//Program name: Selections statement
//Program Purpose:More example of selection statements
//Program author: Utkarsh Patel
//Date Created: 2021-068


using System;

namespace Lec_9a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //if-else -identifies which statement to runbased on the values of a Boolean expression
            /* bool condition = true;
            if (condition)
            {
                System.Console.WriteLine("the variable is set to true");
            }
            else{
                System.Console.WriteLine("the variable is set to be false");
            } */

            //another if-else statement
            // if (condition)
            // {
            //     then-statement;
            // }
            // else
            // {

            // }


            //try with m = 12 and then change m = 8
            

            /* if (m > 10)
            {
                if (n > 20)
                {
                    System.Console.WriteLine("REsult 1");
                }
                else
                {
                System.Console.WriteLine("Result 2");
                }
            } */

            /* int m = 8, n = 18;
            if (m > 10)
            {
                if (n > 20)
                    System.Console.WriteLine("Result 1");
            }
            else
            {
                System.Console.WriteLine("Result 2");
            } */

            // use nested-if statement to determine whether the input character is an alphabetic character
            /* System.Console.WriteLine("Enter the character");
            char c = (char)Console.Read();

            if(char.IsLetter(c))
            {
                if(char.IsLower(c))
                {
                    System.Console.WriteLine("The character is Lowercase");
                }
                else{
                    System.Console.WriteLine("The character is Uppercase");
                }
            }
            else{
                System.Console.WriteLine("The character isn't character");
            } */

            //Sample Output
            //Enter a character: 2 > Msg "The character isn't Alpha"
            //Enter a character: A > Msg "The character is Upper"
            //Enter a character: h > Msg "The character is Lowercase"

            // Use a Logical operator to make compound conditions 
            
            //NOT
            bool result = true;

            if(!result)
            {
                System.Console.WriteLine("The condition is true (result is false)");
            }
            else{
                System.Console.WriteLine("The condition is true (result is true)");
            }

            //Short-Circuit AND
            int m = 9;
            int n = 7;
            int p = 5;

            if(m>= n && m>= p)
            {
                System.Console.WriteLine("Nothing is larger than m");
            }

            //AND and NOT
            if (m>= n && !(p > m))
            {
                System.Console.WriteLine("Nothing is larger than m");
            }

            //Short-circuit OR
            if (m > n || m > p)
            {
                System.Console.WriteLine("M isn't the smallest");
            }

            //NOT and OR
            m = 4;

            if (!(m >= n || m >= p ))
            {
                System.Console.WriteLine("Now m is smallest");
            }

            //Output
            /* The condition is true (result is true)
            Nothing is larger than m
            Nothing is larger than m
            M isn't the smallest
            Now m is smallest */
            

           /* System.Console.WriteLine("Enter the character");
            char c = (char)Console.Read();

            if(c >= 65 && c<=90 || c >= 97 && c <= 122 )
            {
                if(c >= 97 && c <=122)
                {
                    System.Console.WriteLine("The character is Lowercase");
                }
                else{
                    System.Console.WriteLine("The character is Uppercase");
                }
            }
            else{
                System.Console.WriteLine("The character isn't character");
            } */
        }
    }
}
