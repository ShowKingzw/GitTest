/* while循环 */

//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine("test");
//    i++;
//}
//Console.ReadKey();



/* for循环 */

//int i = 0;
//for (i = 0; i < 10; i++)
//{
//    Console.WriteLine("test");
//}
//Console.ReadKey();



/* for循环
 * for (表达式1;表达式2;表达式3)
 * {
 * 循环体;
 * }
 * 
 * 
 * 表达式1一般是循环变量，记录循环次数初始0
 * 表达式2一般是循环条件，
 * 表达式3一般为改变循环条件的代码，使得某一时刻循环条件不再成立，结束
 * 
 * 首先执行表达式1，判断表达式2是否成立，true则执行循环体，
 * 之后执行表达式3
 */



// 输出1到10
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.ReadKey();



//输出10到1
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
//Console.ReadKey();



//求1到100所有整数和，偶数和，奇数和
//int sum_zhengshu = 0;
//int sum_oushu = 0;
//int sum_jishu = 0;

//for (int i = 1; i <= 100; i++)
//{
//    sum_zhengshu+= i;
//    if (i % 2 == 0)
//    {
//        sum_oushu+= i;
//    }
//    else
//    {
//        sum_jishu += i;
//    }
//}
//Console.WriteLine($"1到100整数和为{sum_zhengshu}");//5050
//Console.WriteLine($"1到100偶数和为{sum_oushu}");//2550
//Console.WriteLine($"1到100奇数和为{sum_jishu}");//2500



// 求100到999之间的水仙花数
//一个数百位、十位、个位各自的立方相加等于该数

//for (int i = 100; i <= 999; i++)
//{
//    int baiwei = i / 100;
//    int shiwei = i % 100 / 10;
//    int gewei = i % 10;
//    if (baiwei * baiwei * baiwei +
//        shiwei * shiwei * shiwei +
//        gewei * gewei * gewei == i)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.ReadKey();




/* 乘法口诀表 */

//for (int line = 1; line <= 9; line++)
//{
//    for (int i = 1; i <= line; i++)
//    {
//        Console.Write($"{i}x{line}={i * line}\t");// /t制表符对齐
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();





Console.WriteLine("请输入一个数字:");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    Console.WriteLine($"{i}+{num - i}={num}");
}
Console.ReadKey();