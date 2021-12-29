using System;

using Example1;


    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Coin myCoin;
            myCoin = new Coin();

            Program.showCoinStatus(myCoin);

            // System.Console.WriteLine(myCoin.getSideUp());
            //myCoin.Toss();

            Pet myDog;
            myDog = new Pet();

            myDog.Name = "Nika";

            System.Console.WriteLine("My dogs name is {0}, and she is a {2}", myDog.Name, myDog.Bread);
            
        

        }

        static void showCoinStatus (Coin coin)
        {
            System.Console.WriteLine("My coin flip turned out to be " + coin.getSideUp());
        }

    }

