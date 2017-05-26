using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VeDTO
    {
        public int MaVe { get; set; }
        public string TenPhim { get; set; }
        public string NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public string SoGhe { get; set; }
        public string LoaiGhe { get; set; }
        public int GiaVe { get; set; }

        public VeDTO(string tenPhim, string ngayChieu, string gioChieu, string soGhe, string loaiGhe, int giaVe)
        {
            TenPhim = tenPhim;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            SoGhe = soGhe;
            LoaiGhe = loaiGhe;
            GiaVe = giaVe;
        }
    }
}
