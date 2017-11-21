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
    public partial class frmLogin : Form
    {
        public int UserID;
        public frmLogin()
        {

            InitializeComponent();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            UserID = 0;
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ResultMessageBO result;
            UserBO userBO = new UserBO();
            UserBL userBL = new UserBL();
            userBO.Username = tbTenDangNhap.Text;
            userBO.Password = tbMK.Text;
            result = userBL.CheckUserLoginBL(userBO);
            if (result.ResultCode > 0)
            {
                UserID = result.ResultCode;
                MessageBox.Show(result.ResultMessage);
                this.Close();
                
            }
            else
            {
                MessageBox.Show(result.ResultMessage);
            }
        }
    }
}
