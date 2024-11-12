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
    public partial class FrmTimKiemSP_DM : Form
    {
        private TimKiemSP_DM timKiemSP_DM;
        public FrmTimKiemSP_DM()
        {
            InitializeComponent();
            timKiemSP_DM = new TimKiemSP_DM();
        }
        private void LoadDanhMuc()
        {
            DataTable dtDanhMuc = timKiemSP_DM.LayDanhMuc();
            cmbDanhMuc.DisplayMember = "TenDanhMuc";
            cmbDanhMuc.ValueMember = "MaDanhMuc";
            cmbDanhMuc.DataSource = dtDanhMuc;
        }

        private void FrmTimKiemSP_DM_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDanhMuc = cmbDanhMuc.SelectedValue.ToString();
            LoadSanPhamTheoDanhMuc(maDanhMuc);
        }
        private void LoadSanPhamTheoDanhMuc(string maDanhMuc)
        {
            // Lấy sản phẩm theo danh mục từ TimKiem và hiển thị trong DataGridView
            DataTable dtSanPham = timKiemSP_DM.LaySanPhamTheoDanhMuc(maDanhMuc);
            dgv_sanPham.DataSource = dtSanPham;
        }
    }
}
