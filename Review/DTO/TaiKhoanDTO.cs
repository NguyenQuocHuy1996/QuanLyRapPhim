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
        public string LoaiTaiKhoan { get; set; }

        public TaiKhoanDTO(string taiKhoan, string matKhau, string loaiTaiKhoan)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
        }

        public TaiKhoanDTO()
        {

        }
    }
}
