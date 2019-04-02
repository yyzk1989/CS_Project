using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Struct_3
{
    public struct MyStruct
    {
        public int Age;
    }

    class MyClass
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct test1 = new MyStruct();
            test1.Age = 12;
            MyStruct test2 = test1; //값만 복사 한것 이다.
            test2.Age = 24;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3; //참조 형식이기 때문에 test3 의 값이 변경된다.
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);

            return;
        }
    }
}
