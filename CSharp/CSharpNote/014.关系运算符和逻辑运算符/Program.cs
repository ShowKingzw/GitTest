//关系表达式的结果是bool类型
//bool a = 10 == 10.0;
//Console.WriteLine(a);

// 逻辑运算符
// &&且，或||，非！

//复合赋值运算符
// +=   -=    *=   /=   %= 





//// 例如
//Console.WriteLine("输入A成绩");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("输入B成绩");
//double b = Convert.ToDouble(Console.ReadLine());

//// 判断AB两成绩是否都大于90才可返回
//bool res1 = a >= 90 && b >= 90;

//// 判断AB两成绩是否有一大于80
//bool res2 = a > 80 || b > 80;

//Console.WriteLine(res2);



//逻辑非..........不等于
//bool res3 = !true; //false
//Console.WriteLine(res3);
//Console.ReadKey();





// 闰年判断
// 可被400整除
// 可被4整除，但不能被100整除
int year = Convert.ToInt32(Console.ReadLine());
bool y = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
Console.WriteLine(y);
Console.ReadKey();


// 逻辑表达式中，逻辑与的优先级更高，&&优先级更高
// &&有逻辑短路的原则，&没有，故&&效率更高，不再使用&