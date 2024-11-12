using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetN2_MiniSup
{
    internal class TimKiemHoaDon
    {
        private Ketnoi ketnoi = new Ketnoi(); 

        public void TimKiemHoaDonTheoTieuChi(string tieuChi, string giaTri, DateTime? ngayLapHoaDontruoc, DateTime? ngayLapHoaDonsau, DataGridView dataGridView)
        {
            string sql = @"
                SELECT 
                    HoaDon.MaHoaDon,
                    SanPham.TenSanPham,
                    ChiTietHoaDon.SoLuong,
                    HoaDon.NgayLap,
                    HoaDon.MaKhachHang,
                    HoaDon.TongTien
                FROM 
                    HoaDon
                INNER JOIN 
                    ChiTietHoaDon ON HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon
                INNER JOIN 
                    SanPham ON ChiTietHoaDon.MaSanPham = SanPham.MaSanPham
                WHERE 1 = 1";

            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(tieuChi) && !string.IsNullOrEmpty(giaTri))
            {
                switch (tieuChi)
                {
                    case "Mã Hóa Đơn":
                        sql += " AND HoaDon.MaHoaDon = @MaHoaDon";
                        sqlParameters.Add(new SqlParameter("@MaHoaDon", giaTri));
                        break;
                    case "Mã Sản Phẩm":
                        sql += " AND ChiTietHoaDon.MaSanPham = @MaSanPham";
                        sqlParameters.Add(new SqlParameter("@MaSanPham", giaTri));
                        break;
                    case "Tên Sản Phẩm":
                        sql += " AND SanPham.TenSanPham LIKE @TenSanPham";
                        sqlParameters.Add(new SqlParameter("@TenSanPham", "%" + giaTri + "%"));
                        break;
                    case "Mã Khách Hàng":
                        sql += " AND HoaDon.MaKhachHang = @MaKhachHang";
                        sqlParameters.Add(new SqlParameter("@MaKhachHang", giaTri));
                        break;
                    case "Ngày Lập Hóa Đơn":
                        if (ngayLapHoaDontruoc.HasValue && ngayLapHoaDonsau.HasValue)
                        {
                            sql += " AND HoaDon.NgayLap BETWEEN @FromDate AND @ToDate";

                            sqlParameters.Add(new SqlParameter("@FromDate", ngayLapHoaDontruoc.Value.ToString("yyyy-MM-dd")));
                            sqlParameters.Add(new SqlParameter("@ToDate", ngayLapHoaDonsau.Value.ToString("yyyy-MM-dd")));
                        }
                        break;
                }
            }
            DataTable dt = ketnoi.SearchData(sql, sqlParameters.ToArray());
            dataGridView.DataSource = dt;
        }

    }
}
