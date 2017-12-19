using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessObject;

namespace QuanLyThuVien
{
    public partial class frmDanhSachPhieuMuon : Form
    {
        List<TraSachBO> ls;
        BindingSource BS;
        public frmDanhSachPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadThanhVienM();
            LoadTraSach();
            LuoiThongTinPhieuMuon.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
            LuoiThongTinPhieuMuon.Columns["MaPhieu"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["MaSach"].HeaderText = "Mã Sách";
            LuoiThongTinPhieuMuon.Columns["MaSach"].Width = 73;
            LuoiThongTinPhieuMuon.Columns["TenSach"].HeaderText = "Tên Sách";
            LuoiThongTinPhieuMuon.Columns["TenSach"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["MaTV"].HeaderText = "Mã Thành Viên";
            LuoiThongTinPhieuMuon.Columns["MaTV"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["HoTen"].HeaderText = "Họ Tên";
            LuoiThongTinPhieuMuon.Columns["HoTen"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            LuoiThongTinPhieuMuon.Columns["NgayMuon"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["NgayTra"].HeaderText = "Ngày Trả";
            LuoiThongTinPhieuMuon.Columns["NgayTra"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["SoLuong"].HeaderText = "Số Lượng";
            LuoiThongTinPhieuMuon.Columns["SoLuong"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            LuoiThongTinPhieuMuon.Columns["DiaChi"].Width = 75;
            LuoiThongTinPhieuMuon.Columns["SoDienThoai"].HeaderText = "Điện Thoại";
            LuoiThongTinPhieuMuon.Columns["SoDienThoai"].Width = 70;
            LuoiThongTinPhieuMuon.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            LuoiThongTinPhieuMuon.Columns["MaNV"].Width = 75;
        }

        void LoadThanhVienM()
        {
            List<ThanhVienMuonSach_BO> DanhSachTVM = QL_PhieuMuon_BL.LoadTVMuon();
            LuoiThongTinPhieuMuon.DataSource = DanhSachTVM;
        }
        public void LoadTraSach()
        {
            TraSachBL BL = new TraSachBL();
            ls = BL.LoadTraSach();
            BS = new BindingSource { DataSource = ls };
            dataGridView1.DataSource = BS;
        }
    }
}
