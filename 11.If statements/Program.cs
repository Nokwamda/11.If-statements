using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //the test can be either true or false
            bool isMale = true;

            if (isMale)
            {
                Console.WriteLine("You are a male");
            }
            else
            {
                Console.WriteLine("You are a female");

            }
            //can also test 2 conditions with and i.e && in c#, or is ||
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall");
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("You are not tall but you are male");
            }
            else
            {
                Console.WriteLine("You are either not tall or not a male");
            }
            Console.ReadLine();
        }
    }
}
