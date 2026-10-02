using System;

namespace BaiTap04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Nhập và kiểm tra số nguyên x
            Console.Write("Nhap so nguyen x: ");
            string strX = Console.ReadLine();
            // Sử dụng int.TryParse để kiểm tra tính hợp lệ
            if (!int.TryParse(strX, out int x))
            {
                Console.WriteLine("Loi: x khong phai la so nguyen!");
                return; // Thoát chương trình nếu x không hợp lệ
            }

            // 2. Nhập và kiểm tra số nguyên y
            Console.Write("Nhap so nguyen y: ");
            string strY = Console.ReadLine();
            // Kiểm tra tính hợp lệ của y
            if (!int.TryParse(strY, out int y))
            {
                Console.WriteLine("Loi: y khong phai la so nguyen!");
                return; // Thoát chương trình nếu y không hợp lệ
            }

            // 3. Tính toán và in kết quả nếu cả hai đều là số nguyên
            double ketQua = Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}