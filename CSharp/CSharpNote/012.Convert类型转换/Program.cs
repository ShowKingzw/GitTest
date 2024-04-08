// int和double是兼容的，但二者和string不兼容，
// 只有兼容可以用隐式转换和显式转换


string str = "6999";

// string 转 double

double str_d = Convert.ToDouble(str);
Console.WriteLine(str_d);

// string 转 int

int str_i = Convert.ToInt32(str);

Console.WriteLine(str_i);
Console.ReadKey();



// Convert.Todouble()
//        .ToInt()
//        .ToChar()