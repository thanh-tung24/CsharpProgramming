using System;

namespace BaiTap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập họ tên từ bàn phím 
            Console.Write("Nhap ho ten cua ban: ");
            string hoTen = Console.ReadLine();

            // In lời chào theo định dạng đề bài yêu cầu
            Console.WriteLine("Chao ban " + hoTen + "!");
        }
    }
}