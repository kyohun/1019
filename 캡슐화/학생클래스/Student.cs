using System;
using System.Runtime.CompilerServices;

namespace 학생클래스
{
    internal class Student
    {
        int iq;
        int cp;
        readonly int num;
        string name;
        static int lastnum;

        public Student(string name)
        {
            this.name = name;
            lastnum++;
            num = lastnum;
        }

        public void Study(int cnt)
        {
            Console.WriteLine("{0}번 {1}학생 {2}횟수 공부하다.", num, name, cnt);
            iq += cnt;
        }
        public void Dance(int cnt)
        {
            Console.WriteLine("{0}번 {1}학생 {2}횟수 춤추다.", num, name, cnt);
            cp += cnt;
        }
        public void Sing(int cnt)
        {
            Console.WriteLine("{0}번 {1}학생 {2}횟수 노래하다.", num, name, cnt);
            cp += cnt;
        }
        public override string ToString()
        {
            return name;
        }
        public int get_IQ
        {
            get
            {
                return iq;
            }
            private set
            {
                iq = value;
            }
        }
        public int get_CP
        {
            get
            {
                return cp;
            }
            private set
            { 
                cp = value;
            }
        }
        public int get_Num
        {
            get
            {
                return num;
            }
        }
        public string get_Name
        {
            get
            {
                return name;
            }
            private set 
            {
                name = value;
            }
        }
        public int get_LastNum
        {
            get
            { 
                return lastnum;
            }
        }

    }
}
