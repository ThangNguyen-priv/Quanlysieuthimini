namespace DotNetN2_MiniSup
{
    partial class FrmHoaDon
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
            this.dgv_cthd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hienthicthd = new System.Windows.Forms.Button();
            this.btn_hienthihd = new System.Windows.Forms.Button();
            this.btn_suacthd = new System.Windows.Forms.Button();
            this.btn_xoacthd = new System.Windows.Forms.Button();
            this.btn_themcthd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_msp = new System.Windows.Forms.ComboBox();
            this.cbx_mahd = new System.Windows.Forms.ComboBox();
            this.txt_cthddg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cthdsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.cbx_kh = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.dt_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txt_mhd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_hd = new System.Windows.Forms.DataGridView();
            this.btn_xuatEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cthd
            // 
            this.dgv_cthd.AllowUserToAddRows = false;
            this.dgv_cthd.AllowUserToDeleteRows = false;
            this.dgv_cthd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cthd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_cthd.Location = new System.Drawing.Point(603, 372);
            this.dgv_cthd.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cthd.Name = "dgv_cthd";
            this.dgv_cthd.ReadOnly = true;
            this.dgv_cthd.RowHeadersWidth = 48;
            this.dgv_cthd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cthd.Size = new System.Drawing.Size(569, 365);
            this.dgv_cthd.TabIndex = 124;
            this.dgv_cthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cthd_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xuatEx);
            this.groupBox1.Controls.Add(this.btn_hienthicthd);
            this.groupBox1.Controls.Add(this.btn_hienthihd);
            this.groupBox1.Controls.Add(this.btn_suacthd);
            this.groupBox1.Controls.Add(this.btn_xoacthd);
            this.groupBox1.Controls.Add(this.btn_themcthd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_msp);
            this.groupBox1.Controls.Add(this.cbx_mahd);
            this.groupBox1.Controls.Add(this.txt_cthddg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cthdsl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_macthd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.cbx_kh);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.dt_ngaylap);
            this.groupBox1.Controls.Add(this.txt_mhd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 725);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btn_hienthicthd
            // 
            this.btn_hienthicthd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hienthicthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hienthicthd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthicthd.Location = new System.Drawing.Point(45, 575);
            this.btn_hienthicthd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthicthd.Name = "btn_hienthicthd";
            this.btn_hienthicthd.Size = new System.Drawing.Size(100, 38);
            this.btn_hienthicthd.TabIndex = 138;
            this.btn_hienthicthd.Text = "Hiển thị";
            this.btn_hienthicthd.UseVisualStyleBackColor = false;
            this.btn_hienthicthd.Click += new System.EventHandler(this.btn_hienthicthd_Click);
            // 
            // btn_hienthihd
            // 
            this.btn_hienthihd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hienthihd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hienthihd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthihd.Location = new System.Drawing.Point(45, 236);
            this.btn_hienthihd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthihd.Name = "btn_hienthihd";
            this.btn_hienthihd.Size = new System.Drawing.Size(100, 38);
            this.btn_hienthihd.TabIndex = 137;
            this.btn_hienthihd.Text = "Hiển thị";
            this.btn_hienthihd.UseVisualStyleBackColor = false;
            this.btn_hienthihd.Click += new System.EventHandler(this.btn_hienthihd_Click);
            // 
            // btn_suacthd
            // 
            this.btn_suacthd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_suacthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suacthd.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suacthd.Location = new System.Drawing.Point(297, 575);
            this.btn_suacthd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suacthd.Name = "btn_suacthd";
            this.btn_suacthd.Size = new System.Drawing.Size(100, 38);
            this.btn_suacthd.TabIndex = 136;
            this.btn_suacthd.Text = "Sửa";
            this.btn_suacthd.UseVisualStyleBackColor = false;
            this.btn_suacthd.Click += new System.EventHandler(this.btn_suacthd_Click);
            // 
            // btn_xoacthd
            // 
            this.btn_xoacthd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoacthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoacthd.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoacthd.Location = new System.Drawing.Point(422, 575);
            this.btn_xoacthd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoacthd.Name = "btn_xoacthd";
            this.btn_xoacthd.Size = new System.Drawing.Size(100, 38);
            this.btn_xoacthd.TabIndex = 135;
            this.btn_xoacthd.Text = "Xoá";
            this.btn_xoacthd.UseVisualStyleBackColor = false;
            this.btn_xoacthd.Click += new System.EventHandler(this.btn_xoacthd_Click);
            // 
            // btn_themcthd
            // 
            this.btn_themcthd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_themcthd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themcthd.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themcthd.Location = new System.Drawing.Point(175, 575);
            this.btn_themcthd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themcthd.Name = "btn_themcthd";
            this.btn_themcthd.Size = new System.Drawing.Size(100, 38);
            this.btn_themcthd.TabIndex = 134;
            this.btn_themcthd.Text = "Thêm";
            this.btn_themcthd.UseVisualStyleBackColor = false;
            this.btn_themcthd.Click += new System.EventHandler(this.btn_themcthd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "Chi tiết hoá đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "Thông tin hoá đơn";
            // 
            // cbx_msp
            // 
            this.cbx_msp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_msp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_msp.FormattingEnabled = true;
            this.cbx_msp.Location = new System.Drawing.Point(213, 441);
            this.cbx_msp.Name = "cbx_msp";
            this.cbx_msp.Size = new System.Drawing.Size(308, 27);
            this.cbx_msp.TabIndex = 131;
            // 
            // cbx_mahd
            // 
            this.cbx_mahd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_mahd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mahd.FormattingEnabled = true;
            this.cbx_mahd.Location = new System.Drawing.Point(213, 405);
            this.cbx_mahd.Name = "cbx_mahd";
            this.cbx_mahd.Size = new System.Drawing.Size(308, 27);
            this.cbx_mahd.TabIndex = 130;
            // 
            // txt_cthddg
            // 
            this.txt_cthddg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cthddg.Location = new System.Drawing.Point(213, 518);
            this.txt_cthddg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cthddg.Name = "txt_cthddg";
            this.txt_cthddg.Size = new System.Drawing.Size(308, 27);
            this.txt_cthddg.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 122;
            this.label6.Text = "Mã chi tiết hoá đơn:";
            // 
            // txt_cthdsl
            // 
            this.txt_cthdsl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cthdsl.Location = new System.Drawing.Point(213, 481);
            this.txt_cthdsl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cthdsl.Name = "txt_cthdsl";
            this.txt_cthdsl.Size = new System.Drawing.Size(308, 27);
            this.txt_cthdsl.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 526);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 128;
            this.label7.Text = "Đơn giá:";
            // 
            // txt_macthd
            // 
            this.txt_macthd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_macthd.Location = new System.Drawing.Point(213, 367);
            this.txt_macthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.Size = new System.Drawing.Size(308, 27);
            this.txt_macthd.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 123;
            this.label8.Text = "Mã hoá đơn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 125;
            this.label9.Text = "Mã sản phẩm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 489);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 126;
            this.label10.Text = "Số lượng:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(213, 632);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(137, 41);
            this.btn_thoat.TabIndex = 108;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(297, 236);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 38);
            this.btn_sua.TabIndex = 106;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // cbx_kh
            // 
            this.cbx_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_kh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_kh.FormattingEnabled = true;
            this.cbx_kh.Location = new System.Drawing.Point(177, 106);
            this.cbx_kh.Name = "cbx_kh";
            this.cbx_kh.Size = new System.Drawing.Size(356, 27);
            this.cbx_kh.TabIndex = 119;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(422, 236);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_xoa.TabIndex = 105;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(177, 185);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(356, 27);
            this.txt_tongtien.TabIndex = 115;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(177, 236);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 38);
            this.btn_them.TabIndex = 104;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dt_ngaylap
            // 
            this.dt_ngaylap.CalendarFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaylap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_ngaylap.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaylap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaylap.Location = new System.Drawing.Point(177, 147);
            this.dt_ngaylap.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaylap.Name = "dt_ngaylap";
            this.dt_ngaylap.Size = new System.Drawing.Size(356, 27);
            this.dt_ngaylap.TabIndex = 116;
            // 
            // txt_mhd
            // 
            this.txt_mhd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mhd.Location = new System.Drawing.Point(177, 71);
            this.txt_mhd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mhd.Name = "txt_mhd";
            this.txt_mhd.Size = new System.Drawing.Size(356, 27);
            this.txt_mhd.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 112;
            this.label4.Text = "Tổng tiền:";
            // 
            // dgv_hd
            // 
            this.dgv_hd.AllowUserToAddRows = false;
            this.dgv_hd.AllowUserToDeleteRows = false;
            this.dgv_hd.AllowUserToResizeColumns = false;
            this.dgv_hd.AllowUserToResizeRows = false;
            this.dgv_hd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_hd.Location = new System.Drawing.Point(603, 13);
            this.dgv_hd.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.ReadOnly = true;
            this.dgv_hd.RowHeadersWidth = 48;
            this.dgv_hd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hd.Size = new System.Drawing.Size(569, 334);
            this.dgv_hd.TabIndex = 122;
            this.dgv_hd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hd_CellClick);
            // 
            // btn_xuatEx
            // 
            this.btn_xuatEx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xuatEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuatEx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatEx.Location = new System.Drawing.Point(26, 282);
            this.btn_xuatEx.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xuatEx.Name = "btn_xuatEx";
            this.btn_xuatEx.Size = new System.Drawing.Size(141, 38);
            this.btn_xuatEx.TabIndex = 139;
            this.btn_xuatEx.Text = "Xuất Excel";
            this.btn_xuatEx.UseVisualStyleBackColor = false;
            this.btn_xuatEx.Click += new System.EventHandler(this.btn_xuatEx_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 753);
            this.Controls.Add(this.dgv_cthd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_hd);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cthd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_hienthicthd;
        private System.Windows.Forms.Button btn_hienthihd;
        private System.Windows.Forms.Button btn_suacthd;
        private System.Windows.Forms.Button btn_xoacthd;
        private System.Windows.Forms.Button btn_themcthd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_msp;
        private System.Windows.Forms.ComboBox cbx_mahd;
        private System.Windows.Forms.TextBox txt_cthddg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cthdsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ComboBox cbx_kh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dt_ngaylap;
        private System.Windows.Forms.TextBox txt_mhd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_hd;
        private System.Windows.Forms.Button btn_xuatEx;
    }
}