using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Data_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.1415923";
            string strC = "3.1415923138470209379";

            int parseA = int.Parse(strA); //int parseA = 100;
            float parseB = float.Parse(strB); //float parseB = 3.1415923f;
            decimal parseC = decimal.Parse(strC); //decimal parseC = 3.1415923138470209379m;

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
        }
    }
}
