using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: {0}", num++); //후치연산 //10 11 12  12 11 10
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", ++num); //전치연산

            Console.WriteLine("num: {0}", num--); //후치연산
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", --num); //전치연산
        }
    }
}
