using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheristance
{
    /// <summary>
    /// Lớp cơ sở, lớp cha
    /// </summary>
    class Animal
    {
        // Field
        string Name;

        // bổ từ protected (field)
        protected string food;
        protected string activity;

        //Constructor
        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine("Dong vat an mot vai thu");
        }
        public void DoSomething()
        {
            Console.WriteLine("Dong vat lam mot vai thu");
        }

        public void Display()
        {
            Console.WriteLine("Hello, " + Name);
        }
    }
}
