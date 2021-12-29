// Program Name: HairCut Bill Calculator
// Purpose: Create a program to calculate the amount of haircut for customer's
// Author: Utkarsh Patel
// Date: 2021-06-15

using System;

namespace Assignment_C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......Welcome to the HairCut Bill Calculator......"); // Welcome message for program

            // Declare variables
            string CustomerName; // For inputing Customer's Name
            decimal AmountForHairCut; // For inputing the fixed amount of Haircut
            decimal Tip; // For inputing the fixed amount of Tip
            decimal Tax; // For calculating a Tax
            decimal TotalTip, TotalBill; // For calculating amount of hair cut with total tip and final bill to be payed by customer
            decimal PriceBeforeTax; // For calculating the price of Haircut before the tax applied

            Console.Write("Enter the Customer's Full Name: "); // message for taking the input of Customer's Name
            CustomerName = Console.ReadLine(); // Takes input Customer's Name and stores in a variable called: CustomerName

            Console.Write("A haircut ranges from $10 (Youth), $30 (Adults), $50 (Styled)\nEnter the amount of HairCut: "); // message to get input of fixed amount of tip by Customer
            AmountForHairCut = Convert.ToDecimal(Console.ReadLine()); // Takes input fixed haircut price and stores in a variable called: AmountForHairCut

            Console.Write("The Tip can be either 0, 15 or 20%\nEnter the Tip: "); // message for taking input of fixed tip
            Tip = Convert.ToDecimal(Console.ReadLine()); //Takes input fixed Tip price and stores in a variable called: Tip

            // calculation process
            TotalTip = (AmountForHairCut * Tip) / 100; // calculating total tip applied on amount of haircut
            Tax = (AmountForHairCut * 13)/100; // calculating total tax applied on amount of haircut
            PriceBeforeTax = AmountForHairCut + TotalTip; // calculating the price of haircut without applying tax
            TotalBill = PriceBeforeTax + Tax; // calculate the final amount to be paid to by customer

            Console.WriteLine("The price of HairCut before tax is: ${0:f2}",PriceBeforeTax); // displaying the amount before tax applied on price of haircut
            Console.WriteLine("The Total Tax is applied on the Price of HairCut is: ${0:f2}",Tax); // displaying the total tax applied on the haircut price
            Console.WriteLine("The total price of HairCut for " + CustomerName + " is: ${0:f2}",TotalBill); // displaying the total amount to be paid

            Console.WriteLine("......Thanks For Using this program!!!......"); // Closing message for program
        }
    }
}




