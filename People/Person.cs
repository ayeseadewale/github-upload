using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.People
{
    public class Person
    {
        public string name;
        public int age;
        public bool HasPet;
        public void Greeting()
        {
            Console.WriteLine("Hello World, My name is {0}, I am {1} years old, my pet status is {2}", name, age, HasPet);

        }
    }
}
