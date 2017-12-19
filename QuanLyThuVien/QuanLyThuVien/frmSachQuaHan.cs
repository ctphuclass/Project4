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
    public partial class frmSachQuaHan : Form
    {
        List<SachQH_BO> ls;
        BindingSource BS;
        public frmSachQuaHan()
        {
            InitializeComponent();
            Load();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public void Load()
        {
            SachQH_BL BL = new SachQH_BL();
            ls = BL.LoadSachQH();
            BS = new BindingSource { DataSource = ls };
            LuoiThongTinPhieuMuon.DataSource = BS;
        }
    }
}
