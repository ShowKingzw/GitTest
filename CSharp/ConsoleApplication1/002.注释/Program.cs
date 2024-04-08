//以下被称为命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.注释符 //项目名称
{
    /// <summary>
    /// 
    /// </summary>
    class Program //类名称
    {
        /// <summary>
        /// 文档注释，多用于解释类或者方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) //这是Main函数或Main方法，代码从此开始执行
        {
            #region 折叠的冗余代码
            Console.WriteLine("Hello World!");//打印输出文本Hello World!
            Console.ReadKey();//暂停程序，等待按下任意键时输入这个键同时继续执行程序
            //Console.WriteLine("This is old code");
            //Console.ReadKey();

            //这是单行注释；

            /*这是多行注释；
             *可以有很多行；
             */
            #endregion

        }
    }
}
