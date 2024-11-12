using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetN2_MiniSup
{
    internal class TimKiemSP_DM
    {
        private Ketnoi ketNoi;

        public TimKiemSP_DM()
        {
            ketNoi = new Ketnoi();
        }

        public DataTable LayDanhMuc()
        {
            string sql = "SELECT MaDanhMuc, TenDanhMuc FROM DanhMucSanPham";
            return ketNoi.ReadData(sql);
        }

        public DataTable LaySanPhamTheoDanhMuc(string maDanhMuc)
        {
            string sql = "SELECT MaSanPham, TenSanPham, Gia, SoLuong FROM SanPham WHERE MaDanhMuc = @maDanhMuc";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@maDanhMuc", maDanhMuc)
            };

            return ketNoi.SearchData(sql, parameters);
        }
    }
}
