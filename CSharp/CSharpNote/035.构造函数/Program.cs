using _035.构造函数;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 常规实例化(没写构造函数)  逐一写入属性
            //Student KK = new Student();
            //KK.Name = "KK";
            //KK.Age = 20;
            //KK.GraduateDate = 2020;
            //KK.IntroduceSelf();


            // 构造函数帮助我们初始化对象（一次赋值属性）
            // 使用构造函数
            Student KK = new Student("KK", 20, 2020);
            KK.IntroduceSelf(); // 使用
            
            // 重载的构造函数
            Student GT = new Student();
            GT.Name = "GT";
            GT.Age = 50;
            GT.GraduateDate = 2014;
            GT.IntroduceSelf();

            Student ZZ= new Student("ZZ");
            ZZ.IntroduceSelf();


            // 关键字 new:::::::::
            // 1.在内存中开辟一块空间
            // 2.在开辟的空间中创建对象
            // 3.调用对象的构造函数进行初始化对象


        }
    }
}