public class Func
{
    string line="999";

    public Func(string str)
    {
        line = str;
        testFunc();
    }
    public Func()
    {

    }

    public void testFunc()
    {
        Console.WriteLine("这是用函数");
        Console.WriteLine(line);

    }
}