using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _01.Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            string Address = Console.ReadLine();
            IPAddress IP = IPAddress.Parse(Address);
            Console.WriteLine("IP = {0}", IP.ToString());
            return;
        }
    }
}
