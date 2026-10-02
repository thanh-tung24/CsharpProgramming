using System;

namespace BaiTap01
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //Yêu cầu người dùng nhập họ lót
            Console.Write("Nhap ho dem: ");
            string surname = Console.ReadLine();

            //Yêu cầu người dùng nhập tên
            Console.Write("Nhap ten: ");
            string name =Console.ReadLine();

            //Nối chuỗi bằng phép cộng chuỗi để xuất ra họ và tên đầy đủ
            string hoVaTen = surname + " " + name;
            Console.WriteLine("Ho va ten cua ban: " +  hoVaTen);
        }
    }
}