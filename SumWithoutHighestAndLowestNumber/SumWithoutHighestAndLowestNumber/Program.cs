using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithoutHighestAndLowestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = {2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine(Sum(number));

            int[] number2 = { 5, 3, 4, 4, 2, 71, 8 };
            Console.WriteLine(Sum(number2));

            int[] number3 = {5, 8, 88, 77, 42, 65, 10};
            Console.WriteLine(Sum(number3));

            Console.Read();
        }


        public static int Sum(int[] numbers)
        {
            bool condition = (numbers == null || numbers.Length < 2);

            if (condition)
            {
                return 0;
            }
            else
            {
                return (numbers.Sum() - (numbers.Max() + numbers.Min()));
            }
        }
    }
}
