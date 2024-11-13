using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetN2_MiniSup
{
    internal class PhieuNhap
    {
        Ketnoi ketnoi;
        public PhieuNhap()
        {
            ketnoi = new Ketnoi();
        }
        public DataTable GetAllPhieuNhap()
        {
            string sql = "SELECT * FROM PhieuNhap";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllChiTietPhieuNhap()
        {
            string sql = "SELECT * FROM ChiTietPhieuNhap";
            return ketnoi.ReadData(sql);
        }
        
        public DataTable GetAllMaNhacc()
        {
            string sql = "SELECT MaNhaCungCap FROM NhaCungCap";
            return ketnoi.ReadData(sql);
        }

        public DataTable GetAllMaPhieuNhap()
        {
            string sql = "SELECT MaPhieuNhap FROM PhieuNhap";
            return ketnoi.ReadData(sql);
        }

        public DataTable GetAllMaSanPham()
        {
            string sql = "SELECT MaSanPham FROM SanPham";
            return ketnoi.ReadData(sql);
        }

        public void ThemPhieuNhap(string maPhieuNhap, string maNhaCungCap, DateTime ngayNhap , string tongTien)
        {
            string sql = "Insert into PhieuNhap(MaPhieuNhap,MaNhaCungCap,NgayNhap,TongTien) Values(@maPhieuNhap,@maNhaCungCap,@ngayNhap,@tongTien)";
            SqlParameter[] sqlParameters = new SqlParameter[] 
            {
                new SqlParameter("@maPhieuNhap",maPhieuNhap),
                new SqlParameter("@maNhaCungCap",maNhaCungCap),
                new SqlParameter("@ngayNhap",ngayNhap),
                new SqlParameter("@tongTien",tongTien)
                
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public void ThemChiTietPhieuNhap(string mctpn, string mpn, string msp, int sl, string dg)
        {
            string sql = "Insert into ChiTietPhieuNhap(MaChiTietPhieuNhap,MaPhieuNhap,MaSanPham,SoLuong,DonGia) Values(@mctpn,@mpn,@msp,@sl,@dg)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mctpn",mctpn),
                new SqlParameter("@mpn",mpn),
                new SqlParameter("@msp",msp),
                new SqlParameter("@sl",sl),
                new SqlParameter("@dg",dg)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void DeletePhieuNhap(string maPhieuNhap)
        {
            string sql = "Delete from PhieuNhap where MaPhieuNhap = @maPhieuNhap";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@maPhieuNhap",maPhieuNhap),
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public void DeleteChiTietPhieuNhap(string mctpn)
        {
            string sql = "Delete from ChiTietPhieuNhap where MaChiTietPhieuNhap = @mctpn";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@mctpn", mctpn),
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void UpdatePhieuNhap(string maPhieuNhap, string maNhaCungCap, DateTime ngayNhap, string tongTien)
        {
            string sql = "Update PhieuNhap " +
                "set MaNhaCungCap = @maNhaCungCap, NgayNhap = @ngayNhap,TongTien = @tongTien where MaPhieuNhap = @maPhieuNhap";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@maPhieuNhap",maPhieuNhap),
                new SqlParameter("@maNhaCungCap",maNhaCungCap),
                new SqlParameter("@ngayNhap",ngayNhap),
                new SqlParameter("@tongTien",tongTien)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void UpdateChiTietPhieuNhap(string mctpn, string mpn, string msp, int sl, string dg)
        {
            string sql = "Update ChiTietPhieuNhap " +
                "set MaPhieuNhap = @mpn , MaSanPham = @msp, SoLuong = @sl,DonGia = @dg where MaChiTietPhieuNhap = @mctpn";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@mctpn",mctpn),
                new SqlParameter("@mpn",mpn),
                new SqlParameter("@msp",msp),
                new SqlParameter("@sl",sl),
                new SqlParameter("@dg",dg)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public DataTable SearchPhieuNhap(string maPhieuNhap)
        {
            string sql = "SELECT * FROM ChiTietPhieuNhap where MaPhieuNhap = @maPhieuNhap";
            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@maPhieuNhap",maPhieuNhap) };
            return ketnoi.SearchData(sql, sqlParameters);
        }

        public bool KiemTraMaTonTai(string tableName, string columnName, string ma)
        {
            Ketnoi ketnoi = new Ketnoi();
            string sql = $"SELECT COUNT(*) AS SoLuong FROM {tableName} WHERE {columnName} = @ma";
            SqlParameter[] sqlParameters = { new SqlParameter("@ma", ma) };

            DataTable dt = ketnoi.SearchData(sql, sqlParameters);

            if (dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0]["SoLuong"]);
                return count > 0;
            }
            return false;
        }
    }
}
