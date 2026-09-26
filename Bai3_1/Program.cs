using System;

namespace Bai3_1
{
    public class SinhVien : IComparable<SinhVien>
    {
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string ten, double dtb) { HoTen = ten; DiemTB = dtb; }

        // Cài đặt hàm CompareTo của interface IComparable
        public int CompareTo(SinhVien other)
        {
            // Sắp xếp điểm trung bình tăng dần
            return this.DiemTB.CompareTo(other.DiemTB);
        }

        public override string ToString() => $"{HoTen} - ĐTB: {DiemTB}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SinhVien[] arr = new SinhVien[]
            {
                new SinhVien("An", 7.5),
                new SinhVien("Binh", 9.0),
                new SinhVien("Cuong", 6.0)
            };

            // Gọi phương thức tĩnh của thư viện .NET
            Array.Sort(arr);

            Console.WriteLine("Danh sách sau khi Array.Sort (theo Điểm TB tăng dần):");
            foreach (var sv in arr) Console.WriteLine(sv);
        }
    }
}