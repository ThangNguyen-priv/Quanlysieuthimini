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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmnhacc frmnhacc = new Frmnhacc();
            frmnhacc.Show();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachhang frm = new FrmKhachhang();  
            frm.Show();
        }

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVoucher frmVoucher = new FrmVoucher();   
            frmVoucher.Show();
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDanhmuc frmDanhMuc = new FrmDanhmuc();
            frmDanhMuc.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap frmPhieuNhap = new FrmPhieuNhap();
            frmPhieuNhap.Show();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemKhachHang frmTimKiemKhachHang = new FrmTimKiemKhachHang();
            frmTimKiemKhachHang.Show();
        }

        private void tìmKiếmSảnPhẩmTheoDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemSP_DM frmTimKiemSP_DM = new FrmTimKiemSP_DM();
            frmTimKiemSP_DM.Show();
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemHoaDon frmTimKiemHoaDon = new FrmTimKiemHoaDon();
            frmTimKiemHoaDon.Show();
        }
    }
}
