using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class GheDTO
    {
        public string MaRapPhim { get; set; }
        public string TenRapPhim { get; set; }
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public string SoGhe { get; set; }


        public GheDTO(string maRapPhim, string tenRapPhim, string maPhim, string tenPhim, string ngayChieu, string gioChieu , string soGhe)
        {
            MaRapPhim = maRapPhim;
            TenRapPhim = tenRapPhim;
            MaPhim = maPhim;
            TenPhim = tenPhim;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            SoGhe = soGhe;
        }
    }
}
