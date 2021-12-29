using System; //use the classes in the system library
//blankspace for readability
namespace C__COURSE_PRACTICAL_WORK //used to organize...is a container for classes/namespaces
{
    class Program //a class is a container for data and methods
    {

        // new main method
        static void ExploreIf()
        {
            int a = 3;
            int b = 4;
            int c = 5;

            if((a+b+c > 10) && (a == 3) )
            {
                System.Console.WriteLine("The sum is greater than 10");
                System.Console.WriteLine("The value of a is 3");
            }
            else
            {
               System.Console.WriteLine("The sum is not greater than 10");
                System.Console.WriteLine("The value of a is not 3"); 
            }
        } 
        static void Main(string[] args) //always have a Main method
        {


              ExploreIf();




            // System.Console.WriteLine("Hello WOrld");

            string student;
            string professor = "Andrew";
            student = "John Smith";
            student = "Andrew";

//             Console.WriteLine("Hello World");
//             Console.WriteLine(student);
              System.Console.WriteLine($"\"Hello, {student}\"" ); 

              
              
               System.Console.WriteLine("Enter a character");

              ConsoleKeyInfo value = Console.ReadKey();
              System.Console.WriteLine("\n" + value.Key); 



              //orinting hello world with the its index 10 times

              //using while

             int count = 0;

               while (count < 10)
              {
                  System.Console.WriteLine("Hello World is at index of " + count);
              } 


              //using for loop

              for (count = 1; count <= 10; count ++)
              {
                 System.Console.WriteLine("Hello World is at index of " + count);
              } 

             //Correct one
              double ans;
              ans = Math.Floor(87.2);
              System.Console.WriteLine(ans); */
               //incorect one's
               ans = Floor(87.2);
              Floor(87.2);

              Math.Floor(double);
              Math.Floor(87.2); 
           


        //    for displaying the 3 digit after .
            float a , b;
            System.Console.WriteLine("Enter the A : ");
            a = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the B : ");
            b = float.Parse(Console.ReadLine());

            System.Console.WriteLine("a is : {0:f3}",a);
            System.Console.WriteLine("b is : {0:f3}",b);
 

        //    taking three Iunput and print the sum of them

            int a, b, c;
            System.Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter c: ");
            c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            System.Console.WriteLine(sum); 

            System.Console.WriteLine("Hello WOrld");


            // if statement

            string  name = "uhp";

            if (name == "uhp")
            {
                System.Console.WriteLine("the name is correct");
            } 
               
               System.Console.WriteLine("..........................");
             //if...else statement
             System.Console.WriteLine("Enter the name: ");
             string x = Console.ReadLine();

             if (x == "uki" )
             {
                 System.Console.WriteLine("Login successful");
             }
             else
             {
                 System.Console.WriteLine("Incorect PassWord");
             }
 
               
               //if else if statement

               System.Console.WriteLine("Enter the name: ");
             string x = Console.ReadLine();

             if (x == "uki")
             {
                 System.Console.WriteLine("sign in sucessfull");
             }
             else if (x == "Patel")
             {
                 System.Console.WriteLine("sign in sucesssful");
             }
             else
             {
                 System.Console.WriteLine("sign in failed");
             } 
       


            // using short hand 
              
              System.Console.WriteLine("Enter the name: ");
             string x = Console.ReadLine(); 
             string res = (x == "uki") ? "sign in sucessfull" : "login failed";
             System.Console.WriteLine(res);
 
              

                System.Console.WriteLine("Enter the name: ");
             string x = Console.ReadLine();
 
                  switch (x)
                  {
                      case "Uki": System.Console.WriteLine("Login sucessfull");
                      break;
                  
                      default : System.Console.WriteLine("Login failed");
                      break;
                  }       



                   System.Console.WriteLine("Enter a char: ");

                  char value = (char)Console.Read();

                  
                  if (char.IsLetter(value))
                  {
                      if (char.IsLower(value))
                      {
                          System.Console.WriteLine("Entered char is in LowerCase");
                      }
                      else
                      {
                          System.Console.WriteLine("Entered char is in UpperCase");
                      }
                  }
                  else
                  {
                      System.Console.WriteLine("Entered char is not CHARACTER");
                  } 
            
             
              
        }
    }
}