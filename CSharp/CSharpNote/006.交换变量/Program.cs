//int num1 = 100;
//int num2 = 200;
//Console.WriteLine("num1是{0}，num2是{1}。",num1,num2);
////交换二者数据
//Console.WriteLine("下面交换变量：");
//int temp = num1;//引入中间变量
//num1 = num2;//把num2赋值给num1（对变量重复命名)
//num2 = temp;//把temp赋值给num2（对变量重复命名)
////此时num1=200，num2=100
//Console.WriteLine("num1是{0}，num2是{1}。", num1, num2);
//Console.ReadKey();



//面试题，要求：不使用中间变量
int n1 = 600;
int n2 = 54651;
n1 = n1 - n2;
n2 = n1 + n2;
n1 = n2 - n1;
Console.WriteLine("n1:{0},n2:{1}.", n1, n2);
Console.ReadKey();