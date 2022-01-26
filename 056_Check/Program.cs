using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int num = 0;

            Random rnd = new Random();
            int a = rnd.Next(0, 100);

            while (true)
            {
                Console.Write("1~99사이 어떤 숫자일까요(단, 0은 나가기)");
                answer = int.Parse(Console.ReadLine());
                if (answer == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
                if (answer > a)
                {
                    Console.WriteLine("입력한 수는 커요");
                    num++;
                }
                else if (answer < a)
                {
                    Console.WriteLine("입력한 수는 작아요");
                    num++;
                }
                else if (answer == a)
                {
                    Console.WriteLine("=== 정답입니다 ===");
                    Console.WriteLine("총 {0}번 시도", num);
                    break;
                }
            }
        }
    }
}
