using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The test that can be either true or false
            bool isMale = true;
            if (isMale) 
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }
            // Can test 2 conditions
            bool isTall= false
                ; if (isTall && isMale) { Console.WriteLine("You are male and tall");
            }
                else if (isTall && isMale) { Console.WriteLine("Your not tall but male"); }
                else { Console.WriteLine("You are either tall nor male"); }
        }
    }
}
