// if else可做的也可用三元表达式

int a = 10, b = 6999;

//if (a > b)
//{
//    Console.WriteLine(a);
//}
//else
//{
//    Console.WriteLine(b);
//}

int res = a > b ? a : b;

Console.WriteLine(res);
Console.ReadKey();


/*三元表达式
 * 关系表达式?true时返回的值:false返回的值;
 * 三个表达式
 * 表达式的返回类型与整体的返回类型要一至，
 * 需要一个相同的类型来接收表达式
 */