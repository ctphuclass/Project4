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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultMessageBO result;
            UserBO userBO = new UserBO();
            UserBL userBL = new UserBL();
            userBO.Username = tbTK.Text;
            userBO.Password = tbMK.Text;
            userBO.ChangePassword = tbDMK.Text;
            result = userBL.ChangeUserLoginBL(userBO);
            MessageBox.Show(result.ResultMessage);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
