using System;

namespace Lesson03
{
    /// <summary>
    /// Review
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Review!");
            // Khởi tạo đối tượng sinh viên / sử dụng constructor không tham số
            Student obj = new Student();
            // Sử dụng phương thức (Gọi thực hiện phương thức Display())
            obj.Display();
            // Khởi tạo đối tượng sinh viên với constructor có tham số
            obj = new Student(1122, "Chuung Trinh", 40);
            obj.Display();

            Console.WriteLine(obj.ToString());

            Console.WriteLine("\n Gan gia tri thong qua thuoc tinh");
            obj.ID = 1000;
            obj.Name = "Do Van Tuong";
            obj.Age = 20;

            obj.Display();

        }
    }
    /// <summary>
    /// Create class
    /// </summary>
    class Student 
    {
        // attribute (field / properties /dynamic properties)
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // method (constructor / normal method/ ...)
        // constructor
        public Student()
        {
            ID = 0;
            this.Name = "NTU";
            this.Age = 0;
        }
        // Constructor có tham số
        public Student(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Mã sinh viên \t:" + ID);
            Console.WriteLine("Tên sinh viên \t:" + Name);
            Console.WriteLine("Tuổi sinh viên \t:{0}" , Age);
        }

        // method override
        public override string ToString()
        {
            return string.Format(" Mã: {0} \n Tên: {1} \n Tuổi:{2}",ID,Name,Age);
        }


    }

}
