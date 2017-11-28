namespace QuanLyThuVien
{
    partial class frmSeach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.bttiemkiem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LuoiDuLieu_Seach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiDuLieu_Seach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.bttiemkiem);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(599, 83);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(104, 37);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bttiemkiem
            // 
            this.bttiemkiem.Location = new System.Drawing.Point(599, 26);
            this.bttiemkiem.Name = "bttiemkiem";
            this.bttiemkiem.Size = new System.Drawing.Size(104, 37);
            this.bttiemkiem.TabIndex = 4;
            this.bttiemkiem.Text = "Tìm Kiếm";
            this.bttiemkiem.UseVisualStyleBackColor = true;
            this.bttiemkiem.Click += new System.EventHandler(this.bttiemkiem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 32);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LuoiDuLieu_Seach);
            this.groupBox2.Location = new System.Drawing.Point(13, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tìm Kiếm";
            // 
            // LuoiDuLieu_Seach
            // 
            this.LuoiDuLieu_Seach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiDuLieu_Seach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuoiDuLieu_Seach.Location = new System.Drawing.Point(3, 18);
            this.LuoiDuLieu_Seach.Name = "LuoiDuLieu_Seach";
            this.LuoiDuLieu_Seach.RowTemplate.Height = 24;
            this.LuoiDuLieu_Seach.Size = new System.Drawing.Size(729, 422);
            this.LuoiDuLieu_Seach.TabIndex = 0;
            // 
            // frmSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSeach";
            this.Text = "frmSeach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiDuLieu_Seach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bttiemkiem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView LuoiDuLieu_Seach;
    }
}