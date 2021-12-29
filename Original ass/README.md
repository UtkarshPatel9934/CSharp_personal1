Program Name: Speeding Ticket Application
Program Purpose: Is to calculate fine based on classification of student on campus for issuing parking tickets
Program Author: Utkarsh Patel
Date Created: 2021-07-05


.................IPO Input-Processing-Output.................

1.What inputs are available?
-> studentNumber, speedLimit, ticketedSpeed, classif

2.What processing is required?
-> For calculating speed, ticketedSpeed - speedLimit.

-> For calculating fine with initial 75 dollars charge, (speed / 5 * 87.50) + 75.00.

-> For calculating fine based on classif ie. calculation of fine according to classification of student, by using if...else statement with the condition and statements based on classification of student,according to the values inputted by the user that's stored in variable called: classif

-> For calculating what classification student belongs ie. taken input by user in form of char and processing it to get the full classification of student in form of string, by using simple if statements

3.What outputs are requested?
-> student number, same as taken by the user

-> classification in form of "full classificatioon name"(Not in Numbers) ie. based on the the input taken by user

-> speed Limit, same as taken by the user

-> ticketedSpeed, same as taken by the user

-> fine, calculated by the method setFine( )



.................PSEUDOCODE.................

Start

	// starting of class named: Ticket
     Class Ticket   // newly created class called Ticket

	Method SetFine(String studentNumber, Numeric ticketedSpeed, Numeric speedLimit, String classif) // starting of method called setFine()
	// method called SetFine for calculation of fine

	    Numeric speed = ticketedSpeed - speedLimit // for calculating a difference between default speed limit on road and speed at which travelled

	    Numeric fine = (speed / 5 * 87.50) + 75.00 // for calculating fine with initial 75 dollars charge

	// calculating a fine based on the classification of student
	if (classif == 4)
		if(speed > 20)
			fine = fine + 200
		else
			fine = fine + 50
	else
		if(classif == 1)
			if(speed < 20)
				fine = fine - 50
			else
				fine = fine + 100
		else
			if(speed > 19)
				fine = fine + 100

	Display "Student number: " + studentNumber // prints a student number on console

	// prints a classification of student according to input taken from user of program
	if(classif == 1)
	Display "Classification: Freshman"

	if(classif == 2)
	Display "Classification: Sophomore"

	if(classif == 3)
	Display "Classification: Junior"

	if(classif == 4)
	Display "Classification: Senior"

	Display "Speed Limit: " + speedLimit // prints a speed limit on console

	Display "Reported speed: " + ticketedSpeed // prints a speed travelled on console

	Display "\nFine: ${0:f2}", fine // prints a calculated fine according to classification

	End Method   // ending of method SetFine()


	// starting of Main method that created by default
	Method Main() // default created Main method

	// Get input from user
	Display "Enter Student Number: "  // prints a message for taking input student number and save inputted value to variable called studentNumber
	Input studentNumber

	Display "Enter the Speed Limit: " // prints a message for taking input speed limit and save inputted value to variable called speedLimit
	Input speedLimit

	Display "Enter the Ticketed Speed: " // prints a message for taking input speed travelled and save inputted value to variable called ticketedSpeed
	Input ticketedSpeed

	// prints a message for taking input for classification of student and save inputted value to variable called classif
	Display "Enter Your classification: \n\tFreshmen <enter 1>\n\tSophomore <enter 2>\n\tJunior <enter 3>\n\tSenior <enter 4>"
	Input classif

	Display "\n\tTicket App\n"

	Ticket.setFine(studentNumber, ticketedSpeed, speedLimit, classif) // invoking a method to get the results ie. calculation of fine according to classification of student

	End Method // ending of the Main method
    End Class    // ending of class Ticket

Stop

.................DeskCheck.................

>>>>>>>>INPUTS<<<<<<<<<


     studentnumber      speedlimit          ticketedspeed          classification 
1.    2975982759            35                    50                       1
2.    0293758275            35                    40                       4
3.    8276385235            35                    45                       1


>>>>>>>>>Expected Outputs<<<<<<<<<<

    studentnumber       speedlimit      reportedspeed    classification   fine
