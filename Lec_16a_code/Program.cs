using System;
using System.Collections;

namespace Lec_16a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");



            double [] waterDepth = {1.2, 4.6, 0.5, 5.5, 3.4};

            double [] w = new double [5];

            



            Array.Copy(waterDepth, 0, w, 0, 5);

            Array.Sort(w);
            System.Console.WriteLine("Source array: ");
            for(int i = 0; i < waterDepth.Length; i++)
            {
           System.Console.Write("{0}, ", waterDepth[i]);;
            }
            System.Console.WriteLine("\ntarget array: ");
            for(int i = 0; i < waterDepth.Length; i++)
            {
            System.Console.Write("{0}, ", w[i]);
            }
            System.Console.WriteLine(" "); 
        }
    }
}
