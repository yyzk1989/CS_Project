using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _22.File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!";
            // 읽기 쓰기 가능
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str1);
            sw.Close();

            // 쓰기만 가능
            StreamWriter sw1 = new StreamWriter("test1.txt");

            sw1.WriteLine(value);
            sw1.WriteLine(value2);
            sw1.WriteLine(str1);
            sw1.Close();


            //using 은 Close 를 잃어버리고 안쓸경우등에 사용
            using (StreamWriter sw2 = new StreamWriter(new FileStream("test2.txt",
                FileMode.Create)))
            {
                sw2.WriteLine(value);
                sw2.WriteLine(value2);
                sw2.WriteLine(str1);
            }




        }
    }
}
