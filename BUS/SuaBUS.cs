using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class SuaBUS
    {
        //Sua Rap PHim
        public int SuaRapPhimBUS(RapPhimDTO rapphim)
        {
            try
            {
                return new SuaDAL().SuaRapPhimDAL(rapphim);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Sua Phong chieu
        public int SuaPhongChieuBUS(PhongChieuDTO phongchieu)
        {
            try
            {
                return (new SuaDAL().SuaPhongChieuDAL(phongchieu));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Sua Phim
        public int SuaPhimBUS(PhimDTO film)
        {
            try
            {
                return (new SuaDAL().SuaPhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        //Sua LichChieu
        public int SuaLichChieuBUS(LichChieuDTO lichchieu)
        {
            try
            {
                return (new SuaDAL().SuaLichChieuDAL(lichchieu));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        //Sua Nhan vien
        public int SuaNhanVienBUS(NhanVienDTO nhanvien)
        {
            try
            {
                return (new SuaDAL().SuaNhanVienDAL(nhanvien));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
