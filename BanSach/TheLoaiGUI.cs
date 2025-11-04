using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TheLoaiGUI : Form
    {
        private DataTable dtTheLoai; // Biến lưu DataTable gốc
        private TheLoaiBLL _bll = new TheLoaiBLL();
        public TheLoaiGUI()
        {
            InitializeComponent();
        }

        private void TheLoaiGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtTheLoai = _bll.GetAll();
                dgTheLoai.DataSource = dtTheLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text.Trim();

            // Validation cơ bản
            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TheLoai newTheLoai = new TheLoai
            {
                TenTheLoai = tenTheLoai
            };

            bool result = _bll.Create(newTheLoai);

            if (result)
            {
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetFields()
        {
            // Dùng hàm helper của bạn nếu có
            FormHelper.ResetForm(this);

            // Hoặc reset thủ công nếu hàm helper không hoạt động như ý
            // txtMaTheLoai.Clear();
            // txtTenTheLoai.Clear();
            // txtTimKiem.Clear();
            // dtTheLoai.DefaultView.RowFilter = string.Empty;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dtTheLoai.DefaultView.RowFilter = string.Empty; // Xóa bộ lọc
                return;
            }

            // Lọc trên DataTable đã tải về (client-side)
            string filter = $"CONVERT(MaTheLoai, 'System.String') LIKE '%{keyword}%' OR " +
                          $"TenTheLoai LIKE '%{keyword}%'";

            // Áp dụng bộ lọc
            dtTheLoai.DefaultView.RowFilter = filter;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTheLoai = Convert.ToInt32(txtMaTheLoai.Text);
            string tenTheLoai = txtTenTheLoai.Text.Trim();

            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TheLoai updatedTheLoai = new TheLoai
            {
                MaTheLoai = maTheLoai,
                TenTheLoai = tenTheLoai
            };

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thể loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            bool result = _bll.Update(updatedTheLoai);

            if (result)
            {
                MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Cập nhật thể loại thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTheLoai = txtMaTheLoai.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?\n(Lưu ý: Không thể xóa nếu thể loại này đang được sách sử dụng)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            bool result = _bll.Delete(maTheLoai);

            if (result)
            {
                MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Xóa thể loại thất bại! (Có thể do lỗi khóa ngoại - thể loại đang được sử dụng ở bảng Sách)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tự động xóa bộ lọc khi ô tìm kiếm trống
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dtTheLoai.DefaultView.RowFilter = string.Empty;
            }
        }

        private void dgTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgTheLoai.Rows[e.RowIndex];
                txtMaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
            }
        }
    }
}
