using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인덱서___영한_사전
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NWHOI nwhoi = new NWHOI();
            nwhoi[3] = "셋";
            for(int i = 1; i<=5;i++)
            {
                Console.WriteLine(nwhoi[i]);
            }
        }
    }
}
