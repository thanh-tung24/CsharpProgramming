using System;
using System.Collections.Generic;

namespace Bai3_5
{
    public abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Mã NV: "); MaNV = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
        }

        // Phương thức trừu tượng để mỗi lớp con tự đa hình công thức tính lương
        public abstract double TinhLuong();

        public virtual void Xuat() =>
            Console.WriteLine($"[{MaNV}] {HoTen} | Lương: {TinhLuong():N0} VNĐ");
    }

    public class NhanVienKinhDoanh : NhanVien
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Lương cơ bản: "); LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Số hợp đồng ký được: "); SoHopDong = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong() => LuongCoBan + (SoHopDong * 500000);
    }

    public class NhanVienSanXuat : NhanVien
    {
        public int SoLuongSanPham { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số lượng sản phẩm: "); SoLuongSanPham = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            double luong = SoLuongSanPham * 1000.0;
            if (SoLuongSanPham > 3000) luong += luong * 0.05; // Thưởng 5%
            return luong;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<NhanVien> ds = new List<NhanVien>();

            Console.WriteLine("Nhập thông tin Nhân viên Kinh doanh:");
            NhanVienKinhDoanh nvkd = new NhanVienKinhDoanh();
            nvkd.Nhap();
            ds.Add(nvkd);

            Console.WriteLine("\nNhập thông tin Nhân viên Sản xuất:");
            NhanVienSanXuat nvsx = new NhanVienSanXuat();
            nvsx.Nhap();
            ds.Add(nvsx);

            Console.WriteLine("\n--- DANH SÁCH LƯƠNG NHÂN VIÊN ---");
            foreach (var nv in ds) nv.Xuat();
        }
    }
}
