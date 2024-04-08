// string转int
string str = "3060";

int num1 = Convert.ToInt32(str); // Convert方法转换

int num2 = int.Parse(str); // Parse方法转换

/* 二者的区别
 * Convert方法实质也是调用Parse方法
 * 所以Parse的效率会更高
 * 效果一样
 */