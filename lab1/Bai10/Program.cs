/* Bài 10: Viết phương thức thành viên kiểm tra chuỗi có đối xứng hay không */
using System;

namespace bai10
{
    class Program
    {
        // Phương thức kiểm tra đối xứng trả về true nếu đối xứng, ngược lại trả về false
        public static bool ChuoiDoiXung(string str)
        {
            int left = 0;               // Chỉ số bắt đầu từ đầu chuỗi
            int right = str.Length - 1; // Chỉ số bắt đầu từ cuối chuỗi

            // Lặp cho đến khi hai chỉ số gặp nhau ở giữa chuỗi
            while (left < right)
            {
                // Nếu phát hiện hai ký tự đối xứng khác nhau thì không phải chuỗi đối xứng
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;  // Tăng chỉ số bên trái
                right--; // Giảm chỉ số bên phải
            }

            // Nếu duyệt hết mà tất cả các cặp ký tự đều khớp nhau thì là chuỗi đối xứng
            return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine(); // Đọc chuỗi ký tự từ bàn phím

            // Gọi phương thức ChuoiDoiXung để kiểm tra kết quả
            if (ChuoiDoiXung(str))
            {
                Console.WriteLine("Chuỗi đối xứng");
            }
            else
            {
                Console.WriteLine("Chuỗi không đối xứng");
            }
        }
    }
}