using System;

namespace Lesson03_NapChong
{
    /// <summary>
    /// Nạp chồng phương thức
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong thuc nap chon!");
            int sum = NapChong.Sum(10);
            Console.WriteLine("Sum = " + sum);
            sum = NapChong.Sum(10,20);
            Console.WriteLine("Sum = " + sum);


            int a = NapChong.Add(10, 20);
            Console.WriteLine("Add:" + a);
            double b = NapChong.Add(10.1, 20.1);
            Console.WriteLine("Add:" + b);
        }
    }

    /// <summary>
    /// Nạp chồng phương thức
    /// - Có cùng tên
    /// - Khác nhau về số lượng tham số
    /// - Khác nhau về kiểu dữ liệu
    /// </summary>
    class NapChong
    {
        // properties (Không có)

        // Method:
        public static int Sum(int a)
        {
            int s = 0;
            for (int i = 0; i <= a; i++)
            {
                s += i;
            }
            return s;
        }
        public static int Sum(int a, int b)
        {
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s += i;
            }
            return s;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
