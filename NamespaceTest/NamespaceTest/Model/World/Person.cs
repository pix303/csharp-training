using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceTest.Model.World
{
    internal class Person
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"My name is {Name} {Surname} and i'm {Age} old";
        }
    }
}
