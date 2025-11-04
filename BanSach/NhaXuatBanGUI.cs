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
    public partial class NhaXuatBanGUI : Form
    {
        private DataTable dtNhaXuatBan; // Biến lưu DataTable gốc
        private NhaXuatBanBLL _bll = new NhaXuatBanBLL();
        public NhaXuatBanGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhaXuatBanGUI_Load(object sender, EventArgs e)
        {
            LoadData();

            // Cấu hình DataGridView
            dgNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNXB.Columns["MaNhaXuatBan"].HeaderText = "Mã NXB";
            dgNXB.Columns["TenNhaXuatBan"].HeaderText = "Tên Nhà Xuất Bản";
            dgNXB.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgNXB.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgNXB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Vô hiệu hóa textbox Mã
            txtMaNXB.ReadOnly = true;
        }
        void LoadData()
        {
            dtNhaXuatBan = _bll.GetAll();
            dgNXB.DataSource = dtNhaXuatBan;
        }
        private void ResetFields()
        {
            FormHelper.ResetForm(this);
            // Hoặc reset thủ công
            // txtMaNhaXuatBan.Clear();
            // txtTenNhaXuatBan.Clear();
            // txtDiaChi.Clear();
            // txtSoDienThoai.Clear();
            // txtTimKiem.Clear();
            // dtNhaXuatBan.DefaultView.RowFilter = string.Empty;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTenNXB.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // (Các trường khác có thể null dựa trên CSDL của bạn)
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            NhaXuatBan newNXB = new NhaXuatBan
            {
                TenNhaXuatBan = txtTenNXB.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim()
            };

            try
            {
                bool result = _bll.Create(newNXB);
                if (result)
                {
                    MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            NhaXuatBan updatedNXB = new NhaXuatBan
            {
                MaNhaXuatBan = Convert.ToInt32(txtMaNXB.Text),
                TenNhaXuatBan = txtTenNXB.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim()
            };

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhà xuất bản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Update(updatedNXB);
                if (result)
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNXB = txtMaNXB.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            try
            {
                bool result = _bll.Delete(maNXB);
                if (result)
                {
                    MessageBox.Show("Xóa nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi khóa ngoại nếu NXB này đang được sách sử dụng
                if (ex.Message.Contains("FK_Sach_NhaXuatBan"))
                {
                    MessageBox.Show("Xóa thất bại! Nhà xuất bản này đang được sử dụng bởi bảng Sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                dtNhaXuatBan.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Lọc trên tất cả các cột
            string filter = $"CONVERT(MaNhaXuatBan, 'System.String') LIKE '%{keyword}%' OR " +
                          $"TenNhaXuatBan LIKE '%{keyword}%' OR " +
                          $"DiaChi LIKE '%{keyword}%' OR " +
                          $"SoDienThoai LIKE '%{keyword}%'";

            dtNhaXuatBan.DefaultView.RowFilter = filter;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dtNhaXuatBan.DefaultView.RowFilter = string.Empty;
            }
        }

        private void dgNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgNXB.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells["MaNhaXuatBan"].Value.ToString();
                txtTenNXB.Text = row.Cells["TenNhaXuatBan"].Value.ToString();

                // Xử lý giá trị NULL từ CSDL
                txtDiaChi.Text = row.Cells["DiaChi"].Value != DBNull.Value ? row.Cells["DiaChi"].Value.ToString() : "";
                txtSDT.Text = row.Cells["SoDienThoai"].Value != DBNull.Value ? row.Cells["SoDienThoai"].Value.ToString() : "";
            }
        }
    }
}
