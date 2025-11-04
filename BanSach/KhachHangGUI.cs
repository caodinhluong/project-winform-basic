using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class KhachHangGUI : Form
    {
        private DataTable dtKhachHang; // Biến lưu DataTable gốc
        private KhachHangBLL _bll = new KhachHangBLL();
        public KhachHangGUI()
        {
            InitializeComponent();
        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            LoadData();

            // Cấu hình DataGridView
            dgKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKhachHang.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
            dgKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dgKhachHang.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgKhachHang.Columns["Email"].HeaderText = "Email";
            dgKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Vô hiệu hóa textbox Mã
            txtMaKH.ReadOnly = true;
        }
        void LoadData()
        {
            dtKhachHang = _bll.GetAll();
            dgKhachHang.DataSource = dtKhachHang;
        }
        private void ResetFields()
        {
            FormHelper.ResetForm(this);
            // Hoặc reset thủ công
            // txtMaKhachHang.Clear();
            // txtHoTen.Clear();
            // txtSoDienThoai.Clear();
            // txtEmail.Clear();
            // txtDiaChi.Clear();
            // txtTimKiem.Clear();
            // dtKhachHang.DefaultView.RowFilter = string.Empty;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // (Bạn có thể thêm kiểm tra định dạng Email/SĐT ở đây)
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            KhachHang newKH = new KhachHang
            {
                HoTen = txtTenKH.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            try
            {
                bool result = _bll.Create(newKH);
                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi (ví dụ: trùng SĐT/Email)
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            KhachHang updatedKH = new KhachHang
            {
                MaKhachHang = Convert.ToInt32(txtMaKH.Text),
                HoTen = txtTenKH.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Update(updatedKH);
                if (result)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi (ví dụ: trùng SĐT/Email)
                MessageBox.Show("Cập nhật thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = txtMaKH.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Delete(maKH);
                if (result)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi khóa ngoại nếu khách hàng này đã có hóa đơn
                if (ex.Message.Contains("FK_HoaDon_KhachHang"))
                {
                    MessageBox.Show("Xóa thất bại! Khách hàng này đã có hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dtKhachHang.DefaultView.RowFilter = string.Empty;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                dtKhachHang.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Lọc trên tất cả các cột
            string filter = $"CONVERT(MaKhachHang, 'System.String') LIKE '%{keyword}%' OR " +
                          $"HoTen LIKE '%{keyword}%' OR " +
                          $"SoDienThoai LIKE '%{keyword}%' OR " +
                          $"Email LIKE '%{keyword}%' OR " +
                          $"DiaChi LIKE '%{keyword}%'";

            dtKhachHang.DefaultView.RowFilter = filter;
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();

                // Xử lý giá trị NULL từ CSDL
                txtEmail.Text = row.Cells["Email"].Value != DBNull.Value ? row.Cells["Email"].Value.ToString() : "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value != DBNull.Value ? row.Cells["DiaChi"].Value.ToString() : "";
            }
        }
    }
}
