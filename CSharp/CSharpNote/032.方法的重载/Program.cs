namespace 重载
{
    class Program
    {
        // 三个函数名相同，但函数的参数个数和参数类型都有不同
        // 可以是参数类型相同，但参数个数不同
        // 可以是参数个数相同，但参数类型不同
        // ******参数 类型 和 个数 不能同时相同
        // 此时调用Plus函数可以传入三种不同类型的参数
        // 与返回值没有关系

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Plus(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static string Plus(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //int a = 10, b = 10;
            //double d1 = 1.0, d2 = 1.0;
            //string s1 = "1", s2 = "222";

            //// 方法名相同，直接调用
            //int res = Plus(a, b);
            //double d = Plus(d1, d2);
            //string s = Plus(s1, s2);

            double a = 9.1453;
            Console.WriteLine($"{a:0.00}是一个小数");
            Console.WriteLine(Math.Round(a, 3));

        }
    }
}