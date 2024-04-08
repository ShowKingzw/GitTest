using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004._的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            /*+的作用
             *1.连接：当左右两边其中一边或两边是字符串时
             *2.相加：当两边是数字时
             */

            //int age = 20;
            //Console.WriteLine("我的年龄是" + age + "岁");
            //Console.ReadKey();

            //decimal num1 = 1575m;
            //decimal num2 = 0.78m;
            //Console.WriteLine("本金：" + num1 + "元");
            //Console.WriteLine("利息：" + num2 + "元");
            //Console.WriteLine("余额：" + (num1 + num2) + "元");//括号内进行相加运算
            //Console.ReadKey();

            //填入初始信息
            string name = "卡卡西";
            string address = "火影村";
            int age = 18;
            string email = "kakaxi@gmail.com";
            decimal salary = 5000m;
            age = 81;//经核查，发现有无信息，平台要对有误信息进行修改
            //根据以上信息生成一段话
            Console.WriteLine("我叫" + name + "，家住" + address + "，今年" + age + "岁，" + "我的邮箱是" + email + "，当前薪资是" + salary + "元。");
            Console.ReadKey();

        }
    }
}
