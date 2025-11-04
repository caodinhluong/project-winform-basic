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

namespace BanSach
{
    public partial class TrangChuGUI : Form
    {
        string quyen;
        public TrangChuGUI(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }
        private void CenterControlInPanel(Control control, Panel panel)
        {
            control.Left = (panel.Width - control.Width) / 2;
            control.Top = (panel.Height - control.Height) / 2;
        }
        private void TrangChuGUI_Load(object sender, EventArgs e)
        {
            CenterControlInPanel(lblHeader, panelHeader);
        }
        private Form Formhientai;
        private void OpenFormCon(Form form)
        {
            if (Formhientai != null)
            {
                Formhientai.Close();
            }
            Formhientai = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnOpenFormTacGia_Click(object sender, EventArgs e)
        {
            OpenFormCon(new TacGiaGui());
            lblHeader.Text = btnOpenFormTacGia.Text;
            CenterControlInPanel(lblHeader, panelHeader);
        }

        private void btnOpenFormSach_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormSach.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new SachGUI());
        }

        private void btnOpenFormTheLoai_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormTheLoai.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new TheLoaiGUI());
        }

        private void btnOpenFormNhaXuatBan_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormNhaXuatBan.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new NhaXuatBanGUI());
        }

        private void btnOpenFormNhaCungCap_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormNhaCungCap.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new NhaCungCapGUI());
        }

        private void btnOpenFormHoaDon_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormHoaDon.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new HoaDonGUI());
        }

        private void btnOpenFormHoaDonNhap_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormHoaDonNhap.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new HoaDonNhapGUI());
        }

        private void btnOpenFormNguoiDung_Click(object sender, EventArgs e)
        {
            if (Session.Role == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblHeader.Text = btnOpenFormNguoiDung.Text;
                CenterControlInPanel(lblHeader, panelHeader);
                OpenFormCon(new NguoiDungGUI());
            }
           
        }

        private void btnOpenFormKhachHang_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormKhachHang.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new KhachHangGUI());
        }

        private void btnOpenFormCaNhan_Click(object sender, EventArgs e)
        {
            lblHeader.Text = btnOpenFormCaNhan.Text;
            CenterControlInPanel(lblHeader, panelHeader);
            OpenFormCon(new CaNhanGUI());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?","Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.DangXuat();
                this.Close();
                DangNhapGUI frmDangNhap = new DangNhapGUI();
                frmDangNhap.Show();
            }
            
        }

       
    }
}
