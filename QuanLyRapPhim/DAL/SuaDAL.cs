﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAL
{
    public class SuaDAL
    {
        private DataProvider dp;

        public SuaDAL()
        {
            dp = new DataProvider();
        }

        //Sua rap phim
        public int SuaRapPhimDAL(RapPhimDTO rapphim)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaRP", rapphim.MaRapPhim));
            paras.Add(new SqlParameter("@TenRP", rapphim.TenRapPhim));
            paras.Add(new SqlParameter("@DiaChi", rapphim.DiaChi));
            paras.Add(new SqlParameter("@MaNV", rapphim.MaNV));
            paras.Add(new SqlParameter("@TenNV", rapphim.TenNhanVien));

            try
            {
                return (dp.executeNonQuery("SuaRapPhim", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Sua PhongChieu
        public int SuaPhongChieuDAL(PhongChieuDTO phongchieu)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPC", phongchieu.MaPC));
            paras.Add(new SqlParameter("@TenPC", phongchieu.TenPC));
            paras.Add(new SqlParameter("@DinhDang", phongchieu.DinhDang));
            paras.Add(new SqlParameter("@MaRP", phongchieu.MaRP));
            paras.Add(new SqlParameter("@TenRP", phongchieu.TenRP));

            try
            {
                return (dp.executeNonQuery("SuaPhongChieu", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Sua Phim
        public int SuaPhimDAL(PhimDTO film)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPhim", film.MaPhim));
            paras.Add(new SqlParameter("@TenPhim", film.TenPhim));
            paras.Add(new SqlParameter("@DaoDien", film.DaoDien));
            paras.Add(new SqlParameter("@QuocGia", film.QuocGia));
            paras.Add(new SqlParameter("@Nam", film.Nam));
            paras.Add(new SqlParameter("@ThoiLuong", film.ThoiLuong));
            paras.Add(new SqlParameter("@TheLoai", film.TheLoai));
            paras.Add(new SqlParameter("@HinhAnh", film.HinhAnh));

            try
            {
                return (dp.executeNonQuery("SuaPhim", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Sua LichChieu
        public int SuaLichChieuDAL(LichChieuDTO lichchieu)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaRP", lichchieu.MaRP));
            paras.Add(new SqlParameter("@TenRP", lichchieu.TenRP));
            paras.Add(new SqlParameter("@MaPC", lichchieu.MaPC));
            paras.Add(new SqlParameter("@TenPC", lichchieu.TenPC));
            paras.Add(new SqlParameter("@MaPhim", lichchieu.MaPhim));
            paras.Add(new SqlParameter("@TenPhim", lichchieu.TenPhim));
            paras.Add(new SqlParameter("@NgayChieu", lichchieu.NgayChieu));
            paras.Add(new SqlParameter("@GioChieu", lichchieu.GioChieu));
            paras.Add(new SqlParameter("@DinhDang", lichchieu.DinhDang));

            try
            {
                return (dp.executeNonQuery("SuaLichChieu", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Sua NhanVien
        public int SuaNhanVienDAL(NhanVienDTO nhanvien)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", nhanvien.MaNV));
            paras.Add(new SqlParameter("@TenNV", nhanvien.TenNV));
            paras.Add(new SqlParameter("@NgaySinh", nhanvien.NgaySinh));
            paras.Add(new SqlParameter("@GioiTinh", nhanvien.GioiTinh));
            paras.Add(new SqlParameter("@SoCMND", nhanvien.SoCMND));
            paras.Add(new SqlParameter("@DiaChi", nhanvien.DiaChi));
            paras.Add(new SqlParameter("@SDT", nhanvien.SDT));
            paras.Add(new SqlParameter("@Email", nhanvien.Email));
            paras.Add(new SqlParameter("@ChucVu", nhanvien.ChucVu));
            paras.Add(new SqlParameter("@NgayVaoLam", nhanvien.NgayVaoLam));

            try
            {
                return (dp.executeNonQuery("SuaNhanVien", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Sua ThucAn_Tam (Tăng số lượng thức ăn)
        public int TangThucAnTamDAL(ThucAn_TamDTO thucan_tam)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@ID", thucan_tam.ID));
            paras.Add(new SqlParameter("@TenTA", thucan_tam.TenTA));
            try
            {
                return dp.executeNonQuery("TangThucAnTam", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Sua ThucAn_Tam (Giảm số lượng thức ăn)
        public int GiamThucAnTamDAL(ThucAn_TamDTO thucan_tam)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@ID", thucan_tam.ID));
            paras.Add(new SqlParameter("@TenTA", thucan_tam.TenTA));
            try
            {
                return dp.executeNonQuery("GiamThucAnTam", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
