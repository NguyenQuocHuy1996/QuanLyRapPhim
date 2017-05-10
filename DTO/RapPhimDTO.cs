using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class RapPhimDTO
    {
        public string MaRapPhim { get; set; }
        public string TenRapPhim { get; set; }
        public string DiaChi { get; set; }
        public string MaNV { get; set; }
        public string TenNhanVien { get; set; }

        public RapPhimDTO(string maRapPhim, string tenRapPhim, string diaChi, string maNV, string tenNV)
        {
            MaRapPhim = maRapPhim;
            TenRapPhim = tenRapPhim;
            DiaChi = diaChi;
            MaNV = maNV;
            TenNhanVien = tenNV;
        }

        public RapPhimDTO()
        {

        }
    }
}
