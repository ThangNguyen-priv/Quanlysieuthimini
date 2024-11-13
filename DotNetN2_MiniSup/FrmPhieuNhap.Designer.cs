namespace DotNetN2_MiniSup
{
    partial class FrmPhieuNhap
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
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pn = new System.Windows.Forms.DataGridView();
            this.maphieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.dt_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hienthictpn = new System.Windows.Forms.Button();
            this.btn_hienthipn = new System.Windows.Forms.Button();
            this.btn_suactpn = new System.Windows.Forms.Button();
            this.btn_xoactpn = new System.Windows.Forms.Button();
            this.btn_themctpn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_msp = new System.Windows.Forms.ComboBox();
            this.cbx_mapn = new System.Windows.Forms.ComboBox();
            this.txt_ctpndg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ctpnsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mactpn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_mancc = new System.Windows.Forms.ComboBox();
            this.dgv_ctpn = new System.Windows.Forms.DataGridView();
            this.btn_xuatEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctpn)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Ngày nhập:";
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
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
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
            // txt_mapn
            // 
            this.txt_mapn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mapn.Location = new System.Drawing.Point(177, 71);
            this.txt_mapn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mapn.Name = "txt_mapn";
            this.txt_mapn.Size = new System.Drawing.Size(356, 27);
            this.txt_mapn.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // dgv_pn
            // 
            this.dgv_pn.AllowUserToAddRows = false;
            this.dgv_pn.AllowUserToDeleteRows = false;
            this.dgv_pn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_pn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieunhap,
            this.manhacc,
            this.ngaynhap,
            this.tongtien});
            this.dgv_pn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_pn.Location = new System.Drawing.Point(602, 13);
            this.dgv_pn.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pn.Name = "dgv_pn";
            this.dgv_pn.ReadOnly = true;
            this.dgv_pn.RowHeadersWidth = 48;
            this.dgv_pn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pn.Size = new System.Drawing.Size(569, 334);
            this.dgv_pn.TabIndex = 109;
            this.dgv_pn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maphieunhap
            // 
            this.maphieunhap.DataPropertyName = "MaPhieuNhap";
            this.maphieunhap.HeaderText = "MaPhieuNhap";
            this.maphieunhap.MinimumWidth = 6;
            this.maphieunhap.Name = "maphieunhap";
            this.maphieunhap.ReadOnly = true;
            // 
            // manhacc
            // 
            this.manhacc.DataPropertyName = "MaNhaCungCap";
            this.manhacc.HeaderText = "MaNhaCungCap";
            this.manhacc.MinimumWidth = 6;
            this.manhacc.Name = "manhacc";
            this.manhacc.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "NgayNhap";
            this.ngaynhap.HeaderText = "NgayNhap";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TongTien";
            this.tongtien.HeaderText = "TongTien";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
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
            // dt_ngaynhap
            // 
            this.dt_ngaynhap.CalendarFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaynhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_ngaynhap.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaynhap.Location = new System.Drawing.Point(177, 147);
            this.dt_ngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaynhap.Name = "dt_ngaynhap";
            this.dt_ngaynhap.Size = new System.Drawing.Size(356, 27);
            this.dt_ngaynhap.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xuatEx);
            this.groupBox1.Controls.Add(this.btn_hienthictpn);
            this.groupBox1.Controls.Add(this.btn_hienthipn);
            this.groupBox1.Controls.Add(this.btn_suactpn);
            this.groupBox1.Controls.Add(this.btn_xoactpn);
            this.groupBox1.Controls.Add(this.btn_themctpn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_msp);
            this.groupBox1.Controls.Add(this.cbx_mapn);
            this.groupBox1.Controls.Add(this.txt_ctpndg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ctpnsl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mactpn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.cbx_mancc);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.dt_ngaynhap);
            this.groupBox1.Controls.Add(this.txt_mapn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 725);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btn_hienthictpn
            // 
            this.btn_hienthictpn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hienthictpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hienthictpn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthictpn.Location = new System.Drawing.Point(45, 575);
            this.btn_hienthictpn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthictpn.Name = "btn_hienthictpn";
            this.btn_hienthictpn.Size = new System.Drawing.Size(100, 38);
            this.btn_hienthictpn.TabIndex = 138;
            this.btn_hienthictpn.Text = "Hiển thị";
            this.btn_hienthictpn.UseVisualStyleBackColor = false;
            this.btn_hienthictpn.Click += new System.EventHandler(this.btn_hienthictpn_Click);
            // 
            // btn_hienthipn
            // 
            this.btn_hienthipn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hienthipn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hienthipn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthipn.Location = new System.Drawing.Point(45, 236);
            this.btn_hienthipn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthipn.Name = "btn_hienthipn";
            this.btn_hienthipn.Size = new System.Drawing.Size(100, 38);
            this.btn_hienthipn.TabIndex = 137;
            this.btn_hienthipn.Text = "Hiển thị";
            this.btn_hienthipn.UseVisualStyleBackColor = false;
            this.btn_hienthipn.Click += new System.EventHandler(this.btn_hienthipn_Click);
            // 
            // btn_suactpn
            // 
            this.btn_suactpn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_suactpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suactpn.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suactpn.Location = new System.Drawing.Point(297, 575);
            this.btn_suactpn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suactpn.Name = "btn_suactpn";
            this.btn_suactpn.Size = new System.Drawing.Size(100, 38);
            this.btn_suactpn.TabIndex = 136;
            this.btn_suactpn.Text = "Sửa";
            this.btn_suactpn.UseVisualStyleBackColor = false;
            this.btn_suactpn.Click += new System.EventHandler(this.btn_suactpn_Click);
            // 
            // btn_xoactpn
            // 
            this.btn_xoactpn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoactpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoactpn.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoactpn.Location = new System.Drawing.Point(422, 575);
            this.btn_xoactpn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoactpn.Name = "btn_xoactpn";
            this.btn_xoactpn.Size = new System.Drawing.Size(100, 38);
            this.btn_xoactpn.TabIndex = 135;
            this.btn_xoactpn.Text = "Xoá";
            this.btn_xoactpn.UseVisualStyleBackColor = false;
            this.btn_xoactpn.Click += new System.EventHandler(this.btn_xoactpn_Click);
            // 
            // btn_themctpn
            // 
            this.btn_themctpn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_themctpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themctpn.Font = new System.Drawing.Font("Times New Roman", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themctpn.Location = new System.Drawing.Point(175, 575);
            this.btn_themctpn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themctpn.Name = "btn_themctpn";
            this.btn_themctpn.Size = new System.Drawing.Size(100, 38);
            this.btn_themctpn.TabIndex = 134;
            this.btn_themctpn.Text = "Thêm";
            this.btn_themctpn.UseVisualStyleBackColor = false;
            this.btn_themctpn.Click += new System.EventHandler(this.btn_themctpn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "Chi tiết phiếu nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "Thông tin phiếu nhập";
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
            // cbx_mapn
            // 
            this.cbx_mapn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_mapn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mapn.FormattingEnabled = true;
            this.cbx_mapn.Location = new System.Drawing.Point(213, 407);
            this.cbx_mapn.Name = "cbx_mapn";
            this.cbx_mapn.Size = new System.Drawing.Size(308, 27);
            this.cbx_mapn.TabIndex = 130;
            // 
            // txt_ctpndg
            // 
            this.txt_ctpndg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ctpndg.Location = new System.Drawing.Point(213, 518);
            this.txt_ctpndg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ctpndg.Name = "txt_ctpndg";
            this.txt_ctpndg.Size = new System.Drawing.Size(308, 27);
            this.txt_ctpndg.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 122;
            this.label6.Text = "Mã chi tiết phiếu nhập:";
            // 
            // txt_ctpnsl
            // 
            this.txt_ctpnsl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ctpnsl.Location = new System.Drawing.Point(213, 481);
            this.txt_ctpnsl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ctpnsl.Name = "txt_ctpnsl";
            this.txt_ctpnsl.Size = new System.Drawing.Size(308, 27);
            this.txt_ctpnsl.TabIndex = 127;
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
            // txt_mactpn
            // 
            this.txt_mactpn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mactpn.Location = new System.Drawing.Point(213, 367);
            this.txt_mactpn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mactpn.Name = "txt_mactpn";
            this.txt_mactpn.Size = new System.Drawing.Size(308, 27);
            this.txt_mactpn.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 123;
            this.label8.Text = "Mã phiếu nhập:";
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
            // cbx_mancc
            // 
            this.cbx_mancc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_mancc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mancc.FormattingEnabled = true;
            this.cbx_mancc.Location = new System.Drawing.Point(177, 106);
            this.cbx_mancc.Name = "cbx_mancc";
            this.cbx_mancc.Size = new System.Drawing.Size(356, 27);
            this.cbx_mancc.TabIndex = 119;
            // 
            // dgv_ctpn
            // 
            this.dgv_ctpn.AllowUserToAddRows = false;
            this.dgv_ctpn.AllowUserToDeleteRows = false;
            this.dgv_ctpn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ctpn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_ctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ctpn.Location = new System.Drawing.Point(602, 372);
            this.dgv_ctpn.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ctpn.Name = "dgv_ctpn";
            this.dgv_ctpn.ReadOnly = true;
            this.dgv_ctpn.RowHeadersWidth = 48;
            this.dgv_ctpn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ctpn.Size = new System.Drawing.Size(569, 365);
            this.dgv_ctpn.TabIndex = 121;
            this.dgv_ctpn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctpn_CellClick);
            // 
            // btn_xuatEx
            // 
            this.btn_xuatEx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xuatEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuatEx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatEx.Location = new System.Drawing.Point(18, 282);
            this.btn_xuatEx.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xuatEx.Name = "btn_xuatEx";
            this.btn_xuatEx.Size = new System.Drawing.Size(141, 38);
            this.btn_xuatEx.TabIndex = 140;
            this.btn_xuatEx.Text = "Xuất Excel";
            this.btn_xuatEx.UseVisualStyleBackColor = false;
            this.btn_xuatEx.Click += new System.EventHandler(this.btn_xuatEx_Click);
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 753);
            this.Controls.Add(this.dgv_ctpn);
            this.Controls.Add(this.dgv_pn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctpn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pn;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DateTimePicker dt_ngaynhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_mancc;
        private System.Windows.Forms.DataGridView dgv_ctpn;
        private System.Windows.Forms.ComboBox cbx_msp;
        private System.Windows.Forms.ComboBox cbx_mapn;
        private System.Windows.Forms.TextBox txt_ctpndg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ctpnsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mactpn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_suactpn;
        private System.Windows.Forms.Button btn_xoactpn;
        private System.Windows.Forms.Button btn_themctpn;
        private System.Windows.Forms.Button btn_hienthipn;
        private System.Windows.Forms.Button btn_hienthictpn;
        private System.Windows.Forms.Button btn_xuatEx;
    }
}