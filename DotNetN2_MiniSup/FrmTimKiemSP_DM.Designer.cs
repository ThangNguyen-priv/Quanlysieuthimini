namespace DotNetN2_MiniSup
{
    partial class FrmTimKiemSP_DM
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsSanPham = new System.Windows.Forms.DataGridView();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txb_thongTinTimKiem = new System.Windows.Forms.TextBox();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.cbx_chonKhoaTimKiem = new System.Windows.Forms.ComboBox();
            this.lb_chonKhoaTimKiem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục sản phẩm";
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(229, 211);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(246, 33);
            this.cmbDanhMuc.TabIndex = 1;
            this.cmbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cmbDanhMuc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 286);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgv_dsSanPham
            // 
            this.dgv_dsSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsSanPham.Location = new System.Drawing.Point(3, 26);
            this.dgv_dsSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dsSanPham.Name = "dgv_dsSanPham";
            this.dgv_dsSanPham.RowHeadersWidth = 51;
            this.dgv_dsSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsSanPham.Size = new System.Drawing.Size(714, 257);
            this.dgv_dsSanPham.TabIndex = 36;
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.Location = new System.Drawing.Point(235, 14);
            this.lb_tieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(283, 39);
            this.lb_tieuDe.TabIndex = 50;
            this.lb_tieuDe.Text = "Thông tin sản phẩm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Location = new System.Drawing.Point(511, 263);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 33);
            this.btn_thoat.TabIndex = 49;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiem.Location = new System.Drawing.Point(271, 263);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 33);
            this.btn_timkiem.TabIndex = 48;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txb_thongTinTimKiem
            // 
            this.txb_thongTinTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_thongTinTimKiem.Location = new System.Drawing.Point(229, 135);
            this.txb_thongTinTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_thongTinTimKiem.Name = "txb_thongTinTimKiem";
            this.txb_thongTinTimKiem.Size = new System.Drawing.Size(359, 30);
            this.txb_thongTinTimKiem.TabIndex = 47;
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_timKiem.Location = new System.Drawing.Point(13, 135);
            this.lb_timKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(114, 22);
            this.lb_timKiem.TabIndex = 46;
            this.lb_timKiem.Text = "Mã sản phẩm";
            // 
            // cbx_chonKhoaTimKiem
            // 
            this.cbx_chonKhoaTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_chonKhoaTimKiem.FormattingEnabled = true;
            this.cbx_chonKhoaTimKiem.Location = new System.Drawing.Point(229, 71);
            this.cbx_chonKhoaTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_chonKhoaTimKiem.Name = "cbx_chonKhoaTimKiem";
            this.cbx_chonKhoaTimKiem.Size = new System.Drawing.Size(359, 30);
            this.cbx_chonKhoaTimKiem.TabIndex = 45;
            this.cbx_chonKhoaTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbx_chonKhoaTimKiem_SelectedIndexChanged);
            // 
            // lb_chonKhoaTimKiem
            // 
            this.lb_chonKhoaTimKiem.AutoSize = true;
            this.lb_chonKhoaTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chonKhoaTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_chonKhoaTimKiem.Location = new System.Drawing.Point(13, 74);
            this.lb_chonKhoaTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_chonKhoaTimKiem.Name = "lb_chonKhoaTimKiem";
            this.lb_chonKhoaTimKiem.Size = new System.Drawing.Size(166, 22);
            this.lb_chonKhoaTimKiem.TabIndex = 44;
            this.lb_chonKhoaTimKiem.Text = "Chọn khóa tìm kiếm";
            // 
            // FrmTimKiemSP_DM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_tieuDe);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txb_thongTinTimKiem);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.cbx_chonKhoaTimKiem);
            this.Controls.Add(this.lb_chonKhoaTimKiem);
            this.Controls.Add(this.cmbDanhMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTimKiemSP_DM";
            this.Text = "FrmTimKiemSP_DM";
            this.Load += new System.EventHandler(this.FrmTimKiemSP_DM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsSanPham;
        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txb_thongTinTimKiem;
        private System.Windows.Forms.Label lb_timKiem;
        private System.Windows.Forms.ComboBox cbx_chonKhoaTimKiem;
        private System.Windows.Forms.Label lb_chonKhoaTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}