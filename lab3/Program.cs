using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThucHanhLINQ
{
    #region Định nghĩa các lớp đối tượng (Bài 4.1 & Bài 6.1)
    
    // Bài 4.1: Lớp MonHoc
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }

    // Bài 6.1: Lớp He
    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";
    }

    // Lớp chứa dữ liệu mẫu
    public static class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "JLCB",  TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
                new MonHoc { MaMon = "LINQ",  TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
                new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "CC++",  TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
                new MonHoc { MaMon = "JQUE",  TenMon = "JQuery", He = "CD", SoTiet = 22 },
                new MonHoc { MaMon = "XML",   TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "CRYS",  TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "BWEB",  TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "XYZ",   TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
            };
        }

        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
                new He { MaHe = "CD",  TenHe = "Chuyên đề" },
                new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
            };
        }
    }
    #endregion

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("================ BÀI 2.1 ================");
            Bai21();

            Console.WriteLine("\n================ BÀI 2.2 ================");
            Bai22();

            Console.WriteLine("\n================ BÀI 3.1 ================");
            Bai31();

            Console.WriteLine("\n================ BÀI 3.2 ================");
            Bai32();

            Console.WriteLine("\n================ BÀI 5.1 ================");
            Bai51();

            Console.WriteLine("\n================ BÀI 5.2 ================");
            Bai52();

            Console.WriteLine("\n================ BÀI 6.2 ================");
            Bai62();

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }

        #region Bài 2.1: Truy vấn mảng số nguyên
        static void Bai21()
        {
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            // a. Chia hết cho 4 và 3 (tức chia hết cho 12)
            // Query syntax:
            var cauA_Query = from n in mangSo where n % 4 == 0 && n % 3 == 0 select n;
            // Method syntax:
            var cauA_Method = mangSo.Where(n => n % 4 == 0 && n % 3 == 0);
            Console.WriteLine("a. Các phần tử chia hết cho 4 và 3: " + string.Join(", ", cauA_Method));

            // b. Nhỏ hơn hoặc bằng 3
            var cauB = mangSo.Where(n => n <= 3);
            Console.WriteLine("b. Các phần tử <= 3: " + string.Join(", ", cauB));

            // c. Số chẵn chia đôi, số lẻ giữ nguyên
            var cauC = mangSo.Select(n => n % 2 == 0 ? n / 2 : n);
            Console.WriteLine("c. Dãy mới (chẵn / 2, lẻ giữ nguyên): " + string.Join(", ", cauC));
        }
        #endregion

        #region Bài 2.2: Truy vấn mảng chuỗi
        static void Bai22()
        {
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

            // a. Có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên
            var cauA = mangChuoi.Where(s => s.Length == 4)
                                .OrderBy(s => s[0]);
            Console.WriteLine("a. Phần tử 4 ký tự sắp xếp tăng theo ký tự đầu: " + string.Join(", ", cauA));

            // b. Dạng: <chữ thường> - <CHỮ HOA>
            var cauB = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");
            Console.WriteLine("b. Chuyển đổi thường - HOA:");
            foreach (var item in cauB) Console.WriteLine("   " + item);

            // c. Chứa ký tự 'u' hoặc 'U'
            var cauC = mangChuoi.Where(s => s.Contains("u", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("c. Các phần tử chứa ký tự 'u': " + string.Join(", ", cauC));

            // d. Lọc các từ bắt đầu bằng chữ in hoa
            var cauD = mangChuoi.Where(s => char.IsUpper(s[0]));
            Console.WriteLine("d. Các từ bắt đầu bằng chữ in hoa: " + string.Join(" ", cauD));
        }
        #endregion

        #region Bài 3.1: Thống kê mảng số
        static void Bai31()
        {
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            // a. Tổng số phần tử, số chẵn, số lẻ
            int tongSo = mangSo.Count();
            int soChan = mangSo.Count(n => n % 2 == 0);
            int soLe = mangSo.Count(n => n % 2 != 0);
            Console.WriteLine($"a. Tổng số: {tongSo}, Số chẵn: {soChan}, Số lẻ: {soLe}");

            // b. Tổng, Max, Min
            Console.WriteLine($"b. Tổng: {mangSo.Sum()}, Max: {mangSo.Max()}, Min: {mangSo.Min()}");

            // c. Số lượng giá trị khác nhau
            int distinctCount = mangSo.Distinct().Count();
            Console.WriteLine($"c. Số giá trị khác nhau: {distinctCount}");

            // d. Phân nhóm theo số dư chia cho 5
            var groups = mangSo.GroupBy(n => n % 5)
                               .OrderBy(g => g.Key);
            Console.WriteLine("d. Phân nhóm theo số dư chia cho 5:");
            foreach (var g in groups)
            {
                Console.WriteLine($"   - Dư {g.Key}: {string.Join(", ", g)}");
            }
        }
        #endregion

        #region Bài 3.2: Thống kê mảng chuỗi
        static void Bai32()
        {
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                               "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây",
                               "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            // a. Món có chiều dài ngắn nhất và dài nhất
            int minLen = monAn.Min(m => m.Length);
            int maxLen = monAn.Max(m => m.Length);
            var nganNhat = monAn.Where(m => m.Length == minLen);
            var daiNhat = monAn.Where(m => m.Length == maxLen);
            Console.WriteLine($"a. Ngắn nhất ({minLen} ký tự): {string.Join(", ", nganNhat)}");
            Console.WriteLine($"   Dài nhất ({maxLen} ký tự): {string.Join(", ", daiNhat)}");

            // b. Phân nhóm theo từ đầu tiên
            var groups = monAn.GroupBy(m => m.Split(' ')[0]);
            Console.WriteLine("b. Phân nhóm theo từ đầu tiên:");
            foreach (var g in groups)
            {
                Console.WriteLine($"   * [{g.Key}]: {string.Join("; ", g)}");
            }

            // c. Đếm số phần tử có từ đầu tiên là "Bánh"
            int countBanh = monAn.Count(m => m.StartsWith("Bánh "));
            Console.WriteLine($"c. Số lượng món bắt đầu bằng 'Bánh': {countBanh}");
        }
        #endregion

        #region Bài 5.1: Truy vấn cơ bản trên List<MonHoc>
        static void Bai51()
        {
            var dsMon = DuLieu.DS_Mon();

            // a. Môn học bắt đầu bằng "Lập trình"
            var cauA = dsMon.Where(m => m.TenMon.StartsWith("Lập trình")).Select(m => m.TenMon);
            Console.WriteLine("a. Các môn bắt đầu bằng 'Lập trình':\n   " + string.Join("\n   ", cauA));

            // b. Hệ "CD", SoTiet giảm dần rồi MaMon tăng dần
            var cauB = dsMon.Where(m => m.He == "CD")
                            .OrderByDescending(m => m.SoTiet)
                            .ThenBy(m => m.MaMon);
            Console.WriteLine("\nb. Môn hệ 'CD' (Số tiết giảm dần, Mã môn tăng dần):");
            foreach (var m in cauB) Console.WriteLine($"   {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");

            // c. Tên môn chứa từ "web", chỉ lấy TenMon và He
            var cauC = dsMon.Where(m => m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
                            .Select(m => new { m.TenMon, m.He });
            Console.WriteLine("\nc. Môn có chứa 'web':");
            foreach (var m in cauC) Console.WriteLine($"   {m.TenMon} - Hệ: {m.He}");

            // d. Thuộc hệ "KTV", sắp xếp tăng dần theo MaMon
            var cauD = dsMon.Where(m => m.He == "KTV")
                            .OrderBy(m => m.MaMon);
            Console.WriteLine("\nd. Môn hệ 'KTV' theo mã tăng dần:");
            foreach (var m in cauD) Console.WriteLine($"   {m.MaMon}: {m.TenMon}");
        }
        #endregion

        #region Bài 5.2: Thống kê trên List<MonHoc>
        static void Bai52()
        {
            var dsMon = DuLieu.DS_Mon();

            // a. Tổng số môn
            Console.WriteLine($"a. Tổng số môn: {dsMon.Count}");

            // b. Đếm số môn bắt đầu bằng "Lập trình"
            Console.WriteLine($"b. Số môn bắt đầu bằng 'Lập trình': {dsMon.Count(m => m.TenMon.StartsWith("Lập trình"))}");

            // c. Tổng số tiết hệ KTV
            Console.WriteLine($"c. Tổng số tiết hệ KTV: {dsMon.Where(m => m.He == "KTV").Sum(m => m.SoTiet)}");

            // d. Tổng số môn của mỗi hệ
            var cauD = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Chưa rõ)" : m.He)
                            .Select(g => new { He = g.Key, TongSoMon = g.Count() });
            Console.WriteLine("d. Tổng số môn theo hệ:");
            foreach (var item in cauD) Console.WriteLine($"   Hệ: {item.He} - Tổng môn: {item.TongSoMon}");

            // e. Nhóm theo SoTiet, in Số tiết và tổng môn, giảm dần theo Số tiết
            var cauE = dsMon.GroupBy(m => m.SoTiet)
                            .OrderByDescending(g => g.Key)
                            .Select(g => new { SoTiet = g.Key, SoLuong = g.Count() });
            Console.WriteLine("e. Thống kê theo số tiết (giảm dần):");
            foreach (var item in cauE) Console.WriteLine($"   {item.SoTiet} tiết: {item.SoLuong} môn");

            // f. Môn có số tiết cao nhất
            byte maxTiet = dsMon.Max(m => m.SoTiet);
            var cauF = dsMon.Where(m => m.SoTiet == maxTiet);
            Console.WriteLine("f. Môn có số tiết cao nhất:");
            foreach (var m in cauF) Console.WriteLine($"   {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");

            // g. Thống kê theo Hệ: tổng môn, tổng tiết, max tiết, min tiết
            var cauG = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Trống)" : m.He)
                            .Select(g => new
                            {
                                He = g.Key,
                                TongMon = g.Count(),
                                TongTiet = g.Sum(x => x.SoTiet),
                                MaxTiet = g.Max(x => x.SoTiet),
                                MinTiet = g.Min(x => x.SoTiet)
                            });
            Console.WriteLine("g. Thống kê theo Hệ:");
            foreach (var item in cauG)
            {
                Console.WriteLine($"   Hệ {item.He}: {item.TongMon} môn, Tổng: {item.TongTiet} tiết, Max: {item.MaxTiet}, Min: {item.MinTiet}");
            }

            // h. Liệt kê phân nhóm theo Hệ
            var cauH = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Không có hệ)" : m.He);
            Console.WriteLine("h. Danh sách môn phân theo Hệ:");
            foreach (var g in cauH)
            {
                Console.WriteLine($"   === Hệ: {g.Key} ===");
                foreach (var m in g) Console.WriteLine($"       {m.MaMon} - {m.TenMon}");
            }

            // i. Phân nhóm theo Số tiết và tăng dần theo Số tiết
            var cauI = dsMon.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
            Console.WriteLine("i. Phân nhóm theo Số tiết (tăng dần):");
            foreach (var g in cauI)
            {
                Console.WriteLine($"   * {g.Key} tiết:");
                foreach (var m in g) Console.WriteLine($"       - {m.TenMon}");
            }

            // j. Với hệ KTV, nhóm theo học phần HP2, HP3, HP4, HP5, sắp xếp theo MaMon
            var cauJ = dsMon.Where(m => m.He == "KTV")
                            .GroupBy(m => m.MaMon.Length >= 3 ? m.MaMon.Substring(0, 3) : "Khác")
                            .OrderBy(g => g.Key);
            Console.WriteLine("j. Hệ KTV phân nhóm theo Học phần (HP):");
            foreach (var g in cauJ)
            {
                Console.WriteLine($"   Nhóm {g.Key}:");
                foreach (var m in g.OrderBy(x => x.MaMon)) Console.WriteLine($"       {m.MaMon} - {m.TenMon}");
            }

            // k. Phân nhóm theo Hệ, chỉ lấy môn > 40 tiết, sắp xếp theo MaMon
            var cauK = dsMon.Where(m => m.SoTiet > 40)
                            .GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Trống)" : m.He);
            Console.WriteLine("k. Môn có số tiết > 40 phân theo Hệ:");
            foreach (var g in cauK)
            {
                Console.WriteLine($"   Hệ {g.Key}:");
                foreach (var m in g.OrderBy(x => x.MaMon)) Console.WriteLine($"       [{m.MaMon}] {m.TenMon} ({m.SoTiet} tiết)");
            }
        }
        #endregion

        #region Bài 6.2: Join và các toán tử tập hợp
        static void Bai62()
        {
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            // a. Inner Join: Tên hệ, Mã môn, Tên môn
            var cauA = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He
                       select new { h.TenHe, m.MaMon, m.TenMon };
            Console.WriteLine("a. Inner Join (Hệ & Môn học):");
            foreach (var item in cauA) Console.WriteLine($"   [{item.TenHe}] {item.MaMon} - {item.TenMon}");

            // b. Left Join (GroupJoin + DefaultIfEmpty) lấy cả hệ chưa có môn (hệ QT)
            var cauB = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into nhomMon
                       from m in nhomMon.DefaultIfEmpty()
                       select new
                       {
                           TenHe = h.TenHe,
                           MaMon = m?.MaMon ?? "(Chưa có)",
                           TenMon = m?.TenMon ?? "(Chưa có môn)"
                       };
            Console.WriteLine("\nb. Left Outer Join (Cả hệ chưa có môn):");
            foreach (var item in cauB) Console.WriteLine($"   [{item.TenHe}] {item.MaMon} - {item.TenMon}");

            // c. Full Outer Join mô phỏng: Hệ chưa có môn + Môn chưa khai báo hệ + Cặp hợp lệ
            // Left join: dsHe -> dsMon
            var left = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into nhomMon
                       from m in nhomMon.DefaultIfEmpty()
                       select new
                       {
                           TenHe = h.TenHe,
                           MaMon = m?.MaMon ?? "(Chưa có)",
                           TenMon = m?.TenMon ?? "(Chưa có)",
                           MaHeMon = m?.He ?? ""
                       };

            // Right-only: Các môn có He không nằm trong dsHe
            var rightOnly = from m in dsMon
                            where !dsHe.Any(h => h.MaHe == m.He)
                            select new
                            {
                                TenHe = "(Chưa khai báo hệ)",
                                MaMon = m.MaMon,
                                TenMon = m.TenMon,
                                MaHeMon = m.He
                            };

            var cauC = left.Union(rightOnly);
            Console.WriteLine("\nc. Cả hệ chưa có môn và môn chưa khai báo hệ:");
            foreach (var item in cauC) Console.WriteLine($"   [{item.TenHe}] {item.MaMon} - {item.TenMon}");

            // d. CHỈ liệt kê những hệ chưa có môn học VÀ những môn học chưa khai báo hệ
            var heChuaCoMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe))
                                  .Select(h => $"Hệ chưa có môn: [{h.MaHe}] {h.TenHe}");
            var monChuaCoHe = dsMon.Where(m => !dsHe.Any(h => h.MaHe == m.He))
                                   .Select(m => $"Môn chưa có hệ: [{m.MaMon}] {m.TenMon}");
            Console.WriteLine("\nd. Chỉ hệ chưa có môn và môn chưa có hệ:");
            foreach (var h in heChuaCoMon) Console.WriteLine("   " + h);
            foreach (var m in monChuaCoHe) Console.WriteLine("   " + m);

            // e. Top 5 môn có số tiết giảm dần: Tên hệ, Mã môn, Tên môn, Số tiết
            var cauE = (from m in dsMon
                        join h in dsHe on m.He equals h.MaHe into nhomHe
                        from h in nhomHe.DefaultIfEmpty()
                        orderby m.SoTiet descending
                        select new
                        {
                            TenHe = h?.TenHe ?? "(Chưa có hệ)",
                            m.MaMon,
                            m.TenMon,
                            m.SoTiet
                        }).Take(5);
            Console.WriteLine("\ne. Top 5 môn có số tiết cao nhất:");
            foreach (var item in cauE)
            {
                Console.WriteLine($"   [{item.TenHe}] {item.MaMon} - {item.TenMon} ({item.SoTiet} tiết)");
            }

            // f. Tổng số môn của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn
            var cauF = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into nhomMon
                       select new
                       {
                           h.MaHe,
                           h.TenHe,
                           TongSoMon = nhomMon.Count()
                       };
            Console.WriteLine("\nf. Tổng số môn của mỗi hệ:");
            foreach (var item in cauF)
            {
                Console.WriteLine($"   Mã hệ: {item.MaHe} | Tên hệ: {item.TenHe} | Tổng môn: {item.TongSoMon}");
            }

            // g. Có bao nhiêu loại Số tiết khác nhau
            int distinctSoTiet = dsMon.Select(m => m.SoTiet).Distinct().Count();
            Console.WriteLine($"\ng. Có {distinctSoTiet} loại số tiết khác nhau.");

            // h. Môn học đầu tiên có tên bắt đầu bằng "Lập trình"
            var cauH = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
            Console.WriteLine($"h. Môn đầu tiên bắt đầu bằng 'Lập trình': {cauH?.MaMon} - {cauH?.TenMon}");

            // i. Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm
            var cauI = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into nhomMon
                       select new
                       {
                           TenHe = h.TenHe,
                           DanhSach = nhomMon.Select((mon, index) => new { STT = index + 1, mon.MaMon, mon.TenMon })
                       };
            Console.WriteLine("\ni. Danh sách môn theo từng hệ kèm STT:");
            foreach (var he in cauI)
            {
                Console.WriteLine($"   Hệ: {he.TenHe}");
                if (!he.DanhSach.Any())
                {
                    Console.WriteLine("       (Không có môn)");
                }
                else
                {
                    foreach (var m in he.DanhSach)
                    {
                        Console.WriteLine($"       {m.STT}. [{m.MaMon}] {m.TenMon}");
                    }
                }
            }
        }
        #endregion
    }
}