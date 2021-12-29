using System;
using System.Collections;

namespace Lec_16b_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            ArrayList anArray = new ArrayList();
            anArray.Add("Hi How are you");
            anArray.Add("Live the life");
            anArray.Add("ok");
            anArray.Add("You are awesome");
             anArray.Add(10.2);
            anArray.Add(5);
            anArray.Add(true);



            anArray.RemoveAt(2);

            for(int i = 0; i < anArray.Count; i ++)
            {
                System.Console.WriteLine(anArray[i]);
            }
        }
    }
}
