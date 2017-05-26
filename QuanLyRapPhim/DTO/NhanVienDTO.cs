using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int SoCMND { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string NgayVaoLam { get; set; }

        public NhanVienDTO(string maNV, string tenNV, string ngaySinh, string gioiTinh, int soCMND, string diaChi, int sdt, string email, string chucVu, string ngayVaoLam)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoCMND = soCMND;
            DiaChi = diaChi;
            SDT = sdt;
            Email = email;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
        }
    }
}
