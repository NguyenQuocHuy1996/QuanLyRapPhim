using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class GetOneDataDAL
    {
        private DataProvider dp;

        public GetOneDataDAL()
        {
            dp = new DataProvider();
        }
        
        //Lấy thông tin 1 rap phim dựa vào mã rap phim
        public RapPhimDTO GetOneRapPhimDAL(string maphim)
        {
            RapPhimDTO RapPhim = new RapPhimDTO();
            string query = "Select * From RapPhim Where MaRapPhim = '" + maphim + "'";
            try
            {
                dp.Connect();
                SqlCommand cmd = new SqlCommand(query, dp.cn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    RapPhim.MaRapPhim = read.GetString(0);
                    RapPhim.TenRapPhim = read.GetString(1);
                    RapPhim.DiaChi = read.GetString(2);
                    RapPhim.MaNV = read.GetString(3);
                    RapPhim.TenNhanVien = read.GetString(4);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
            return RapPhim;
        }

        //Lay 1 đối tượng phim dua vao MaPhim
        public PhimDTO GetOnePhimDAL(string maphim)
        {
            PhimDTO phim = new PhimDTO();
            string query = "Select * From Phim Where MaPhim = '" + maphim + "'";
            try
            {
                dp.Connect();
                SqlCommand cmd = new SqlCommand(query, dp.cn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    phim.MaPhim = read.GetString(0);
                    phim.TenPhim = read.GetString(1);
                    phim.DaoDien = read.GetString(2);
                    phim.QuocGia = read.GetString(3);
                    phim.Nam = read.GetInt32(4);
                    phim.ThoiLuong = read.GetInt32(5);
                    phim.TheLoai = read.GetString(6);
                    phim.HinhAnh = (byte[])read["hinhAnh"];
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
            return phim;
        }
    }
}
