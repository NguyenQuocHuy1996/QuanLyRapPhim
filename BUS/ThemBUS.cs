using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class ThemBUS
    {
        //Them RapPhim
        public int ThemRapPhimBUS(RapPhimDTO rapphim)
        {
            try
            {
                return new ThemDAL().ThemRapPhimDAL(rapphim);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them PhongChieu
        public int ThemPhongChieuBUS(PhongChieuDTO phongchieu)
        {
            try
            {
                return new ThemDAL().ThemPhongChieuDAL(phongchieu);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them Phim
        public int Them_PhimBUS(PhimDTO film)
        {
            try
            {
                return (new ThemDAL().Them_PhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them TheLoai
        public int ThemTheLoaiBUS(TheLoaiDTO TheLoai)
        {
            try
            {
                return (new ThemDAL().ThemTheLoaiDAL(TheLoai));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them LichChieu
        public int ThemLichChieuBUS(LichChieuDTO lichchieu)
        {
            try
            {
                return (new ThemDAL().ThemLichChieuDAL(lichchieu));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        //Them Nhan vien
        public int ThemNhanVienBUS(NhanVienDTO nhanvien)
        {
            try
            {
                return (new ThemDAL().ThemNhanVienDAL(nhanvien));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them thuc an tam
        public int ThemThucAn_TamBUS(ThucAn_TamDTO thucantam)
        {
            try
            {
                return new ThemDAL().ThemThucAn_TamDAL(thucantam);
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        //Them tai khoan
        public int ThemTaiKhoanBUS(TaiKhoanDTO taikhoan)
        {
            try
            {
                return (new ThemDAL().ThemTaiKhoanDAL(taikhoan));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Them Ve
        public int Them_VeBUS(VeDTO ve)
        {
            try
            {
                return (new ThemDAL().Them_VeDAL(ve));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemKhachHangBUS(KhachHangDTO khachhang)
        {
            try
            {
                return (new ThemDAL().ThemKhachHangDAL(khachhang));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}