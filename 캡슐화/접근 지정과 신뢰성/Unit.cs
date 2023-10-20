using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace 접근_지정과_신뢰성
{
    internal class Unit
    {
        internal string Name
        {
            get;            
        }
        const int max_hp = 100;
        const int min_hp = 0;
        int hp;
        internal int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if(value <min_hp)
                {
                    value = min_hp;
                }
                if(value>max_hp)
                {
                    value = max_hp;
                }
                hp = value;
            }
        }

        public Unit(string name)
        {
            Name = name;
            Hp = min_hp;
        }
        internal void Training(int tcnt)
        {
            Hp += tcnt;
        }
    }
}