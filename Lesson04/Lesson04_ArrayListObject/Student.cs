using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ArrayListObject
{
    class Student
    {
        // field / properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // constructor
        public Student() { }
        public Student(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
        // method normal
        public void Display()
        {
            Console.WriteLine("ID\t:" + ID);
            Console.WriteLine("Name\t:" + Name);
            Console.WriteLine("Age\t:" + Age);
        }
        // override
        public override string ToString()
        {
            return string.Format("ID\t:{0}\nName\t:{1}\nAge\t:{2}", ID, Name, Age);
        }
        // ....
    }
}
