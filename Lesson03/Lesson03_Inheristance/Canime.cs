using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheristance
{
    /// <summary>
    /// Lớp con, lớp dẫn xuất từ lớp Animal
    /// </summary>
    class Canime:Animal
    {
        public Canime():base("Lion") // gọi constructor từ lớp cơ sở
        {
            Console.WriteLine("Lớp Canime");
        }
    }
}
