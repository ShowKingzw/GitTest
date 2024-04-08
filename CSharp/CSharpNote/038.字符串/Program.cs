using System.Text;


/* 字符串有不可变性*/
string s1 = "aa";
s1 = "bb";

// s1再次赋值后内存堆中aa还存在，但没有东西指向他，会被GC释放
// s1再次赋值时相当与在堆中新开一块内存空间，但栈中的s1不变
// s1只是指向堆的对象原来的aa指向了bb

#region 字符串 与 字符 
/* 字符串相当于一个 char 的 只读数组
 * 数组就可以通过下标去进行访问到单个元素
 */
string s2 = "abcd";
char char1 = s2[2]; //s2 类似 char[] 数组
Console.WriteLine(char1); //c

// 字符串转换为字符数组
char[] charArr1 = s2.ToCharArray();
//s2 直接成了 char[]数组

Console.WriteLine(charArr1); //abcd
Console.WriteLine(charArr1[2]); //c

//现在是数组就可修改了
charArr1[0] = 'A';
charArr1[1] = 'B';
charArr1[2] = 'C';
charArr1[3] = 'D';

// 将字符数组转换为字符串
s2 = new String(charArr1); // ABCD

Console.WriteLine(s2);
#endregion

#region StringBuilder
// 在大量读写字符串相关的任务时，十分耗费资源 时间
// 此时可使用String Build，就可以不用开辟内存空间

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10; i++)
{
    sb.Append(i);
}
string str = sb.ToString(); // 最后将这个对象转化为字符串
Console.WriteLine(str);//0123456789
/*一切类型都可转换为字符串
 */
#endregion

#region 字符串方法

string str1 = "ABCDEFGHIJK", str2 = "abcd";

// 截取该string从下标为（第一个参数）处开始，
// 共截取长度为（第二个参数）的长度
string str3 = str1.Substring(5, 3);
Console.WriteLine(str3); // FGH


// 把该string中的（第一个参数）子串换成（第二个参数）string
string str4 = str1.Replace("EFGHIJK", str2);
Console.WriteLine(str4); // ABCDabcd


// 在该string下标为（第一个参数）处，插入（第二个参数）string
string str5 = str1.Insert(4, "---");
Console.WriteLine(str5); // ABCDabcdEFGHIJK


// 该string是否包含（参数）字串
bool isContains = str1.Contains("EFG");
Console.WriteLine(isContains); // True


// string.Format实现占位符
string str6 = string.Format("字母是{0}...", str1);
Console.WriteLine(str6);


// 属性>>>>获取字符串的长度 
string str7 = "1234321";
int str7Length = str7.Length;
Console.WriteLine(str7Length);


// ToUpper()变大写 
// ToLower()变小写
string str8 = "123abcDEF";
str8 = str8.ToUpper();
Console.WriteLine(str8);


// 对比字符串是否相同
// 区分大小写比较
Console.WriteLine("AA".Equals("aa")); // False
// 不区分大小写比较
Console.WriteLine("AA".Equals("aa", StringComparison.OrdinalIgnoreCase)); // True


// 拆分字符串
string str9 = "2020.02.01.14:12:10";
char[] c = { '.', ':' }; // 分隔符放到数组中
string[] strArr2 = str9.Split(c); //字符串分成字符串数组，split传入数组
foreach (string i in strArr2)
{
    Console.WriteLine(i);
}
Console.WriteLine(strArr2.Length); // 6



#endregion