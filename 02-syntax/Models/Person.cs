using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_syntax.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old");
        }
    }

}