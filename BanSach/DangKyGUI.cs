using BanSach;
using BLL;
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
    public partial class DangKyGUI : Form
    {
        private NguoiDungBLL _bll = new NguoiDungBLL();
        public DangKyGUI()
        {
            InitializeComponent();
        }

        private void linkDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhapGUI frmDangNhap = new DangNhapGUI();
            this.Close();
            frmDangNhap.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox trên giao diện
                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
                string hoTen = txtHoVaTen.Text.Trim();
                string soDienThoai = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim(); 
                string anhDaiDien = ""; // Nếu có chọn ảnh, thêm xử lý tại đây
                string role = cbRole.SelectedItem?.ToString(); // Lấy quyền từ combobox

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xác nhận mật khẩu
                if (matKhau != xacNhanMatKhau)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức đăng ký từ BUS
                bool ketQua = _bll.DangKy(tenDangNhap, matKhau, hoTen, soDienThoai, email, diaChi, anhDaiDien, role);

                if (ketQua)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi đăng ký thành công
                    DangNhapGUI frmdangNhap = new DangNhapGUI();
                    frmdangNhap.Show();

                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Tên đăng nhập có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

    }
}
