// Program Name: Rainbow Colors Array
// Program Purpose: TO create an array of rainbow colours
// Author: Utkarsh Patel
// Date: 2021-06-17

using System;

namespace Lec_11a_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Write an array that displays the colours of the rainbow
            string[] rainbowColors = {"red", "orange", "yellow", "green","cyan", "blue"};
            System.Console.WriteLine(rainbowColors[0]);

            foreach(string i in rainbowColors)
            {
                System.Console.WriteLine(i);
            }

        }
    }
}
