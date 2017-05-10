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
        public Boolean G1 {get;set;}
        public Boolean G2 { get; set; }
        public Boolean G3 { get; set; }
        public Boolean G4 { get; set; }
        public Boolean G5 { get; set; }


        public GheDTO(string maRapPhim, string tenRapPhim, string maPhim, Boolean g1, Boolean g2, Boolean g3, Boolean g4, Boolean g5)
        {
            MaRapPhim = maRapPhim;
            TenRapPhim = tenRapPhim;
            MaPhim = maPhim;
            G1 = g1;
            G2 = g2;
            G3 = g3;
            G4 = g4;
            G5 = g5;
        }

        public GheDTO(string maPhim, Boolean g1, Boolean g2, Boolean g3, Boolean g4, Boolean g5)
        {
            MaPhim = maPhim;
            G1 = g1;
            G2 = g2;
            G3 = g3;
            G4 = g4;
            G5 = g5;
        }
        public GheDTO(string maRapPhim, string maPhim)
        {
            MaRapPhim = maRapPhim;
            MaPhim = maPhim;
        }

        public GheDTO()
        {

        }
    }
}
