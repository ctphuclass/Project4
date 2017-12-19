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
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        public int UserID;
        List<ThongTinCN> ls = new List<ThongTinCN>();
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuMuon_BO PhieuMuonS = new PhieuMuon_BO();
            PhieuMuonS.MaPhieu = tbMaPhieuMuon.Text;
            PhieuMuonS.MaThanhVien = tbMaThanhVien.Text;
            PhieuMuonS.NgayMuon = DateTime.Parse(dtpNgayMuon.Text);
            PhieuMuonS.MaNhanVien = "NV0001";
            PhieuMuonS.NgayTra = DateTime.Parse(dtpNgayTra.Text);
            PhieuMuonS.MaSach = tbMaSach.Text;
            PhieuMuonS.SoLuong = int.Parse(tbSoLuong.Text);
            if (PhieuMuon_BL.PhieuMuon(PhieuMuonS) == true)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
                MessageBox.Show("them that bai");
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();
            ThongTinCN TT = new ThongTinCN();
            ls = userBL.ThongTinCN(UserID);
            tbMaThanhVien.Text = ls[0].MaCN;
        }
    }
}
