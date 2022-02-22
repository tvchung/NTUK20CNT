using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheristance
{
    /// <summary>
    /// Lớp con, lớp dẫn xuất, kế thừa từ lớp cha (Animal)
    /// </summary>
    class Cat:Animal
    {

        public void Actions()
        {
            Eat(); // Gọi từ lớp animal
            DoSomething(); // Gọi từ lớp animal
        }

        public void Show()
        {
            Console.WriteLine("Meo an :" + food);
            Console.WriteLine("Meo:" + activity);
        }
    }
}
