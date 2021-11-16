using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "C:/Autodesk";
            String[] direct = Directory.GetDirectories(path, "**", SearchOption.AllDirectories);
            foreach (String d in direct)
            {
                Console.WriteLine("Подкаталог: {0}", d);
                String[] files = Directory.GetFiles(d);
                if (files.Length != 0)  
                foreach (String f in files)
                {
                    Console.WriteLine("Файлы: {0}", f);
                }
                else Console.WriteLine("Файлов нет");
            }
            Console.ReadKey();
        }
    }
}
