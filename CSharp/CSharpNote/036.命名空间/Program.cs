using System;
using System.IO;
using _033.类; // 引用项目【033.类】的命名空间到此使用

namespace _036.命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 命名空间，用于解决重名问题，可以看作类的文件夹，当中有很多类
             * 要使用某一个类要先应用引用他的命名空间
             */

            /*一个项目中引用另一个项目的类：：：：
             * 1.在解决方案中现有项目处 添加引用（依赖项）的项目
             * 2.在命名空间处写using语句引用要用的命名空间
             */
            

            // 引用项目【033.类】的内容到此使用
            Student me = new Student();
            me.Name = "KK";
            me.Age = 20;
            me.GraduateDate = 2020;
            me.IntroduceSelf();


        }
    }
}