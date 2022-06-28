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
            bool A = char.IsUpper(a);
            bool B = char.IsUpper(b);
            bool C = char.IsLetter(a);
            bool D = char.IsLetter(b);

            bool BothLower = (A == false && B == false);
            bool BothUpper = (A == true && B == true);

            bool LowerUpper = (A == false && B == true);
            bool UpperLower = (A == true && B == false);

            bool NotLetter = (C == false || D == false);

            if (NotLetter) { return -1; }
            else if (LowerUpper || UpperLower) { return 0;}
            else if(BothLower || BothUpper) { return 1; }
            return 2;
        }        
    }
}
