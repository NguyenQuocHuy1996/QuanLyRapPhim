using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class GetDataDAL
    {
        private DataProvider dp;

        public GetDataDAL()
        {
            dp = new DataProvider();
        }

        //Lấy thông tin rap phim
        public DataSet GetRapPhimDAL(string sql)
        {
            try
            {
                return (new DataProvider().GetData(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy thông tin phòng chiếu
        public DataSet GetPhongChieuDAL(string sql)
        {
            try
            {
                return (new DataProvider().GetData(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }        

        //Lay thông tin phim
        public DataSet GetPhimDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy toàn bộ thông tin thể loại
        public DataSet GetTheLoaiDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy thông tin lịch chiếu
        public DataSet GetLichChieuDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lấy toàn bộ thông tin nhân viên
        public DataSet GetNhanVienDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    
        //Lấy thông tin về chức vụ
        public DataSet GetChucVuDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        //Lay thong tin thuc an
        public DataSet GetThucAnDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex) 
            {                
                throw ex;
            }
        }

        //Lay thong tin thuc an tam
        public DataSet GetThucAnTamDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lay thong tin trang thai cua ghe
        public DataSet GetGheDAL(string sql)
        {
            try
            {
                return (new DataProvider().GetData(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
               
        }

        //Lấy thông tin vé xem phim
        public DataSet GetVeDAL(string sql)
        {
            try
            {
                return (new DataProvider().GetData(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Lay thong tin tài khoản
        public DataSet GetTaiKhoanDAL(string sql)
        {
            try
            {
                return new DataProvider().GetData(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
