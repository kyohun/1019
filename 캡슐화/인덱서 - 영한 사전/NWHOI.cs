using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인덱서___영한_사전
{
    internal class NWHOI
    {
        string[] engs = new string[5];
        internal string this[int num]
        {
            get
            {
                if((num>=1)&&(num <= engs.Length)) 
                {
                    return engs[num-1];
                }
                return string.Empty;
            }
            set
            {
                if ((num >= 1) && (num <= engs.Length))
                {
                    engs[num-1] = value;
                }
            }
        }
        internal NWHOI() 
        {
            for(int i = 0; i<engs.Length; i++)
            {
                engs[i] = string.Empty;
            }
        }

        
    }
}
