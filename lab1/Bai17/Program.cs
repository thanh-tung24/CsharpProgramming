/* Bài 17: Viết các phương thức thành viên sau:
• Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100] (n,m nhập từ bàn phím)
• In mảng ra màn hình
• Trả về hai mảng: mảng các số chẵn và mảng các số lẻ */
using System;

namespace Bai17
{
    public class Program
    {
        // 1. Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100]
        public static void Input(int[,] arr)
        {
            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random random = new Random();

            // Duyệt qua từng dòng của mảng hai chiều
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Duyệt qua từng cột của mảng hai chiều
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Sinh số ngẫu nhiên trong đoạn [10, 100] (cận trên là 101)
                    arr[i, j] = random.Next(10, 101);
                }
            }
        }

        // 2. In mảng hai chiều ra màn hình theo cấu trúc ma trận
        public static void Output(int[,] arr)
        {
            Console.WriteLine("Mảng vừa sinh là:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // In phần tử cách nhau bởi dấu tab (\t) để căn cột thẳng hàng
                    Console.Write(arr[i, j] + "\t");
                }
                // Xuống dòng sau khi in hết một hàng của ma trận
                Console.WriteLine();
            }
        }

        // 3. Trả về hai mảng: mảng số chẵn và mảng số lẻ dùng tham chiếu out
        public static void GetEvenOdd(int[,] arr, out int[] even, out int[] odd)
        {
            int evenCount = 0; // Đếm số lượng phần tử chẵn
            int oddCount = 0;  // Đếm số lượng phần tử lẻ

            // Vòng lặp đợt 1: Thống kê số lượng số chẵn và số lẻ
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }

            // Cấp phát kích thước chính xác cho hai mảng kết quả
            even = new int[evenCount];
            odd = new int[oddCount];

            int evenIndex = 0; // Chỉ số mảng chẵn
            int oddIndex = 0;  // Chỉ số mảng lẻ

            // Vòng lặp đợt 2: Đưa các phần tử chẵn/lẻ vào đúng mảng tương ứng
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        even[evenIndex] = arr[i, j];
                        evenIndex++;
                    }
                    else
                    {
                        odd[oddIndex] = arr[i, j];
                        oddIndex++;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập số dòng và số cột của ma trận
            Console.Write("Nhập số dòng n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột m: ");
            int m = int.Parse(Console.ReadLine());

            // Khởi tạo mảng hai chiều A[n, m]
            int[,] A = new int[n, m];

            // Gọi hàm sinh ngẫu nhiên và hàm in ma trận
            Input(A);
            Output(A);

            // Gọi phương thức phân tách số chẵn và số lẻ
            GetEvenOdd(A, out int[] even, out int[] odd);

            // Xuất danh sách các số chẵn
            Console.Write("\nMảng các số chẵn: ");
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }

            // Xuất danh sách các số lẻ
            Console.Write("\nMảng các số lẻ: ");
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine();
        }
    }
}