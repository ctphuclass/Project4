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
    public partial class frmReportNhanVien : Form
    {
        DataView dv;
        public frmReportNhanVien()
        {
            InitializeComponent();
        }

        private void frmReportNhanVien_Load(object sender, EventArgs e)
        {
            dv = new DataView();
            // TODO: This line of code loads data into the 'QuanLyThuVienDataSet.THANHVIEN' table. You can move, or remove it, as needed.
            this.THANHVIENTableAdapter.Fill(this.QuanLyThuVienDataSet.THANHVIEN);
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
