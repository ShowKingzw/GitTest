// 语法没错，运行时出现错误，无法再运行

// 要注意变量的作用域
// 一般代码写完后，才对可能出现的异常进行try


bool res = false;
double num = 0;
//bool t = false;

try
{
    num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{num * 2}");
}
                // 二者间不能有代码
catch           // 异常处理
{
    Console.WriteLine("输入的不是数字！");
    //t = true;
}

//if (t == false)
//{
//    Console.WriteLine($"{num * 2}");
//}

Console.ReadKey();




