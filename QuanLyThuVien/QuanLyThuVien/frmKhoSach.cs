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
    public partial class frmKhoSach : Form
    {
        public frmKhoSach()
        {
            InitializeComponent();
        }

        private void frmKhoSach_Load(object sender, EventArgs e)
        {
            LoadKhoSach();
            LuoiThongTinPhieuMuon.Columns["MaSach"].HeaderText = "Mã Sách";
            LuoiThongTinPhieuMuon.Columns["TenSach"].HeaderText = "Tên Sách";
            LuoiThongTinPhieuMuon.Columns["Gia"].HeaderText = "Giá Sách";
            LuoiThongTinPhieuMuon.Columns["DaMuon"].HeaderText = "Đã Mượn";
            LuoiThongTinPhieuMuon.Columns["ConLai"].HeaderText = "Còn Lại";
        }

        void LoadKhoSach()
        {
            List<KhoSach_BO> DanhSachPM = QL_PhieuMuon_BL.LoadPhieuMuon();
            LuoiThongTinPhieuMuon.DataSource = DanhSachPM;
        }
    }
}
