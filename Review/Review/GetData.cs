using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DTO;
using BUS;

namespace Review
{
    public class GetData
    {
        //Rạp phim
        public static DataSet GetRapPhim()
        {
            string sql = "SELECT * FROM RapPhim";
            return new GetDataBUS().GetRapPhimBUS(sql);
        }

        //Lay thông tin nhân viên quản lý rạp phim dựa vào ma rạp phim
        public static DataSet GetRapPhimDK(string marapphim)
        {
            string sql = "SELECT TenNV FROM RapPim WHERE MaRP = '" + marapphim + "'";
            return new GetDataBUS().GetRapPhimBUS(sql);
        }

        //Lấy thông tin phòng chiếu
        public static DataSet GetPhongChieu()
        {
            string sql = "SELECT * FROM PhongChieu";
            return new GetDataBUS().GetPhongChieuBUS(sql);
        }

        //Phong Chieu theo ma rap phim
        public static DataSet GetPhongChieuDK(string marapphim)
        {
            string sql = "SELECT * FROM PhongChieu where MaRapPhim=N'"+ marapphim +"'";
            return (new GetDataBUS().GetPhongChieuBUS(sql));
        }

        //Phong Chieu theo ma rap phim + dinh dang
        public static DataSet GetPhongChieuDK2(string marapphim, string dinhdang)
        {
            string sql = "SELECT * FROM PhongChieu where DinhDang=N'"+ dinhdang +"' and MaRapPhim=N'" + marapphim + "'";
            return (new GetDataBUS().GetPhongChieuBUS(sql));
        }

        //Phim
        public static DataSet GetPhim()
        {
            string sql = "SELECT * FROM Phim";
            return (new GetDataBUS().GetPhimBUS(sql));
        }

        //Thể loại
        public static DataSet GetTheLoai()
        {
            string sql = "SELECT * FROM TheLoai";
            return (new GetDataBUS().GetTheLoaiBUS(sql));
        }

        //Lich chieu
        public static DataSet GetLichChieu()
        {
            string sql = " SELECT * FROM LichChieu";
            return new GetDataBUS().GetLichChieuBUS(sql);
        }
        
        //Lich chieu theo ma rap phim
        public static DataSet GetLichChieuDK(string maRP)
        {
            string sql = " SELECT * FROM LichChieu WHERE MaRapPhim = '"+ maRP +"'";
            return new GetDataBUS().GetLichChieuBUS(sql);
        }

        //All nhan vien trừ tài khoản + mật khẩu
        public static DataSet GetNhanVien()
        {
            string sql = "SELECT MaNV,TenNV,NgaySinh,GioiTinh,SoCMND,DiaChi,SDT,Email,ChucVu,NgayVaoLam FROM NhanVien";
            return new GetDataBUS().GetNhanVienBUS(sql);
        }

        //Nhan vien dua vao chuc vu
        public static DataSet GetNhanVienDK(string chucvu)
        {
            string sql = "Select * from NhanVien where ChucVu=N'" + chucvu + "'";
            return new GetDataBUS().GetNhanVienBUS(sql);
        }

        //Lấy thông tin chức vụ
        public static DataSet GetChucVu()
        {
            string sql = "SELECT * FROM ChucVu";
            return new GetDataBUS().GetChucVuBUS(sql);
        }

        public static DataSet GetNgayChieu()
        {
            string sql = "Select * FROM NgayChieu";
            return new GetDataBUS().GetNgayChieuBUS(sql);
        }

        public static DataSet GetGioChieu()
        {
            string sql = "Select * from GioChieu";
            return new GetDataBUS().GetGioChieuBus(sql);
        }

        public static DataSet GetVe()
        {
            string sql = "SELECT * FROM Ve";
            return (new GetDataBUS().GetVeBUS(sql));
        }

        public static DataSet GetTaiKhoanDK(string acc, string pass)
        {
            string sql = "Select * FROM TaiKhoan where TaiKhoan=N'" + acc + "' and MatKhau='" + pass + "'";
            return new GetDataBUS().GetTaiKhoanBUS(sql);
        }
    }
}
