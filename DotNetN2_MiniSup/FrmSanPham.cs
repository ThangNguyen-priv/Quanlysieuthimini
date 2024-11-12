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
    
    public partial class FrmSanPham : Form
    {
        SanPham sanpham = new SanPham();
        public FrmSanPham()
        {
            InitializeComponent();
            dataGridView1.DataSource = sanpham.GetAllSanPham();
        }
        public void cleartxt()
        {
            txt_masp.Text = string.Empty;
            txt_tensp.Text = string.Empty;
            txt_madanhmuc.Text = string.Empty;
            txt_gia.Text = string.Empty;
            txt_soluong.Text = string.Empty;
            dt_hsd.Value = DateTime.Now;
            txt_tk.Text = string.Empty;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            string tensp = txt_tensp.Text;
            string madanhmuc = txt_madanhmuc.Text;
            string gia = txt_gia.Text;
            string soluong = txt_soluong.Text;
            DateTime hsd = dt_hsd.Value;
            

            if (string.IsNullOrWhiteSpace(masp) || string.IsNullOrWhiteSpace(tensp) || string.IsNullOrWhiteSpace(madanhmuc) || string.IsNullOrWhiteSpace(gia) || string.IsNullOrWhiteSpace(soluong) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của sản phẩm trước khi thêm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sanpham.ThemSanPham(masp, tensp, madanhmuc, gia, soluong, hsd);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = sanpham.GetAllSanPham();
                cleartxt();
                MessageBox.Show("Thêm dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            if (string.IsNullOrWhiteSpace(masp))
            {
                MessageBox.Show("Vui nhập mã sản phẩm trước khi xóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sanpham.DeleteSanPham(masp);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    cleartxt();
                    dataGridView1.DataSource = sanpham.GetAllSanPham();
                    MessageBox.Show("Xóa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            string tensp = txt_tensp.Text;
            string madanhmuc = txt_madanhmuc.Text;
            string gia = txt_gia.Text;
            string soluong = txt_soluong.Text;
            DateTime hsd = dt_hsd.Value;
            if (string.IsNullOrWhiteSpace(masp) || string.IsNullOrWhiteSpace(tensp) || string.IsNullOrWhiteSpace(madanhmuc) || string.IsNullOrWhiteSpace(gia) || string.IsNullOrWhiteSpace(soluong) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của sản phẩm trước khi thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sanpham.UpdateSanPham(masp, tensp, madanhmuc, gia, soluong,hsd);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = sanpham.GetAllSanPham();
                    cleartxt();
                    MessageBox.Show("Sửa dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txt_tk.Text.Trim();
            if (string.IsNullOrWhiteSpace(timkiem))
            {
                MessageBox.Show("Vui nhập mã sản phẩm muốn tìm kiếm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = sanpham.SearchSanPham(timkiem);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masp.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tensp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_madanhmuc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_gia.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_soluong.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dt_hsd.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
