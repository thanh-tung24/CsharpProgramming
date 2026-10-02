/* Bài 1.2: Thiết kế lớp Point
- Field: x, y
- Property: X, Y
- Constructor: default khởi tạo x = 0, y = 0
- Method: Input, Output, override ToString()
- Phép toán: +, -, lấy âm (-)
- Tính khoảng cách và trung điểm theo 2 cách: phương thức thành viên và phương thức tĩnh */
using System;

namespace Bai1_2
{
    public class Point
    {
        // 1. Fields
        private double x;
        private double y;

        // 2. Properties
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // 3. Constructors
        // Default constructor khởi tạo x và y bằng 0
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Parameterized constructor hỗ trợ khởi tạo nhanh
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Copy constructor
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        // 4. Methods: Input / Output
        public void Input()
        {
            Console.Write("Nhập hoành độ x: ");
            X = double.Parse(Console.ReadLine()); // Gán qua Property
            Console.Write("Nhập tung độ y: ");
            Y = double.Parse(Console.ReadLine()); // Gán qua Property
        }

        public void Output()
        {
            Console.WriteLine($"({x}, {y})");
        }

        // Override hàm ToString() để xuất Point
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // 5. Overload operators: +, -, lấy âm (-)
        // Toán tử hai ngôi: cộng hai điểm
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        // Toán tử hai ngôi: trừ hai điểm
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        // Toán tử một ngôi: lấy âm điểm (-Point)
        public static Point operator -(Point p)
        {
            return new Point(-p.x, -p.y);
        }

        // 6. Khoảng cách giữa 2 điểm (2 CÁCH)
        // Cách 1: Phương thức thành viên (Instance Method)
        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
        }

        // Cách 2: Phương thức tĩnh (Static Method)
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        // 7. Trung điểm của 2 điểm (2 CÁCH)
        // Cách 1: Phương thức thành viên (Instance Method)
        public Point MidPointTo(Point other)
        {
            return new Point((this.x + other.x) / 2.0, (this.y + other.y) / 2.0);
        }

        // Cách 2: Phương thức tĩnh (Static Method)
        public static Point MidPoint(Point p1, Point p2)
        {
            return new Point((p1.x + p2.x) / 2.0, (p1.y + p2.y) / 2.0);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== NHẬP TỌA ĐỘ ĐIỂM A ===");
            Point A = new Point();
            A.Input();

            Console.WriteLine("\n=== NHẬP TỌA ĐỘ ĐIỂM B ===");
            Point B = new Point();
            B.Input();

            Console.WriteLine("\n--- THÔNG TIN VỪA NHẬP ---");
            Console.WriteLine("Điểm A: " + A.ToString());
            Console.WriteLine("Điểm B: " + B.ToString());

            Console.WriteLine("\n--- KIỂM TRA ĐA NĂNG TOÁN TỬ ---");
            Point sum = A + B;
            Point diff = A - B;
            Point negA = -A;
            Console.WriteLine($"A + B = {sum}");
            Console.WriteLine($"A - B = {diff}");
            Console.WriteLine($"-A    = {negA}");

            Console.WriteLine("\n--- TÍNH KHOẢNG CÁCH GIỮA A VÀ B ---");
            // Cách 1: Phương thức thành viên
            double distMember = A.DistanceTo(B);
            Console.WriteLine($"[Phương thức thành viên] Khoảng cách AB = {distMember:F2}");
            // Cách 2: Phương thức tĩnh
            double distStatic = Point.Distance(A, B);
            Console.WriteLine($"[Phương thức tĩnh]       Khoảng cách AB = {distStatic:F2}");

            Console.WriteLine("\n--- TÌM TRUNG ĐIỂM I CỦA AB ---");
            // Cách 1: Phương thức thành viên
            Point midMember = A.MidPointTo(B);
            Console.WriteLine($"[Phương thức thành viên] Trung điểm I = {midMember}");
            // Cách 2: Phương thức tĩnh
            Point midStatic = Point.MidPoint(A, B);
            Console.WriteLine($"[Phương thức tĩnh]       Trung điểm I = {midStatic}");
        }
    }
}