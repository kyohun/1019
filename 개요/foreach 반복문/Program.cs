using System;
using System.ComponentModel;

namespace foreach_반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 2, 5, 7, 9 };
            foreach(int elem in arr)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
