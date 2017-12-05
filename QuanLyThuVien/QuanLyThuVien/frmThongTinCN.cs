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
    public partial class frmThongTinCN : Form
    {
        public int UserID;
       
        List<ThongTinCN> ls = new List<ThongTinCN>();
        public frmThongTinCN()
        {
            InitializeComponent();

        }
        public void TT()
        {
            //frmMain fM = new frmMain();
            UserBL userBL = new UserBL();
            ThongTinCN TT = new ThongTinCN();
            //fM.UserID = UserID;
            ls = userBL.ThongTinCN(UserID);
            tbGT.Text = ls[0].GioiTinh;
            tbHoTen.Text = ls[0].HoTen;
            tbMa.Text = ls[0].MaCN;
            tbSDT.Text = ls[0].SDT.ToString();
            tbEmail.Text = ls[0].Emial;
            dtNgaySinh.Value = ls[0].NgaySinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinCN_Load(object sender, EventArgs e)
        {
            TT();
        }
    }
}
