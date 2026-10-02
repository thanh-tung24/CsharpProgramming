using System;

namespace Bai3_3
{
    // Định nghĩa delegate so sánh 2 đối tượng kiểu generic T
    public delegate int CompareDelegate<T>(T a, T b);

    public class SortHelper
    {
        public static void BubbleSort<T>(T[] arr, CompareDelegate<T> compare)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers = { 42, 12, 88, 3, 25 };

            // Truyền biểu thức lambda khớp với delegate
            SortHelper.BubbleSort(numbers, (a, b) => a.CompareTo(b));

            Console.WriteLine("Mảng số nguyên sắp xếp tăng dần bằng Delegate:");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
