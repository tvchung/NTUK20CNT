using System;

namespace Lesson04
{
    /// <summary>
    /// Review
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // test
            Student obj = new Student();
            obj.ID = 111;
            obj.Name = "Chung Trinh";
            obj.Age = 44;

            obj.Display();
            Console.WriteLine("\n");
            Console.WriteLine(obj.ToString());

            obj = new Student(123, "Trinh Chung", 44);
            obj.Display();
            Console.WriteLine("\n");
            Console.WriteLine(obj.ToString());
        }
    }

    /// <summary>
    /// Review -> Class Student
    /// </summary>
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
            return string.Format("ID\t:{0}\nName\t:{1}\nAge\t:{2}",ID,Name,Age);
        }
        // ....
    }
}
