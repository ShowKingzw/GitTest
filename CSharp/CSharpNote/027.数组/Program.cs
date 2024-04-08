/* 数组和python的列表有相似之处
 * 一个数组只能存同一类型的元素
 * 数组长度一旦声明，无法改变
 */

#region 创建数组

//// 创建空数组，不赋值
//int[] intNums = new int[10]; /*******/

//// 创建数组并赋值
//int[] ints = { 4, 5, 8, 9, 5, 4, 5, 58 };/*推荐*/
//int[] ints2 = new int[3] { 6, 5, 2 };
//int[] ints3 = new int[] { 4, 5, 8, 9, 8, 5 };

#endregion
//// 赋值

//intNums[0] = 99;

//// 赋值
//for (int i = 0; i <= 9; i++)
//{
//    intNums[i] = 10 + i;
//}
#region
//Console.WriteLine(intNums[6]); // 取某一值

//bool[] boolNums = new bool[10];
//boolNums[0] = true;

//string[] strings = new string[10];
//strings[5] = "666";
//double[] doubleNums = new double[10];
//doubleNums[0] = 55.000;
//decimal[] decimalNums = new decimal[10];
//decimalNums[2] = 600m;

//Console.ReadKey();
#endregion

#region 取数组最大值，最小值，总和，平均值
//int[] ints1 = { 51, 51, -11, 98, 86, 1, 84, 54, 22, 12 };
//int maxNum = ints1[0];
//int minNum = ints1[0];// 避免偶然情况,默认第一个数是最大或最小
//int sum = 0;
//double avr = 0;
//for (int i = 0; i <= 9; i++)
//{
//    if (ints1[i] > maxNum)
//    {
//        maxNum = ints1[i];
//    }
//    if (ints1[i] < minNum)
//    {
//        minNum = ints1[i];
//    }
//    sum += ints1[i];
//    avr = sum / (i+1);

//}
//Console.WriteLine(maxNum);
//Console.WriteLine(minNum);
//Console.WriteLine(sum);
//Console.WriteLine(avr);
#endregion


int[] sortArray = { 11, 50, 36, 88, 51, 65, 13, 1, 5, 9 };
// 排序算法
Array.Sort(sortArray); // 排序，从小到大
Array.Reverse(sortArray); // 数组顺序反转
Console.WriteLine(sortArray[0]);

/*array.Length属性与 python中len()类似，得出数组的长度大小*/