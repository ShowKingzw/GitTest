////if else if 可以处理范围
////switch用于等值比较



////int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = 600;
//string str = "6999";

//switch (str) // 值类型要一致
//{
//    case "7777":  // case值与上述类型一致
//        Console.WriteLine("1");
//        break;
//    case "5555":  // 和6999执行相同的语句
//    case "6999":
//        Console.WriteLine("this is 6999");
//        break;
//    default:
//        Console.WriteLine("Nothing");
//        break;
//}







// 判断闰年,月的天数
try
{
    int year = Convert.ToInt32(Console.ReadLine());
    int month = Convert.ToInt32(Console.ReadLine());
    if (month >= 1 && month <= 12)
    {

        int day = 0;
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                day = 31;
                break;
            case 2:
                bool y = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
                if (y)
                {
                    day = 29;
                }
                else
                {
                    day = 28;
                }
                break;
            default:
                day = 30;
                break;
        }
        Console.WriteLine($"{year}年{month}月有{day}天");
    }
    else
    {
        Console.WriteLine("月份不正确,退出！");
    }
}
catch
{
    Console.WriteLine("输入有误，程序退出！");
}
Console.ReadKey();