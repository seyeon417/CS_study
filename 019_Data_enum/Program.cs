﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Data_enum
{
    internal class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.TUE, (int)DAY_OF_WEEK.TUE);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT);
        }
    }
}
