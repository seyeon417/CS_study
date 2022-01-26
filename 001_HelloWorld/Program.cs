using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using: 선언된 네임스페이스 내부 개체들에 접근

namespace _001_HelloWorld
//namespace: 그룹화(구조체), 동일한 함수의 이름 사용 가능
{
    internal class Program
    //class: 필드(변수)와 메소드(함수)로 분리, 프로그램을 구성하는 기본
    {
        static void Main(string[] args)
        //static void main: 가장 중요한 메소드, 최초의 진입점, 메인 메소드가 반드시 존재
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
