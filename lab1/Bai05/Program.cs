/* Bài 5: In menu và xử lý các lựa chọn toán học */
using System;

namespace BaiTap05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0; // x và y là số thực nên khai báo kiểu double
            int choice;          // Biến lưu chức năng người dùng chọn

            do
            {
                // In giao diện menu
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                // Đọc lựa chọn và ép sang kiểu số nguyên
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhap gia tri x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Nhap gia tri y: ");
                        y = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"Ket qua {x}^{y} = {Math.Pow(x, y)}");
                        break;

                    case 3:
                        Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                        Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                        break;

                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            } while (choice != 4); // Lặp lại cho đến khi người dùng nhập 4 để thoát
        }
    }
}