using System;

namespace Lesson02_Lab02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tam giac sao:\n");
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
