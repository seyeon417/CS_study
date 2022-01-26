using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; //캐스트연산오류
            int num = (int)sbyteData;
            //큰 거에서 작은 걸로 옮길 때만 오류 발생
            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbyteData2: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue); //127까지 가능
            Console.WriteLine("num: " + num);
        }
    }
}
