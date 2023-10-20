using System;
using System.CodeDom;

namespace 접근_지정과_신뢰성
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit("홍길동");
            unit.Training(1000);
            Console.WriteLine("hp:{0}", unit.Hp);
            unit.Hp += 1000;
            Console.WriteLine("hp:{0}", unit.Hp);
        }
    }
}
