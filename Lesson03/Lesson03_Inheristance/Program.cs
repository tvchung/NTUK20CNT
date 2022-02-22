using System;

namespace Lesson03_Inheristance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat c = new Cat();
            c.Actions(); // gọi từ lớp Cat
            c.Eat(); // gọi thông qua sự thừa kế
            c.DoSomething(); // gọi thông qua sự thừa kế
            c.Show();

            //Console.WriteLine(c.food); // không truy xuất được

            Canime can = new Canime();
            can.Display();

        }
    }
}
