﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Variable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100; //선언과 동시에 초기화
            int y = 200;
            int a = 1000, b = 2000;

            Console.WriteLine("x: {0}", x); //콤마 주의
            Console.WriteLine("y: " + y);
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }
}
