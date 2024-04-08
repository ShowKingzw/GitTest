namespace _039.继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student kk = new Student();
            Student mm = new Student();
            kk.Name = "kk";
            kk.Grader = Student.Grades.Freshman;
            mm.Grader = Student.Grades.Junior;
            kk.ShowMe();
            mm.ShowMe();

            /* 类的继承
             * class1 : calss2 //class2为基类，class1为派生类
             * 继承具有单根性（只能有一个父类）
             * 传递性（可以继承父类的父类.......）
             * 子类可以继承 属性 方法
             * 
             * 对于子类调用父类的构造函数
             * 子类默认只能调用父类的无参（默认的）构造函数
             * 如果父类除了无参的构造函数还有其他需要传参的构造函数
             * 那么这时候子类就不会去调用父类的默认构造函数
             * 出现报错
             */
           
        }
    }
}