#region 循环输出1000次
//int cnt = 0;
//while (cnt < 100)
//{
//    Console.WriteLine($"{cnt}程序异常");
//    cnt++;//计数
//}
//Console.WriteLine("完毕");
//Console.ReadKey();
#endregion


#region 求1到100整数的和-----5050
//int num = 1, sum = 0;
//while (num <= 100)
//{
//    sum += num++;
//}
//Console.WriteLine($"1到100的整数和为{sum}");
//Console.ReadKey();
#endregion


#region 求1到100偶数的和
//int num = 1, sum = 0;
//while (true) //(num <= 100)
//{
//    if (num % 2 == 0)
//    {
//        sum += num;
//    }
//    num++;
//    ////debug一下
//    //Console.WriteLine(num);
//    //Console.WriteLine($"{num - 1}是奇数，不计算");


//    //如果使用while(true),则需启用break;
//    if (num > 100)
//    {
//        break;
//    }

//}
//Console.WriteLine($"1到100的偶数和为{sum}");
//Console.ReadKey();
#endregion


#region 登录密码验证
//int cnt = 0;
//while (true)
//{

//    Console.WriteLine("输入用户名：");
//    string id = Console.ReadLine();
//    Console.WriteLine("输入密码");
//    string pwd = Console.ReadLine();

//    if (id == "admin" && pwd == "88888888")
//    {
//        Console.WriteLine("登陆成功！");
//        break;
//    }
//    else
//    {
//        cnt++;
//        if (cnt == 3)
//        {
//            Console.WriteLine("用户名或密码输入错误超过三次，程序退出！");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("用户名或密码输入错误，请重试！");
//            Console.WriteLine($"您还有{3 - cnt}次输入的机会。");
//        }

//    }

//    Console.WriteLine();

//}

#endregion


#region
//double person = 80000, year = 2006;
//while(person < 200000)
//{
//    person *=1.25;
//    year++;
//}
//Console.WriteLine($"{year}年将达到20w人");
//Console.ReadKey();
#endregion