using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007.接收用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.ReadLine();用于接收控制台的输入,同时暂停程序
            //Console.WriteLine("你喜欢吃什么水果？");
            //string fruit = Console.ReadLine(); //创建一个变量用于存储readline接收到的数据
            //Console.WriteLine("哈哈，我也喜欢吃{0}。", fruit);
            //Console.ReadKey();

            Console.WriteLine("请输入姓名：");
            string name = Console.ReadLine();

            Console.WriteLine("请输入性别：");
            string gender = Console.ReadLine();

            Console.WriteLine("请输入年龄：");
            string age = Console.ReadLine();

            Console.WriteLine("您好，{0}同学，您的年龄是{1}岁，您是一个{2}生。",name,age,gender);
            Console.ReadKey();

            /*注意
             *存储console.readline()接收到的数据时，只能使用string进行存储
             */
        }
    }
}
