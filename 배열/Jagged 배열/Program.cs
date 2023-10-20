using System;

namespace Jagged_배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] scores = new int[3][];
            scores[0] = new int[3] { 3, 6, 9 };
            scores[1] = new int[5] { 34, 33, 38,32,35 };
            scores[2] = new int[2] { 99, 91 };
            foreach (int[] elem_arr in scores)
            {
                Console.WriteLine("====");
                foreach(int elem in elem_arr)
                {
                    Console.Write("{0} ", elem);
                }
                Console.WriteLine();
            }
        }
    }
}
