using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039.继承
{
    public class Police : Person
    {
        private int _policeId;

        public int PoliceId { get => _policeId; set => _policeId = value; }

        public void ShowMe()
        {
            Console.WriteLine("警察，是执法者");
        }
    }
}
