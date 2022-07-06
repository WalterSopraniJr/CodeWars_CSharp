using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAtoRNAConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //

            string dna = "AGCU";

            Console.WriteLine(DnaToRna(dna));
            Console.Read();
        }

        public static string DnaToRna(string dna)
        {
            string RNA = dna.Replace("U", "T");
            

            if (string.IsNullOrEmpty(dna))
            {
                throw new Exception("Preencher o DNA");
            }
            
            return RNA;
        }

    }

}
