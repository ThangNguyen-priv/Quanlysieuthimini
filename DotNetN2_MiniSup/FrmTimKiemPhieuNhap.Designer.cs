﻿namespace DotNetN2_MiniSup
{
    partial class FrmTimKiemPhieuNhap
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
            this.dgv_dsHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txb_thongTinTimKiem = new System.Windows.Forms.TextBox();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.cbx_chonKhoaTimKiem = new System.Windows.Forms.ComboBox();
            this.lb_chonKhoaTimKiem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dpk_ngayNhapSau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpk_ngayNhapTruoc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 305);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khách hàng";
            // 
            // dgv_dsHoaDon
            // 
            this.dgv_dsHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsHoaDon.Location = new System.Drawing.Point(3, 26);
            this.dgv_dsHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dsHoaDon.Name = "dgv_dsHoaDon";
            this.dgv_dsHoaDon.RowHeadersWidth = 51;
            this.dgv_dsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsHoaDon.Size = new System.Drawing.Size(839, 276);
            this.dgv_dsHoaDon.TabIndex = 36;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiem.Location = new System.Drawing.Point(278, 249);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(156, 42);
            this.btn_timkiem.TabIndex = 52;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.Location = new System.Drawing.Point(236, 1);
            this.lb_tieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(264, 39);
            this.lb_tieuDe.TabIndex = 54;
            this.lb_tieuDe.Text = "Thông tin hóa đơn";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Location = new System.Drawing.Point(514, 249);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 42);
            this.btn_thoat.TabIndex = 53;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // txb_thongTinTimKiem
            // 
            this.txb_thongTinTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_thongTinTimKiem.Location = new System.Drawing.Point(255, 114);
            this.txb_thongTinTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_thongTinTimKiem.Name = "txb_thongTinTimKiem";
            this.txb_thongTinTimKiem.Size = new System.Drawing.Size(359, 30);
            this.txb_thongTinTimKiem.TabIndex = 51;
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_timKiem.Location = new System.Drawing.Point(36, 122);
            this.lb_timKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(104, 22);
            this.lb_timKiem.TabIndex = 50;
            this.lb_timKiem.Text = "Mã hóa đơn";
            // 
            // cbx_chonKhoaTimKiem
            // 
            this.cbx_chonKhoaTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_chonKhoaTimKiem.FormattingEnabled = true;
            this.cbx_chonKhoaTimKiem.Location = new System.Drawing.Point(255, 58);
            this.cbx_chonKhoaTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_chonKhoaTimKiem.Name = "cbx_chonKhoaTimKiem";
            this.cbx_chonKhoaTimKiem.Size = new System.Drawing.Size(359, 30);
            this.cbx_chonKhoaTimKiem.TabIndex = 49;
            this.cbx_chonKhoaTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbx_chonKhoaTimKiem_SelectedIndexChanged);
            // 
            // lb_chonKhoaTimKiem
            // 
            this.lb_chonKhoaTimKiem.AutoSize = true;
            this.lb_chonKhoaTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chonKhoaTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_chonKhoaTimKiem.Location = new System.Drawing.Point(36, 66);
            this.lb_chonKhoaTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_chonKhoaTimKiem.Name = "lb_chonKhoaTimKiem";
            this.lb_chonKhoaTimKiem.Size = new System.Drawing.Size(166, 22);
            this.lb_chonKhoaTimKiem.TabIndex = 48;
            this.lb_chonKhoaTimKiem.Text = "Chọn khóa tìm kiếm";
            // 
            // dpk_ngayNhapSau
            // 
            this.dpk_ngayNhapSau.CustomFormat = "dd/MM/yyyy";
            this.dpk_ngayNhapSau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_ngayNhapSau.Location = new System.Drawing.Point(539, 179);
            this.dpk_ngayNhapSau.Name = "dpk_ngayNhapSau";
            this.dpk_ngayNhapSau.Size = new System.Drawing.Size(179, 30);
            this.dpk_ngayNhapSau.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(460, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "đến";
            // 
            // dpk_ngayNhapTruoc
            // 
            this.dpk_ngayNhapTruoc.CustomFormat = "dd/MM/yyyy";
            this.dpk_ngayNhapTruoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_ngayNhapTruoc.Location = new System.Drawing.Point(255, 179);
            this.dpk_ngayNhapTruoc.Name = "dpk_ngayNhapTruoc";
            this.dpk_ngayNhapTruoc.Size = new System.Drawing.Size(179, 30);
            this.dpk_ngayNhapTruoc.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ngày lập Hóa đơn";
            // 
            // FrmTimKiemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.lb_tieuDe);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txb_thongTinTimKiem);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.cbx_chonKhoaTimKiem);
            this.Controls.Add(this.lb_chonKhoaTimKiem);
            this.Controls.Add(this.dpk_ngayNhapSau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpk_ngayNhapTruoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTimKiemPhieuNhap";
            this.Text = "FrmTimKiemPhieuNhap";
            this.Load += new System.EventHandler(this.FrmTimKiemPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsHoaDon;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txb_thongTinTimKiem;
        private System.Windows.Forms.Label lb_timKiem;
        private System.Windows.Forms.ComboBox cbx_chonKhoaTimKiem;
        private System.Windows.Forms.Label lb_chonKhoaTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dpk_ngayNhapSau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpk_ngayNhapTruoc;
        private System.Windows.Forms.Label label1;
    }
}