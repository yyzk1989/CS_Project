using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Testaver
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kor, Eng, Math, Total;
            float Average;

            Console.Write("국어 점수 입력 : ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수 입력 : ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수 입력 : ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("국 : {0} 영 : {1} 수 : {2} 합 : {3} 평균 : {4:f2}", Kor, Eng, Math, Total, Average);

            return;
        }
    }
}
