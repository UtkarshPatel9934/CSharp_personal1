// Program Name: Speeding Ticket Application
// Program Purpose: Is to calculate fine based on classification of student on campus
// Program Author: Utkarsh Patel
// Date Created: 2021-07-05

using System;

namespace C_Assignment2
{
    class Ticket // Created a class called Ticket for calculate the fine for overspeeding on the campus road.
    {
        public static void SetFine(string studentNumber, int ticketedSpeed, int speedLimit, char classif) // created a Method called SetFine ie. to assign different values of fines according to the classification of students.
            {
                     int speed = ticketedSpeed - speedLimit; // declaring a variable called speed to calculate the speed difference between speedlimit and speed travelled by student.
                     // ticketedSpeed and speedLimit is an input from the user of program

                      double fine = (speed / 5 * 87.50) + 75.00; // to calculate a fine for overspeed with initial charge of 75 dollars


                    if(classif == '4') // verifies that classification of student is: Senior
                        {
                            if(speed > 20) // verifies that if the speed is greater than 20
                                {
                                     fine = fine + 200; // In this case additional 200 dollars have to pay by student on amount of fine

                                }
                            else // If the speed is not greater than 20
                                {
                                    fine = fine + 50; // In this case additional 50 dollars have to pay by student on amount of fine

                                }
                        }
                    else
                        {
                            if(classif == '1') // verifies that classification of student is: Freshmen
                                {
                                    if(speed < 20) // verifies that if the speed is less than 20
                                        {
                                          fine = fine - 50; // In this case deduction of 50 dollars on amount of fine

                                        }
                                    else
                                         {
                                             fine = fine + 100; // In this case additional 100 dollars have to pay by student on amount of fine

                                         }
                                }
                            else // For classification belongs to Sophomore and Junior
                                {
                                    if(speed > 19) // verifies that if the speed is greater than 19
                                        {
                                            fine = fine + 100; // In this case additional 100 dollars have to pay by student on amount of fine

                                        }
                                }
                        }
                        Console.WriteLine("Student number: " + studentNumber); // For printing the student number in console

                        if(classif == '1') // Verifies that classification by user of program is: 1
                        {
                            Console.WriteLine("Classification: Freshman"); // prints the classification belongs to student ie. Freshman
                        }
                        if(classif == '2') // Verifies that classification by user of program is: 2
                        {
                            Console.WriteLine("Classification: Sophomore"); // prints the classification belongs to student ie. Sophomore
                        }
                        if(classif == '3') // Verifies that classification by user of program is: 3
                        {
                            Console.WriteLine("Classification: Junior"); // prints the classification belongs to student ie. Junior
                        }
                        if(classif == '4') // Verifies that classification by user of program is: 4
                        {
                            Console.WriteLine("Classification: Senior"); // prints the classification belongs to student ie. Senior
                        }

                        Console.WriteLine("Speed Limit: " + speedLimit); // prints the speed limit set on the campus road ie. the input taken by the user of program
                        Console.WriteLine("Reported speed: " + ticketedSpeed); // prints the speed (over speed) on which the student travelled on campus ie. the input taken by the user of program
                        Console.WriteLine("\nFine: ${0:f2}", fine); // prints the actual fine that student have to pay for overspeed on campus roads

            }


        class Program // default created class called, Program
        {

        }

        static void Main(string[] args)
        {

                Console.Write("Enter Student Number: "); // prints a message on console for taking the input, student number by the user of this program
                string studentNumber = Console.ReadLine(); // takes the input student number and stores in a variable called, studentNumber

                Console.Write("Enter the Speed Limit: "); // prints a message on console for taking the input, speed limit by the user of this program
                int speedLimit = int.Parse(Console.ReadLine()); // takes the input speed limit and stores in a variable called, speedLimit

                Console.Write("Enter the Ticketed Speed: "); // prints a message on console for taking the input, speed (Overspeed) at which student travelled on campus by the user of this program
                int ticketedSpeed = int.Parse(Console.ReadLine()); // takes the input Ticketed Speed and stores in a variable called, ticketedSpeed

                Console.WriteLine("Enter Your classification: \n\tFreshmen <enter 1>\n\tSophomore <enter 2>\n\tJunior <enter 3>\n\tSenior <enter 4>");
                // prints a message on console for taking the input, classification of student by the user of this program
                char classif = Console.ReadLine() [0]; // takes the input classification and stores in a variable called, classif




                Console.WriteLine("\n\tTicket App\n"); // Simply prints a message called, Ticket App on console



                Ticket.SetFine(studentNumber, ticketedSpeed, speedLimit, classif); // takes an input called, "studentNumber", "ticketedSpeed", "speedLimit", "classif".
                // and passed it to the created method called SetFine in a Ticket class for calculating a fine.
                // and get the studentnumber, classification (in string), speedlimit, reportedspeed ie. taken by user and finally prints the fine calculated by a method called setFine on console.
                // ie. invoking a method

        }
    }
}
