using System;

namespace Lec_15c_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }


        static void insertionSort (int[] someNums)
        {
            int pulledValues;
            int insertIndex;

            for(int pulledIndex = 1; pulledIndex < someNums.Length; pulledIndex++)
            {
                pulledIndex = someNums[pulledIndex];
                insertIndex = pulledIndex;

                while(insertIndex > 0 && someNums[insertIndex - 1] > pulledValues)
                {
                    someNums[insertIndex] = someNums[insertIndex-- -1]; // after finishing, insert index = insertIndex - 1
                    insertIndex -= 1;

                }

                someNums[insertIndex] = pulledValues;

            }
        }
    }
}
