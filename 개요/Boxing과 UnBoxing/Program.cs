using System;

namespace Boxing과_UnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            Console.WriteLine("1");
            object o = i;
            Console.WriteLine("2");
            int j = (int)o;
            Console.WriteLine("3");
        }
    }
}
