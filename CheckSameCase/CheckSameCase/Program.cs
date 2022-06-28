using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSameCase
{
    public class Kata
    {
        //se um dos caracteres não for uma letra, retorne -1
        //se ambos caracteres forem do mesmo case, retorne 1
        //se ambos caracteres forem letras mas de cases distintos, retorne 0
        public static int SameCase(char a, char b)
        {
            bool BothLower = (a > 96 && a < 123 && b > 96 && b < 123);
            bool BothUpper = (a > 65 && a < 90 && b > 65 && b < 90);

            bool LowerUpper = (a > 96 && a < 123 && b > 65 && b < 90);
            bool UpperLower = (a > 65 && a < 90 && );

            if (BothLower || BothUpper)
            {
                return 1;
            }
            else if (a > 96 && a < 123 || b > 96 && b < 123 || a > 65 && a < 90 || b > 65 && b < 90)
            {
                return 0;
            }
            return -1;
        }

        
    }
}
