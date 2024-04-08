/* 不需要返回值，在传入的原参数上进行修改再赋值回去
 * 声明函数时ref位于形参处，
 * 调用时ref也要有
 * ref参数与out相反，需要ref的变量在外部先赋值
 */


namespace ref参数
{

    class Program
    {
        /// <summary>
        /// 将一个数翻一倍
        /// </summary>
        /// <param name="num">一个整数</param>
        public static void PlusSelf(int num)
        {
            num += num;
        }

        /// <summary>
        /// 将一个数翻一倍，同时对原数的变量重新赋值
        /// </summary>
        /// <param name="num">一个整数</param>
        public static void PlusSelf1(ref int num)
        {
            num += num;
        }

        /// <summary>
        /// 两个数的值相互交换
        /// </summary>
        /// <param name="num1">一个数</param>
        /// <param name="num2">一个数</param>
        public static void Exchange(ref int num1, ref int num2)
        {
            num1 = num1 - num2;
            num2 = num1 + num2;
            num1 = num2 - num1;
        }


        static void Main(string[] args)
        {
            //int num1 = 3000;
            //int num2 = 2000;

            //PlusSelf(num1); // 执行后对num1没改变
            //PlusSelf1(ref num2); // 执行后对num2进行修改 num2=4000

            //Console.WriteLine(num1); //3000
            //Console.WriteLine(num2); //4000


            #region 交换两个数
            int a = 6999, b = 5999;
            Exchange(ref a, ref b); // a与b的值相互交换
            Console.WriteLine(a); // 5999
            Console.WriteLine(b); // 6999

            #endregion
        }
    }
}

