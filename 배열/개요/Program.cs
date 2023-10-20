using System;

namespace 개요
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 12, 7, 8, 7 };
            Console.WriteLine("길이:",arr.Length);
            Array.Sort(arr);
            Console.WriteLine("요소:");
            foreach (int i in arr)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            arr[0] = 9;
            Console.WriteLine("요소:");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
