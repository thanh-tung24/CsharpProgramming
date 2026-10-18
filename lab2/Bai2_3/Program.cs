using System;

namespace Bai2_3_Mang1Chieu
{
    public class DaySo
    {
        private int[] data;

        public DaySo() { data = new int[0]; }
        public DaySo(int n) { data = new int[n]; }
        public DaySo(DaySo other)
        {
            data = new int[other.data.Length];
            Array.Copy(other.data, data, other.data.Length);
        }

        public int Length => data.Length;

        // Indexer
        public int this[int i]
        {
            get => data[i];
            set => data[i] = value;
        }

        public void Nhap()
        {
            Console.Write("Nhập số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            data = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử [{i}]: ");
                data[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Dãy số: " + string.Join(" ", data));
        }

        public void TimSoChan()
        {
            Console.Write("Các số chẵn trong dãy: ");
            bool found = false;
            foreach (int x in data)
            {
                if (x % 2 == 0) { Console.Write(x + " "); found = true; }
            }
            if (!found) Console.Write("Không có");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DaySo ds = new DaySo();
            ds.Nhap();
            ds.Xuat();
            ds.TimSoChan();
        }
    }
}
