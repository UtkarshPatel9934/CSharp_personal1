using System;

namespace Lec_16c_code
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!"); */

            string storeName = "Goodness Grocery";
            int storeNameLength = storeName.Length; // 16
            string storeAbbr1 = storeName.Substring(0, 4);
            String storeAbbr2 = storeName.Substring(9, 3);

            System.Console.WriteLine(storeAbbr1);
            System.Console.WriteLine(storeAbbr2);
        }
    }
}
