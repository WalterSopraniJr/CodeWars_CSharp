using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number 10 is " + EvenOrOdd(10));

            Console.WriteLine("The number 13 is " + EvenOrOdd(13));

            Console.WriteLine("The number 22 is " + EvenOrOdd(22));

            Console.WriteLine("The number 44 is " + EvenOrOdd(44));

            Console.WriteLine("The number 57 is " + EvenOrOdd(57));

            Console.ReadLine();
        }

        public static string EvenOrOdd(int number)
        {
            float result = number % 2;
            if (result == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}
