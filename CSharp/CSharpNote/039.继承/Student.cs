using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039.继承
{
    public class Student : Person
    {
        public enum Grades
        {
            Freshman,   // 大一
            Sophomore,  // 大二
            Junior,     // 大三
            Senior      // 大四
        }

        private int _studentId;
        private Grades _grader;
        public int StudentId { get => _studentId; set => _studentId = value; }
        public Grades Grader { get => _grader; set => _grader = value; }

        public void ShowMe()
        {
            Console.WriteLine($"{this.Name}年级是{this.Grader}");
        }



    }
}
