using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmThanhVien : Form
    {
        List<ThanhVien_BO> ls;
        BindingSource BS;
        DataGridViewRow dgvrCurrent;
        public frmThanhVien()
        {
            InitializeComponent();
            Load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVien_BO s = new ThanhVien_BO();
                ThanhVien_BL BL = new ThanhVien_BL();
                s.MaTV = "";
                s.HoTen = "";
                s.Email = "";
                s.GioiTinh = "";
                s.NgaySinh = DateTime.Now;
                s.DiaChi = "";
                s.DienThoai = "";
                s.NgayLamThe = DateTime.Now;
                s.NgayHetHan = DateTime.Now;
                List<ThanhVien_BO> ls = (List<ThanhVien_BO>)BS.DataSource;
                ls.Add(s);
                BS = new BindingSource { DataSource = ls };
                dtgv1.DataSource = BS;
                if (dgvrCurrent.IsNewRow == false)
                {
                    MessageBox.Show("Thêm Thành Công!");
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load()
        {
            ThanhVien_BL BL = new ThanhVien_BL();
            ls = BL.LoadThanhVien();
            BS = new BindingSource { DataSource = ls };
            dtgv1.DataSource = BS;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ThanhVien_BO s = new ThanhVien_BO();
            ThanhVien_BL BL = new ThanhVien_BL();
            s.MaTV = tbMaTV.Text;
            s.HoTen = tbHoTen.Text;
            s.Email = tbEmail.Text;
            s.GioiTinh = tbGioiTinh.Text;
            s.NgaySinh = dtNS.Value;
            s.DiaChi = tbDC.Text;
            s.DienThoai = tbDT.Text;
            s.NgayLamThe = dtNLT.Value;
            s.NgayHetHan = dtNHH.Value;
            BL.InsertUpdateTV(s);
            Load();
            if (BL.InsertUpdateTV(s) == true)
            {
                MessageBox.Show("Sửa Thành Công!");
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại!");
            }
        }

        private void dtgv1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dgvrCurrent = dtgv1.CurrentRow;
                if (dgvrCurrent != null)
                {
                    tbMaTV.Text = dgvrCurrent.Cells["MaTV"].Value.ToString();
                    tbHoTen.Text = dgvrCurrent.Cells["HoTen"].Value.ToString();
                    tbEmail.Text = dgvrCurrent.Cells["Email"].Value.ToString();
                    tbGioiTinh.Text = dgvrCurrent.Cells["GioiTinh"].Value.ToString();
                    dtNS.Text = dgvrCurrent.Cells["NgaySinh"].Value.ToString();
                    tbDC.Text = dgvrCurrent.Cells["DiaChi"].Value.ToString();
                    tbDT.Text = dgvrCurrent.Cells["DienThoai"].Value.ToString();
                    dtNLT.Text = dgvrCurrent.Cells["NgayLamThe"].Value.ToString();
                    dtNHH.Text = dgvrCurrent.Cells["NgayHetHan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ThanhVien_BO s = new ThanhVien_BO();
            ThanhVien_BL BL = new ThanhVien_BL();
            s.MaTV = tbMaTV.Text;
            BL.DeleteTV(s);
            Load();
            if (BL.DeleteTV(s) == true)
            {
                MessageBox.Show("Xóa Thành Công!");
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại!");

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            ThanhVien_BO s = new ThanhVien_BO();
            ThanhVien_BL BL = new ThanhVien_BL();
            s.MaTV = tbTK.Text;
            List<ThanhVien_BO> ls = BL.TimTV(s);
            dtgv1.DataSource = ls;
        }
    }
}
