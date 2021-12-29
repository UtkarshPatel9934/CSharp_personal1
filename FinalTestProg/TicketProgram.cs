// Program name: TicketProgram
// Program purpose: To calculate a speeding ticket based on ticketed speed and student classification
// Author: Utkarsh Patel
// Date Modified: 2021-07-29

using System;

namespace TicketProgram
{
    class TicketApp
    {
        static void Main( )
        {
            string studentNumber;
			char classif;
            int speedLimit, speed;

            studentNumber = InputStudentNumber();
			speedLimit = InputSpeed("Speed Limit");
			speed = InputSpeed("Ticketed Speed");
			classif = InputYearInSchool( );
			
			Ticket studentTicket = new Ticket(studentNumber, classif, speedLimit, speed);
            Console.Clear();
            Console.WriteLine(studentTicket);
            Console.ReadKey( );
		}

        public static string InputStudentNumber()
        {
            string sNumber;
            Console.Write("Enter Student Number: ");
            sNumber = Console.ReadLine();
            return sNumber;
        }

		public static int InputSpeed(string whichSpeed)
		{
			string inValue;
            int speed;

			Console.Write("Enter the {0}: ", whichSpeed);
			inValue = Console.ReadLine();
            if (int.TryParse(inValue, out speed) == false)
                Console.WriteLine("Invalid entry entered for {0} - " +
                          "0 was recorded", whichSpeed);
			return speed;
		}

		public static char InputYearInSchool ( )
		{
			string inValue;
			char yrInSchool;
			Console.WriteLine("Enter your classification:" );
			Console.WriteLine("\tFreshmen (enter 1)");
			Console.WriteLine("\tSophomore (enter 1)");
			Console.WriteLine("\tJunior (enter 3)");
			Console.Write("\tSenior (enter 4)");
			Console.WriteLine();
            inValue = Console.ReadLine();
			yrInSchool = Convert.ToChar(inValue);
			return yrInSchool;
        }
    }

    class Ticket
    {
        private const
            decimal COST_PER_5_OVER = 87.50M;
        private string studentNumber;
        private char classif;
        private int speedLimit;
        private int speedTraveling;

        public Ticket(string sNum, char yrInSchool, 
                        int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed;
            classif = yrInSchool;
        }

        public Ticket(string sNum, int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed - speedLimit;
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public char Classif
        {
            get
            {
                return classif;
            }
            set
            {
                classif = value;
            }
        }

        public int SpeedLimt
        {
            get
            {
                return speedLimit;
            }
            set
            {
                speedLimit = value;
            }
        }

        public int Speed
        {
            get
            {
                return speedTraveling;
            }
            set
            {
                speedTraveling = value;
            }
        }


        public decimal SetFine( )
        {
            int milesOverSpeedLimit = speedTraveling - speedLimit;
            decimal fine;

            fine = (milesOverSpeedLimit / 5 * COST_PER_5_OVER) + 75.00M;
            if (classif == '4')
                if (milesOverSpeedLimit > 20)
                    fine += 200;
                else
                    fine += 50;
            else
                if (classif == '1')
                    if (milesOverSpeedLimit < 20)
                        fine -= 50;
                    else
                        fine += 100;
                else
                    if (milesOverSpeedLimit > 19)
                        fine += 100;
            return fine;
        }

        public string ReturnNameOfClassification()
        {
            string classificationName;
            switch (classif)
            {
                case '1':
                    classificationName = "Freshman";
                    break;
                case '2':
                    classificationName = "Sophomore";
                    break;
                case '3':
                    classificationName = "Junior";
                    break;
                case '4':
                    classificationName = "Senior";
                    break;
                default:
                    classificationName = "Unspecified";
                    break;
            }
            return classificationName;
        }

        public override string ToString()
        {
            return "\tTicket App" +
                "\n\nStudent number:  " + studentNumber +
                "\nClassification:  " + ReturnNameOfClassification( ) +
                "\nSpeed limit:  " + speedLimit +
                "\nReported speed:  " + speedTraveling +
                "\n\nFine: $" + SetFine( ).ToString();
        }
    }
}
