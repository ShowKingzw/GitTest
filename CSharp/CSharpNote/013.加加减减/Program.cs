//int num1 = 10;

////num1++; // num1 = num1 + 1;

//int num2 = num1++; //令num2=num1,之后num1=num1+1=11
//Console.WriteLine(num1); //11
//Console.WriteLine(num2); //10

//int num3 = 20;
//int num4 = ++num3; //令num3=num3+1=21,之后num4=num3
//Console.WriteLine(num4); //21
//Console.WriteLine(num3); //21





//++或--属于一元运算符，+-*/是二元运算符
//一元运算符优先级高于二元运算符。。。。首先计算一元运算符





//例如
int a = 5;
int b = a++ + ++a * 2 + --a + a++; //b=5+7*2+6+6  a=7
Console.WriteLine(a);
Console.WriteLine(b);