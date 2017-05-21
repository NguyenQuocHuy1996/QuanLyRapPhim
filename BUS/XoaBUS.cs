using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class XoaBUS
    {
        //Xoa rap phim
        public int XoaRapPhimBUS(RapPhimDTO rapphim)
        {
            try
            {
                return new XoaDAL().XoaRapPhimDAL(rapphim);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa phong chieu
        public int XoaPhongChieuBUS(PhongChieuDTO phongchieu)
        {
            try
            {
                return new XoaDAL().XoaPhongChieuDAL(phongchieu);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        //Xoa Phim
        public int Xoa_PhimBUS(PhimDTO film)
        {
            try
            {
                return (new XoaDAL().Xoa_PhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa TheLoai
        public int XoaTheLoaiBUS(TheLoaiDTO theloai)
        {
            try
            {
                return (new XoaDAL().XoaTheLoaiDAL(theloai));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa LichChieu
        public int XoaLichChieuBUS(LichChieuDTO lichchieu)
        {
            try
            {
                return (new XoaDAL().XoaLichChieuDAL(lichchieu));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa Nhan vien
        public int XoaNhanVienBUS(NhanVienDTO nhanvien)
        {
            try
            {
                return (new XoaDAL().XoaNhanVienDAL(nhanvien));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa TaiKhoan
        public int XoaTaiKhoanBUS(TaiKhoanDTO taikhoan)
        {
            try
            {
                return (new XoaDAL().XoaTaiKhoanDAL(taikhoan));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Xoa ThucAnTam
        public int XoaThucAnTamBUS(ThucAn_TamDTO thucan)
        {
            try
            {
                return (new XoaDAL().XoaThucAnTamDAL(thucan));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
