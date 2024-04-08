using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量用于存储数据
            int number_1;  //int 定义整型变量，变量名为number_1
            number_1 = 100; //给number_1赋值100
            Console.WriteLine(number_1); //控制台输出变量number_1的值
            Console.ReadKey();

            /*变量储存的语法
             * 变量类型 变量名；
             * 变量名=变量值；
             * or
             * 变量类型 变量名 = 变量值；
             */

            double number_2 = 3.14;
            double d = 100;//double可定义小数，也可定义整数，double范围大于int,
            //使用double定义整数时，需加上后缀d或D，否则被视为int 出错
            string s = "这是一个字符串";//字符串可以为空，内容需要使用双引号
            Console.WriteLine(s);
            Console.ReadKey();
            char gender = '男'; //char定义字符，只能是一个字符，使用单引号
            decimal money = 1000m;//适用于货币（金钱小数），数字后加m或M，否则等同double 出错
            
            /*
             * 绿色波浪线（警告线）代表变量未使用过，可能导致错误             * 
             *变量先声明再赋值后使用
             *同一个变量可重复赋值，二次赋值时不必声明，直接赋值
             */
            
            /*
             *String整个.Net平台都在应用，string只在C#中使用，string称为关键字（keyword）
              可以不用大写
             * float定义浮点型变量，后缀加F或f，否则如同double 出错
             */
            
            /*变量的命名规则
             *大小写敏感，A不同a
             *一般以字母开头，特殊以@和_开头，之后可加数字或下划线
             *命名不得与C#系统中的关键字冲突             
             */

            /*两个规范
             * 1》camel,首单词首字母小写，后续单词首字母大写，其余小写，如bestComputerGame
             * 多用于变量命名
             * 2》pascal，每个单词首字母都要大写，其余小写，如BestComputerGame
             * 多用于类和方法的命名
             */


            




        }
    }
}
