using System;

namespace Bai3_2
{
    public interface IMyComparable
    {
        int CompareTo(object obj);
    }

    public class SanPham : IMyComparable
    {
        public string Ten { get; set; }
        public double Gia { get; set; }

        public SanPham(string ten, double gia) { Ten = ten; Gia = gia; }

        public int CompareTo(object obj)
        {
            SanPham sp = obj as SanPham;
            return this.Gia.CompareTo(sp.Gia);
        }

        public override string ToString() => $"{Ten} - {Gia:N0} VNĐ";
    }

    public class SortTool
    {
        // Thuật toán sắp xếp tổng quát qua interface
        public static void MySort(IMyComparable[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        IMyComparable temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
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
            SanPham[] list = new SanPham[]
            {
                new SanPham("Bàn phím", 450000),
                new SanPham("Chuột", 150000),
                new SanPham("Màn hình", 3200000)
            };

            SortTool.MySort(list);

            Console.WriteLine("Danh sách sản phẩm sắp xếp giá tăng dần (bằng Interface):");
            foreach (var sp in list) Console.WriteLine(sp);
        }
    }
}