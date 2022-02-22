using System;

namespace Lesson03_Abstract
{
    class Program
    {
        /// <summary>
        /// test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Speak();
            emp.DoWork();
            emp.EnvironmentWork();
        }

    }
}
