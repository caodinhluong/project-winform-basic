using BLL;
using DTO;
using GUI;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BanSach
{
    public partial class TacGiaGui : Form
    {
        private DataTable dtTacGia; // Biến lưu DataTable gốc

        private TacGiaBLL _bll = new TacGiaBLL();
        public TacGiaGui()
        {
            InitializeComponent();
        }

        private void TacGiaGui_Load(object sender, EventArgs e)
        {
            LoadData();
            //tự động căn chỉnh độ rộng các cột
            dgTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //đặt tên tiêu đề cho có dấu
            dgTacGia.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            dgTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgTacGia.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            //tiêu đề chữ đậm
            dgTacGia.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);



        }
        private void LoadData()
        {
            try
            {
                dtTacGia = _bll.GetAll();
                dgTacGia.DataSource = dtTacGia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string tenTacGia = txtTenTG.Text.Trim();
            DateTime? ngaySinh = dateTimePickerNamSinhTG.Value;
            string quocTich = txtQuocTich.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng mới
            TacGia newTacGia = new TacGia
            {
                TenTacGia = tenTacGia,
                NgaySinh = ngaySinh,
                QuocTich = quocTich
            };

            // Gọi phương thức Create để lưu vào CSDL
            bool result = _bll.Create(newTacGia);

            if (result)
            {
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Làm mới danh sách sau khi thêm
                //reset các điều khiển (textbox,....)
                FormHelper.ResetForm(this);
            }
            else
            {
                MessageBox.Show("Thêm tác giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //load lại dữ liệu sau khi thêm
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng trong DataGridView chưa
            if (txtMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tác giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ DataGridView (MaTacGia)
            int maTacGia = Convert.ToInt32(dgTacGia.CurrentRow.Cells["MaTacGia"].Value);

            // Lấy dữ liệu từ giao diện
            string tenTacGia = txtTenTG.Text.Trim();
            DateTime? ngaySinh = dateTimePickerNamSinhTG.Value;
            string quocTich = txtQuocTich.Text.Trim();

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng TacGia mới
            TacGia updatedTacGia = new TacGia
            {
                MaTacGia = maTacGia,
                TenTacGia = tenTacGia,
                NgaySinh = ngaySinh,
                QuocTich = quocTich
            };
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Gọi phương thức Update để cập nhật vào CSDL
            bool result = _bll.Update(updatedTacGia);

            if (result)
            {
                MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Làm mới danh sách sau khi sửa
                            //reset các điều khiển (textbox,....)
                FormHelper.ResetForm(this);
            }
            else
            {
                MessageBox.Show("Cập nhật tác giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng trong DataGridView chưa
            if (txtMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tác giả cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Lấy mã tác giả từ dòng đang chọn
            int maTacGia = Convert.ToInt32(dgTacGia.CurrentRow.Cells["MaTacGia"].Value);

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Gọi phương thức Delete để xóa trong CSDL
            bool result = _bll.Delete(maTacGia.ToString());

            if (result)
            {
                MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Làm mới danh sách sau khi xóa
                FormHelper.ResetForm(this);//reset các điều khiển (textbox,....)

            }
            else
            {
                MessageBox.Show("Xóa tác giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại mà người dùng đã chọn
                DataGridViewRow row = dgTacGia.Rows[e.RowIndex];

                // Đổ dữ liệu lên TextBox
                txtMaTacGia.Text = row.Cells["MaTacGia"].Value.ToString();
                txtTenTG.Text = row.Cells["TenTacGia"].Value.ToString();
                dateTimePickerNamSinhTG.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
            }

        }
       


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgTacGia.DataSource = dtTacGia; // Hiển thị lại tất cả nếu không nhập gì
                return;
            }

            // Lọc dữ liệu (Tìm trong tất cả các cột)
            string filter = $"CONVERT(MaTacGia, 'System.String') LIKE '%{keyword}%' OR " +
                 $"TenTacGia LIKE '%{keyword}%' OR " +
                 $"CONVERT(NgaySinh, 'System.String') LIKE '%{keyword}%' OR " +
                 $"QuocTich LIKE '%{keyword}%'";


            dtTacGia.DefaultView.RowFilter = filter; // Áp dụng bộ lọc
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Hiển thị lại dữ liệu khi textbox trở về rỗng
            if (txtTimKiem.Text == "")
            {
                dgTacGia.DataSource = dtTacGia;
                LoadData();
            }
        }
    }
}
