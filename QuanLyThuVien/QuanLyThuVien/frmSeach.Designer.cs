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
            this.tbtimkiem = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.tbtimkiem);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.MediumOrchid;
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btthoat.Location = new System.Drawing.Point(787, 31);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(125, 45);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bttiemkiem
            // 
            this.bttiemkiem.BackColor = System.Drawing.Color.MediumOrchid;
            this.bttiemkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttiemkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttiemkiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttiemkiem.Location = new System.Drawing.Point(639, 31);
            this.bttiemkiem.Name = "bttiemkiem";
            this.bttiemkiem.Size = new System.Drawing.Size(119, 45);
            this.bttiemkiem.TabIndex = 4;
            this.bttiemkiem.Text = "Tìm Kiếm";
            this.bttiemkiem.UseVisualStyleBackColor = false;
            this.bttiemkiem.Click += new System.EventHandler(this.bttiemkiem_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(16, 43);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(580, 25);
            this.tbtimkiem.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LuoiDuLieu_Seach);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tìm Kiếm";
            // 
            // LuoiDuLieu_Seach
            // 
            this.LuoiDuLieu_Seach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LuoiDuLieu_Seach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LuoiDuLieu_Seach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiDuLieu_Seach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuoiDuLieu_Seach.Location = new System.Drawing.Point(3, 18);
            this.LuoiDuLieu_Seach.Name = "LuoiDuLieu_Seach";
            this.LuoiDuLieu_Seach.RowTemplate.Height = 24;
            this.LuoiDuLieu_Seach.Size = new System.Drawing.Size(929, 270);
            this.LuoiDuLieu_Seach.TabIndex = 0;
            // 
            // frmSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(34)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(959, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmSeach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiDuLieu_Seach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bttiemkiem;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.DataGridView LuoiDuLieu_Seach;
    }
}