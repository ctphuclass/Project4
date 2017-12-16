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
    public partial class frmQLSach : Form
    {
        List<SachBO> ls;
        BindingSource BS;
        DataGridViewRow dgvrCurrent;
        public frmQLSach()
        {
            InitializeComponent();
            Load();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SachBO s = new SachBO();
                SachBL BL = new SachBL();
                s.MaSach = "";
                s.TenSach = "";
                s.MaNXB = "";
                s.MaTheLoai = "";
                s.SoLuong = 0;
                s.DonGia = 0;
                s.MaTacGia = "";
                s.SoTrang = 0;
                s.NgayNhap = DateTime.Now;
                s.MaTacGia = "";
                s.TinhTrang = false;
                List<SachBO> ls = (List<SachBO>)BS.DataSource;
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
            SachBL BL = new SachBL();
            ls = BL.LoadSach();
            BS = new BindingSource { DataSource = ls };
            dtgv1.DataSource = BS;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SachBO s = new SachBO();
            SachBL BL = new SachBL();
            s.MaSach = tbMaSach.Text;
            s.TenSach = tbTenSach.Text; 
            s.MaNXB = tbMaNXB.Text;
            s.MaTheLoai = tbMaTL.Text; 
            s.SoLuong = int.Parse(tbSoLuog.Text); 
            s.DonGia = int.Parse(tbGia.Text);
            s.MaTacGia = tbMaTG.Text; 
            s.SoTrang = int.Parse(tbSoTrang.Text); 
            s.NgayNhap = dtNgayNhap.Value; 
            s.MaTacGia = tbMaTG.Text; 
            s.TinhTrang = bool.Parse(tbTinhTrang.Text); 
            BL.InsertUpdate(s);
            Load();
            if (BL.InsertUpdate(s) == true)
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
                    tbMaSach.Text = dgvrCurrent.Cells["MaSach"].Value.ToString();
                    tbTenSach.Text = dgvrCurrent.Cells["TenSach"].Value.ToString();
                    tbSoTrang.Text = dgvrCurrent.Cells["SoTrang"].Value.ToString();
                    tbGia.Text = dgvrCurrent.Cells["DonGia"].Value.ToString();
                    tbSoLuog.Text = dgvrCurrent.Cells["SoLuong"].Value.ToString();
                    dtNgayNhap.Text = dgvrCurrent.Cells["NgayNhap"].Value.ToString();
                    tbMaNXB.Text = dgvrCurrent.Cells["MaNXB"].Value.ToString();
                    tbMaTG.Text = dgvrCurrent.Cells["MaTacGia"].Value.ToString();
                    tbMaTL.Text = dgvrCurrent.Cells["MaTheLoai"].Value.ToString();
                    tbTinhTrang.Text = dgvrCurrent.Cells["TinhTrang"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SachBO s = new SachBO();
            SachBL BL = new SachBL();
            s.MaSach = tbMaSach.Text;
            BL.Delete(s);
            Load();
            if (BL.Delete(s) == true)
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

        private void tbMaTL_TextChanged(object sender, EventArgs e)
        {
            tbMaTL.MaxLength = 6;
        }

        private void tbMaNXB_TextChanged(object sender, EventArgs e)
        {
            tbMaNXB.MaxLength = 6;
        }

        private void tbMaTG_TextChanged(object sender, EventArgs e)
        {
            tbMaTG.MaxLength = 6;
        }

        private void tbMaSach_TextChanged(object sender, EventArgs e)
        {
            tbMaSach.MaxLength = 8;
        }

        private void tbTinhTrang_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SachBO s = new SachBO();
            SachBL BL = new SachBL();
            s.MaSach = tbTimKiemSach.Text;
            List<SachBO> ls = BL.TimSach(s);
            dtgv1.DataSource = ls;
        }
    }
}
