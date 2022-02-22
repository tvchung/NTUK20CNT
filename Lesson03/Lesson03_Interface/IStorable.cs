using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Interface
{
    /// <summary>
    /// Lớp giao diện
    /// </summary>
    interface IStorable
    {
        void Read();
        void Write(Object Data);
    }
}
