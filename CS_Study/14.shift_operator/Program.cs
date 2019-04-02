using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.shift_operator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * is 연산자
             * 형식 호환을 조사하는 연산자
             * 
             * 결과는 true false
             * 박싱/ 언박싱 변환 참조 변환에서 사용 
             */             
            int nValue = 10;
            float fValue = 10.2f;
            if (nValue is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            if (fValue is int)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");


            if (nValue is object)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            object obj = nValue;
            if(obj is int)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");
                       
            return;
        }
    }
}
