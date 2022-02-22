using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Abstract
{
    /// <summary>
    /// Lớp dẫn xuất, triển khai kế thừa từ lớp trừu tượng
    /// </summary>
    class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Làm việc....");
        }

        public override void EnvironmentWork()
        {
            Console.WriteLine("Làm việc tại môi trường....");
        }
    }
}
