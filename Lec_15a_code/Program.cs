using System;

namespace Lec_15a_code
{
    class Program
    {
        
     static void bubbleSort(int[] someNums)
            {
                for (int  maxElement = someNums.Length - 1; maxElement >= 1; maxElement--) // each array pass
                {
                    for (int index = 0; index < maxElement; index ++)
                    {
                        if (someNums[index] > someNums[index + 1]) // 8 , 3
                        {
                            System.Console.WriteLine("Swapping index {0} with {1}, values {2} and {3}", index, index + 1, someNums[index + 1], someNums[index] );
                            int Temp = someNums[index];
                            someNums[index] = someNums[index + 1];
                            someNums[index + 1] = Temp;
                            }
                        }
                    }
                }
            
        static void Main(string[] args)
        {
            

            // Console.WriteLine("Hello World!");
         int [] numbers = {8, 3, 6, 9, 10, 2};
         bubbleSort(numbers);
         foreach(int num in numbers)
         {
             System.Console.Write(num + ", ");
         }
         System.Console.WriteLine("");



        }
    }
}
