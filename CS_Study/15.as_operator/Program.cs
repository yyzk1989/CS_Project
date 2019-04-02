using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.as_operator
{
    class A
    {

    }
    class B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * as 연산자
             * 형변환과 변환 조사
             * 캐스트 연산자의 역할
             * 불변환은 null 리턴
             */
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");


            //nullable 형식

            int? x = null;
            int y = x ?? -1;  //x 가 null 이아니면 x 대입 null 이면 -1 대입
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);

            return;

        }
    }
}
