using System;

namespace Lesson02_NhapXuat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b, c;

            Console.Write("Nhap a=");
            a =Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b =");
            b = int.Parse(Console.ReadLine());

            c = a + b;
            Console.WriteLine("\n {0} + {1} = {2}", a, b, c);
            Console.WriteLine("\n {2} ={1} + {0}", a, b, c);


            // if
            if(c%2 == 0)
            {
                Console.WriteLine("{0} là số chẵn",c);
            }

            // if .. else
            if (c % 2 == 0)
            {
                Console.WriteLine("{0} là số chẵn", c);
            }
            else
            {
                Console.WriteLine("{0} là số le", c);
            }

            // switch

            // loop: for, do...while, while, foreach
            Console.WriteLine("day cac so <={0}", a);
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("So thu {0}", i);
            }

            string[] names = { "hung", "dung", "sang", "trong" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
