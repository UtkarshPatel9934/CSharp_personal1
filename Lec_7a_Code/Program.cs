// Program name: Chocolate store
// Program Purpose : to calc # of chocolates bars .....a bar costs $2.45
// Author : Utkarsh Patel
// Date created : 2021-06-01
using System;

namespace Lec_7a_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            System.Console.WriteLine("Welcome to the Chocolate Store Calculator");
            System.Console.Write("Enter Customer Name: ");// input for cust name
            string Buyer_name = System.Console.ReadLine();// declare variable for cust name
            // System.Console.WriteLine("Customer's name is : " + Buyer_name); // test output

            System.Console.Write("Enter the number of chocolate bars: "); // input for choco bars
            int numChoco = int.Parse(Console.ReadLine()); // variables for choco bars
            // System.Console.WriteLine("Number of chocolate bars: " + numChoco);
            

            // calc the number of chocolates bars multiplied by the price
            double price = 2.45; // constant - we can also use float
            double total = numChoco * price;


            //output the cust name , number of bars and total price
            System.Console.WriteLine("Customer's name is : " + Buyer_name);
            System.Console.WriteLine("Number of chocolate bars: " + numChoco);
            System.Console.WriteLine("total Price: ${0:f2} ", total);
            
            
            
            /* int tot = Convert.ToInt32(total);
            float roundof = total - tot;
            float round = 1 - roundof;
            float  total_round = tot + round;
            System.Console.WriteLine(total_round); */






        }
    }
}
