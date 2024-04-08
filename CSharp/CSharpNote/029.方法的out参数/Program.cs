/* 需要方法返回多个不同类型的值时，使用out参数
 * out的值要先声明，函数内部只赋值
 */

namespace out参数
{
    class Program
    {
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

        /// <summary>
        /// 测试out参数的函数
        /// </summary>
        /// <param name="array">int数组</param>
        /// <param name="str">平均数的字符串</param>
        /// <param name="avg">平均数</param>
        /// <returns>排序后的数组</returns>
        public static int[] OutTest(int[] array, out string str, out double avg)
        {
            // 返回不仅是数组，多余返回（out）其他类型的值时，使用out参数
            // out参数在使用函数前先声明，函数内部仅赋值，

            avg = AvgArray(array);
            str = "avg是" + (Convert.ToString(avg));
            Array.Sort(array);
            return array;
        }

        /// <summary>
        /// 验证用户名密码是否能正确登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">登录失败时的报错信息</param>
        /// <returns>true或false</returns>
        public static bool IsLogin(string name, string pwd, out string msg)
        {
            if (name != "admin")
            {
                msg = "用户名错误";
                return false;

            }
            else
            {
                if (pwd != "88888888")
                {
                    msg = "密码错误";
                    return false;
                }
                else
                {
                    msg = "";
                    return true;
                }
            }


            //else if (name == "admin" && pwd == "88888888")
            //{

            //}

        }

        /// <summary>
        /// 返回一个由int数组的最大值和最小值组成的数组，out传入数组的大小
        /// </summary>
        /// <param name="array">一个int数组</param>
        /// <param name="arrlength">传入数组的大小</param>
        /// <returns>由该数组的最大值和最小值组成的数组</returns>
        public static int[] GetMaxMin(int[] array, out int arrlength)
        {
            arrlength = array.Length;
            int maxNum = array[0];
            int minNum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
            }
            int[] res = { maxNum, minNum };
            return res;
        }


        static void Main(string[] args)
        {
            #region 调用

            //int[] arrayOut = { 60, 91, 5, 6, 10 };

            //// 调用方法1
            //int[] arrayOut1 = OutTest(arrayOut, out string str, out double avg);

            //Console.WriteLine(str);
            //Console.WriteLine(avg);


            //// 调用方法2
            //string strOut; // 可赋值也可不赋值
            //double dOut;
            //int[] arrayOut2 = OutTest(arrayOut, out strOut, out dOut);

            //Console.WriteLine(strOut);
            //Console.WriteLine(dOut);

            #endregion

            #region 登录，返回是否成功，错误还需提示哪里出错

            //while (true)
            //{
            //    Console.Write("请输入用户名：");
            //    string name = Console.ReadLine();
            //    Console.Write("请输入密码：");
            //    string pwd = Console.ReadLine();
            //    bool logRes = IsLogin(name, pwd, out string errorMsg);

            //    if (logRes == false)
            //    {
            //        Console.WriteLine($"登陆失败！{errorMsg}");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录成功！");
            //        break;
            //    }
            //}
            //Console.ReadKey();


            #endregion

            int[] arr = { 1080, 6999, 1650 };
            int[] maxmin = GetMaxMin(arr, out int arrSize);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"最大值是{maxmin[0]},最小值是{maxmin[1]}");
            Console.WriteLine(arrSize);
        }
    }
}