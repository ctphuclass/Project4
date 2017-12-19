namespace QuanLyThuVien
{
    partial class frmThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMaTV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNLT = new System.Windows.Forms.DateTimePicker();
            this.dtNHH = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Location = new System.Drawing.Point(214, 233);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(570, 66);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng Quản Lý";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(444, 17);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 37);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "   Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(313, 17);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 37);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "   Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.Control;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(174, 17);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(89, 37);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "  Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.Control;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(38, 17);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 37);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "   Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTimKiem);
            this.groupBox4.Controls.Add(this.tbTK);
            this.groupBox4.Location = new System.Drawing.Point(216, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(570, 56);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(455, 13);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(89, 35);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(26, 17);
            this.tbTK.Margin = new System.Windows.Forms.Padding(2);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(397, 25);
            this.tbTK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv1);
            this.groupBox2.Location = new System.Drawing.Point(214, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(572, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Thẻ Thư Viện";
            // 
            // dtgv1
            // 
            this.dtgv1.AllowUserToAddRows = false;
            this.dtgv1.AllowUserToDeleteRows = false;
            this.dtgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv1.Location = new System.Drawing.Point(2, 15);
            this.dtgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(568, 140);
            this.dtgv1.TabIndex = 0;
            this.dtgv1.CurrentCellChanged += new System.EventHandler(this.dtgv1_CurrentCellChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNHH);
            this.groupBox1.Controls.Add(this.dtNLT);
            this.groupBox1.Controls.Add(this.tbGioiTinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtNS);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.tbDC);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbMaTV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(199, 288);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thẻ Thư Viện";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(80, 101);
            this.tbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(114, 20);
            this.tbGioiTinh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Giới Tính";
            // 
            // tbDT
            // 
            this.tbDT.Location = new System.Drawing.Point(80, 180);
            this.tbDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(114, 20);
            this.tbDT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Điện Thoại";
            // 
            // dtNS
            // 
            this.dtNS.CustomFormat = "dd/MM/yyyy";
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNS.Location = new System.Drawing.Point(81, 129);
            this.dtNS.Margin = new System.Windows.Forms.Padding(2);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(114, 20);
            this.dtNS.TabIndex = 5;
            this.dtNS.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(80, 52);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(114, 20);
            this.tbHoTen.TabIndex = 1;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(80, 153);
            this.tbDC.Margin = new System.Windows.Forms.Padding(2);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(114, 20);
            this.tbDC.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(80, 76);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(114, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbMaTV
            // 
            this.tbMaTV.Location = new System.Drawing.Point(80, 28);
            this.tbMaTV.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaTV.Name = "tbMaTV";
            this.tbMaTV.Size = new System.Drawing.Size(114, 20);
            this.tbMaTV.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày Hết Hạn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Làm Thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TV";
            // 
            // dtNLT
            // 
            this.dtNLT.CustomFormat = "dd/MM/yyyy";
            this.dtNLT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNLT.Location = new System.Drawing.Point(80, 209);
            this.dtNLT.Margin = new System.Windows.Forms.Padding(2);
            this.dtNLT.Name = "dtNLT";
            this.dtNLT.Size = new System.Drawing.Size(114, 20);
            this.dtNLT.TabIndex = 23;
            this.dtNLT.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            // 
            // dtNHH
            // 
            this.dtNHH.CustomFormat = "dd/MM/yyyy";
            this.dtNHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNHH.Location = new System.Drawing.Point(80, 237);
            this.dtNHH.Margin = new System.Windows.Forms.Padding(2);
            this.dtNHH.Name = "dtNHH";
            this.dtNHH.Size = new System.Drawing.Size(114, 20);
            this.dtNHH.TabIndex = 24;
            this.dtNHH.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 307);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhVien";
            this.Text = "Quản Lý Thẻ Thư Viện";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMaTV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNHH;
        private System.Windows.Forms.DateTimePicker dtNLT;
    }
}