/* Bài 13. Nhập xuất thông tin sinh viên
Xây dựng lớp sinh viên để lưu trữ 1 sinh viên (mã sinh viên, họ tên, địa chỉ, sinh viên năm thứ mấy). Hãy nhập xuất 1 sinh viên. */
using System;

namespace Bai13
{
    // Xây dựng lớp SinhVien để quản lý dữ liệu đối tượng
    class SinhVien
    {
        // Khai báo các thuộc tính tự động (Auto-implemented properties)
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int NamThu { get; set; }

        // Phương thức thành viên dùng để nhập thông tin sinh viên
        public void NhapThongTin()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSinhVien = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhập năm thứ mấy: ");
            NamThu = int.Parse(Console.ReadLine()); // Ép kiểu chuỗi sang số nguyên
        }

        // Phương thức thành viên dùng để xuất thông tin sinh viên ra màn hình
        public void XuatThongTin()
        {
            Console.WriteLine("Mã sinh viên: " + MaSinhVien);
            Console.WriteLine("Họ tên:       " + HoTen);
            Console.WriteLine("Địa chỉ:      " + DiaChi);
            Console.WriteLine("Năm thứ mấy:  " + NamThu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một đối tượng sinh viên cụ thể từ lớp SinhVien
            SinhVien sv = new SinhVien();

            // Gọi các phương thức thành viên để thực thi việc nhập và xuất
            sv.NhapThongTin();
            sv.XuatThongTin();
        }
    }
}