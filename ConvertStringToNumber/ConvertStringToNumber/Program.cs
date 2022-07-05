using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToNumber("1546"));

            Console.WriteLine(StringToNumber("0000"));

            Console.WriteLine(StringToNumber("1111"));

            Console.WriteLine(StringToNumber("78512"));

            Console.ReadLine();
        }

        public static int StringToNumber(String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
