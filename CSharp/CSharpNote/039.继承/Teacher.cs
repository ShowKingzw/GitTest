using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039.继承
{
    public class Teacher : Person
    {
        public enum Majors 
        {
            Math,
            English,
            Chinese
        }

        private int _teacherId;
        private Majors _major;
        public int TeacherId { get => _teacherId; set => _teacherId = value; }
        public Majors Major { get => _major; set => _major = value; }

        public void ShowMe()
        {
            Console.WriteLine($"老师任教的是{this.Major}");
        }
    }
}
