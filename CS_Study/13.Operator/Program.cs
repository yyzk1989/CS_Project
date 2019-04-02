using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bFlag = false;
            Console.WriteLine("{0} {1} {2}", !bFlag, !true, !false);

            //산술 연산자
            string str = "3" + ".14";
            Console.WriteLine(+5);              //숫자 5
            Console.WriteLine(5+5);             //숫자 10
            Console.WriteLine(5+.5);            //숫자 5.5
            Console.WriteLine("5"+"5");         //문자열 55
            Console.WriteLine(5.01f+"5");       //문자열 5.015
            Console.WriteLine(3.14f+"5");       //문자열 3.145
            Console.WriteLine(str);             //문자열 3.14
            str = 1 + "test" + 3.14f + "abcd";  //하나만 문자라도 문자열로 바뀐다
            Console.WriteLine(str);                 

            return;

        }
    }
}
