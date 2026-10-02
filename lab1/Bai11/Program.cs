/* Bài 11: Viết phương thức thành viên trả về chuỗi là đảo của một chuỗi */
using System;

namespace bai11
{
    public class Program
    {
        // Phương thức nhận vào một chuỗi và trả về chuỗi đảo ngược
        public static string ChuoiDaoNguoc(string str)
        {
            char[] charArray = str.ToCharArray(); // Chuyển đổi chuỗi thành mảng các ký tự
            Array.Reverse(charArray);             // Sử dụng hàm có sẵn để đảo ngược thứ tự các phần tử mảng
            return new string(charArray);         // Gom mảng ký tự đã đảo ngược thành chuỗi mới và trả về
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine(); // Đọc chuỗi nhập vào từ bàn phím

            // Gọi phương thức ChuoiDaoNguoc để xử lý đảo chuỗi
            string ketQua = ChuoiDaoNguoc(str);

            // Xuất kết quả chuỗi đã đảo ra màn hình
            Console.WriteLine("Chuỗi đảo ngược: " + ketQua);
        }
    }
}