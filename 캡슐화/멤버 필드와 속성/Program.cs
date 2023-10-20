using System;

namespace 멤버_필드와_속성
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man(3, "홍길동");
            Console.WriteLine("번호:",man.GetMNo());
            Console.WriteLine("번호:", man.MNo);            
        }
    }
}
