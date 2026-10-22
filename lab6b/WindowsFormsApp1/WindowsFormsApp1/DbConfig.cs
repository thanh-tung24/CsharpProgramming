using System;

namespace QLSinhVien
{
    public class DbConfig
    {
        // Sử dụng Data Source=. để tự kết nối SQL Server máy cục bộ
        public static string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
    }
}