﻿using System;
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
    public partial class FrmTimKiemHoaDon : Form
    {
        private TimKiemHoaDon timKiemHoaDon = new TimKiemHoaDon();
        public FrmTimKiemHoaDon()
        {
            InitializeComponent();

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tieuChi = cbx_chonKhoaTimKiem.SelectedItem.ToString();
            string giaTri = txb_thongTinTimKiem.Text;
            DateTime? ngayLapHoaDontruoc = dpk_ngayLapHDtruoc.Enabled ? (DateTime?)dpk_ngayLapHDtruoc.Value : null;
            DateTime? ngayLapHoaDonsau = dpk_ngayLapHDsau.Enabled ? (DateTime?)dpk_ngayLapHDsau.Value : null;

            timKiemHoaDon.TimKiemHoaDonTheoTieuChi(tieuChi, giaTri, ngayLapHoaDontruoc, ngayLapHoaDonsau, dgv_dsHoaDon);
        }


        private void FrmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            cbx_chonKhoaTimKiem.Items.Add("Mã Hóa Đơn");
            cbx_chonKhoaTimKiem.Items.Add("Mã Sản Phẩm");
            cbx_chonKhoaTimKiem.Items.Add("Tên Sản Phẩm");
            cbx_chonKhoaTimKiem.Items.Add("Mã Khách Hàng");
            cbx_chonKhoaTimKiem.Items.Add("Ngày Lập Hóa Đơn");
            cbx_chonKhoaTimKiem.SelectedIndex = 0; 


            dpk_ngayLapHDtruoc.Visible = false;
            dpk_ngayLapHDsau.Visible = false;
        }

        private void cbx_chonKhoaTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_chonKhoaTimKiem.SelectedItem.ToString() == "Ngày Lập Hóa Đơn")
            {
                dpk_ngayLapHDtruoc.Visible = true;
                dpk_ngayLapHDsau.Visible = true; 
                txb_thongTinTimKiem.Enabled = false; 
            }
            else
            {
                dpk_ngayLapHDtruoc.Visible = false;
                dpk_ngayLapHDsau.Visible = false;  
                txb_thongTinTimKiem.Enabled = true; 
            }
        }

    }
   
}