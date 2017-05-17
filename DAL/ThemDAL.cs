using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using DTO;

namespace DAL
{
    public class ThemDAL
    {
        private DataProvider dp;

        public ThemDAL()
        {
            dp = new DataProvider();
        }

        //Them rap phim
        public int ThemRapPhimDAL(RapPhimDTO rapphim)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaRP", rapphim.MaRapPhim));
            paras.Add(new SqlParameter("@TenRP", rapphim.TenRapPhim));
            paras.Add(new SqlParameter("@DiaChi", rapphim.DiaChi));
            paras.Add(new SqlParameter("@MaNV", rapphim.MaNV));
            paras.Add(new SqlParameter("@TenNV", rapphim.TenNhanVien));
                        try
            {
                return (dp.executeNonQuery("ThemRapPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
        //Them phong chieu
        public int ThemPhongChieuDAL(PhongChieuDTO phongchieu)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPC", phongchieu.MaPC));
            paras.Add(new SqlParameter("@TenPC", phongchieu.TenPC));
            paras.Add(new SqlParameter("@DinhDang", phongchieu.DinhDang));
            paras.Add(new SqlParameter("@MaRP", phongchieu.MaRP));
            paras.Add(new SqlParameter("@TenRP", phongchieu.TenRP));
            try
            {
                return (dp.executeNonQuery("ThemPhongCHieu", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Them Phim
        public int Them_PhimDAL(PhimDTO film)
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
                return (dp.executeNonQuery("ThemPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Them LichChieu
        public int ThemLichChieuDAL(LichChieuDTO lichchieu)
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
                return (dp.executeNonQuery("ThemLichChieu", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        //Them NhanVien
        public int ThemNhanVienDAL(NhanVienDTO nhanvien)
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
                return (dp.executeNonQuery("ThemNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int ThemKhachHangDAL(KhachHangDTO khachhang)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TaiKhoan", khachhang.TaiKhoan));
            paras.Add(new SqlParameter("@MatKhau", khachhang.MatKhau));
            paras.Add(new SqlParameter("@HoTen", khachhang.HoTen));
            paras.Add(new SqlParameter("@GioiTinh", khachhang.GioiTinh));
            paras.Add(new SqlParameter("@NgaySinh", khachhang.NgaySinh));
            paras.Add(new SqlParameter("@CMND", khachhang.CMND));
            paras.Add(new SqlParameter("@DiaChi", khachhang.DiaChi));
            paras.Add(new SqlParameter("@Email", khachhang.Email));
            paras.Add(new SqlParameter("@SDT", khachhang.SDT));

            try
            {
                return (dp.executeNonQuery("ThemKhachHang", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public int ThemTaiKhoanDAL(TaiKhoanDTO taikhoan)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TaiKhoan", taikhoan.TaiKhoan));
            paras.Add(new SqlParameter("@MatKhau", taikhoan.MatKhau));
            paras.Add(new SqlParameter("@LoaiTaiKhoan", taikhoan.LoaiTaiKhoan));

            try
            {
                return (dp.executeNonQuery("ThemTaiKhoan", CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        //Them Ve
        public int Them_VeDAL(VeDTO ve)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@TenPhim", ve.TenPhim));
            paras.Add(new SqlParameter("@NgayChieu", ve.NgayChieu));
            paras.Add(new SqlParameter("@GioChieu", ve.GioChieu));
            paras.Add(new SqlParameter("@SoGhe", ve.SoGhe));
            paras.Add(new SqlParameter("@LoaiGhe", ve.LoaiGhe));
            paras.Add(new SqlParameter("@DoiTuong", ve.LoaiGhe));
            paras.Add(new SqlParameter("@GiaVe", ve.GiaVe));

            try
            {
                return (dp.executeNonQuery("ThemVe", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //public void Them_VeDAL(List<string> maghe) //maghe = 1,3,5,7,9
        //{
        //    for (int i = 0; i < maghe.Count; i++)
        //    {
        //        string query = "Insert into Ve MaGhe = '" + maghe[i] + "'";
        //        SqlCommand cmd = new SqlCommand(query, dp.cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
    }
}
