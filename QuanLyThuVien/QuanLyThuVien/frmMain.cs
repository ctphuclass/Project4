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
        private clsImage gifImage = null;
        private string filePath = @"C:\Users\HP\Source\Repos\Project4\QuanLyThuVien\QuanLyThuVien\Resources\bgLogo.gif";
        public frmMain()
        {
            InitializeComponent();
            gifImage = new clsImage(filePath);
            gifImage.ReverseAtEnd = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = gifImage.GetNextFrame();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDoiMK.Enabled = false;
            btnThongTin.Enabled = false;
            btnThongTinBanThan.Enabled = false;
            btnDSNV.Enabled = false;
            BtnDangXuat.Enabled = false;
            btnDoiMK1.Enabled = false;
            btnThongTinNV.Enabled = false;
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
    }
}
