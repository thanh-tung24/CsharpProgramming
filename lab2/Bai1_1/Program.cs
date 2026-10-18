using System;

namespace Bai1_1
{
    public class SinhVien
    {
        // 1. Fields
        private string hoTen;
        private int namSinh;

        // 2. Properties
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set
            {
                // Ràng buộc: năm sinh là số dương và không lớn hơn năm hiện tại
                if (value > 0 && value <= DateTime.Now.Year)
                {
                    namSinh = value;
                }
                else
                {
                    Console.WriteLine("Cảnh báo: Năm sinh không hợp lệ!");
                }
            }
        }

        // 3. Constructors
        public SinhVien()
        {
            hoTen = string.Empty;
            namSinh = 0;
        }

        // Parameterized Constructor
        public SinhVien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.NamSinh = namSinh; // Dùng property để kiểm tra dữ liệu
        }

        // Copy Constructor
        public SinhVien(SinhVien sv)
        {
            this.hoTen = sv.hoTen;
            this.namSinh = sv.namSinh;
        }

        // 4. Methods
        public void Input()
        {
            Console.Write("Nhập họ tên sinh viên: ");
            HoTen = Console.ReadLine(); // Gán qua Property HoTen

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine()); // Gán qua Property NamSinh để kích hoạt kiểm tra
        }

        public int TinhTuoi()
        {
            if (namSinh == 0) return 0;
            int currentYear = DateTime.Now.Year;
            return currentYear - namSinh;
        }

        public void Output()
        {
            Console.WriteLine("\n--- THÔNG TIN SINH VIÊN ---");
            Console.WriteLine($"Họ tên:   {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}");
            Console.WriteLine($"Tuổi:     {TinhTuoi()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SinhVien sv = new SinhVien();
            sv.Input();
            sv.Output();
        }
    }
}
