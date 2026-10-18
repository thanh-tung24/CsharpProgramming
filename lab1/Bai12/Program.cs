/* Bài 12: Nhập một chuỗi gồm nhiều từ. Hãy chuyển chuỗi đó sang ký tự thường, 
sang ký tự hoa, đếm số từ trong chuỗi. */
using System;

namespace bai12
{
    class Program
    {
        public static void Main()
        {
            // Nhập chuỗi văn bản từ bàn phím
            Console.Write("Nhập vào một chuỗi: ");
            string text = Console.ReadLine();

            // Chuyển toàn bộ chuỗi sang ký tự thường và ký tự hoa
            string chuoiThuong = text.ToLower();
            string chuoiHoa = text.ToUpper();

            // Đếm số từ trong chuỗi
            // Cắt chuỗi dựa trên khoảng trắng và loại bỏ các khoảng trắng thừa liên tiếp
            string[] danhSachTu = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int soTu = danhSachTu.Length;

            // In kết quả ra màn hình Console
            Console.WriteLine("KẾT QUẢ:");
            Console.WriteLine($"Chuỗi chữ thường: {chuoiThuong}");
            Console.WriteLine($"Chuỗi chữ hoa:    {chuoiHoa}");
            Console.WriteLine($"Số từ trong chuỗi: {soTu}");
        }
    }
}