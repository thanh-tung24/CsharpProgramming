using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QLSinhVien
{
    public partial class frmDanhSachDiem : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmDanhSachDiem()
        {
            InitializeComponent();
        }

        private void frmDanhSachDiem_Load(object sender, EventArgs e)
        {
            LoadMonHocCombo();
            HienThiDuLieu(""); // Load tất cả môn học
        }

        private void LoadMonHocCombo()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaMonHoc FROM MonHoc", conn);
                SqlDataReader rd = cmd.ExecuteReader();

                cboMonHoc.Items.Clear();
                cboMonHoc.Items.Add(""); // Thêm item khoảng trắng đại diện tất cả[cite: 25]

                while (rd.Read())
                {
                    cboMonHoc.Items.Add(rd["MaMonHoc"].ToString());
                }
                rd.Close();
                cboMonHoc.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void HienThiDuLieu(string maMH)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT SV.HoTen, SV.NgaySinh, MH.TenMonHoc, D.Diem 
                               FROM Diem D 
                               JOIN SinhVien SV ON D.MaSinhVien = SV.MaSinhVien 
                               JOIN MonHoc MH ON D.MaMonHoc = MH.MaMonHoc";

                if (!string.IsNullOrEmpty(maMH))
                {
                    sql += " WHERE D.MaMonHoc = @MaMH";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (!string.IsNullOrEmpty(maMH))
                {
                    cmd.Parameters.AddWithValue("@MaMH", maMH);
                }

                SqlDataReader rd = cmd.ExecuteReader();
                lvDiem.Items.Clear();

                int stt = 1;
                double tongDiem = 0;

                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(rd["HoTen"].ToString());

                    DateTime ngaySinh = Convert.ToDateTime(rd["NgaySinh"]);
                    item.SubItems.Add(ngaySinh.ToString("M/d/yyyy HH:mm:ss"));

                    item.SubItems.Add(rd["TenMonHoc"].ToString());

                    double diem = Convert.ToDouble(rd["Diem"]);
                    item.SubItems.Add(diem.ToString());

                    tongDiem += diem;
                    lvDiem.Items.Add(item);
                    stt++;
                }
                rd.Close();

                txtTongDiem.Text = tongDiem.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maMH = cboMonHoc.SelectedItem != null ? cboMonHoc.SelectedItem.ToString().Trim() : "";
            HienThiDuLieu(maMH);
        }
    }
}