using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27.File_IO_Serialize
{
    //구조체 전체를 저장을 한번에 함
    // Serializeable을 선언하면 해당 구조체 or 클래스의 데이터를 하나의 단위로 조정
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str1 = "Test2";

            using (FileStream fs1 =
                new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            DATA[] ResultData;

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }
            for(int i = 0; i< 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1,
                    ResultData[i].var2, ResultData[i].str1);
            }

            return;


        }
    }
}
