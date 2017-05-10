using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DAL;
using DTO;

namespace BUS
{
    public class GetOneDataBUS
    {
        //Lấy thông tin 1 rap phim dua vao ma rap phim
        public RapPhimDTO GetOneRapPhimBUS(string maphim)
        {
            try
            {
                return (new GetOneDataDAL().GetOneRapPhimDAL(maphim));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Lấy thông tin 1 phòng chiếu
        public GheDTO GetOnePhongChieuBUS(string maphim)
        {
            try
            {
                return (new GetOneDataDAL().GetOnePhongChieuDAL(maphim));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Get 1 doi tuong phim
        public PhimDTO GetOnePhimBUS(string maphim)
        {
            try
            {
                return (new GetOneDataDAL().GetOnePhimDAL(maphim));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
