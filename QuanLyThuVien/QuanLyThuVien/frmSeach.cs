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
    public partial class frmSeach : Form
    {
        Seach_BL DSS = new Seach_BL();
        public frmSeach()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttiemkiem_Click(object sender, EventArgs e)
        {
            SeachBO SBO = new SeachBO();
            SBO.TenSach = tbtimkiem.Text;
            List<SeachBO> DSTKS = Seach_BL.DSTK(SBO);      
            LuoiDuLieu_Seach.DataSource = DSTKS;
            //Mã Sách
            LuoiDuLieu_Seach.Columns["MaSach"].HeaderText = "Mã Sách";
            LuoiDuLieu_Seach.Columns["MaSach"].Width = 75;
            // Tên Sách
            LuoiDuLieu_Seach.Columns["TenSach"].HeaderText = "Tên Sách";
            LuoiDuLieu_Seach.Columns["TenSach"].Width = 100;
            //Nhà Xuất Bản
            LuoiDuLieu_Seach.Columns["TenNXB"].HeaderText = "Nhà Xuất Bản";
            LuoiDuLieu_Seach.Columns["TenNXB"].Width = 100;
            //Tác Giả
            LuoiDuLieu_Seach.Columns["TenTG"].HeaderText = "Tác Giả";
            LuoiDuLieu_Seach.Columns["TenTG"].Width = 100;
            //Thể Loại
            LuoiDuLieu_Seach.Columns["TheLoai"].HeaderText = "Thể Loại";
            LuoiDuLieu_Seach.Columns["TheLoai"].Width = 80;
            //Ngày Nhập
            LuoiDuLieu_Seach.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            LuoiDuLieu_Seach.Columns["NgayNhap"].Width = 90;
            //Giá
            LuoiDuLieu_Seach.Columns["Gia"].HeaderText = "Giá";
            LuoiDuLieu_Seach.Columns["Gia"].Width = 50;
            //Số Lượng
            LuoiDuLieu_Seach.Columns["SoLuong"].HeaderText = "Số Lượng";
            LuoiDuLieu_Seach.Columns["SoLuong"].Width = 60;

        }

        private void frmSeach_Load(object sender, EventArgs e)
        {
           
        }

        private void LuoiDuLieu_Seach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPhieuMuon PM = new frmPhieuMuon();
            DataGridViewRow dr = LuoiDuLieu_Seach.CurrentRow;
            if (dr.Cells["MaSach"].Selected == true)
            {
                PM.Show();
                PM.tbMaSach.Text = dr.Cells["MaSach"].Value.ToString();
            }
        }
    }
}
