using System;
using System.Collections;

namespace Lesson04_ArrayListSimple
{
    /// <summary>
    /// ArrayList Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Demo");
            // Khởi tạo đối tượng tập hợp với ArrayList
            ArrayList list = new ArrayList();
            // Thêm phần tử => Sử dụng các phương thức: Add, addRange, Insert; InsetRange
            list.Add("Xin chào");
            list.Add(10);
            // output
            Output(list);
            // Chèn
            list.Insert(1, true);
            // AddRange
            string[] names = { "Long", "Ly", "Quy", "Phuong" };
            list.AddRange(names);

            // output
            Output(list);

            // Xóa phần tử: Remove; RemoveAt; RemoveRange; Clear
            list.Remove("Xin chào");
            Output(list);
            list.RemoveAt(0);
            Output(list);
            list.RemoveRange(0, 2);
            Output(list);

            // add
            list.AddRange(names);
            Output(list);

            // sắp xếp
            list.Sort();
            Output(list);
            list.Sort(new CaseInsensitiveComparer());

            // Tìm kiếm: IndexOf / LastIndexOf / Contain
            if (list.IndexOf("Lyy") > 0)
            {
                Console.WriteLine("Có tìm thấy");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        // output
        static void Output(ArrayList list)
        {
            Console.WriteLine("Danh sach:");
            foreach (var item in list)
            {
                Console.WriteLine("\t " + item);
            }
        }
    }
}
