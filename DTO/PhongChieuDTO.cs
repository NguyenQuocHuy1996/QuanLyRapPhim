using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhongChieuDTO
    {
        public string MaPC { get; set; }
        public string TenPC { get; set; }
        public string DinhDang { get; set; }
        public string MaRP { get; set; }
        public string TenRP { get; set; }

        public PhongChieuDTO(string maPC, string tenPC, string dinhDang, string maRP, string tenRP)
        {
            MaPC = maPC;
            TenPC = tenPC;
            DinhDang = dinhDang;
            MaRP = maRP;
            TenRP = tenRP;
        }
    }
}
