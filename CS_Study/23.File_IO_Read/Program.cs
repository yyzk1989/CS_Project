﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _23.File_IO_Read
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr= new StreamReader(fs);

            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            sr.Close();

            Console.WriteLine("{0} {1} {2}", value, value2, str1);


            using (StreamReader sr1 = new StreamReader(new FileStream("test.txt", FileMode.Open)))
            {
                int value3 = int.Parse(sr1.ReadLine());
                float value4 = float.Parse(sr1.ReadLine());
                string str2 = sr1.ReadLine();
                
                Console.WriteLine("{0} {1} {2}", value3, value4, str2);
            }


            //읽기만 할 경우 
            StreamReader sr3 = new StreamReader("test.txt");

            int value5 = int.Parse(sr3.ReadLine());
            float value6 = float.Parse(sr3.ReadLine());
            string str3 = sr3.ReadLine();
            sr.Close();

            Console.WriteLine("{0} {1} {2}", value5, value6, str3);

            return;
        }
    }
}
