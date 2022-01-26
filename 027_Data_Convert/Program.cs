﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Data_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.1415923f;
            decimal c = 3.1415923138470209379m;

            string strA = a.ToString();
            string strB = b.ToString();
            string strC = c.ToString();

            //문자열
            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
            Console.WriteLine();

            int parseA = int.Parse(strA);
            float parseB = float.Parse(strB);
            decimal parseC = decimal.Parse(strC);

            //정수, 실수
            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
            Console.WriteLine();

            int convertA = Convert.ToInt32(strA);
            float convertB = Convert.ToSingle(strB);
            decimal convertC = Convert.ToDecimal(strC);

            //정수, 실수
            Console.WriteLine("Convert.ToInt32(strA): {0}", convertA);
            Console.WriteLine("Convert.ToSingle(strB): {0}", convertB);
            Console.WriteLine("Convert.ToDecimal(strC): {0}", convertC);
        }
    }
}