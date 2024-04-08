//// if判断两个数的大小
//double num1 = Convert.ToDouble(Console.ReadLine());
//double num2 = Convert.ToDouble(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine($"{num1}大于{num2}。");
//}
//else
//{
//    Console.WriteLine($"{num1}小于等于{num2}。");
//}





//// 判断输入正确
//Console.WriteLine("输入用户名");
//string id = Console.ReadLine();
//Console.WriteLine("输入密码");
//string password = Console.ReadLine();

//if ((id == "admin")&&(password == "mypass"))
//{
//    Console.WriteLine("登录成功");
//}
//Console.ReadKey();





// if(){} else if(){}        
int score = Convert.ToInt32(Console.ReadLine());

if (score >= 90 && score <= 100) // 区间[90,100]
{
    Console.WriteLine("A");
}
else if (score >= 80 && score < 90)
{
    Console.WriteLine("B");
}
else if (score >= 70 && score < 80)
{
    Console.WriteLine("C");
}
else if (score >= 60 && score < 70)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("E");
}
Console.ReadKey();