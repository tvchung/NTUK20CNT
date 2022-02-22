using System;

namespace Lesson02_Lab02._04
{
    /// <summary>
    /// Lab02.4: Viết chương trình in ra các số tổng 3 ký số là chẵn từ 100-999.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab02.4: Viết chương trình in ra các số tổng 3 ký số là chẵn từ 100-999.");
            for (int i = 100; i <= 999; i++)
            {
                int so1 = i / 100;
                int so2 = (i / 10) % 10; // 153; 153/10 = 15; 15%10 = 5
                int so3 = i % 100; // 153%100 = 3

                int tong = so1 + so2 + so3;
                if(tong%2 == 0)
                {
                    Console.Write("  {0};  ", i);
                }
            }
        }
    }
}
