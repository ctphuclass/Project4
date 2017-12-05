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

    public partial class frmMain : Form
    {
        public int UserID;
        private List<UserPermissionBO> listPermission;
        UserBL userBL;
        frmLogin fLogin;
        UserPermissionBO result;
        frmSeach TimKiem = new frmSeach();
        frmListPersonel NhanVien = new frmListPersonel();
        private clsImage gifImage = null;
        public frmMain()
        {
            InitializeComponent();
            gifImage = new clsImage(Properties.Resources.bgLogo);
            gifImage.ReverseAtEnd = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            userBL = new UserBL();
            fLogin = new frmLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fLogin.ShowDialog();
            if (fLogin.UserID > 0)
            {
                this.UserID = fLogin.UserID;
                listPermission = userBL.GetPermission(fLogin.UserID, "MAIN");
                CheckPermission();
                BtnDangXuat.Enabled = true;
                btnLogin.Enabled = false;
                btnDoiMK.Enabled = true;
                btnThongTin.Enabled = true;
            }
        }
        Random ramdom = new Random();
        int x = 0, y = 24, a = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if (x > 250)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(ramdom.Next(0, 255), ramdom.Next(0, 255), ramdom.Next(0, 255));
                }
                if (x < 0)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(ramdom.Next(0, 255), ramdom.Next(0, 255), ramdom.Next(0, 255));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            fLogin.tbTenDangNhap.Text = "";
            fLogin.tbMK.Text = "";
            btnThongTin.Enabled = false;
            btnDSNV.Enabled = false;
            BtnDangXuat.Enabled = false;
            btnDoiMK.Enabled = false;
            btnTTTTV.Enabled = false;
            btnTTS.Enabled = false;
            btnPhieuMuon.Enabled = false;
            btnPhieuTra.Enabled = false;
            btnRThanhVien.Enabled = false;
            btnRTraSach.Enabled = false;
            btnSCM.Enabled = false;
            btnLuotMuon.Enabled = false;
            btnMSQH.Enabled = false;
            btnLogin.Enabled = true;
            fLogin.UserID = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = gifImage.GetNextFrame();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            TimKiem.ShowDialog();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            NhanVien.ShowDialog();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTinCN frmTT = new frmThongTinCN();
            frmTT.UserID = this.UserID;
            frmTT.ShowDialog();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK frmDMK = new frmDoiMK();
            frmDMK.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDoiMK.Enabled = false;
            btnThongTin.Enabled = false;
            btnDSNV.Enabled = false;
            BtnDangXuat.Enabled = false;
            btnTTTTV.Enabled = false;
            btnTTS.Enabled = false;
            btnPhieuMuon.Enabled = false;
            btnPhieuTra.Enabled = false;
            btnRThanhVien.Enabled = false;
            btnRTraSach.Enabled = false;
            btnSCM.Enabled = false;
            btnLuotMuon.Enabled = false;
            btnMSQH.Enabled = false;
        }
        public void CheckPermission()
        {

            result = listPermission.Find(item => item.Permission == "ADMIN");
            if (result != null)
            {
                btnDSNV.Enabled = true;
                btnTTTTV.Enabled = true;
                btnTTS.Enabled = true;
                btnPhieuMuon.Enabled = true;
                btnPhieuTra.Enabled = true;
                btnRThanhVien.Enabled = true;
                btnRTraSach.Enabled = true;
                btnSCM.Enabled = true;
                btnLuotMuon.Enabled = true;
                btnMSQH.Enabled = true;
            }
            result = listPermission.Find(item => item.Permission == "TV");
            if (result != null)
            {
                btnDSNV.Enabled = false;
                btnTTTTV.Enabled = false;
                btnTTS.Enabled = false;
                btnPhieuMuon.Enabled = true;
                btnPhieuTra.Enabled = true;
                btnRThanhVien.Enabled = false;
                btnRTraSach.Enabled = false;
                btnSCM.Enabled = false;
                btnLuotMuon.Enabled = false;
                btnMSQH.Enabled = false;
            }
        }
    }
}
