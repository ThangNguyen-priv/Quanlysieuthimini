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
    public partial class FrmTimKiemKhachHang : Form
    {
        TimKiemKhachHang timKiemKhachHang;
        Khachhang khachhang;
        public FrmTimKiemKhachHang()
        {
            InitializeComponent();
            timKiemKhachHang = new TimKiemKhachHang();
            khachhang = new Khachhang();    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }


        private void FrmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            cbx_chonKhoaTimKiem.Items.Add("Mã Khách Hàng");
            cbx_chonKhoaTimKiem.Items.Add("Tên");
            cbx_chonKhoaTimKiem.Items.Add("Số Điện Thoại");
            cbx_chonKhoaTimKiem.Items.Add("Địa Chỉ");
            cbx_chonKhoaTimKiem.SelectedIndex = 0;

            lb_timKiem.Text = cbx_chonKhoaTimKiem.SelectedItem.ToString();

            dgv_dsKhachHang.DataSource = khachhang.GetAllKH();
        }

        private void cbx_chonKhoaTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_timKiem.Text = cbx_chonKhoaTimKiem.SelectedItem.ToString();
        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            string tuKhoa = txb_thongTinTimKiem.Text.Trim();
            string loaiTimKiem = cbx_chonKhoaTimKiem.SelectedItem.ToString();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgv_dsKhachHang.DataSource = khachhang.GetAllKH();
                return;
            }

            try
            {
                DataTable dtKhachHang = timKiemKhachHang.TimKiem(tuKhoa, loaiTimKiem);

                if (dtKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào.");
                }

                dgv_dsKhachHang.DataSource = dtKhachHang; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_tieuDe_Click(object sender, EventArgs e)
        {

        }

        private void txb_thongTinTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_timKiem_Click(object sender, EventArgs e)
        {

        }

        private void lb_chonKhoaTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dgv_dsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
