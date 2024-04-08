/*
 * do while首先会执行一次循环体，在判断条件，至少执行一次
 * while 先判断在执行，有可能不执行循环体
 */

//int cnt = 0;
//do
//{
//    Console.WriteLine("test");
//    cnt++;
//    //if (cnt == 1)
//    //{
//    //    break;
//    //}
//} while (cnt <= 1);
//Console.WriteLine(cnt);
//Console.ReadKey();



#region 
string id = "";
string pwd = "";
do
{
    Console.WriteLine("输入id");
    id = Console.ReadLine();
    Console.WriteLine("输入密码");
    pwd = Console.ReadLine();
} while (id != "admin" || pwd != "88888888");
Console.WriteLine("登录成功");
Console.ReadKey();

#endregion