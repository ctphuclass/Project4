namespace QuanLyThuVien
{
    partial class frmDanhSachPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LuoiThongTinPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiThongTinPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Old English Text MT", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(658, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 38);
            this.label13.TabIndex = 26;
            this.label13.Text = "Danh Sách Phiếu Mượn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuoiThongTinPhieuMuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 250);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // LuoiThongTinPhieuMuon
            // 
            this.LuoiThongTinPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LuoiThongTinPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiThongTinPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuoiThongTinPhieuMuon.Location = new System.Drawing.Point(3, 18);
            this.LuoiThongTinPhieuMuon.Name = "LuoiThongTinPhieuMuon";
            this.LuoiThongTinPhieuMuon.RowTemplate.Height = 24;
            this.LuoiThongTinPhieuMuon.Size = new System.Drawing.Size(1234, 229);
            this.LuoiThongTinPhieuMuon.TabIndex = 0;
            // 
            // frmDanhSachPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "frmDanhSachPhieuMuon";
            this.Text = "frmDanhSachPhieuMuon";
            this.Load += new System.EventHandler(this.frmDanhSachPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiThongTinPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView LuoiThongTinPhieuMuon;
    }
}