using System;

namespace Parameterized_Method
{
    class Program
    {


        // Method syntax
        /* <Access Specifier> <Return Type> <Method Name> (Parameters)
        {

            Method Body

        } */

         /* A method can be invoked in a class by creating an object 
         of the class where the object name is followed by a period (.) 
         and the name of the method followed by parentheses */



        // Parameterized Method

        // we can use any data-type in parameter.
        public static void Add(int num1, int num2) // calling method
        {
            //local variable is a variable declared inside the scope ie. {} and used within it only.
            int result = num1 + num2;
            System.Console.WriteLine("Addition result is: {0}", result);
        }

        public static void ShowName(string name) // calling method
        {
            System.Console.WriteLine("Your Name Is: {0}",name);
        }

        // NOTE: if we want to set a default value in the method's parameter.
        public static void ShowName1(string name = "UNKNOWN") // calling method
        {
            System.Console.WriteLine("Your Name Is: {0}",name);
        }

        public static void Show_Name_Age(string name, int Age) // calling method
        {
            System.Console.WriteLine("Your name is: " + name);
            System.Console.WriteLine("Your age is: " + Age);
        }
        public static void Main(string[] args) 
        {
            // Console.WriteLine("Hello World!");
            // FOR SHOWNAME METHOD
            Program.ShowName("Utkarsh");// called method
            Program.ShowName("Zeel"); // called method


            

            // FOR SHOWNAME1 METHOD
            Program.ShowName1(); // called method



            // FOR ADD METHOD
            // In parameterized Method we have to give the value of each variables ie. Parameter at the time of calling it.
            // We have to give the value of parameter seprated by comma ","
            // In this case the 10 is save to num1 and 20 is save to num2

            // NOTE: when we provide the values to the parameter then its called "ARGUMENT"
            Program.Add(10, 20); // arguments // called method
            Program.Add(30, 40); // arguments // called method
            Program.Add(50, 60); // arguments  // called method

            // If we want to take the input from user by using the following:
            System.Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Program.Add(a,b); // called method



            // FOR SHOW_NAME_AGE METHOD
            Program.Show_Name_Age("Adil", 27); // called method

            // If we want to change the order of giving the value
            // NOTE: WE USE NAMED ARGUMENT.
            // for example
            Program.Show_Name_Age(Age:19, name:"Utkarsh"); // named argument // called method

        }
    }
}
