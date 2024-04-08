using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035.构造函数
{
    public class Student
    {
        #region 构造函数
        // 构造函数 （创建对象时会执行该函数）
        // 构造函数没有 返回值 也不写 void ，必须public
        // 函数名与类名要相同

        ///////////// 构造函数可以重载////////////////
        /// <summary>
        /// 构造函数，实例化Student
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="graduateDate">毕业年</param>
        public Student(string name, int age, int graduateDate)
        {   //传参最全的构造函数
            this.Name = name;
            this.Age = age;
            this.GraduateDate = graduateDate;
        }
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Student() { }

        // 用到继承的理念
        public Student(string name, int age) : this(name, age, 0) { }
        public Student(string name) : this(name, 0, 0) { }
        /* this另一个作用，
         * 一个构造函数调用另一构造函数
         * 这样其他构造函数（传部分参）就不用再写构造函数内部的内容
         */

        #endregion

        /* 析构函数
        * 该函数在程序结束时才自动执行
        * 构造函数一般用于帮助释放资源
        * GC(Garbage Collection)是C#系统的垃圾回收机制（程序自动调用）
        * 一般程序自动调用GC工作
        * 为防止GC未及时释放资源，我们可使用析构函数
        * 没有析构函数，则系统自动用GC释放
        */

        ~Student()
        {
            Console.WriteLine("这是析构函数");
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
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
            get
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
        public void IntroduceSelf()
        {
            Console.WriteLine($"{this.Name}同学，你现在{this.Age}岁，毕业时间是{this.GraduateDate}");
        }
    }
}
