using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QLSinhVien
{
    public partial class frmDiem_Combo : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmDiem_Combo()
        {
            InitializeComponent();
        }

        private void frmDiem_Combo_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlCommand cmdSV = new SqlCommand("SELECT MaSinhVien FROM SinhVien", conn);
                SqlDataReader rdSV = cmdSV.ExecuteReader();
                cboSinhVien.Items.Clear();
                while (rdSV.Read()) cboSinhVien.Items.Add(rdSV["MaSinhVien"].ToString());
                rdSV.Close();

                SqlCommand cmdMH = new SqlCommand("SELECT MaMonHoc FROM MonHoc", conn);
                SqlDataReader rdMH = cmdMH.ExecuteReader();
                cboMonHoc.Items.Clear();
                while (rdMH.Read()) cboMonHoc.Items.Add(rdMH["MaMonHoc"].ToString());
                rdMH.Close();

                if (cboSinhVien.Items.Count > 0) cboSinhVien.SelectedIndex = 0;
                if (cboMonHoc.Items.Count > 0) cboMonHoc.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private bool KiemTraTrungKhoaChinh(string maSV, string maMH)
        {
            bool exists = false;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Diem WHERE MaSinhVien = @MaSV AND MaMonHoc = @MaMH", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                int count = (int)cmd.ExecuteScalar();
                exists = (count > 0);
            }
            catch { exists = false; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return exists;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedItem == null || cboMonHoc.SelectedItem == null || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtDiem.Text.Trim(), out float diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng (0-10)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            if (KiemTraTrungKhoaChinh(maSV, maMH))
            {
                MessageBox.Show("Đã tồn tại điểm cho sinh viên và môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Diem VALUES (@MaSV, @MaMH, @Diem)", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                cmd.Parameters.AddWithValue("@Diem", diem);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = cboSinhVien.SelectedItem?.ToString();
            string maMH = cboMonHoc.SelectedItem?.ToString();

            if (!KiemTraTrungKhoaChinh(maSV, maMH))
            {
                MessageBox.Show("Không tìm thấy dòng điểm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Diem WHERE MaSinhVien = @MaSV AND MaMonHoc = @MaMH", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtDiem.Text.Trim(), out float diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng (0-10)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboSinhVien.SelectedItem?.ToString();
            string maMH = cboMonHoc.SelectedItem?.ToString();

            if (!KiemTraTrungKhoaChinh(maSV, maMH))
            {
                MessageBox.Show("Chưa có điểm để sửa, hãy chọn Thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Diem SET Diem = @Diem WHERE MaSinhVien = @MaSV AND MaMonHoc = @MaMH", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaMH", maMH);
                cmd.Parameters.AddWithValue("@Diem", diem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
}