using BLL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace BanSach
{
    public partial class DangNhapGUI : Form
    {
        private NguoiDungBLL _bll = new NguoiDungBLL();

        public DangNhapGUI()
        {
            InitializeComponent();

        }

        private void DangNhapGUI_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();

                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NguoiDung user = _bll.DangNhap(tenDangNhap, matKhau);

                if (user != null)
                {
                    // Lưu thông tin vào Session để sử dụng giữa các form
                    Session.MaNguoiDung = user.MaNguoiDung;
                    Session.HoTen = user.HoTen;
                    Session.Role = user.Role;

                    MessageBox.Show($"Đăng nhập thành công!\nXin chào: {user.HoTen} ({user.Role})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển sang form chính
                    this.Hide();
                    TrangChuGUI mainFrm = new TrangChuGUI(Session.Role);
                    mainFrm.Show();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyGUI frmDagky = new DangKyGUI();
            this.Close();
            frmDagky.Show();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txtMatKhau.Focus(); 
                e.SuppressKeyPress = true; 
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnDangNhap_Click(sender,e); 
                e.SuppressKeyPress = true;
            }
        }
    }
}
