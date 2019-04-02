using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *var 
 * 대입되는 데이터에 따라 데이터 결정
 * var 사용 불가 예
 * 1. null값 초기화, 매개변수 사용 못함
 * 2. var 지역변수로만 사용
 * 클래스 멘버로 사용 못함
 * 연속적으로 초기화 못함
 * var m= 10, n =20;
 * 
 *      
     */
namespace _03_DataType_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            var value1 = 3.14f;
            float value2 = 10.12f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f2} {2}", value1, value2, sum);


            // nullable
            /*null을 허용하지 않는 데이터형이 null값을 허용            * 
             * 
             * int? Var1;
             * bool? Var2 = null; //true, false, null
             */
            Console.WriteLine("==========================Nullable");
            int? Num1 = null;

            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("Null 값");

            Console.WriteLine("null : {0}", Num1);


            //데이터 변환

            /*
             * 기본 데이터형.Parse()
             * Convert.ToInt32()
             * Convert.ToSingle()
             * Convert.Toxxxxx()
             */
            Console.WriteLine("==========================ToString()");

            int value3 = 127;
            string str1 = value3.ToString();
            Console.WriteLine(str1);

            int value4 = Convert.ToInt32(str1);
            Console.WriteLine(value4);

            string str2 = "3.14";
            float value5 = float.Parse(str2);
            Console.WriteLine(value5);


            return;
        }
    }
}
