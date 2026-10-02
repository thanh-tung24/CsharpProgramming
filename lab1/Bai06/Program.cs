/* Bài 7: Xây dựng lớp có phương thức bool kiểm tra số nguyên tố */
using System;

namespace BaiTap07
{
    internal class Program
    {
        // Phương thức kiểu bool trả về true nếu n là SNT, ngược lại trả về false
        public static bool IsPrime(int n)
        {
            // Số nguyên tố phải lớn hơn 1
            if (n <= 1) return false;

            // Kiểm tra các ước số từ 2 đến căn bậc hai của n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) // Nếu chia hết thì n là hợp số
                {
                    return false;
                }
            }
            return true; // Không chia hết cho số nào thì là SNT
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            // Gọi phương thức IsPrime và in kết quả tương ứng
            if (IsPrime(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}