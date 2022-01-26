﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; //10
            Console.WriteLine("result: " + result);

            result = a ?? c ?? d; //100
            Console.WriteLine("result: " + result);

            c = 1000;
            result = a ?? c ?? d; //1000
            Console.WriteLine("result: " + result);
        }
    }
}
