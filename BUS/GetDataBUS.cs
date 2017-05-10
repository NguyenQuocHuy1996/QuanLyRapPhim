using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class GetDataBUS
    {
        //Lấy thông tin rạp phim
        public DataSet GetRapPhimBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetRapPhimDAL(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        //Lấy thông tin phòng chiếu
        public DataSet GetPhongChieuBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetPhongChieuDAL(sql));

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        } 

        //Get toan bo phim
        public DataSet GetPhimBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetPhimDAL(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        } 
        
        //Get toan bo the loai
        public DataSet GetTheLoaiBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetTheLoaiDAL(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy thông tin lịch chiếu
        public DataSet GetLichChieuBUS(string sql)
        {
            try
            {
                return new GetDataDAL().GetLichChieuDAL(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy toàn bộ thông tin nhân viên
        public DataSet GetNhanVienBUS(string sql)
        {
            try
            {
                return new GetDataDAL().GetNhanVienDAL(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
   
        //Lấy thông tin chúc vụ
        public DataSet GetChucVuBUS(string sql)
        {
            try
            {
                return new GetDataDAL().GetChucVuDAL(sql);
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        //Lấy thông tin vé xem phim
        public DataSet GetVeBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetVeDAL(sql));

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy thông tin ngày chiếu
        public DataSet GetNgayChieuBUS(string sql)
        {
            try
            {
                return (new GetDataDAL().GetNgayChieuDAL(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy thông tin giờ chiếu
        public DataSet GetGioChieuBus(string sql)
        {
            try
            {
                return (new GetDataDAL().GetGioChieuDAL(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lay thong tin tài khoản có điều kiện là username + pass
        public DataSet GetTaiKhoanBUS(string sql)
        {
            try
            {
                return new GetDataDAL().GetTaiKhoanDAL(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
