namespace QuanLyThuVien
{
    partial class frmKhoSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoSach));
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
            this.label13.Font = new System.Drawing.Font("MercuriusScript", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(202, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 33);
            this.label13.TabIndex = 27;
            this.label13.Text = "Kho Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuoiThongTinPhieuMuon);
            this.groupBox1.Location = new System.Drawing.Point(9, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(523, 204);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // LuoiThongTinPhieuMuon
            // 
            this.LuoiThongTinPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LuoiThongTinPhieuMuon.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.LuoiThongTinPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiThongTinPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuoiThongTinPhieuMuon.Location = new System.Drawing.Point(2, 15);
            this.LuoiThongTinPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.LuoiThongTinPhieuMuon.Name = "LuoiThongTinPhieuMuon";
            this.LuoiThongTinPhieuMuon.RowTemplate.Height = 24;
            this.LuoiThongTinPhieuMuon.Size = new System.Drawing.Size(519, 187);
            this.LuoiThongTinPhieuMuon.TabIndex = 0;
            // 
            // frmKhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKhoSach";
            this.Text = "Kho Sách";
            this.Load += new System.EventHandler(this.frmKhoSach_Load);
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