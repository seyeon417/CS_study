﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Data_const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            const int MIN = 0;
            //MAX=1000; 오류 -> 중간에 변경 불가
            Console.WriteLine("MIN: {0} ~ MAX: {1}", MIN, MAX);
        }
    }
}
