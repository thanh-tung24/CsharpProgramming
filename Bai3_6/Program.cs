using System;
using System.Collections.Generic;

namespace Bai3_6
{
    public abstract class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Số báo danh: "); SBD = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Điểm bài 1: "); Bai1 = double.Parse(Console.ReadLine());
            Console.Write("Điểm bài 2: "); Bai2 = double.Parse(Console.ReadLine());
            Console.Write("Điểm bài 3: "); Bai3 = double.Parse(Console.ReadLine());
        }

        public abstract double TongDiem();

        public virtual void Xuat() =>
            Console.WriteLine($"[{SBD}] {HoTen} | Tổng điểm: {TongDiem()}");
    }

    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Tiếng Anh: "); TiengAnh = double.Parse(Console.ReadLine());
        }

        public override double TongDiem()
        {
            double tong = Bai1 + Bai2 + Bai3;
            if (TiengAnh >= 7 && TiengAnh <= 8) tong += 1;
            else if (TiengAnh >= 9 && TiengAnh <= 10) tong += 2;
            return tong;
        }
    }

    public class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm CSDL: "); CSDL = double.Parse(Console.ReadLine());
        }

        public override double TongDiem() => Bai1 + Bai2 + Bai3 + CSDL;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<ThiSinh> cuocThi = new List<ThiSinh>();

            Console.WriteLine("=== NHẬP THÍ SINH CHUYÊN ===");
            ThiSinh c = new ThiSinhChuyen();
            c.Nhap();
            cuocThi.Add(c);

            Console.WriteLine("\n=== NHẬP THÍ SINH SIÊU CÚP ===");
            ThiSinh sc = new ThiSinhSieuCup();
            sc.Nhap();
            cuocThi.Add(sc);

            Console.WriteLine("\n--- KẾT QUẢ ĐIỂM THI ---");
            foreach (var ts in cuocThi) ts.Xuat();
        }
    }
}