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
    public partial class frmPhieuTra : Form
    {
        DataTable dt;
        DataRow row;
        List<TraSachBO> list = new List<TraSachBO>(); 
        public frmPhieuTra()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Mã Phiếu", typeof(string)));
            dt.Columns.Add(new DataColumn("Mã Sách", typeof(string)));
            dt.Columns.Add(new DataColumn("Mã Nhân Viên", typeof(string)));
            dt.Columns.Add(new DataColumn("Số Lượng", typeof(string)));
            dt.Columns.Add(new DataColumn("Ngày Trả", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Phạt Hư Hỏng", typeof(string)));
            dt.Columns.Add(new DataColumn("Phạt Quá Hạn", typeof(string)));
            dataGridView1.DataSource = dt;
            tbPhatHH.Text = "0";
            tbPhatQH.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            row = dt.NewRow();
            row["Mã Phiếu"] = tbMaPhieu.Text;
            row["Mã Sách"] = tbMaSach.Text;
            row["Mã Nhân Viên"] = tbMaNV.Text;
            row["Số Lượng"] = int.Parse(tbSoLuong.Text);
            row["Ngày Trả"] = dtNgayTra.Value;
            row["Phạt Hư Hỏng"] = int.Parse(tbPhatHH.Text);
            row["Phạt Quá Hạn"] = int.Parse(tbPhatQH.Text);
            dt.Rows.Add(row);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraSachBO ts = new TraSachBO();
            TraSachBL BL = new TraSachBL();
            for (int i =0; i< dataGridView1.Rows.Count; i++)
            {
                try
                {
                    ts.MaPhieu = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    ts.MaSach = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    ts.MaNV = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    ts.SoLuong = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    ts.SachTraNgay =DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    ts.PhatHuHong = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    ts.PhatQuaHan = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    BL.PhieuTra(ts);
                    MessageBox.Show("Lưu Thành Công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            this.Close();
        }
    }
}
