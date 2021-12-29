using System;

namespace Return_Type
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




        // Creating a return type Method

        // we use return statement in method.
        public static int plus (int num1, int num2) // calling method
        {
           int  result = num1 + num2;
           return result;
        }

        public void add() // calling method // non-static method
        {
            System.Console.WriteLine("HELLO WORLD!!");
        }

        static void Main(string[] args)
        {

            Program.plus(10,30); // called method
            // NOTE: IF WE ONLY USE "Program.plus(10,30);" WE CAN'T GET THE VALUE IN OUTPUT.
            // because the plus Method will return results but we can't use method that prints results.

            // we have to do the following
            System.Console.WriteLine(Program.plus(10,30)); // called method

            // Console.WriteLine("Hello World!");


            // we use return because we don't have to print it, we have to store it in other variable
            // for example
            int a = Program.plus(20,30); // called method
            int b = 20;
            int c = a + b;
            System.Console.WriteLine(c);



            // FOR ADD METHOD ie. non-static method 
            Program p = new Program(); // called method
            p.add();

        }
    }
}
