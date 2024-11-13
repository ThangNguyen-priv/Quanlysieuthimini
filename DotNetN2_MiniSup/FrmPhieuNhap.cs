﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetN2_MiniSup
{
    public partial class FrmPhieuNhap : Form
    {
        private PhieuNhap phieunhap = new PhieuNhap();

        public FrmPhieuNhap()
        {
            InitializeComponent();
            dgv_pn.DataSource = phieunhap.GetAllPhieuNhap();
            dgv_ctpn.DataSource = phieunhap.GetAllChiTietPhieuNhap();
            LoadNhaCungCapToComboBox();
            LoadMaPhieuNhapToComboBox();
            LoadMaSanPhamToComboBox();
        }

        public void cleartxt()
        {
            txt_mapn.Text = string.Empty;
            cbx_mancc.Text = string.Empty;
            dt_ngaynhap.Value = DateTime.Now;
            txt_tongtien.Text = string.Empty;
        }
        public void cleartxt2()
        {
            txt_mactpn.Text = string.Empty;
            cbx_mapn.Text = string.Empty;
            cbx_msp.Text = string.Empty;
            txt_ctpnsl.Text = string.Empty;
            txt_ctpndg.Text = string.Empty;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string mapn = txt_mapn.Text.ToUpper();
            string mancc = cbx_mancc.Text;
            DateTime ngaynhap = dt_ngaynhap.Value;
            string tongtien = txt_tongtien.Text;

            if (string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tongtien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phiếu nhập trước khi thêm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phieunhap.KiemTraMaTonTai("PhieuNhap", "MaPhieuNhap", mapn))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                phieunhap.ThemPhieuNhap(mapn, mancc, ngaynhap, tongtien);
                dgv_pn.DataSource = null;
                dgv_pn.Rows.Clear();
                dgv_pn.DataSource = phieunhap.GetAllPhieuNhap();
                cleartxt();
                MessageBox.Show("Thêm dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string mapn = txt_mapn.Text;
            string mancc = cbx_mancc.Text;
            DateTime ngaynhap = dt_ngaynhap.Value;
            string tongtien = txt_tongtien.Text;
            if (string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tongtien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phiếu nhập trước khi thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    phieunhap.UpdatePhieuNhap(mapn, mancc, ngaynhap, tongtien);
                    dgv_pn.DataSource = null;
                    dgv_pn.Rows.Clear();
                    dgv_pn.DataSource = phieunhap.GetAllPhieuNhap();
                    cleartxt();
                    MessageBox.Show("Sửa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_ctpn.DataSource = phieunhap.GetAllChiTietPhieuNhap();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string mapn = txt_mapn.Text;
            if (string.IsNullOrWhiteSpace(mapn))
            {
                MessageBox.Show("Vui nhập mã phiếu nhập trước khi xóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    phieunhap.DeletePhieuNhap(mapn);
                    dgv_pn.DataSource = null;
                    dgv_pn.Rows.Clear();
                    cleartxt();
                    dgv_pn.DataSource = phieunhap.GetAllPhieuNhap();
                    MessageBox.Show("Xóa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_hienthipn_Click(object sender, EventArgs e)
        {
            dgv_pn.DataSource = null;
            dgv_pn.Rows.Clear();
            dgv_pn.DataSource = phieunhap.GetAllPhieuNhap();
            cleartxt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng không click vào header row
                if (e.RowIndex >= 0)
                {
                    // Lấy mã phiếu nhập từ cột đầu tiên của dòng được click
                    string maPhieuNhap = dgv_pn.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // Đổ dữ liệu vào các textbox từ các cột trong dòng
                    txt_mapn.Text = dgv_pn.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbx_mancc.Text = dgv_pn.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dt_ngaynhap.Text = dgv_pn.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_tongtien.Text = dgv_pn.Rows[e.RowIndex].Cells[3].Value.ToString();

                    // Lấy chi tiết phiếu nhập từ mã phiếu nhập đã chọn
                    DataTable dtChiTiet = phieunhap.SearchPhieuNhap(maPhieuNhap);

                    // Hiển thị chi tiết phiếu nhập vào DataGridView khác (dgv_ctpn)
                    dgv_ctpn.DataSource = dtChiTiet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        
        private void dgv_ctpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_mactpn.Text = dgv_ctpn.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbx_mapn.Text = dgv_ctpn.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbx_msp.Text = dgv_ctpn.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ctpnsl.Text = dgv_ctpn.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_ctpndg.Text = dgv_ctpn.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        // chi tiet phieu nhap--------------------------------------------------------------------------------
        private void btn_hienthictpn_Click(object sender, EventArgs e)
        {
            dgv_ctpn.DataSource = null;
            dgv_ctpn.Rows.Clear();
            dgv_ctpn.DataSource = phieunhap.GetAllChiTietPhieuNhap();
            cleartxt2();
        }

        private void btn_themctpn_Click(object sender, EventArgs e)
        {
            string mctpn = txt_mactpn.Text.ToUpper();
            string mapn = cbx_mapn.Text;
            string msp = cbx_msp.Text;
            int sl = int.Parse(txt_ctpnsl.Text);
            string dg = txt_ctpndg.Text;

            if (string.IsNullOrWhiteSpace(mctpn) || string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(msp))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của chi tiết phiếu nhập trước khi thêm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phieunhap.KiemTraMaTonTai("ChiTietPhieuNhap", "MaChiTietPhieuNhap", mctpn))
            {
                MessageBox.Show("Mã chi tiết phiếu nhập đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                phieunhap.ThemChiTietPhieuNhap(mctpn, mapn, msp, sl, dg);
                dgv_pn.DataSource = null;
                dgv_pn.Rows.Clear();
                dgv_ctpn.DataSource = phieunhap.GetAllPhieuNhap();
                cleartxt();
                MessageBox.Show("Thêm dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_suactpn_Click(object sender, EventArgs e)
        {
            string mctpn = txt_mactpn.Text;
            string mapn = cbx_mapn.Text;
            string msp = cbx_msp.Text;
            int sl = int.Parse(txt_ctpnsl.Text);
            string dg = txt_ctpndg.Text;

            if (string.IsNullOrWhiteSpace(mctpn) || string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(msp))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phiếu nhập trước khi thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    phieunhap.UpdateChiTietPhieuNhap(mctpn, mapn, msp, sl, dg);
                    dgv_ctpn.DataSource = null;
                    dgv_ctpn.Rows.Clear();
                    dgv_ctpn.DataSource = phieunhap.GetAllChiTietPhieuNhap();
                    cleartxt();
                    MessageBox.Show("Sửa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_xoactpn_Click(object sender, EventArgs e)
        {
            string mctpn = txt_mactpn.Text;
            if (string.IsNullOrWhiteSpace(mctpn))
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu nhập trước khi xóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    phieunhap.DeleteChiTietPhieuNhap(mctpn);
                    dgv_ctpn.DataSource = null;
                    dgv_ctpn.Rows.Clear();
                    cleartxt2();
                    dgv_ctpn.DataSource = phieunhap.GetAllChiTietPhieuNhap();
                    MessageBox.Show("Xóa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Day du lieu vao combobox------------------------------------------------------------------------------------------------

        private void LoadNhaCungCapToComboBox()
        {
            // Lấy danh sách mã nhà cung cấp
            DataTable dtncc = phieunhap.GetAllMaNhacc();

            cbx_mancc.DataSource = dtncc;
            cbx_mancc.DisplayMember = "MaNhaCungCap"; // Cột hiển thị
            cbx_mancc.ValueMember = "MaNhaCungCap"; // Giá trị mã nhà cung cấp

            cbx_mancc.SelectedIndex = -1; // Không chọn mục nào ban đầu
        }

        private void LoadMaPhieuNhapToComboBox()
        {
            // Lấy danh sách mã nhà cung cấp
            DataTable dtpn = phieunhap.GetAllMaPhieuNhap();

            cbx_mapn.DataSource = dtpn;
            cbx_mapn.DisplayMember = "MaPhieuNhap"; // Cột hiển thị
            cbx_mapn.ValueMember = "MaPhieuNhap"; // Giá trị mã nhà cung cấp

            cbx_mapn.SelectedIndex = -1; // Không chọn mục nào ban đầu
        }

        private void LoadMaSanPhamToComboBox()
        {
            // Lấy danh sách mã nhà cung cấp
            DataTable dtsp = phieunhap.GetAllMaSanPham();

            cbx_msp.DataSource = dtsp;
            cbx_msp.DisplayMember = "MaSanPham"; // Cột hiển thị
            cbx_msp.ValueMember = "MaSanPham"; // Giá trị mã nhà cung cấp

            cbx_msp.SelectedIndex = -1; // Không chọn mục nào ban đầu
        }

    }
}