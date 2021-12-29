using System;

namespace Lec_15b_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Selection Sort 
            

            static void selectionSort(int [] someNums)
            {

                // include the screenshot text for running program



                int minValue ;
                int minPosition;

                for (int currEl = 0; currEl < someNums.Length - 1; currEl++)
                {
                    minValue = someNums[currEl];
                    minPosition = currEl;


                    for(int index = currEl + 1; index < someNums.Length - 1; index++)
                    {
                        if(someNums[index] < minValue)
                        {
                            minValue = someNums[index];
                            minPosition = index;
                        }
                    }

                    if(minPosition != currEl)
                    {
                        int temp = someNums[currEl];
                        someNums[currEl] = someNums[minPosition];
                        someNums[minPosition] = temp;
                    }
                }
            }
        }
    }
}
