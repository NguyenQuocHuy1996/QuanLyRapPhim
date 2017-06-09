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

        public static DataSet GetRapPhimDK2(string manv)
        {
            string sql = "SELECT * FROM RapPhim WHERE MaNV = N'"+manv+"'";
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

        //Lấy giờ chiếu có trong lịch chiếu
        public static DataSet GetGioChieu(string maRP, string maPhim, string NgayChieu)
        {
            string sql = "SELECT * FROM LichChieu WHERE MaRapPhim=N'"+maRP+"' and MaPhim =N'"+maPhim+"' and NgayChieu =N'"+NgayChieu+"'";
            return new GetDataBUS().GetLichChieuBUS(sql);
        }

        //All nhan vien
        public static DataSet GetNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return new GetDataBUS().GetNhanVienBUS(sql);
        }

        //Lấy thông tin nhân viên cho bảng tài khoản
        public static DataSet GetNhanVien_TK()
        {
            string sql = "SELECT TenNV, ChucVu, NgaySinh, MaNV FROM NhanVien Where ChucVu like N'Nhân viên quầy vé' or ChucVu like N'Nhân viên quầy ăn' or ChucVu like N'Quản lý%' or ChucVu like 'Admin'";
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

        //Lay thong tin thuc an dua vao ten thuc an
        public static DataSet GetThucAnDK(string thucan)
        {
            string sql = "Select * from ThucAn Where TenThucAn=N'"+ thucan +"'";
            return new GetDataBUS().GetThucAnBUS(sql);
        }

        //Lay thong tin thuc an tam
        public static DataSet GetThucAnTam()
        {
            string sql = "Select TenThucAn, SoLuong, DonGia, TongTien from ThucAn_Tam order by ID";
            return new GetDataBUS().GetThucAnTamBUS(sql);
        }

        //Lay thong tin trang thai ghe ngoi
        public static DataSet GetGhe(string marp, string maphim, string ngaychieu, string giochieu, string soghe)
        {
            string sql = "SELECT * FROM Ghe WHERE MaRapPhim=N'" + marp + "' and MaPhim=N'" + maphim + "' and NgayChieu=N'" + ngaychieu + "' and GioChieu=N'" + giochieu + "' and SoGhe =N'" + soghe + "'";
            return new GetDataBUS().GetGheBUS(sql);
        }


        //Lay thong tin ve
        public static DataSet GetVe()
        {
            string sql = "SELECT * FROM Ve";
            return (new GetDataBUS().GetVeBUS(sql));
        }

        //Lấy toàn bộ tài khoản
        public static DataSet GetTaiKhoan()
        {
            string sql = "SELECT TaiKhoan, MatKhau, TenNV, ChucVu, NgaySinh, MaNV FROM TaiKhoan";
            return new GetDataBUS().GetTaiKhoanBUS(sql);
        }

        //Lấy tài khoản quản lý
        public static DataSet GetTaiKhoanDK(string acc)
        {
            string sql = "Select * FROM TaiKhoan where TaiKhoan=N'" + acc + "'";
            return new GetDataBUS().GetTaiKhoanBUS(sql);
        }

        public static DataSet GetTaiKhoanDK2(string acc, string pass)
        {
            string sql = "Select * FROM TaiKhoan where TaiKhoan=N'" + acc + "' and MatKhau = N'" + pass + "'";
            return new GetDataBUS().GetTaiKhoanBUS(sql);
        }
    }
}
