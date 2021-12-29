//Program name: c# operators
//Program Purpose: use operators to performs operations on variable and values
//Program author: Utkarsh Patel
//Date Created: 2021-05-25
using System;

namespace Lec_5_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //use the + operator to add two values together.
            int x = 100 + 50;
            System.Console.WriteLine(x); //the output should equal 150


            // + operator can also be used to add together a variable and a value 
            // or a variable and another variable
            int sum1= 100 + 50;
            int sum2 = sum1 + 250; // 400(150+250)
            int sum3= sum2 +sum1; //

            System.Console.WriteLine(sum1);
            System.Console.WriteLine(sum2);
            System.Console.WriteLine(sum3);

            //use the assignment operator = to assign a value 10 to variable called y
            int y= 10;
            System.Console.WriteLine(y);

            //multiply operator (+=) to add value
            int z = 10;
            z += 5;
            System.Console.WriteLine(z);

            //multiply operator (-=) to substract value
            int foo = 10; 
            foo -= 5;
            System.Console.WriteLine(foo);


            //multiply operator (*=) to multiple value
            int mul = 10;
            mul *= 10;
            System.Console.WriteLine(mul);

            // the div operator (/=) to divide value
            int div = 100;
            div /= 10;
            System.Console.WriteLine(div);

            // c# comparision operators
            int a = 5;
            int b = 3;
            System.Console.WriteLine(a == b); //compare the values and bec a and b are not equal it returns "false"
            System.Console.WriteLine(a != b); //compare the values and they are not equal and it will returns "true"
            System.Console.WriteLine(a > b); //compare and will return "true" 
            System.Console.WriteLine(a < b); //compare and results "false"
            System.Console.WriteLine(a >= b); //compare and returns "true"
            System.Console.WriteLine(a <= b); //compare and returns "false"

            // C# logical operators
            int c = 5;
            System.Console.WriteLine(c > 3 &&  c < 10); // return true bec 5 is greater than 3 and less than 10
            System.Console.WriteLine(c > 3 || c < 4);//returns true bec one condition is true (5 > 3) but (5 < 4)
            System.Console.WriteLine(!(c > 3 && c < 10)); //returns false bec !(not is used to reverse the condition)


            //C# Math
            // the c# math class has many methods that you to perform mathematical tasks  on numbers
            System.Console.WriteLine(Math.Max(5,10));//find highest value
            System.Console.WriteLine(Math.Min(5,10));//find lowest value
            System.Console.WriteLine(Math.Sqrt(16));//find square root
            System.Console.WriteLine(Math.Abs(-4.7));//find absolute
            System.Console.WriteLine(Math.Round(49.999998));//round to nearest whole number
            System.Console.WriteLine(Math.Truncate(173279.239));
        }
    }
}
