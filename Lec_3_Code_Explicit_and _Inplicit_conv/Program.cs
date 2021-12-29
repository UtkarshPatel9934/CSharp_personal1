using System; //use the classes in the system library
//blankspace for readability
namespace C__COURSE_PRACTICAL_WORK //used to organize...is a container for classes/namespaces
{
    class Program //a class is a container for data and methods
    {
        static void Main(string[] args) //always have a Main method
        {
/*             // Console.WriteLine("Hello World!");
            string name = "Utkarsh";
            System.Console.WriteLine(name);

            int myNum = 10;
            myNum = 20; //myNum is now 20 when it runs
            System.Console.WriteLine(myNum);

            declare different data type
            int newNumber = 5; //this number is of type integer (whole number)
        
            double newDoubleNum= 5.990d; //store a fractional numbers to 15 decimal digits (note D)

            char newLetter = 'A'; //type character - stores single character 

            bool newBool = true; //type Boolean

            string myText = "Hello ";  //type string

            System.Console.WriteLine(newNumber);
            System.Console.WriteLine(newDoubleNum);
            System.Console.WriteLine(newLetter);
            System.Console.WriteLine(newBool);
            System.Console.WriteLine(myText);

            scientific numbers
            float f1 = 35e3f;

            double d1= 12e4d;

            System.Console.WriteLine(f1);
            System.Console.WriteLine(d1); */

            //c# type casting
            //Implicit Casting - automatic 
            //Explicit Casting - manually

            //Implicit casting ex.


            int myInt = 10;
            double myDouble = myInt; //automatic Casting : int to double.

            System.Console.WriteLine(myInt); //output 10 as an int
            System.Console.WriteLine(myDouble); //output 10 as double

            //Explicit Casting
            double newDouble= 9.87d;
            int newInt = (int) newDouble; //manual casting : double to int
            System.Console.WriteLine(newDouble); //output 9.78 
            System.Console.WriteLine(newInt); //output 9

            //type conversion Methods
            int num= 10;
            double dbl =5.25;
            bool nBool = true;
            System.Console.WriteLine(Convert.ToString(num));//convert int to string
            System.Console.WriteLine(Convert.ToDouble(num));//int to double
            System.Console.WriteLine(Convert.ToInt32(dbl)); //convert double to int
            System.Console.WriteLine(Convert.ToString(nBool)); //bool to string

            
            System.Console.WriteLine("............................");

            int a = 100;
            System.Console.WriteLine(Convert.ToString(a));
            
            
            

        }
    }
}
