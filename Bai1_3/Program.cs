/* Bài 1.3: Xây dựng lớp Person
- Dữ liệu thành viên: id, name, yob (năm sinh), yod (năm mất)
- Constructor: Default Constructor, Copy Constructor
- Method: Input(), Output(), IsLiving() */
using System;

namespace Bai1_3
{
    public class Person
    {
        // 1. Fields
        private string id;
        private string name;
        private int yob;
        private int yod;

        // 2. Properties
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

        public int Yob
        {
            get { return yob; }
            set { yob = value; }
        }

        public int Yod
        {
            get { return yod; }
            set { yod = value; }
        }

        // 3. Constructors
        // Default Constructor: khởi tạo giá trị mặc định
        public Person()
        {
            id = string.Empty;
            name = string.Empty;
            yob = 0;
            yod = 0; // 0 nghĩa là người đó vẫn còn sống
        }

        // Parameterized Constructor
        public Person(string id, string name, int yob, int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }

        // Copy Constructor: khởi tạo từ một đối tượng Person khác
        public Person(Person other)
        {
            this.id = other.id;
            this.name = other.name;
            this.yob = other.yob;
            this.yod = other.yod;
        }

        // 4. Methods
        // Phương thức kiểm tra còn sống hay không: yod == 0 -> true, yod != 0 -> false
        public bool IsLiving()
        {
            return yod == 0;
        }

        // Nhập thông tin Person
        public void Input()
        {
            Console.Write("Nhập mã định danh (ID): ");
            id = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();

            Console.Write("Nhập năm sinh (YOB): ");
            yob = int.Parse(Console.ReadLine());

            Console.Write("Nhập năm mất (YOD - nhập 0 nếu còn sống): ");
            yod = int.Parse(Console.ReadLine());
        }

        // Xuất thông tin Person
        public void Output()
        {
            Console.WriteLine($"[ID: {id}] - Họ tên: {name} | Năm sinh: {yob} | " +
                (IsLiving() ? "Tình trạng: Còn sống" : $"Năm mất: {yod} (Đã mất)"));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== NHẬP THÔNG TIN PERSON 1 ===");
            Person p1 = new Person();
            p1.Input();

            Console.WriteLine("\n=== THỬ NGHIỆM COPY CONSTRUCTOR CHO PERSON 2 ===");
            // Tạo đối tượng p2 sao chép từ p1
            Person p2 = new Person(p1);
            Console.WriteLine("Thông tin của Person 2 (sao chép từ Person 1):");
            p2.Output();

            Console.WriteLine("\n=== KẾT QUẢ KIỂM TRA TRẠNG THÁI (IsLiving) ===");
            Console.WriteLine($"Người thứ nhất {(p1.IsLiving() ? "hiện vẫn còn sống" : "đã mất")}.");
        }
    }
}