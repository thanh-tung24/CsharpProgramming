/* Bài 9. Tham chiếu out
Xây dựng lớp có phương thức tìm giá trị lớn nhất và giá trị nhỏ nhất của ba số thực. */
using System;

namespace bai09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào ba số thực từ bàn phím
            Console.Write("Nhap so thuc thu nhat: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc thu hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc thu ba: ");
            double c = double.Parse(Console.ReadLine());

            // Khai báo hai biến max và min để hứng giá trị trả về từ phương thức
            double max, min;

            // Gọi phương thức FindMaxMin và truyền vào hai tham số out
            FindMaxMin(a, b, c, out max, out min);

            // Xuất kết quả lớn nhất và nhỏ nhất ra màn hình
            Console.WriteLine($"Gia tri lon nhat: {max}");
            Console.WriteLine($"Gia tri nho nhat: {min}");
        }

        // Phương thức nhận vào 3 số thực và gán kết quả cho 2 tham chiếu out
        static void FindMaxMin(double x, double y, double z, out double max, out double min)
        {
            // Tìm giá trị lớn nhất bằng cách lồng hàm Math.Max
            max = Math.Max(x, Math.Max(y, z));

            // Tìm giá trị nhỏ nhất bằng cách lồng hàm Math.Min
            min = Math.Min(x, Math.Min(y, z));
        }
    }
}