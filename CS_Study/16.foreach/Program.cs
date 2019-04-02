using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.@foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3, 4 };

            //처음부터 끝까지 그 값을 읽어온다.
            foreach(int nValue in Array1)
            {
                Console.WriteLine(nValue);
            }
            return;
        }
    }
}
