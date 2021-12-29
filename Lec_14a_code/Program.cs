using System;

namespace Lec_14a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int [] myArray;
            // myArray = new int[10];

            // myArray[0] = 1;
            // myArray[1] = 5;

            // int ROWS = 3;
            // int COLS = 4;
            // int [,] scores;
            // scores = new double[ROWS,COLS];

            // scores [0, 0] = 1;
            // scores [0, 1] = 2;


            
            // System.Console.WriteLine("{0}, {1}, {2}",scores, /*scores[0]*/ scores[0,0],scores[0,1]);

            int [,] scores = {

                {900,750,659},// Row 0 // sun
                {200,450,567}, // Row 1 // Mon
                {500,700,2100}, // Row 2 // Tues
                {300,479,3483}, // Wed
                {327,2376,474}, // Thurs
                {236,657,292}, // Fri
                {283,6984,3487} // Sat
            };
            // Rows: 3, COlS: 3

            /* string [,] rawEmpty = {
                {""}, {""}
            };

            System.Console.WriteLine("{0}",rawEmpty[0,0]); */

            System.Console.WriteLine("{0},{1},{2},{3}",scores,scores[2,2],scores.Length,scores.Rank,scores.GetLength(0),scores.GetUpperBound(0));
            // Rank means how many dimensions an array is?

            foreach(int cal in scores)
            {
               
                System.Console.Write(cal + " ");
            }


            /* for(int r = 0; r < scores.GetLength(0); r++)
            {
                for(int c = 0; c < scores.GetLength(1);c++)
                {
                        Console.Write(scores[r],[c] + " ");
                }
            }
 */
            public static double[] calculateAverageByDay (int[,] scores)
            {
                int sum = 0;
                double [] dailyAverage = new double[3];
                for (int r = 0; r< scores.GetLength(0);r++)
                {
                    sum = 0;
                    for(int c = 0; c < scores.GetLength(1); c++ )
                    {
                        sum += scores[r,c];
                    }
                    dailyAverage[c] = (double)sum / scores.GetLength(1);
                    sum = 0;
                }
            }
        }


    }
}
