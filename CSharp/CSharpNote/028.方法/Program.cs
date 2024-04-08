namespace Function
{

    class FunctionProgram
    {
        // 该字段属于类
        public static int _number = 6999;


        /// <summary>
        /// 返回两个整数中最大的一个 
        /// </summary>
        /// <param name="num1">第1个整数</param>
        /// <param name="num2">第2个整数</param>
        /// <returns>最大的数返回</returns>
        public static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        /// <summary>
        /// 判断一个数组长度是否为1
        /// </summary>
        /// <param name="array">1个int类型的数组</param>
        /// <returns>返回true或者false</returns>
        public static bool ArrIs1(int[] array)
        {
            if (array.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 测试void用的废话
        /// </summary>
        public static void OutWord()
        {
            Console.WriteLine("这是测试语句。。。。。。");

        }

        /// <summary>
        /// 对整数类型数组所有元素求和
        /// </summary>
        /// <param name="array">一个整数类型数组</param>
        /// <returns>数组所有元素的和</returns>
        public static int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// 对整数类型数组所有元素求平均数
        /// </summary>
        /// <param name="array">一个证书类型数组</param>
        /// <returns>数组所有元素的平均数</returns>
        public static double AvgArray(int[] array)
        {
            int sum = SumArray(array);
            double Avg = sum * 1.0 / array.Length;
            return Avg;
        }


        static void Main(string[] args)
        {

            //int[] tArray = { 1, 1, 21 };
            //int sum = SumArray(tArray);
            //Console.WriteLine(sum);
            //Console.WriteLine(AvgArray(tArray));
            //Console.ReadKey();

            /* 方法调用
             * 类名.方法名  
             * 函数和主函数在同一个class中可以省略类名
             * 如果不在同一class中，需要>>>>类名.方法名
             */

            #region 方法
            //int a = 6999, b = 7999;
            //int maxNum = GetMax(a, b);
            //Console.WriteLine(maxNum); // 7999

            //int[] ints1 = { 1, 54, 8, 1, 1 };
            //Console.WriteLine(ArrIs1(ints1)); // False

            //int[] ints2 = { 6999 };
            //bool res = ArrIs1(ints2);
            //Console.WriteLine(res); // True

            //OutWord();

            //FunctionProgram.GetMax(50, 50);

            #endregion


            /* 方法的创建
             * 方法名大写有意义，参数要小写
             * 方法需要和主函数位于同一位置，与主函数并列
             * 访问修饰符 静态 返回值类型（无则写void） 函数名（参数类型 参数）{..}
             */


            /*
             * *********** 方法上面要写Summary注释（开发文档）***********
             */


            /* 主函数中要调用自己写的函数，自己写的函数叫 被调者，主函数叫 调用者
             * 
             * 被调者要使用调用者的参数，方法有
             * 【1】向函数传参，有形参
             * 【2】使用 静态字段 模拟全局变量
             * 
             * 不论形参还是实参都在内存中开辟空间
             * 方法功能要单一
             * 忌讳出现提示用户输入的字眼
             */

        }
    }
}

