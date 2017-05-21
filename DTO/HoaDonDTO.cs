using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonDTO
    {
        public string TenTA { get; set; }
        public int Gia { get; set; }
        public string Ngay { get; set; }
        public string Gio { get; set; }

        public HoaDonDTO(string tenTA, int gia, string ngay, string gio)
        {
            TenTA = tenTA;
            Gia = gia;
            Ngay = ngay;
            Gio = gio;
        }
    }
}
