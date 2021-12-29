using System;

namespace Self_C__Methods_and_Functions
{
    class Program
    {
        // Method

        // Method syntax
        /* <Access Specifier> <Return Type> <Method Name> (Parameters)
        {

            Method Body

        } */

         /* A method can be invoked in a class by creating an object 
         of the class where the object name is followed by a period (.) 
         and the name of the method followed by parentheses */


        // NOTE: we always have to declare the methods in the "Class"

        // Note: we use public because we can use the method in other program as well.

        // Show() is called "METHOD SIGNATURE"
        // What Inside Of Method Signature:
        // 1. Method Name
        // 2. Parenthesis ()
        // 3. Inside parenthesis we also made some variables called "PARAMETER"
        // Note: If we don't make the parameter ie. Variables inside the parenthesis the the method is called as "NON-PARAMETERIZED METHOD"
        // If we declare variable the it is called to be "Parameterized method"

        public void Show() // calling method // Declaring a method // "Non-Static" or "Instance Method"
         // Because we don't use "static" keyword.
         // Note: If we make the non-static method we compulsory have to create the "OBJECT" inside the main method and then we have to call it with the "Object Name"

         {
             //group of statement
             System.Console.WriteLine("Welcome to c sharp Programming");
             System.Console.WriteLine("Hey Bro Whatsapp!!");
         }

         // Static is Keyword.
         public static void Show1() // Static method. // calling method
         {
                System.Console.WriteLine("Welcome to c sharp Programming");
                System.Console.WriteLine("Hey Bro Whatsapp!!");
         }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // FOR SHOW1 METHOD ie.static method
            Program.Show1(); // called method  
            // NOTE: we don't have to create the object in the static method.


            // FOR SHOW METHOD ie. non-static method or instance method
            // NOTE: we always have to call the methods in the Main methods.
            // Calling a method
            // NOTE: we have to make the object for calling the method.
            // Object syntax:
        // Class_name  DecObject_name     new_KeywordforAllocateMemory    Constructor
            Program      p1              =      new                       Program(); 

            //NOTE: the method Show is stored into p1 variable.

            p1.Show(); // called method

            // We can reuse the method as the following:
            // p1.Show();
            // p1.Show();
            // ie. when we use the method we don't have to write many times to print it.

        }
    }
}
