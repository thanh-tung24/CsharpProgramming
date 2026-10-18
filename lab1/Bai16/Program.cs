/* Bài 16: Nhập vào một mảng họ tên của n người. Hãy sắp xếp mảng đó theo thứ tự tăng dần */
using System;

namespace Bai16
{
    public class Program
    {
        // 1. Phương thức nhập danh sách họ tên của n người
        public static void Input(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập họ tên thứ {i + 1}: ");
                arr[i] = Console.ReadLine(); // Đọc chuỗi họ tên từ bàn phím
            }
        }

        // 2. Phương thức in mảng danh sách họ tên ra màn hình
        public static void Output(string[] arr)
        {
            Console.WriteLine("Danh sách sau khi sắp xếp:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // 3. Phương thức sắp xếp mảng họ tên theo thứ tự tăng dần (A - Z)
        public static void Sort(string[] arr)
        {
            // Sử dụng thuật toán sắp xếp đổi chỗ trực tiếp với hai vòng lặp lồng nhau
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // string.Compare > 0 nghĩa là chuỗi arr[i] đứng sau arr[j] theo bảng mã chữ cái
                    if (string.Compare(arr[i], arr[j]) > 0)
                    {
                        // Đổi chỗ hai phần tử thông qua biến trung gian temp
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập số lượng người từ bàn phím
            Console.Write("Nhập số lượng người: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng chuỗi names có kích thước n phần tử
            string[] names = new string[n];

            // Lần lượt gọi các hàm nghiệp vụ
            Input(names);
            Sort(names);
            Output(names);
        }
    }
}