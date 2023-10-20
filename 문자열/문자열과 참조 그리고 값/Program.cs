using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace 문자열과_참조_그리고_값
{
    internal struct VT
    {
        internal int Value { get; set; }
        internal VT(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    internal class RT
    {
        internal int Value { get; set; }
        internal RT(int value)
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            RT rt = obj as RT;
            return Value == rt.Value;
        }
        public static bool operator ==(RT rt1, RT rt2)
        {
            return rt1.Equals(rt2);
        }
        public static bool operator !=(RT rt1, RT rt2)
        {
            return !rt1.Equals(rt2);
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
            int i = 2;
            int j = 2;
            bool check1 = object.ReferenceEquals(i, j);
            bool check2 = object.Equals(i, j);
            bool check3 = i == j;
            Console.WriteLine("{0}{1}{2}", check1, check2, check3);

            RT rt1 = new RT(2);
            RT rt2 = new RT(2);
            RT rt3 = rt1;
            check1 = object.ReferenceEquals(rt1,rt2);
            check2 = object.Equals(rt1, rt2);
            check3 = rt1 == rt2;
            Console.WriteLine("{0}{1}{2}", check1, check2, check3);
            /*
            check1 = object.ReferenceEquals(rt1, rt3);
            check2 = object.Equals(rt1, rt3);
            check3 = rt1 == rt3;
            Console.WriteLine("{0}{1}{2}", check1, check2, check3);

            string s1 = "hello";
            string s2 = "hello";
            string s3 = s1;
            check1 = object.ReferenceEquals(s1, s2);
            check2 = object.Equals(s1, s2);
            check3 = s1 == s2;
            Console.WriteLine("{0}{1}{2}", check1, check2, check3);

            string ss1 = new string(new char[] {'음','냐','뤼'});
            string ss2 = new string(new char[] {'음','냐','뤼'});
            string ss3 = ss1;
            check1 = object.ReferenceEquals(ss1, ss2);
            check2 = object.Equals(ss1, ss2);
            check3 = ss1 == ss2;
            Console.WriteLine("{0}{1}{2}", check1, check2, check3);*/

        }
    }
}
