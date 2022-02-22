using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Interface
{
    class Document : IStorable
    {
        #region "Thực thi các phương thức từ lớp giao diện IStorable"
        public void Read()
        {
            Console.WriteLine("Doc du lieu tu tai lieu");
        }

        public void Write(object Data)
        {
            Console.WriteLine("Ghi du lieu " + Data + " vao tai lieu");
        }

        #endregion
    }
}
