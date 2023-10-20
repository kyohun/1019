using System;

namespace 참조와_값_비교1
{
    struct VT
    {
        internal int Value { get; set; }
        internal VT(int value) { Value = value;}
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    class RT
    {
        internal int Value { get; set; }
        internal RT(int value) { Value = value; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    internal class Program
    {
        static void OnStudy(VT vt, RT rt)
        {
            Console.WriteLine("OnStudy before vt:{0} rt:{1}", vt, rt);
            vt.Value++;
            rt.Value++;
            Console.WriteLine("OnStudy after vt:{0} rt:{1}",vt,rt);
        }
        static void Main(string[] args)
        {            
            VT vt = new VT(1);
            RT rt = new RT(1);
            Console.WriteLine("Main before vt:{0} rt:{1}", vt, rt);
            OnStudy(vt, rt);
            Console.WriteLine("Main after  vt:{0} rt:{1}", vt, rt);
            Console.WriteLine(7 / 2);
            Console.WriteLine(7.0 / 2);
        }
    }
}

