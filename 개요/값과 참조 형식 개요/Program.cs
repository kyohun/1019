using System;

namespace 값과_참조_형식_개요
{

    class Foo
    {
        internal int Value { get; set; }
        internal Foo(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //값 형식
            int i = 1;
            int j = i;
            Console.WriteLine("i:{0} j:{1}",i,j);
            j = 3;
            Console.WriteLine("i:{0} j:{1}", i, j);

            //참조 형식
            Foo foo = new Foo(1);
            Foo soo = foo;
            Console.WriteLine("foo:{0} soo:{1}", foo, soo);
            soo.Value = 3;
            Console.WriteLine("foo:{0} soo:{1}", foo, soo);
        }
    }
}
