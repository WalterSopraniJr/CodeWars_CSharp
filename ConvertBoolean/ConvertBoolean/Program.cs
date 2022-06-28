using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBoolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string boolToWord(bool word)
            {
                if (word == true)
                {
                    return "Yes";
                }
                else if (word == false)
                {
                    return "No";
                }
                return "Wrong entry.";
            }

            Console.WriteLine(boolToWord(true));
            //"Yes"

            Console.WriteLine(boolToWord(false));
            //"No"

            Console.Read();
        }
    }
    
}
