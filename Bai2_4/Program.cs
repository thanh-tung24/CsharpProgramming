using System;

namespace Bai2_4_Mang2Chieu
{
    public class Mang2Chieu
    {
        private int[,] a;
        private int rows;
        private int cols;

        // Constructor mặc định
        public Mang2Chieu()
        {
            rows = 0;
            cols = 0;
            a = new int[0, 0];
        }

        // Constructor có tham số
        public Mang2Chieu(int n, int m)
        {
            rows = n;
            cols = m;
            a = new int[n, m];
        }

        // Indexer 2 chiều
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        // Nhập ma trận
        public void Nhap()
        {
            Console.Write("Nhập số hàng n: ");
            rows = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập số cột m: ");
            cols = int.Parse(Console.ReadLine() ?? "0");

            a = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }

        // Xuất ma trận
        public void Xuat()
        {
            Console.WriteLine("\nMa trận:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // Kiểm tra số nguyên tố
        private bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        // Tìm số nguyên tố
        public void TimSoNguyenTo()
        {
            Console.Write("\nCác số nguyên tố trong ma trận: ");

            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (IsPrime(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.Write("Không có");
            }

            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Mang2Chieu m = new Mang2Chieu();

            m.Nhap();
            m.Xuat();
            m.TimSoNguyenTo();

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}