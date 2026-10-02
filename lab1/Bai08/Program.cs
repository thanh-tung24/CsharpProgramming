/* Bài 8: Xây dựng lớp có phương thức hoán vị hai số thực dùng từ khóa ref */
using System;

namespace BaiTap08
{
    internal class Program
    {
        // Phương thức hoán vị nhận vào hai tham chiếu kiểu double
        public static void HoanVi(ref double a, ref double b)
        {
            double temp = a; // Lưu giá trị ban đầu của a vào biến trung gian
            a = b;           // Gán giá trị của b cho a
            b = temp;        // Gán lại giá trị ban đầu của a cho b
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc thu hai: ");
            double num2 = double.Parse(Console.ReadLine());

            // In giá trị trước khi gọi hàm
            Console.WriteLine("Truoc khi hoan vi: " + num1 + " " + num2);

            // Gọi phương thức hoán vị với từ khóa ref
            HoanVi(ref num1, ref num2);

            // In giá trị sau khi hoán vị để kiểm tra kết quả
            Console.WriteLine("Sau khi hoan vi: " + num1 + " " + num2);
        }
    }
}