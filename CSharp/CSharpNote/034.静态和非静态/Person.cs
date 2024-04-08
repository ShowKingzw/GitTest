using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034.静态和非静态
{
    public class Person // 非静态的class
    {
        // 声明非静态内容
        private int _id;
        public int Id { get => _id; set => _id = value; }
        public string Talk()
        {
            Console.WriteLine("");
            return "a";
        }
        public void T()
        {
            Console.WriteLine();
        }

        // 声明静态内容
        private static string _str;
        public static string Str { get => _str; set => _str = value; }
        public static void A()
        {
            Console.WriteLine();
        }
        public static string B()
        {
            return " ";
        }

       
    }
}
