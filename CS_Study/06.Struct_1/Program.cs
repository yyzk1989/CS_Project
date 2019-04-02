using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Struct_1
{
    public struct MyStruct
    {
        //static or const 면 C#자체인 외부에서 값을 갖게 됨으로 사용 가능
        public const float PI = 3.14f;
        public static int Age = 12;
        // public int val;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            //선언을 해주어야지만 가능함 
            //MyStruct.val = 10;
            //Console.WriteLine(MyStruct.val);
        }
    }
}
