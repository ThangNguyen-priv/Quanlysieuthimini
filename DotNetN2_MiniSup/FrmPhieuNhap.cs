using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetN2_MiniSup
{
    public partial class FrmPhieuNhap : Form
    {
        PhieuNhap phieunhap = new PhieuNhap();
        public FrmPhieuNhap()
        {
            InitializeComponent();
            dataGridView1.DataSource = phieunhap.GetAllPhieuNhap();
        }
        public void cleartxt()
        {
            txt_mapn.Text = string.Empty;
            txt_mapn.Text = string.Empty;
            dt_ngaynhap.Value = DateTime.Now;
            txt_tongtien.Text = string.Empty;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string mapn = txt_mapn.Text;
            string mancc = txt_mancc.Text;
            DateTime ngaynhap = dt_ngaynhap.Value;
            string tongtien = txt_tongtien.Text;
            
            if (string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tongtien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phiếu nhập trước khi thêm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                phieunhap.ThemPhieuNhap(mapn, mancc, ngaynhap, tongtien);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = phieunhap.GetAllPhieuNhap();
                cleartxt();
                MessageBox.Show("Thêm dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    cleartxt();
                    dataGridView1.DataSource = phieunhap.GetAllPhieuNhap();
                    MessageBox.Show("Xóa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string mapn = txt_mapn.Text;
            string mancc = txt_mancc.Text;
            DateTime ngaynhap = dt_ngaynhap.Value;
            string tongtien = txt_tongtien.Text;
            if (string.IsNullOrWhiteSpace(mapn) || string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tongtien) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phiếu nhập trước khi thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    phieunhap.UpdatePhieuNhap(mapn, mancc, ngaynhap, tongtien);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = phieunhap.GetAllPhieuNhap();
                    cleartxt();
                    MessageBox.Show("Sửa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txt_timkiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(timkiem))
            {
                MessageBox.Show("Vui nhập mã phiếu nhập muốn tìm kiếm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = phieunhap.SearchPhieuNhap(timkiem);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                txt_mapn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_mancc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dt_ngaynhap.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_tongtien.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
