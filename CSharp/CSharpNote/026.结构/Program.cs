// 结构可以一次性声明多个不同类型的变量

/* 结构（Struct）类似Python中的类（Class）
 * 当中有许多字段，需要单独public
 * 使用时需要实例化，传入参数，成为属性
 */

/* 结构（Struct）可以理解为Python的Class
 */

/* 字段与变量
 * 二者都是变量
 * 一个字段可以在不同的Struct中有不同的值，
 * 例如A.name和B.name都是同一个name字段，但属于不同的Struct，值不一样
 * 变量只能有一个值
 */

/* *******  规  范  *******
 * 字段前面加一下划线为了和变量区别 */


namespace Struct
{
    public enum Gender
    {
        男,
        女
    }
    
    public struct PersonAttribute
    {
        public string _name;
        public int _age;
        public string _job;
        public Gender _gender; // 使用枚举类型
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            PersonAttribute Me; // 类似于实例化
            PersonAttribute Candy;
           
            Me._name = "KK";    // 类似于类的属性
            Me._age = 20;
            Me._job = "Student";
            Me._gender = Gender.男; //使用枚举类型
   
            Candy._name = "Mike KK";
            Candy._age = 25;
            Candy._job = "driver";
            Candy._gender = Gender.女;

            Console.WriteLine(Me._name);
            Console.WriteLine(Candy._name);
            Console.WriteLine(Me._gender);
            Console.WriteLine(Candy._gender);

        }
    }
}