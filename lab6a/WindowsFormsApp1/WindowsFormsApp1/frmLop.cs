using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmLop : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmLop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã khoa, Mã lớp và Tên lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm lớp thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "DELETE FROM Lop WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy mã lớp!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool hasTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);

            if (!hasMaKhoa && !hasTenLop)
            {
                MessageBox.Show("Mã khoa hoặc Tên lớp phải có ít nhất 1 trường có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "UPDATE Lop SET ";
                if (hasMaKhoa && hasTenLop)
                    sql += "MaKhoa = @MaKhoa, TenLop = @TenLop";
                else if (hasMaKhoa)
                    sql += "MaKhoa = @MaKhoa";
                else
                    sql += "TenLop = @TenLop";

                sql += " WHERE MaLop = @MaLop";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                if (hasMaKhoa) cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                if (hasTenLop) cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Cập nhật lớp thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy mã lớp!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}