using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Struct_2
{
    public struct MyStruct
    {
        public int Age;
        public MyStruct(int InAge)
        {
            Age = InAge;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 선언만 해줘도 메모리가 생성이 된다.
            MyStruct TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct TestStruct2 = new MyStruct();
            Console.WriteLine(TestStruct2.Age);

            MyStruct TestStruct3 = new MyStruct(12);
            Console.WriteLine("{0}", TestStruct3.Age);

            return;
        }
    }
}
