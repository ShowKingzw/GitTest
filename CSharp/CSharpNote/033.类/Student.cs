using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033.类
{
    public class Student // 声明一个（非静态）类 一个cs文件
    {
        /* 每个字段应该配备一个属性（Attribute）
         * 属性对字段的赋值和取值进行保护等。。。
         */

        // 声明字段
        private string _name;
        // 为该私有字段声明属性
        public string Name
        {
            get { return _name; }   // 访问时进行 // 只有get有return
            set { _name = value; }  // 赋值时进行
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set // 在set中处理
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }

        }

        private int _graduateDate;
        public int GraduateDate
        {
            get // 在get中处理
            {
                if (_graduateDate > 2022 || _graduateDate < 2000)
                {
                    return _graduateDate = 2020;
                }

                return _graduateDate;


            }
            set
            {
                _graduateDate = value;
            }
        }

        // 方法
        public void IntroduceSelf() // 非静态方法
        {
            Console.WriteLine($"{this.Name}同学，你现在{this.Age}岁，毕业时间是{this.GraduateDate}");
        }

        public static void F1()
        {
            Console.WriteLine("static method F1");
        }
        public void F2()
        {
            Console.WriteLine("method F2");
        }
        //声明字段后，自动声明属性，CTRL+R+E
        //public int Num { get => _num; set => _num = value; }
        //public string Str { get => _str; set => _str = value; }
        //public string Name { get => _name; set => _name = value; }
        //public int Age { get => _age; set => _age = value; }
        //public int GraduateDate { get => _graduateDate; set => _graduateDate = value; }

        /* 属性（Attribute，Property）
         * 字段（Field）存储内容，但外部一般不可以直接对字段进行直接赋值
         * 通常把字段设置为 private 私有，使其与外界隔离
         * 通过设置 public 属性，来作为外界与字段间的中介
         * 外界对属性赋值，属性把值再赋给私有字段，
         * 访问字段也是一样，依赖属性
         * 属性不存储内容，字段才存储
         * 
         * 属性的本质是两个（特殊）方法（Method）：get{}, set{}
         * 对属性赋值时，自动调用 set{} 把值赋给字段
         * 访问属性时，自动调用 get{} 从字段那里获取值
         * 
         * 属性可以对值进行处理（把关）
         * 可以在set{}中进行处理，也可在get{}中处理
         */


        /* 类是不占内存的，创建的对象是占内存的
        * this 关键字是指该类，类似Python的 self
        * 类和结构（struct）写法类似，但struct不具面向对象的任一特征（封装，继承，多态）
        */

    }
}
