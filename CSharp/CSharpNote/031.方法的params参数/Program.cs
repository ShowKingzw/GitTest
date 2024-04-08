/* params可以理解为可变参数
 * 例如params int[] a成为可变数组
 * 可以将位于该位置的数字组成一个数组，并传入到函数内部
 * **将实参列表中和可变数组类型一直的元素都当作数组的元素去处理
 * *********  params 参数数组必须是形参的最后一个参数
 * **params参数具有唯一性，只能有一个params参数，且是最后一个形参   
 * 仅能修饰一维数组
 */

namespace ref参数
{

    class Program
    {
        /// <summary>
        /// 求成绩总和
        /// </summary>
        /// <param name="name">学生姓名</param>
        /// <param name="score">各成绩组成的params数组</param>
        public static void SumScore(string name, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine($"{name}同学，你的总成绩是{sum}.");
        }
        static void Main(string[] args)
        {
            int[] a = { 50, 5, 51, 54, 2, 51 };
            SumScore("KK", a);

            // params把61, 61, 64, 820, 1, 50组成一个数组来看
            SumScore("LL", 61, 61, 64, 820, 1, 50);

        }
    }
}

