using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHLib
{
    /// <summary>
    /// EH 클래스
    /// </summary>
    public static class EH
    {
        /// <summary>
        /// 최종 사용자로부터 정수 입력받는 메서드
        /// </summary>
        /// <param name="msg">입력 받기 전에 콘솔에 출력할 메시지 </param>
        /// <param name="def_val">잘못 입력했을 때 반환할 디폴트 값</param>
        /// <returns>입력한 정수</returns>
        public static int InputNum(string msg,int def_val=0)
        {
            Console.Write(msg);
            int num = 0;
            if(int.TryParse(Console.ReadLine(), out num)) 
            {
                return num;
            }
            return def_val;
        }
    }
}
