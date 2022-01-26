using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Data_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.1415923f;
            decimal c = 3.1415923138470209379m;

            string strA = a.ToString(); //"100"
            string strB = b.ToString(); //"3.1415923"
            string strC = c.ToString(); //"3.1415923138470209379"

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
        }
    }
}
