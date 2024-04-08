using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100;
            int n2 = 200;
            int n3 = 300;
            Console.WriteLine("第一个数是{0}，第二个数是{1}，第三个数是{2}。",n1,n2,n3);
            //更改占位符顺序
            Console.WriteLine("第一个数是{0}，第二个数是{2}，第三个数是{1}。",n1,n2,n3);
            //多个占位符使用同一变量
            Console.WriteLine("第一个数是{0}，第二个数是{1}，第三个数是{2}。",n1,n1,n1);
            Console.ReadKey();
            /*注意
             * 占位符从{0}使用
             * {0}{1}{2}的顺序可以颠倒
             * 0，1，2，分别对应后面变量的顺序1，2，3
             * 使用了几个占位符后面就要有几个变量，变量可以重复使用
             */
        }
    }
}
