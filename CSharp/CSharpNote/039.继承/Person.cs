using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039.继承
{
    public class Person
    {   
        public enum Genders
        {
            Male,
            Female
        }

        private string _name;
        private int _age;
        private int _id;
        private Genders _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public int Id { get => _id; set => _id = value; }
        public Genders Gender { get => _gender; set => _gender = value; }
    }
}
