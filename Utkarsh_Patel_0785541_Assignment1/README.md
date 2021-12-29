Program Name: HairCut Bill Calculator
Program Purpose: Create a program to calculate the amount of haircut for customer's
Program Author: Utkarsh Patel
Date Created: 2021-06-15

.................IPO Input-Processing-Output.................

1.What inputs are available?
-> CustomerName, AmountForHairCut, Tip

2.What processing is required?
-> For calculating TotalTip applied on amount of haircut, multiply tip with AmountOfHairCut and then divide by 100.
-> For calculating 13% Tax applied on amount of haircut, multiply 13 with AmountOfHairCut and then divide by 100.
-> For calculating PriceBeforeTax, add the TotalTip to AmountOfHairCut.
-> For calculating TotalBill, add the PriceBeforeTax with Tax.

3.What outputs are requested?
-> PriceBeforeTax, total tip and price of hair cut
-> Tax, total tax applied on amount of haircut
-> TotalBill, total payable amount by customer

.................PSEUDOCODE.................

Start
    Display "......Welcome to the HairCut Bill Calculator......"

    // Declare Variables
    Declare String CustomerName      // Customer's Full Name
    Declare Numeric AmountForHairCut // entering the fixed AmountForHairCuts
    Declare Numeric Tip              // entering the fixed amount of Tip
    Declare Numeric Tax              // used to calculate the total tax applied on AmountForHairCut
    Declare Numeric TotalTip         // used to calculate the TotalTip applied on AmountForHairCut
    Declare Numeric TotalBill        // used to calculate the TotalBill or final amount to be paid by customer
    Declare Numeric PriceBeforeTax   // used to calculate price of haircut with only Tip applied on it

    // Get input from user
    Display "Enter the Customer's Full Name: "
    Input CustomerName
    Display "A haircut ranges from $10 (Youth), $30 (Adults), $50 (Styled)\nEnter the amount of HairCut: "
    Input AmountForHairCut
    Display "The Tip can be either 0, 15 or 20%\nEnter the Tip: "
    Input Tip

    // Calculate TotalTip, Tax, PriceBeforeTax, TotalBill
    TotalTip = (AmountForHairCut * Tip) / 100
    Tax = (AmountForHairCut * 13)/100
    PriceBeforeTax = AmountForHairCut + TotalTip
    TotalBill = PriceBeforeTax + Tax

    // Display PriceBeforeTax, Tax, TotalBill
    Display "The price of HairCut before tax is: ${0:f2}",PriceBeforeTax
    Display "The Total Tax is applied on the Price of HairCut is: ${0:f2}",Tax
    Display "The total price of HairCut for " + CustomerName + " is: ${0:f2}",TotalBill

    //Close program
    Display "......Thanks For Using this program!!!......"
Stop

.................DeskCheck.................

 INPUTS
  Customers name     Input_haircut price    Input_Tip

1. John                  10                    0
2. Jeo                   30                   15
3. Max                   50                   20

Expected_PriceBeforeTax   Expected_Tax    Expected_TotalBill
 $10.00                     $1.30                  $11.30
 $34.50                     $3.9                  $38.40
 $60.00                     $6.5                  $66.50

.........calculations............

1. John
TotalTip = (10 *0) / 100 = 0
Tax = (10* 13)/100 = 1.30
PriceBeforeTax = 10 + 0 = 10.00
TotalBill = 10.00 + 1.30 = 11.30

2. Jeo
TotalTip = (30 *15) / 100 = 4.50
Tax = (30* 13)/100 = 3.90
PriceBeforeTax = 30 + 4.50 = 34.50
TotalBill = 34.50 + 3.90 = 38.40

3. Max
TotalTip = (50 *20) / 100 = 10.00
Tax = (50* 13)/100 = 6.50
PriceBeforeTax = 50 + 10.00 = 60.00
TotalBill = 60.00 + 6.50 = 66.50

2021-06-15

1000 - Analyse the problem definition performed IPO process ie. Input-Processing-Output
1030 - Design the solution made the Flowchart and Pseudocode for the print Haircut price program
1300 - created the default Hello World program and check for output 'Hello World!' and confirmed that it works fine.
1302 - started to code the solutions ie. Translate the algorithm into source code.
1305 - start with the code that prints the welcome message for program.
1310 - created a code to declare the variables that will stores the input.
1330 - created a code that display message for taking the input of customer's name, amount, tip from users.
1340 - created a code that will take the particular input and stored in the particular variables.
1355 - simply prints the input taken from the user to check it stored or not and it works fine.
1400 - created a code that calculate the TotalTip, Tax, PriceBeforeTax, TotalBill for customers based on the user input.
1420 - made a code that displays the results such as TotalTip, Tax, PriceBeforeTax, TotalBill and test again and again for consistence results.
1430 - displays the closing message for program.
1445 - successful completed the program that prints the the price of haircut.
1500 - check and verify the results of desk check with the final output and I will get the same output as of expected output.

........Results after running the code:.........

1. John
......Welcome to the HairCut Bill Calculator......
Enter the Customer's Full Name: John
A haircut ranges from $10 (Youth), $30 (Adults), $50 (Styled)
Enter the amount of HairCut: 10
The Tip can be either 0, 15 or 20%
Enter the Tip: 0
The price of HairCut before tax is: $10.00
The Total Tax is applied on the Price of HairCut is: $1.30
The total price of HairCut for John is: $11.30
......Thanks For Using this program!!!......

2. Jeo
......Welcome to the HairCut Bill Calculator......
Enter the Customer's Full Name: Jeo
A haircut ranges from $10 (Youth), $30 (Adults), $50 (Styled)
Enter the amount of HairCut: 30
The Tip can be either 0, 15 or 20%
Enter the Tip: 15
The price of HairCut before tax is: $34.50
The Total Tax is applied on the Price of HairCut is: $3.90
The total price of HairCut for Jeo is: $38.40
......Thanks For Using this program!!!......

3. Max
......Welcome to the HairCut Bill Calculator......
Enter the Customer's Full Name: Max
A haircut ranges from $10 (Youth), $30 (Adults), $50 (Styled)
Enter the amount of HairCut: 50
The Tip can be either 0, 15 or 20%
Enter the Tip: 20
The price of HairCut before tax is: $60.00
The Total Tax is applied on the Price of HairCut is: $6.50
The total price of HairCut for Max is: $66.50
......Thanks For Using this program!!!......
