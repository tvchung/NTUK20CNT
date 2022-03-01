using System;
using System.Collections.Generic;

namespace Lesson04_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new  List<int>();
            num.Add(10);
            num.Add(20);
            num.Add(44);
            //num.Add("a");
            Console.WriteLine("Danh sach");
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            // obj Student

            List<Student> lstStudent = new List<Student>()
            {
                new Student(100,"Hung",20),
                new Student(200,"Dung",22),
                new Student(330,"Sang",21),
                new Student(400,"Trong",25)
            };

            foreach (var item in lstStudent)
            {
                // item.Display();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
