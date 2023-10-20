using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 학생클래스
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("a학생");
            Student stu2 = new Student("b학생");
            Student stu3 = new Student("c학생");
            Student stu4 = new Student("d학생");

            Console.WriteLine("공부:아이큐 1증가, 춤:매력 1증가, 노래:매력1증가");
            Console.WriteLine();

            stu1.Study(2);
            stu1.Dance(1);
            stu1.Sing(1);
            Console.WriteLine();

            stu2.Study(5);
            stu2.Dance(0);
            stu2.Sing(1);
            Console.WriteLine();

            stu3.Study(3);
            stu3.Dance(2);
            stu3.Sing(2);
            Console.WriteLine();

            stu4.Study(1);
            stu4.Dance(3);
            stu4.Sing(3);
            Console.WriteLine();

            Console.WriteLine("아이큐 : {0}, 매력 : {1}, 이름 : {2}, 번호 : {3}", stu1.get_IQ, stu1.get_CP, stu1.get_Name, stu1.get_Num);
            Console.WriteLine("아이큐 : {0}, 매력 : {1}, 이름 : {2}, 번호 : {3}", stu2.get_IQ, stu2.get_CP, stu2.get_Name, stu2.get_Num);
            Console.WriteLine("아이큐 : {0}, 매력 : {1}, 이름 : {2}, 번호 : {3}", stu3.get_IQ, stu3.get_CP, stu3.get_Name, stu3.get_Num);
            Console.WriteLine("아이큐 : {0}, 매력 : {1}, 이름 : {2}, 번호 : {3}", stu4.get_IQ, stu4.get_CP, stu4.get_Name, stu4.get_Num);
        }
    }
}
