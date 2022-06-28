using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RemoveCharacter
{
    public class Kata
    {
        static void Main(String[] args)
        {
            string Remove_char(string s)
                    {
                        string S = s;
                        S = S.Remove(0,1);
                        S = S.Remove(S.Length - 1, 1);  
                        return S;
                    }

            string result = Remove_char("teste");

            Console.WriteLine(result);

            //resultado: est

            Console.Read();
        }
        
    }
}
