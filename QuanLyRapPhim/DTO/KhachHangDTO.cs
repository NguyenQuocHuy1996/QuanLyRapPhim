using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public int CMND { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int SDT { get; set; }

        public KhachHangDTO(string taiKhoan, string matKhau, string hoTen, string gioiTinh, string ngaySinh, int cmnd, string diaChi, string email, int sdt)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            CMND = cmnd;
            DiaChi = diaChi;
            Email = email;
            SDT = sdt;
        }

        public KhachHangDTO()
        {

        }
    }
}
