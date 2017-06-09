using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichChieuDTO
    {
        public string MaRP { get; set; }
        public string TenRP { get; set; }
        public string MaPC { get; set; }
        public string TenPC { get; set; }
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public string DinhDang { get; set; }

        public LichChieuDTO(string maRP, string tenRP, string maPC, string tenPC, string maPhim, string tenPhim, string ngayChieu, string gioChieu, string dinhDang)
        {
            MaRP = maRP;
            TenRP = tenRP;
            MaPC = maPC;
            TenPC = tenPC;
            MaPhim = maPhim;
            TenPhim = tenPhim;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            DinhDang = dinhDang;
        }

        public LichChieuDTO(string maRP, string maPC, string maPhim, string ngayChieu, string gioChieu, string dinhDang)
        {
            MaRP = maRP;
            MaPC = maPC;
            MaPhim = maPhim;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            DinhDang = dinhDang;

        }

        public LichChieuDTO()
        {

        }
    }
}
