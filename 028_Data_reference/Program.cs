using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Data_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int refnum = num;
            refnum = 1000;

            Console.WriteLine("refStr: {0}      ReferenceEquals: {1}", num, Object.ReferenceEquals(num, refnum));

            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum;
            refArrNum[0] = 1000;

            Console.WriteLine("refStr: {0} ReferenceEquals: {1}", arrNum[0], Object.ReferenceEquals(refArrNum, arrNum));
        }
    }
}
