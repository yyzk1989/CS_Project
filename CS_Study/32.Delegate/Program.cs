using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Delegate
{
    delegate void DelegateType(string str);

    class A
    {
        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelMethod1 = new DelegateType(Test.print); //C# 1.0 이상 사용가능
            DelMethod1("Hello World1");

            DelegateType DelMethod2 = Test.print; //C# 2.0 사용 가능
            DelMethod2("Hello World2");

            return;
        }
    }
}
