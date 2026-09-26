using System;
using System.Collections.Generic;

namespace Bai3_6
{
    // =========================================================================
    // 1. LỚP CƠ SỞ TRỪU TƯỢNG (Abstract Base Class): Quản lý thông tin chung
    // =========================================================================
    public abstract class ThiSinh
    {
        // Các thuộc tính cơ bản chung của tất cả thí sinh tham gia cuộc thi
        public string SBD { get; set; }        // Số báo danh
        public string HoTen { get; set; }      // Họ và tên
        public double Bai1 { get; set; }       // Điểm bài thi lập trình 1
        public double Bai2 { get; set; }       // Điểm bài thi lập trình 2
        public double Bai3 { get; set; }       // Điểm bài thi lập trình 3

        // Phương thức ảo (virtual) cho phép các lớp con tái sử dụng và mở rộng nhập liệu
        public virtual void Nhap()
        {
            Console.Write("Số báo danh: ");
            SBD = Console.ReadLine();

            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Điểm bài 1: ");
            Bai1 = double.Parse(Console.ReadLine());

            Console.Write("Điểm bài 2: ");
            Bai2 = double.Parse(Console.ReadLine());

            Console.Write("Điểm bài 3: ");
            Bai3 = double.Parse(Console.ReadLine());
        }

        // Phương thức trừu tượng (abstract): Bắt buộc các lớp con kế thừa phải tự định nghĩa
        // công thức tính tổng điểm theo quy chế riêng của từng đối tượng thi đấu
        public abstract double TongDiem();

        // Phương thức xuất thông tin và gọi hàm tính tổng điểm (áp dụng tính đa hình tại runtime)
        public virtual void Xuat() =>
            Console.WriteLine($"[{SBD}] {HoTen} | Tổng điểm: {TongDiem()}");
    }

    // =========================================================================
    // 2. LỚP DẪN XUẤT 1: Thí sinh khối Chuyên (Dành cho người chưa từng đoạt giải)
    // =========================================================================
    public class ThiSinhChuyen : ThiSinh
    {
        // Thuộc tính riêng: Điểm thi môn Tiếng Anh dùng để xét điểm cộng
        public double TiengAnh { get; set; }

        // Ghi đè phương thức nhập: Gọi lại base.Nhap() của lớp cha rồi nhập thêm điểm Tiếng Anh
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Tiếng Anh: ");
            TiengAnh = double.Parse(Console.ReadLine());
        }

        // Ghi đè hàm tính tổng điểm:
        // Điểm = (Tổng 3 bài lập trình) + Điểm thưởng Tiếng Anh (nếu có)
        // Quy tắc thưởng: 7 <= TA <= 8 cộng 1 điểm; 9 <= TA <= 10 cộng 2 điểm
        public override double TongDiem()
        {
            double tong = Bai1 + Bai2 + Bai3;

            if (TiengAnh >= 7 && TiengAnh <= 8)
                tong += 1;
            else if (TiengAnh >= 9 && TiengAnh <= 10)
                tong += 2;

            return tong;
        }
    }

    // =========================================================================
    // 3. LỚP DẪN XUẤT 2: Thí sinh Siêu cúp (Dành cho người đã từng đoạt giải)
    // =========================================================================
    public class ThiSinhSieuCup : ThiSinh
    {
        // Thuộc tính riêng: Điểm thi môn Cơ sở dữ liệu (CSDL) tính trực tiếp vào điểm tổng
        public double CSDL { get; set; }

        // Ghi đè phương thức nhập: Tái sử dụng base.Nhap() và nhập thêm điểm CSDL
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm CSDL: ");
            CSDL = double.Parse(Console.ReadLine());
        }

        // Ghi đè hàm tính tổng điểm: Tổng trực tiếp cả 4 môn thi (3 bài lập trình + 1 bài CSDL)
        public override double TongDiem() => Bai1 + Bai2 + Bai3 + CSDL;
    }

    // =========================================================================
    // 4. CHƯƠNG TRÌNH CHÍNH (Execution & Polymorphism Demonstration)
    // =========================================================================
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font hiển thị tiếng Việt trên màn hình Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Danh sách chứa các đối tượng có kiểu tham chiếu lớp cha ThiSinh
            List<ThiSinh> cuocThi = new List<ThiSinh>();

            // 1. Khởi tạo và nhập dữ liệu cho thí sinh Chuyên
            Console.WriteLine("=== NHẬP THÍ SINH CHUYÊN ===");
            ThiSinh c = new ThiSinhChuyen(); // Tính đa hình: con trỏ lớp cha trỏ đến đối tượng lớp con
            c.Nhap();
            cuocThi.Add(c);

            // 2. Khởi tạo và nhập dữ liệu cho thí sinh Siêu cúp
            Console.WriteLine("\n=== NHẬP THÍ SINH SIÊU CÚP ===");
            ThiSinh sc = new ThiSinhSieuCup(); // Tương tự, dùng kiểu cơ sở quản lý đối tượng con
            sc.Nhap();
            cuocThi.Add(sc);

            // 3. Duyệt danh sách và xuất kết quả:
            // C# sẽ tự động gọi đúng hàm TongDiem() tương ứng của từng lớp con tại thời điểm chạy (Late Binding)
            Console.WriteLine("\n--- KẾT QUẢ ĐIỂM THI ---");
            foreach (var ts in cuocThi)
            {
                ts.Xuat();
            }
        }
    }
}