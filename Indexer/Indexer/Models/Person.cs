using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get { return _age; } set { if (value >= 0 && value <= 150) _age = value; } }
        public int Height { get { return _height; } set { if (value >= 0 && value <= 300) _height = value; } }

        private int _age;
        private int _height;

        public Person(string name, string surname, int age, int height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Height = height;
        }
    }
}
