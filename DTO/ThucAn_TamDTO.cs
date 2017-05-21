using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThucAn_TamDTO
    {
        public int ID { get; set; }
        public string TenTA { get; set; }
        public int Gia { get; set; }

        public ThucAn_TamDTO(int id, string tenTA, int gia)
        {
            ID = id;
            TenTA = tenTA;
            Gia = gia;
        }

        public ThucAn_TamDTO(string tenTA, int gia)
        {
            TenTA = tenTA;
            Gia = gia;
        }


        public ThucAn_TamDTO(string tenTA)
        {
            TenTA = tenTA;
        }
    }
}
