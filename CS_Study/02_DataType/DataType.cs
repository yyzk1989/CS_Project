using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * bool =    1byte = 0 또는 1이 아닌 ture or false
 * char =    2byte = C# 부터는 2byte로 작성됨
 * byte =    1byte              0~255
 * sbyte =   1byte = 음수 가능   -128~127
 * short =   2byte
 * ushort =  2byte
 * int   =   4byte
 * uint  =   4byte
 * long  =   8byte
 * ulong =   8byte
 * float =   4byte
 * double =  8byte
 * decimal = 16byte
 * 
 * 문자열
 * string
 */

 /*
  * char
  * 유니코드 2byte  
  */


namespace _02_DataType
{
    class DataType
    {
        static bool BoolVar;

        static void Main(string[] args)
        {
            Console.WriteLine("==============================bool");
            //bool
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);

            Console.WriteLine("==============================char");
            // char
            char Mun = '7';
            int Num = Mun;
            Num = Num + 1;
            Console.WriteLine("Mun = {0} 문자 상수값 = {1} 유니코드문자 = {2}",
                (int)Mun, Num, (char)Num); // 55  56  8

            // 7 유니코드 값 ==  55   유니코드 값+1 == 56   유니코드 문자 8 

            Mun = (char)Num;
            Console.WriteLine(Mun);

            Console.WriteLine("==============================byte");
            // byte
            int Result;
            byte x = 1, y = 2;
            Result = x + y;
            Console.WriteLine(Result);

            Console.WriteLine("==============================short");
            // short
            Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);
            // short.MinValue   Short.MaxValue  값의 최소값 최대값 출력 가능

            Console.WriteLine("==============================String");
            // String

            /*
             * + 문자열 연결
             * == 문자열 비교
             * [인덱스] : 문자
             * 
             * 문자열에 \을 포함 하는 경우
             * @ 뒤에는 문자열을 다 사용한다.
             * @ 없으면 \\두개로
             * @"C:\temp\test.txt" 
             * "C:\\temp\\test.txt" 
             */

            //chapter 1
            string str1 = "Hello_";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if(str3 == "Hello_World!")
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("다름");
            }

            //chapter 2
            string str5 = "Hello_world!";
            Console.WriteLine("문자 개수 : {0}", str5.Length);

            //chapter 2

            string str6 = @"C:\temp\test.txt";
            string str7 = "C:\\temp\\test.txt";

            Console.WriteLine("{0} {1}", str6, str7);
            



            return;
        }
    }
}
