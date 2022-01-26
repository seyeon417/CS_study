using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer;       //나의 답
            int num = 0;      //문제 맞힌 수
            int check = 1;    //문제 수

            Random rnd = new Random();
            int a;
            int b;

            while(true)
            {
                a = rnd.Next(0, 100);
                b = rnd.Next(0, 100);
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", check);
                Console.WriteLine("{0} + {1} = ??", a, b);
                answer = int.Parse(Console.ReadLine());
                if (answer == a + b)
                {
                    Console.WriteLine("== 정답 ==");
                    num++;
                }
                else
                {
                    Console.WriteLine("== 오답 ==(정답은: {0})", a + b);
                }
                if (check++ >= 5)
                {
                    Console.WriteLine("\n\n=== 결과값 ===");
                    Console.WriteLine("5문제 중 {0}문제 맞춤", num);
                }
            }
        }
    }
}