1.    2975982759            35             50                Freshman     287.50
2.    0293758275            35             40                Senior       212.50
3.    8276385235            35             45                Freshman     200



>>>>>>Calculations<<<<<<

1. speed = 50 - 35 = 15
fine = (15 / 5 * 87.50) + 75.00 = 337.50
fine = 337.50 - 50 = 287.50

2. speed = 40 - 35 = 5
fine = (5 / 5 * 87.50) + 75.00 = 162.50
fine = 162.50 + 50 = 212.50

3. speed = 45 - 35 = 10
fine = (10 / 5 * 87.50) + 75.00 = 250
fine = 250 - 50 = 200





2021-07-06

1000 - Firstly, I analyse the problem definition and try to performed IPO and figure out what input, processing, output are required.

1030 - After that, I designed the pseudocode for the program called speeding ticket application 

1045 - created a default Hello World program tryed to run that and confirmed that it works fine 

1050 - now started to code the soutions ie. converting algorithm into source code

1100 - created a new class called "Ticket" for calculating a fine.

1110 - created a new method under the class name Ticket called SetFine for calculating a fine according to the classification of student.

1120 - declared a variables called speed ie calculating difference between speed at which travelled and speed limit and fine ie. for calculating a fine with initial 75 dollars charge.

1130 - created if..else statement for calculating a fine according to the classsification of students ie. Freshmam, Sophomore, Junior, Senior.

1140 - created a statements for printing out the fine, student number, speed limit, repored speed on console.

1200 - created a if statements for printing a specific classifications of students on behalf of inputted char values on console.

1210 - created a statements that asks for input student number, speed limit, ticketed speed, classification form user.

1220 - declared a variables to store the above values in it ie. studentNumber, speedLimit, ticketedSpeed, classif

1230 - created a statement for printing a simple message called "Ticket App".

1235 - invoking a method called setFine and passed all the variables in it and getting the actual fine price for overspeeding based ie. calculated based on the classification.

1240 - tryed to run the program for several times with different inputs for to check that can I get consistent results or not

1245 - yes....it's worked fine with the different that values inputted.

1250 - check and verify the results of desk check with the final output and I will get the same output as of expected output.

2000 - finally runs the code many times and get the perfect output, I confirmed that code runs preety fine with different inputs.





>>>>>RESULTS AFTER RUNNING THE CODE<<<<<

1.
Enter Student Number: 2975982759
Enter the Speed Limit: 35
Enter the Ticketed Speed: 50
Enter Your classification:
        Freshmen <enter 1>
        Sophomore <enter 2>
        Junior <enter 3>
        Senior <enter 4>
1

        Ticket App

Student number: 2975982759
Classification: Freshman
Speed Limit: 35
Reported speed: 50

Fine: $287.50


2.
Enter Student Number: 0293758275
Enter the Speed Limit: 35
Enter the Ticketed Speed: 40
Enter Your classification:
        Freshmen <enter 1>
        Sophomore <enter 2>
        Junior <enter 3>
        Senior <enter 4>
4

        Ticket App

Student number: 0293758275
Classification: Senior
Speed Limit: 35
Reported speed: 40

Fine: $212.50

3.
Enter Student Number: 8276385235
Enter the Speed Limit: 35
Enter the Ticketed Speed: 45
Enter Your classification:
        Freshmen <enter 1>
        Sophomore <enter 2>
        Junior <enter 3>
        Senior <enter 4>
1

        Ticket App

Student number: 8276385235
Classification: Freshman
Speed Limit: 35
Reported speed: 45

Fine: $200.00


>>>testing code with different values<<<

    speedlimit     ticketedspeed     classification     fine
1.      35              39                  4           $125.00
2.      35              57                  1           $525.00
3.      35              54                  1           $287.50
4.      35              55                  4           $475.00
5.      35              57                  2           $525.00
6.      35              58                  4           $625.00
7.      35              48                  4           $300.00
8.      35              52                  2           $337.50
9.      35              60                  1           $612.50
10.     35              35                  1           $25.00


