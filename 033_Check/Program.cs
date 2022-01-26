using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수 입력하세요? ");
            string str1 = Console.ReadLine();
            //int score1 = int.Parse(Console.ReadLine()); 합치기 가능
            Console.Write("영어 점수 입력하세요? ");
            string str2 = Console.ReadLine();
            Console.Write("수학 점수 입력하세요? ");
            string str3 = Console.ReadLine();
            Console.Write("과학 점수 입력하세요? ");
            string str4 = Console.ReadLine();

            int score1 = int.Parse(str1);
            int score2 = int.Parse(str2);
            int score3 = int.Parse(str3);
            int score4 = int.Parse(str4);

            Console.WriteLine("국어: {0}    영어: {1},    수학: {2},    과학: {3}", score1, score2, score3, score4);
            int tot = score1 + score2 + score3 + score4;
            float avg = tot / 4.0f;
            Console.WriteLine("총점: {0}    평균: {1}", tot, avg);
        }
    }
}
