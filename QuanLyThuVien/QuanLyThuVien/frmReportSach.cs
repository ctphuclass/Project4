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
    public partial class frmReportSach : Form
    {
        DataView dv2;
        public frmReportSach()
        {
            InitializeComponent();
        }

        private void frmReportSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyThuVienDataSet3.TRASACH' table. You can move, or remove it, as needed.
            this.TRASACHTableAdapter.Fill(this.QuanLyThuVienDataSet3.TRASACH);
            // TODO: This line of code loads data into the 'QuanLyThuVienDataSet1.THANHVIEN' table. You can move, or remove it, as needed.
            this.THANHVIENTableAdapter.Fill(this.QuanLyThuVienDataSet1.THANHVIEN);
            dv2 = new DataView();
            // TODO: This line of code loads data into the 'QuanLyThuVienDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QuanLyThuVienDataSet1.DataTable1);
            DataTable1BindingSource.DataSource = dv2;
            this.reportViewer1.RefreshReport();
        }
    }
}
