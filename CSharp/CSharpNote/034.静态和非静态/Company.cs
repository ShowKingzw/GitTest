using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034.静态和非静态
{
    static class Company // 静态class
    {   
        /* 静态class中只能有静态成员，
         * 也没有构造函数
         */

        private static int _number;


        public static int Number { get => _number; set => _number = value; }
    
        public static void AA()
        {
            Console.WriteLine();
        }
    
    }
}
