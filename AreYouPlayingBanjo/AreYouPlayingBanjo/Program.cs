using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreYouPlayingBanjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreYouPlayingBanjo("Nicolas"));
            Console.WriteLine(AreYouPlayingBanjo("Renan"));
            Console.ReadLine();


            string AreYouPlayingBanjo(string name)
            {
                char[] entry = name.ToCharArray();
                char firstLetter = entry[0];
                bool condition = (firstLetter == 'R' || firstLetter == 'r');

                if (condition)
                {
                    return name + " plays banjo";
                }
                return name + " does not play banjo";
            }
        }
    }
}
