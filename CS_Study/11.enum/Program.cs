using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.@enum
{
    enum Days { Sun =1,
                 Mon,
                 Tue,
                 Wed,
                 Thu,
                 Fri,
                 Sat};

    class Program
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
            return;
        }
    }
}
