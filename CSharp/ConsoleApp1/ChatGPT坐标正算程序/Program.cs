//声明变量
double x1, y1, x2, y2;
double distance, angle;

//正算
Console.WriteLine("请输入坐标1：");
Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入坐标2：");
Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());

//计算距离
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("距离：" + distance);

//计算角度
angle = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
Console.WriteLine("角度：" + angle);

//反算
Console.WriteLine("请输入距离和角度：");
Console.Write("距离：");
distance = Convert.ToDouble(Console.ReadLine());
Console.Write("角度：");
angle = Convert.ToDouble(Console.ReadLine());

//计算坐标
x2 = x1 + distance * Math.Cos(angle * Math.PI / 180);
y2 = y1 + distance * Math.Sin(angle * Math.PI / 180);
Console.WriteLine("坐标2：" + "(" + x2 + "," + y2 + ")");