// 产生随机数
// 创建能够产生随机数的对象

Random r = new Random(); // 创建Random对象r
// 让产生随机数的对象用方法来产生随机数
int rNum = r.Next(1, 10); //范围采用左闭右开的区间

Console.WriteLine(rNum);
Console.ReadKey();