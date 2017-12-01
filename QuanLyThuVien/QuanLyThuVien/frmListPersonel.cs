using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using BusinessLogic;

namespace QuanLyThuVien
{
    public partial class frmListPersonel : Form
    {
        public frmListPersonel()
        {
            InitializeComponent();
        }

        private void frmListPersonel_Load(object sender, EventArgs e)
        {
            List<NhanVien_BO> DSTCNV = NhanVien_BL.DanhSachNhanVien();
            LuoiDuLieuNhanVien.DataSource = DSTCNV;
            LuoiDuLieuNhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            LuoiDuLieuNhanVien.Columns["MaNV"].Width = 100;
            LuoiDuLieuNhanVien.Columns["HoTenNV"].HeaderText = "Họ Tên";
            LuoiDuLieuNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            LuoiDuLieuNhanVien.Columns["GioiTinh"].Width = 60;
            LuoiDuLieuNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            LuoiDuLieuNhanVien.Columns["NgaySinh"].Width = 80;
            LuoiDuLieuNhanVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            LuoiDuLieuNhanVien.Columns["SoDienThoai"].Width = 100;
            LuoiDuLieuNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            LuoiDuLieuNhanVien.Columns["DiaChi"].Width = 80;
            LuoiDuLieuNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
            LuoiDuLieuNhanVien.Columns["NgayVaoLam"].Width = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LuoiDuLieuNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgrv = LuoiDuLieuNhanVien.CurrentRow;
            tbMaNhanVien.Text = dgrv.Cells["MaNV"].Value.ToString();
            tbHoTenNhanVien.Text = dgrv.Cells["HoTenNV"].Value.ToString();
            tbGioiTinh.Text = dgrv.Cells["GioiTinh"].Value.ToString();
            if(tbGioiTinh.Text == "True")
            {
                tbGioiTinh.Text = "Nam";
            }
            else
            {
                tbGioiTinh.Text = "Nữ";
            }
            tbSoDienThoai.Text = dgrv.Cells["SoDienThoai"].Value.ToString();
            tbDiaChi.Text = dgrv.Cells["DiaChi"].Value.ToString();
            tbEmail.Text = dgrv.Cells["Email"].Value.ToString();
            DTPNgaySinh.Text = dgrv.Cells["NgaySinh"].Value.ToString();
            DTPNgayVaoLam.Text = dgrv.Cells["NgayVaoLam"].Value.ToString();
        }
    }
}
