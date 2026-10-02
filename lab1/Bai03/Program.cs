using System;

namespace BaiTap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên x
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine()); // Ép kiểu chuỗi sang số nguyên int

            // Nhập số nguyên y
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine()); // Ép kiểu chuỗi sang số nguyên int

            // Tính x lũy thừa y bằng hàm Math.Pow
            double ketQua = Math.Pow(x, y);

            // Xuất kết quả theo đúng định dạng đề bài yêu cầu
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}