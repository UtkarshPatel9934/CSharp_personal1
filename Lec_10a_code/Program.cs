// Program Name: Array Examples
// Proggram Purpose: To create an examples of arrays
// Author: Utkarsh Patel
// Date: 2021-06-15

using System;

namespace Lec_10a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Create an array to store multiple values in a single variable
            // To declare an array, define the variable type with square brackets

            string[] cars = {"Honda", "Mazda", "Porsche", "BMW"};

            /* cars[0] = "KIA"; */ // Changing the index zero's value by KIA

            // Now we want to access the specific piece of  Information
            /* System.Console.WriteLine(cars[3]); */ // Output the value at index zero ie. Honda

            // Find how many elements an array has?
            /* System.Console.WriteLine(cars.Length); */

            // Let's Loop through the array elements and output all elements of the cars array

            /* for (int i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine(cars[i]);
            } */

            // FOREACH  loop to exclusively loop through elements of an array

            /* foreach (string i in cars)
            {
                System.Console.WriteLine(i);
            } */

            // Let's use the sort(), to sort an array alphabetically or in ascending order

            // sort the cars array
            /* Array.Sort(cars);
            foreach (string i in cars)
            {
                System.Console.WriteLine(i);
            } */

            // sort a array o numbers
            /* int[] myNumbers = {5, 1, 8, 9, 4, 17, 33, 99, 99, 100};
            Array.Sort(myNumbers);

            foreach (int i in myNumbers )
            {
                System.Console.WriteLine(i);
            } */

            // Declare a single-dimensional array of 5 interger
            /* int[] array1 = new int[5]; */

            // System.Console.WriteLine(array1); // Output: integer of 32 bit

            // Declared and set array elements values
            // int array2 = new int[] {1, 3, 5, 7, 9};


            // Alternative syntax
           /*  int[] array3 = {1, 3, 5, 7, 9}; */

            // Declare a tow dimensional array
            /* int[,] mdArray = new int[2,3]; */ // We'll look at this in future.....

            // Let's create an array that gives an error
            /* int[] array3; */
            // array3 = {1, 2, 3, 4, 5, }; // Caused error why?

            /* array3 = new int[] {1, 2, 3, 4, 5};
            System.Console.Write(array3); */

            float x;
            System.Console.WriteLine("Enter x");
            x = float.Parse(Console.ReadLine());
            System.Console.WriteLine(x);



        }
    }
}
