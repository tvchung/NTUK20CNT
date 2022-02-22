using System;

namespace Lesson02
{
    /// <summary>
    /// Lab02.1: Viết chương trình C# nhập vào các thông tin nhân viên (Id, Name, Address, 
//Birthday, Salary, Bonus). In ra màn hình các thông tin nhân viên có định dạng và thêm
//trường TotalSalary = Salary + Bonus)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // khai báo các biến
            String Id;
            String Name;
            String Address;
            DateTime BirthDay;
            float Salary;
            float Bonus;


            //nhập
            Console.Write("Nhập ID:");
            Id = Console.ReadLine();

            Console.Write("Nhập tên:");
            Name = Console.ReadLine();

            Console.Write("Nhập địa chỉ:");
            Address = Console.ReadLine();

            Console.Write("Nhập ngày sinh:");
            BirthDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Nhập lương:");
            Salary = float.Parse(Console.ReadLine());

            Console.Write("Nhập thưởng:");
            Bonus = float.Parse(Console.ReadLine());

            // Xuất
            Console.WriteLine("ID\t:" + Id);
            Console.WriteLine("Name\t:{0}", Name);
            Console.WriteLine("Address\t:{0}", Address);
            Console.WriteLine("Birth\t:{0}", BirthDay);
            Console.WriteLine("Salary\t:{0}", Salary);
            Console.WriteLine("Bonus\t:{0}", Bonus);
            Console.WriteLine("Total\t:{0:#,##0}", Salary * Bonus);


        }
    }
}
