using System;
using System.Collections;

namespace Lesson04_ArrayListObject
{
    /// <summary>
    /// Sử dụng ArrayList lưu trữ đối tượng student
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // thêm đối tượng sinh viên vào list
            Student obj = new Student(111, "Hung", 20);
            list.Add(obj);
            obj = new Student(121, "Duung", 22);
            list.Add(obj);
            list.Add(new Student(122, "Sang", 23));
            list.Add(new Student(123, "Trong", 20));
            list.Add(new Student(124, "Minh", 25));
            list.Add(new Student(125, "Hue", 28));

            Output(list);


        }
        static void Output(ArrayList list)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach (Student item in list)
            {
                Console.WriteLine("===================================");
                item.Display();
            }
        }
    }
}
