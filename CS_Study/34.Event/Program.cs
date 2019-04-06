using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Event
{
    delegate void DelegateType(string Message);
    class A
    {
        public event DelegateType EventHandler;

        public void Func(string Message)
        {
            EventHandler(Message);
        }
    }

    class B
    {
        public void printA(string Message)
        {
            Console.WriteLine(Message);
        }
        public void printB(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test1 = new A();
            B Test2 = new B();

            Test1.EventHandler += new DelegateType(Test2.printA);
            Test1.EventHandler += new DelegateType(Test2.printB);
            Test1.Func("Good!!");
            Test1.EventHandler -= Test2.printB;
            Test1.Func("Hi~~!");
            Test1.EventHandler -= Test2.printA;

            Test1.EventHandler += Test2.printA;
            Test1.EventHandler += Test2.printB;
            Test1.Func("Hello World!");

            return;
        }
    }
}
