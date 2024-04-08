namespace cs;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        const double pi = Math.PI;
        Console.WriteLine(pi);
        
        Func func1 =new Func();
        func1.testFunc();
        Func Func2 = new Func("Hello");
        Proc.PreProcess();
        Console.ReadKey();


    }
}
