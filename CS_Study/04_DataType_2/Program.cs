using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*박싱 언박싱
 * 
 * 데이터형을 최상위 object 형으로 변환 하여 힙에 저장
 * int m = 123;
 * object obj = m;
 * 
 * 언박싱
 * 힙에 저자된 형식을 다시 원래 형식으로 변환
 * int n= (int)obj;
 * 
 * 
 */
namespace _04_DataType_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing unboxing

            int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);

            int j = 123;
            object o = j;
            j = 456;
            Console.WriteLine("{0} {1}", j, (int)o);

            // ConsoleKeyInfo속성
            Console.WriteLine("==================== Key Info");
            ConsoleKeyInfo KeyInfo;

            do
            {
                KeyInfo = Console.ReadKey(); //대소문자를 구분을 하지 않는다.
            } while (KeyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine("==================== 대소문자 비교");
            do
            {
                KeyInfo = Console.ReadKey(true); // 입력을 받지만 화면에 출력 안함
                if(KeyInfo.KeyChar == 'a') // 대소문자 구분함
                    Console.Write("a눌림");
            } while (KeyInfo.Key != ConsoleKey.Escape);

            return;
        }
    }
}
