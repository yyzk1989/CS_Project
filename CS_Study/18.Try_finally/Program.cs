using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Try_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            try
            {
                Console.WriteLine("try 문 예외 발생");
                array[3] = 10;
            }
            finally
            {
                Console.WriteLine("finally 구문");
            }

            foreach (var m in array)
                Console.Write("{0} ", m);

  
        }
    }
}
