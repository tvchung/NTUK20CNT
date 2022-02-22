using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Abstract
{
    /// <summary>
    /// Xây dựng lớp trừu tượng
    /// </summary>
    abstract class Person
    {
        // Phương thức thông thường
        public void Speak()
        {
            Console.WriteLine("Mọi người đều nói tiếng việt");
        }
        // Phương thức trừu tượng
        public abstract void DoWork();
        public abstract void EnvironmentWork();
    }
}
