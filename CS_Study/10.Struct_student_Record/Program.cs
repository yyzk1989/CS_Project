using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Struct_student_Record
{
    public struct MyStruct
    {
        public int Kor, Eng, Math, Total;
        public float Average;
        
        public void Compute()
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct Test1 = new MyStruct();
            Test1.Kor = 80;
            Test1.Eng = 90;
            Test1.Math = 88;
            Test1.Compute();

            Console.WriteLine("총점 : {0}   평균 : {1:f1}", Test1.Total, Test1.Average);
            return;
        }
    }
}
