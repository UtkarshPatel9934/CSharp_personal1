//Program Name: Hello World!
//Program Purpose: To simily output text to the screen via console
//Author: Utkarsh Patel
//Date modified: 2021-05-13
//single Line comment.
/*Multi Line Comments*/
using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // System.Console.WriteLine("I will Prints On a new Line");
            // System.Console.Write("Hi I Print IN same line.");
            // System.Console.Write("Hi Hello");

            // System.Console.WriteLine("\n");
            // string gName = "Patel"; //g_Name is Given Name
            // System.Console.WriteLine(gName);

            // string YName = "1"; //this is string not number : 1

            // int Num = 12;//Thi is actually a numeric value.
            // System.Console.WriteLine(Num);

            // int No;
            // No = 1234;
            // System.Console.WriteLine(No);

            // int myNum = 15;
            // myNum = 20;
            // System.Console.WriteLine(myNum);
            // System.Console.WriteLine("\n");
            // System.Console.WriteLine("Enter user name :");//Message to be print before taking the name.

            // create a string to store user input.
            // string u_name=Console.ReadLine();//read the user input using console.
            // System.Console.WriteLine("\n");
            // System.Console.WriteLine("user name is :" + " " + u_name);//Print the user name.

            
        //    System.Console.WriteLine("\n"); 
        //     System.Console.WriteLine("Enter the age :");//print the line simply.
        //     int age = Convert.ToInt32(Console.ReadLine());//ask the user for the age.
        //     System.Console.WriteLine("Your age is :"+ " " + age);//Print the age.

            

            //Using int.parse
            System.Console.WriteLine("Enter the Birthday year:");
            int year = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Year Of Your BirthDay is :" + " " + year);
        }
    }
}
