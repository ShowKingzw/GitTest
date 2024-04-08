/* 枚举一般声明到namespace里，class之外，所有class，主函数都可用
 * 也可声明在class内，主函数外
 * 不可声明在主函数内
 */


/* 枚举（enum）和普通变量一样，存储内容，本质是一个变量类型
 * 只是声明，赋值，使用的方式和普通变量类型不一样
 * 为了让一些代码变量更统一，规范，使用枚举声明变量存储内容
 * 通用的变量，提升开发效率，规范
 */


/* 枚举可以和int，double等等类型发生转换（强制转换）
 */


/* int可以和枚举类型发生转换（强制转换）
 */


namespace test
{
    /*声明枚举*/


    class TestProgram
    {
        public enum Season //Season是枚举名
        {
            spring,
            summer,
            autumn,
            winter,
            春,
            夏,
            秋,
            冬
        }

        public enum OS
        {
            MacOSX = 10,//转换时，此为12之后以此类推，直到重新设定序号
            Windows,
            Linux,
            Android = 20,
            iOS
        }


        static void Main(string[] args)
        {

            Season jijie1 = Season.autumn;
            Season jijie2 = Season.秋;
            OS phone1 = OS.Android;
            OS phone2 = OS.iOS;

            #region enum  to  int
            //按声明顺序从0开始

            //int OSnum1 = (int)phone1;
            //int OSnum2 = (int)(OS.MacOSX);

            //Console.WriteLine((int)OS.MacOSX);
            //Console.WriteLine((int)OS.Windows);
            //Console.WriteLine((int)OS.Linux);
            //Console.WriteLine((int)OS.Android);
            //Console.WriteLine((int)OS.iOS);
            #endregion

            #region int  to  enum
            ////  试把tNum1变成枚举类型
            //int tNum1 = 11;

            //OS t = (OS)tNum1; // 枚举中没有11，则转换失败，tNum1还是11
            //Console.WriteLine(t); // 成功则tNum1=Windows,失败则tNum1不变
            #endregion

            #region enum  to  string
            ////任何变量都可转string
            //int a = 60;
            //string stra = a.ToString();
            //Console.WriteLine(stra);

            //// enum  to  string
            //string strEnum = OS.Linux.ToString();
            //Console.WriteLine(strEnum);

            #endregion

            #region string  to  enum
            
            //枚举中没有此数字时，该字符串值不变，
            //字符串内容不是数字，且不是枚举内容，则运行错误
            string strOSNum = "20"; 
            OS strToEnum = (OS)Enum.Parse(typeof(OS), strOSNum);
            Console.WriteLine(strToEnum); //Android
            #endregion
        }
    }
}
