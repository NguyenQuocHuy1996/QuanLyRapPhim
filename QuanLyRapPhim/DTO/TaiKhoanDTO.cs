using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string ChucVu { get; set; }

        public TaiKhoanDTO(string taiKhoan, string matKhau,string maNV, string tenNV,string ngaySinh, string chucvu)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            ChucVu = chucvu;
        }

        public TaiKhoanDTO(string taikhoan)
        {
            TaiKhoan = taikhoan;
        }

        public TaiKhoanDTO()
        {            
        }
    }
}
