using _033.类;

namespace Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 这里是主函数
            // 添加了一个类Student

            // 创建 KK
            Student KK = new Student(); // 类的实例化 new
            // 写入属性
            KK.Name = "KK";
            KK.Age = 20;
            KK.GraduateDate = 2020;
            // 访问属性
            Console.WriteLine($"{KK.Name}同学，你现在{KK.Age}岁，毕业时间是{KK.GraduateDate}");
            // 调用方法
            KK.IntroduceSelf();

            // 创建 GT
            Student GT = new Student();
            GT.Age = -5; // 让属性内部处理  0
            GT.Name = "GT";
            GT.GraduateDate = 0; // 让属性内部处理  2020
            Console.WriteLine($"{GT.Name}同学，你现在{GT.Age}岁，毕业时间是{GT.GraduateDate}");
            GT.IntroduceSelf();

            GT.F2();
            Student.F1();

        }
    }
}