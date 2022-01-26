using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Operator5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == 100) && (b == 1000); //true true
            Console.WriteLine("(a == b): {0}", result); //true
            
            result = (a == 100) || (b == 1000); //true true
            Console.WriteLine("(a != b): {0}", result); //true

            result = (a == 100) && (b == 100); //true false
            Console.WriteLine("(a > b): {0}", result); //false

            result = (a == 100) || (b == 100); //true false
            Console.WriteLine("(a < b): {0}", result); //true

            result = false;
            result = !result;
            Console.WriteLine("!result: {0}", result); //true
            result = !result;
            Console.WriteLine("!result: {0}", result); //false
        }
    }
}
