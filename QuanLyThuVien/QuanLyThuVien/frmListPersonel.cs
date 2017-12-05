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

        void LoadNV()
        {
            List<NhanVien_BO> DSTCNV = NhanVien_BL.DanhSachNhanVien();
            LuoiDuLieuNhanVien.DataSource = DSTCNV;
        }

        //Load Dữ Liệu Và Thiết Kế Soure
        #region
        private void frmListPersonel_Load(object sender, EventArgs e)
        {
            LoadNV();
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
        #endregion

        //Đưa Dữ Liệu Từ Soure Vào TextBox
        #region
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
        #endregion


        private void bttimkiemnhanvien_Click(object sender, EventArgs e)
        {
           NhanVien_BO NVBO = new NhanVien_BO();
            NVBO.HoTenNV = tbtknv.Text;
            List<NhanVien_BO> DSTKS = NhanVien_BL.TimKiemNhanVienBL(NVBO);
            LuoiDuLieuNhanVien.DataSource = DSTKS;
        }

        //Button Thêm
        #region
        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVien_BO NhanVien = new NhanVien_BO();
            NhanVien.MaNV = tbMaNhanVien.Text;
            NhanVien.HoTenNV = tbHoTenNhanVien.Text;
            NhanVien.GioiTinh = tbGioiTinh.Text;
            NhanVien.NgaySinh = DateTime.Parse(DTPNgaySinh.Text);
            NhanVien.SoDienThoai = tbSoDienThoai.Text;
            NhanVien.DiaChi = tbDiaChi.Text;
            NhanVien.Email = tbEmail.Text;
            NhanVien.NgayVaoLam = DateTime.Parse(DTPNgayVaoLam.Text);
            if (NhanVien_BL.Them(NhanVien) == true)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
                MessageBox.Show("them that bai");
            LoadNV();
        }
        #endregion

        //Button Sửa
        #region
        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVien_BO NhanVien = new NhanVien_BO();
            NhanVien.HoTenNV = tbHoTenNhanVien.Text;
            NhanVien.GioiTinh = tbGioiTinh.Text;
            NhanVien.NgaySinh = DateTime.Parse(DTPNgaySinh.Text);
            NhanVien.SoDienThoai = tbSoDienThoai.Text;
            NhanVien.DiaChi = tbDiaChi.Text;
            NhanVien.Email = tbEmail.Text;
            NhanVien.NgayVaoLam = DateTime.Parse(DTPNgayVaoLam.Text);
            NhanVien.MaNV = tbMaNhanVien.Text;
            if(NhanVien_BL.Sua(NhanVien) == true)
            {
                MessageBox.Show("Sửa Thành Công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa Thất bại!", "Cảnh báo");
            }
            LoadNV();
        }
        #endregion

        private void btXoa_Click(object sender, EventArgs e)
        {
            NhanVien_BO NhanVien = new NhanVien_BO();
            NhanVien.MaNV = tbMaNhanVien.Text;
            if (NhanVien_BL.Sua(NhanVien) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!", "Cảnh báo");
            }
            LoadNV();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
