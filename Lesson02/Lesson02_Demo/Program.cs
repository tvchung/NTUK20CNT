using System;

namespace Lesson02_Demo
{
    class Student
    {
        // field
        private string id;
        private string name;
        private double mark1, mark2, mark3;
        // khai báo thuộc tính
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public double Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public double Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

        // Phương thức hiển thị, không có tham số đầu vào, không có giá trị trả về xác định
        public void Display()
        {
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Mark1 {0} \n Mark2 {1} \n Mark3 {2} ", Mark1, Mark2, Mark3);
        }
        // Phương thức không tham số, có giá trị trả về
        public double Average()
        {
            double avg = (Mark1 + Mark2 + Mark3) / 3;
            return avg;
        }
        // Phương thức có tham số, có giá trị trả về
        public int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Khởi tạo đối tượng
            Student st = new Student();
            // truy xuất thuộc tính
            st.Id = "SV01";
            // truy xuất đến trường
            st.name = "Chung Trinh";
            st.mark1 = 9;
            st.mark2 = 8;
            st.mark3 = 9;

            // gọi phương thức
            st.Display();
            // gọi phương thức có trả về giá trị
            double tb = st.Average();
            Console.WriteLine("Diem trung binh: " + tb);

            Console.WriteLine("Tong = " + st.Add(100, 200));
        }
    }
}
