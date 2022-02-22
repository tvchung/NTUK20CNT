using System;

namespace Lesson03_Interface
{
    class Program
    {
        /// <summary>
        /// test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Read();
            doc.Write("ABC");
        }
    }
}
