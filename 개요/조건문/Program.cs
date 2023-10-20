using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("자연수:");
            //string input = Console.ReadLine();
            //int num = int.Parse(input);
            int num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }
            /*
            if(num) //C#에서 int 형식 변수로 참가 거짓을 판단할 수 없다.
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }*/
        }
    }
}
