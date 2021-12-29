using System;

namespace Lec_15d_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // copy an image of array to another blank array ie. make a copy of array
            int [] number = {3, 6, 9, 8, 10, 2};
            // int [] SecondNmumber = number; // it doesn't make a copy of first array ie. number
            // we have to make a single copy of single elememt
            int [] SecondNumber  = new int[6];

            for (int index = 0; index < number.Length; index ++)
            {
                SecondNumber[index] = number[index];

            }
            if(number.Length != SecondNumber.Length)
            {
                System.Console.WriteLine("Length is not same");

            }
            if(number[4] != SecondNumber[4])
            {
                System.Console.WriteLine("values are not same");
            }
            if(number != SecondNumber)
            {
                System.Console.WriteLine("Array points to different location");
            }


   /* static void swap(ref int a, ref int b)
       {
                int temp = a;
                a = b;
                b = temp;
            } */
// swap (ref someNumber[index], ref someNums[index + 1]);
            
        }
    }
}
