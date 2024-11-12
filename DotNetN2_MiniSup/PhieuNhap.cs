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
        public void ThemPhieuNhap(string maPhieuNhap, string maNhaCungCap, DateTime ngayNhap , string tongTien )
        {
            string sql = "Insert into PhieuNhap(MaPhieuNhap,MaNhaCungCap,NgayNhap,TongTien) Values(@maPhieuNhap,@maNhaCungCap,@ngayNhap,@tongTien) ";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@maPhieuNhap",maPhieuNhap),
                new SqlParameter("@maNhaCungCap",maNhaCungCap),
                new SqlParameter("@ngayNhap",ngayNhap),
                new SqlParameter("@tongTien",tongTien)
                
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
        public void UpdatePhieuNhap(string maPhieuNhap, string maNhaCungCap, DateTime ngayNhap, string tongTien)
        {
            string sql = "Update PhieuNhap " +
                "set MaNhaCungCap = @maNhaCungCap, NgayNhap = @ngayNhap,TongTien = @tongTien where  MaKhachHang = @MaKhachHang  ";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@maPhieuNhap",maPhieuNhap),
                new SqlParameter("@maNhaCungCap",maNhaCungCap),
                new SqlParameter("@ngayNhap",ngayNhap),
                new SqlParameter("@tongTien",tongTien)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public DataTable SearchPhieuNhap(string maPhieuNhap)
        {
            string sql = "SELECT * FROM PhieuNhap where MaPhieuNhap = @maPhieuNhap";
            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@maPhieuNhap",maPhieuNhap) };
            return ketnoi.SearchData(sql, sqlParameters);
        }
    }
}
