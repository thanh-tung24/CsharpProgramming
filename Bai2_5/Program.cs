using System;
using System.Collections.Generic;

namespace Bai2_5_PhongBan
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Nhập mức lương: "); MucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày vắng: "); SoNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong() => MucLuong - (SoNgayVang * 100000);
    }

    public class PhongBan
    {
        private List<NhanVien> danhSach = new List<NhanVien>();

        public void Nhap()
        {
            Console.Write("Nhập số lượng nhân viên trong phòng ban: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhân viên thứ {i + 1} ---");
                NhanVien nv = new NhanVien();
                nv.Nhap();
                danhSach.Add(nv);
            }
        }

        public double TongLuongPhongBan()
        {
            double sum = 0;
            foreach (var nv in danhSach) sum += nv.TinhLuong();
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PhongBan pb = new PhongBan();
            pb.Nhap();
            Console.WriteLine($"\n=> TỔNG LƯƠNG PHÒNG BAN: {pb.TongLuongPhongBan():N0} VNĐ");
        }
    }
}
