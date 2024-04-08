using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp2
{
    internal class Program
    {
        private const string file_name = @"C:/Test.txt";

        static void Main(string[] args)
        {
            //if (!File.Exists(file_name))
            //{
            //    Console.WriteLine("不存在！");
            //    return;
            //}

            //FileStream fs = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            //BinaryReader r = new BinaryReader(fs);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(r.ReadString());
            //}
            //r.Close();
            //fs.Close();
            //Console.ReadKey();


       

            string fileName = @"C:/Users/Legion/Desktop/test.txt";


            StreamReader sr = new StreamReader(fileName);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine($"{i}");
            }



        }

    }
}

