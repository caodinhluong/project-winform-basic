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
    public partial class NhaCungCapGUI : Form
    {
        private DataTable dtNhaCungCap; // Biến lưu DataTable gốc
        private NhaCungCapBLL _bll = new NhaCungCapBLL();
        public NhaCungCapGUI()
        {
            InitializeComponent();
        }

        private void dgNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NhaCungCapGUI_Load(object sender, EventArgs e)
        {
            LoadData();

            // Cấu hình DataGridView
            dgNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNCC.Columns["MaNhaCungCap"].HeaderText = "Mã NCC";
            dgNCC.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgNCC.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgNCC.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgNCC.Columns["Email"].HeaderText = "Email";
            dgNCC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Vô hiệu hóa textbox Mã
            txtMaNCC.ReadOnly = true;
        }
        void LoadData()
        {
            dtNhaCungCap = _bll.GetAll();
            dgNCC.DataSource = dtNhaCungCap;
        }
        private void ResetFields()
        {
            FormHelper.ResetForm(this);
            // Hoặc reset thủ công
            // txtMaNhaCungCap.Clear();
            // txtTenNhaCungCap.Clear();
            // txtDiaChi.Clear();
            // txtSoDienThoai.Clear();
            // txtEmail.Clear();
            // txtTimKiem.Clear();
            // dtNhaCungCap.DefaultView.RowFilter = string.Empty;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            NhaCungCap newNCC = new NhaCungCap
            {
                TenNhaCungCap = txtTenNCC.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            try
            {
                bool result = _bll.Create(newNCC);
                if (result)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtMaNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            NhaCungCap updatedNCC = new NhaCungCap
            {
                MaNhaCungCap = Convert.ToInt32(txtMaNCC.Text),
                TenNhaCungCap = txtTenNCC.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Update(updatedNCC);
                if (result)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtMaNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNCC = txtMaNCC.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Delete(maNCC);
                if (result)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                dtNhaCungCap.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Lọc trên tất cả các cột
            string filter = $"CONVERT(MaNhaCungCap, 'System.String') LIKE '%{keyword}%' OR " +
                          $"TenNhaCungCap LIKE '%{keyword}%' OR " +
                          $"DiaChi LIKE '%{keyword}%' OR " +
                          $"SoDienThoai LIKE '%{keyword}%' OR " +
                          $"Email LIKE '%{keyword}%'";

            dtNhaCungCap.DefaultView.RowFilter = filter;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dtNhaCungCap.DefaultView.RowFilter = string.Empty;
            }
        }

        private void dgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
