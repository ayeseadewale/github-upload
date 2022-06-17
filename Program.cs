using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.People;

namespace Test
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person p = new Person();
            
            //Variable for person 1
            p.age= 10;
            p.name= "Adewale";
            p.HasPet = true;
           
            p.Greeting();
            
            Console.ReadKey();
        }
    }
}
