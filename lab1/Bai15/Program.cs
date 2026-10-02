/* Bài 15: Viết các phương thức thành viên sau:
• Nhập mảng gồm n phần tử
• In mảng ra màn hình
• Tìm phần tử lớn nhất và nhỏ nhất trong mảng
• Trả về mảng các số nguyên tố */
using System;

namespace Bai15
{
    public class Program
    {
        // 1. Phương thức nhập mảng gồm n phần tử
        public static void Input(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        // 2. Phương thức in mảng ra màn hình
        public static void Output(int[] arr)
        {
            Console.Write("Mảng vừa nhập là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // 3. Phương thức tìm phần tử lớn nhất trong mảng
        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // Phương thức tìm phần tử nhỏ nhất trong mảng
        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        // Phương thức kiểm tra một số có phải là số nguyên tố hay không
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // 4. Phương thức trả về mảng các số nguyên tố
        public static int[] PrintPrimes(int[] arr)
        {
            // Bước 1: Đếm số lượng số nguyên tố có trong mảng
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    count++;
                }
            }

            // Bước 2: Tạo mảng mới có kích thước đúng bằng số lượng SNT vừa đếm
            int[] primeArray = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primeArray[index] = arr[i];
                    index++;
                }
            }

            return primeArray; // Trả về mảng chứa các số nguyên tố
        }

        // Hàm main thực thi chương trình
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng Numbers có n phần tử
            int[] Numbers = new int[n];

            // Gọi các phương thức nghiệp vụ
            Input(Numbers);
            Output(Numbers);

            Console.WriteLine("Phần tử lớn nhất trong mảng: " + FindMax(Numbers));
            Console.WriteLine("Phần tử nhỏ nhất trong mảng: " + FindMin(Numbers));

            // Lấy mảng các số nguyên tố và in kết quả
            int[] primeNumbers = PrintPrimes(Numbers);
            Console.Write("Các số nguyên tố: ");
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                Console.Write(primeNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}