using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNetN2_MiniSup
{
    internal class HoaDon
    {
        Ketnoi ketnoi;
        public HoaDon()
        {
            ketnoi = new Ketnoi();
        }
        public DataTable GetAllHoaDon()
        {
            string sql = "SELECT * FROM HoaDon";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllChiTietHoaDon()
        {
            string sql = "SELECT * FROM ChiTietHoaDon";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllVoucher()
        {
            string sql = "SELECT MaVoucher FROM Voucher";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllMaKhachHang()
        {
            string sql = "SELECT MaKhachHang FROM KhachHang";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllMaHoaDon()
        {
            string sql = "SELECT MaHoaDon FROM HoaDon";
            return ketnoi.ReadData(sql);
        }
        public DataTable GetAllMaSanPham()
        {
            string sql = "SELECT MaSanPham FROM SanPham";
            return ketnoi.ReadData(sql);
        }
        public void ThemHoaDon(string mahd, string makh, DateTime ngaylap, string tongtien)
        {
            string sql = "Insert into HoaDon(MaHoaDon,MaKhachHang,NgayLap,TongTien) Values(@mahd,@makh,@ngaylap,@tongtien)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mahd",mahd),
                new SqlParameter("@makh",makh),
                new SqlParameter("@ngaylap",ngaylap),
                new SqlParameter("@tongtien",tongtien)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
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

        public void UpdateHoaDon(string mahd, string makh, DateTime ngaylap, string tongtien)
        {
            string sql = "Update HoaDon " +
                "set MaKhachHang = @makh, NgayLap = @ngaylap,TongTien = @tongtien where MaHoaDon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@mahd",mahd),
                new SqlParameter("@makh",makh),
                new SqlParameter("@ngaylap",ngaylap),
                new SqlParameter("@tongtien",tongtien)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void DeleteHoaDon(string mahd)
        {
            string sql = "Delete from HoaDon where MaHoaDon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@mahd",mahd),
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public DataTable SearchChiTietHoaDon(string mahd)
        {
            string sql = "SELECT * FROM ChiTietHoaDon where MaHoaDon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@mahd",mahd)};
            return ketnoi.SearchData(sql, sqlParameters);
        }

        public string NgayHetHan(string mavoucher)
        {
            string sql = "SELECT NgayHetHan FROM Voucher where MaVoucher = @mavoucher";
            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@mavoucher",mavoucher)};
            return Convert.ToString(ketnoi.SearchData(sql, sqlParameters));
        }

        // chi tiet hoa don----------------------------------------------------------------

        public void ThemChiTietHoaDon(string macthd, string mahd, string msp, string sl, string dg)
        {
            string sql = "Insert into ChiTietHoaDon(MaChiTietHoaDon,MaHoaDon,MaSanPham,SoLuong,DonGia) Values(@macthd,@mahd,@msp,@sl,@dg)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@macthd",macthd),
                new SqlParameter("@mahd",mahd),
                new SqlParameter("@msp",msp),
                new SqlParameter("@sl",sl),
                new SqlParameter("@dg",dg)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public void UpdateChiTietHoaDon(string macthd, string mahd, string msp, string sl, string dg)
        {
            string sql = "Update ChiTietHoaDon " +
                "set MaHoaDon = @mahd, MaSanPham = @msp, SoLuong = @sl,DonGia = @dg where MaChiTietHoaDon = @mactdh";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@macthd",macthd),
                new SqlParameter("@mahd",mahd),
                new SqlParameter("@msp",msp),
                new SqlParameter("@sl",sl),
                new SqlParameter("@dg",dg)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void DeleteChiTietHoaDon(string macthd)
        {
            string sql = "Delete from ChiTietHoaDon where MaChiTietHoaDon = @macthd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@macthd",macthd),
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        
        public void TongTienHoaDon(string macthd, string mahd)
        {
            string sql = "UPDATE HoaDon SET TongTien = TongTien + " +
                         "(Select SoLuong From ChiTietHoaDon Where MaChiTietHoaDon = @macthd) * (Select DonGia From ChiTietHoaDon Where MaChiTietHoaDon = @macthd) Where MaHoaDon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@macthd",macthd),
                new SqlParameter("@mahd",mahd),
                
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
        public void TongTienSauVoucher(string mavoucher, string mahd)
        {
            string sql = "UPDATE HoaDon SET TongTien = TongTien - " +
                         "(Select GiaTri From Voucher Where MaVoucher = @mavoucher) Where MaHoaDon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@mavoucher",mavoucher),
                new SqlParameter("@mahd",mahd),
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
