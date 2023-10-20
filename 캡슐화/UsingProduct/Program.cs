using CustomLib;
using System;

namespace UsingProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Custom custom = new Custom(2, "음냐링", "어쩌고 저쩌구");
            Console.WriteLine(custom);
        }
    }
}
