using System;

namespace Bai1_4
{
    public class PhanSo
    {
        // ==========================================
        // 1. FIELDS (Các trường dữ liệu riêng tư)
        // ==========================================
        private int tuSo;
        private int mauSo;

        // ==========================================
        // 2. PROPERTIES (Thuộc tính đóng gói dữ liệu)
        // ==========================================
        // Thuộc tính Tử số: đọc và ghi bình thường
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        // Thuộc tính Mẫu số: kiểm tra điều kiện không được bằng 0
        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Mẫu số phải khác 0.");
                mauSo = value;
            }
        }

        // ==========================================
        // 3. CONSTRUCTORS (Các hàm khởi tạo)
        // ==========================================
        // Constructor mặc nhiên (Default): khởi tạo phân số bằng 0/1
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        // Constructor có tham số: nhận tử và mẫu, kiểm tra mẫu và tự động rút gọn
        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
                throw new ArgumentException("Mẫu số phải khác 0.");
            tuSo = tu;
            mauSo = mau;
            RutGon(); // Chuẩn hóa phân số ngay sau khi khởi tạo
        }

        // Constructor sao chép (Copy Constructor): sao chép dữ liệu từ một phân số khác
        public PhanSo(PhanSo ps)
        {
            tuSo = ps.tuSo;
            mauSo = ps.mauSo;
        }

        // ==========================================
        // 4. CÁC HÀM PHỤ TRỢ (Helper Methods)
        // ==========================================
        // Tìm ước số chung lớn nhất (USCLN) bằng thuật toán Euclid
        private int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a == 0 ? 1 : a;
        }

        // Tối giản phân số và đảm bảo dấu âm luôn nằm ở tử số
        public void RutGon()
        {
            int u = USCLN(tuSo, mauSo);
            tuSo /= u;
            mauSo /= u;
            // Nếu mẫu âm, đổi dấu cả tử và mẫu để mẫu luôn dương (ví dụ: 1/-2 -> -1/2)
            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }

        // ==========================================
        // 5. OVERRIDE ToString()
        // ==========================================
        // Ghi đè phương thức ToString để hiển thị dạng chuỗi (nếu mẫu = 1 thì chỉ in tử số)
        public override string ToString() => mauSo == 1 ? $"{tuSo}" : $"{tuSo}/{mauSo}";

        // ==========================================
        // 6. TOÁN TỬ MỘT NGÔI (Unary Operators)
        // ==========================================
        // Toán tử dương: giữ nguyên phân số
        public static PhanSo operator +(PhanSo a) => new PhanSo(a);

        // Toán tử lấy âm (-a): đảo dấu tử số
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

        // ==========================================
        // 7. TOÁN TỬ HAI NGÔI (Binary Operators)
        // ==========================================
        // Cộng: a/b + c/d = (a*d + c*b) / (b*d)
        public static PhanSo operator +(PhanSo a, PhanSo b)
            => new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);

        // Trừ: a/b - c/d = (a*d - c*b) / (b*d)
        public static PhanSo operator -(PhanSo a, PhanSo b)
            => new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);

        // Nhân: a/b * c/d = (a*c) / (b*d)
        public static PhanSo operator *(PhanSo a, PhanSo b)
            => new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);

        // Chia: a/b / c/d = (a*d) / (b*c)
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tuSo == 0)
                throw new DivideByZeroException("Không thể chia cho phân số bằng 0.");
            return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        }

        // ==========================================
        // 8. TOÁN TỬ SO SÁNH (Comparison Operators)
        // Lưu ý: Mẫu luôn dương nên so sánh a/b với c/d quy về so sánh tích chéo: a*d và c*b
        // ==========================================
        // Bằng nhau (==)
        public static bool operator ==(PhanSo a, PhanSo b)
            => a.tuSo * b.mauSo == b.tuSo * a.mauSo;

        // Khác nhau (!=) - bắt buộc đi cặp với ==
        public static bool operator !=(PhanSo a, PhanSo b)
            => !(a == b);

        // Lớn hơn (>)
        public static bool operator >(PhanSo a, PhanSo b)
            => a.tuSo * b.mauSo > b.tuSo * a.mauSo;

        // Nhỏ hơn (<) - bắt buộc đi cặp với >
        public static bool operator <(PhanSo a, PhanSo b)
            => a.tuSo * b.mauSo < b.tuSo * a.mauSo;

        // Lớn hơn hoặc bằng (>=)
        public static bool operator >=(PhanSo a, PhanSo b)
            => a > b || a == b;

        // Nhỏ hơn hoặc bằng (<=) - bắt buộc đi cặp với >=
        public static bool operator <=(PhanSo a, PhanSo b)
            => a < b || a == b;

        // Override Equals và GetHashCode khi nạp chồng toán tử == theo chuẩn C#
        public override bool Equals(object obj) => obj is PhanSo ps && this == ps;
        public override int GetHashCode() => (tuSo, mauSo).GetHashCode();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo hai phân số thử nghiệm
            PhanSo a = new PhanSo(1, 2);
            PhanSo b = new PhanSo(3, 4);

            Console.WriteLine($"Phân số a = {a}");
            Console.WriteLine($"Phân số b = {b}");

            // Kiểm tra các toán tử 2 ngôi
            Console.WriteLine($"\n--- PHÉP TOÁN 2 NGÔI ---");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");

            // Kiểm tra toán tử 1 ngôi
            Console.WriteLine($"\n--- PHÉP TOÁN 1 NGÔI ---");
            Console.WriteLine($"-a    = {-a}");

            // Kiểm tra các phép so sánh
            Console.WriteLine($"\n--- SO SÁNH ---");
            Console.WriteLine($"a > b  : {a > b}");
            Console.WriteLine($"a < b  : {a < b}");
            Console.WriteLine($"a == b : {a == b}");
            Console.WriteLine($"a != b : {a != b}");
        }
    }
}