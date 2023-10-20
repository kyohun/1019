using EHLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_유형을_사용하는_라이브러리_예
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수:");
            int num = 0;
            /*num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);*/
            
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("입력한 수는:{0}", num);
            }
            else
            {
                Console.WriteLine("^^;;");
            }

            num = EH.InputNum("자연수:", -3);
            Console.WriteLine(num);
        }
    }
}
