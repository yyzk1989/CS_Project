using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study
{
    class WriteLine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // Hello World!

            Console.WriteLine("{0} {1}", 3.14f, 12); // 3.14 12

            Console.WriteLine("{0} + {1} = {2}",1,2, 1+2); // 1 + 2 = 3

            Console.WriteLine("{0:C} {1:P} {0:X}", 1, 2, 1+2); // \1 200.00% 1
            /*
             *형식 문자
             * C => 통화 ($, \ 등) 표시
             * D => 10 진수 정수
             * E => 지수형태 출력
             * F => 부동 소수점 출력
             * G => 기본 출력
             * N => 콤마 출력
             * P => %단위 출력
             * X => 16진수 출력
             */
            return;
        }
    }
}
