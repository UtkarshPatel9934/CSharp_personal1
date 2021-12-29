using System;

namespace Example1
{
	class Coin 
    {

        private string _sideUp; // data field


        public Coin()
         {
        _sideUp = "Head";
         }

         public void Toss()
         {
             System.Console.WriteLine(_sideUp);
         }

         public string getSideUp()
         {
             return _sideUp;
         }
    }
}