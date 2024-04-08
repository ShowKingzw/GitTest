using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.显式转换和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //参与运算的（算数运算和赋值运算）的操作系统和结果类型必须一致。
            //如不一致则将发生转换，小转大，自动转换；大转小，强制转换

            //范围 int < double，int与double相兼容（都是数字类型）

            //int num = 100;
            ////int转double（小转大），自动转换（隐式转换）
            //double d = num;


            //double D = 200.9;
            ////double转int（大转小），强制转换（显式转换）
            //int n = (int)D;//声明一个变量int n来接收转化出的int
            //Console.WriteLine(n);
            //Console.ReadKey();//结果取整数部分200
            
            /*注意
             *强制转换（显示转换）的语法是
             *声明 新的目标变量=(目标类型)待转换变量;
             */

            //如果操作数为double，则整个表达式可提升为double，例如
            int n1 = 10;
            int n2 = 3;
            double d = n1*1.0 / n2;//n1/n2等于3，3赋值给double d还是整数3，但是n1*1.0就是double，则d就是3.3333333…
            //n1/n2被称为操作数，其中一个被提升为double，则整个表达式为double
            Console.WriteLine("{0:0.00}",d);//打算保留两位小数，则使用占位符
            Console.ReadKey();


        }
    }
}
