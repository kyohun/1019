using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 매개변수_전달_방식
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int j = 2;
            int k;
            int re = Foo(i, ref j, out k);
            Console.WriteLine("i:{0}, j:{1}, k:{2}, re:{3}",i,j,k,re);

        }

        private static int Foo(int i, ref int j, out int k)
        {
            k = 0;
            Console.WriteLine("Foo i:{0}, j:{1}, k:{2}", i, j, k);
            i++;
            j++;
            k++;
            return 0;
        }
    }
}
