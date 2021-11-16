using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = "C:/10chisel.txt";
            Random random = new Random();
            ushort n = 10;
            int s = 0;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            for (int i = 0; i < n; i++)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    int d = random.Next(1, 100);
                    sw.Write("{0} ",d);
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string read = sr.ReadToEnd();
                string[] array = read.Split();
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    s += Convert.ToInt32(array[i]);
                }
                Console.Write(s);
            }
            Console.ReadKey();
        }
    }
}
