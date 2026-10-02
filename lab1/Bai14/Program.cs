/* Bài 14. Tính lương 1 nhân viên
Viết chương trình nhập thông tin một nhân viên (họ tên, mức lương, số ngày vắng). 
Tính và xuất lương của nhân viên, biết rằng một ngày vắng sẽ bị trừ 100.000 VNĐ. */
using System;

namespace Bai14
{
    class NhanVien
    {
        // Các thuộc tính lưu trữ thông tin nhân viên
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;

        // Phương thức thành viên dùng để nhập thông tin
        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập mức lương (VNĐ): ");
            MucLuong = double.Parse(Console.ReadLine()); // Ép kiểu chuỗi sang double

            Console.Write("Nhập số ngày vắng: ");
            SoNgayVang = int.Parse(Console.ReadLine());   // Ép kiểu chuỗi sang int
        }

        // Phương thức tính toán số lương thực nhận sau khi trừ ngày vắng
        public double TinhLuong()
        {
            return MucLuong - (SoNgayVang * 100000);
        }

        // Phương thức thành viên dùng để xuất thông tin chi tiết
        public void Xuat()
        {
            Console.WriteLine("\n--- THÔNG TIN LƯƠNG NHÂN VIÊN ---");
            Console.WriteLine($"Họ tên:          {HoTen}");
            // Sử dụng định dạng :N0 để tự động phân cách hàng nghìn cho số tiền
            Console.WriteLine($"Mức lương gốc:   {MucLuong:N0} VNĐ");
            Console.WriteLine($"Số ngày vắng:    {SoNgayVang}");
            Console.WriteLine($"Lương thực nhận: {TinhLuong():N0} VNĐ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font chữ UTF-8 để hiển thị tiếng Việt có dấu trong Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo đối tượng nhân viên từ lớp NhanVien
            NhanVien nv = new NhanVien();

            // Gọi các phương thức thành viên nhập và xuất
            nv.Nhap();
            nv.Xuat();
        }
    }
}