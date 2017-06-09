using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using DTO;

namespace DAL
{
    public class XoaDAL
    {
        private DataProvider dp;

        public XoaDAL()
        {
            dp = new DataProvider();
        }
        //Xoa RapPhim
        public int XoaRapPhimDAL(RapPhimDTO rapphim)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaRP", rapphim.MaRapPhim));

            try
            {
                return (dp.executeNonQuery("XoaRapPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
        //Xoa PhongChieu
        public int XoaPhongChieuDAL(PhongChieuDTO phongchieu)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPC", phongchieu.MaPC));

            try
            {
                return (dp.executeNonQuery("XoaPhongChieu", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xoa Phim
        public int Xoa_PhimDAL(PhimDTO film)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPhim", film.MaPhim));

            try
            {
                return (dp.executeNonQuery("XoaPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xoa TheLoai
        public int XoaTheLoaiDAL(TheLoaiDTO theloai)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TheLoai", theloai.TheLoai));

            try
            {
                return (dp.executeNonQuery("XoaTheLoai", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xoa LichChieu
        public int XoaLichChieuDAL(LichChieuDTO lichchieu)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaRP", lichchieu.MaRP));
            paras.Add(new SqlParameter("@MaPC", lichchieu.MaPC));
            paras.Add(new SqlParameter("@MaPhim", lichchieu.MaPhim));
            paras.Add(new SqlParameter("@NgayChieu", lichchieu.NgayChieu));
            paras.Add(new SqlParameter("@GioChieu", lichchieu.GioChieu));
            paras.Add(new SqlParameter("@DinhDang", lichchieu.DinhDang));

            try
            {
                return (dp.executeNonQuery("XoaLichChieu", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa nhan vien
        public int XoaNhanVienDAL(NhanVienDTO nhanvien)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", nhanvien.MaNV));

            try
            {
                return (dp.executeNonQuery("XoaNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xoa TaiKhoan
        public int XoaTaiKhoanDAL(TaiKhoanDTO taikhoan)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TaiKhoan", taikhoan.TaiKhoan));

            try
            {
                return (dp.executeNonQuery("XoaTaiKhoan", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Xoa ThucAnTam
        public int XoaThucAnTamDAL(ThucAn_TamDTO thucan)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TenTA", thucan.TenTA));

            try
            {
                return (dp.executeNonQuery("XoaThucAnTam", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
