using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Serializeable 을 하기 싫은 위치를 선언 가능
 * 
 */ 
namespace _28.File_IO_deserialize
{
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        [NonSerialized]
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
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1,
                    ResultData[i].var2, ResultData[i].str1);
            }

            return;
        }
    }
}
