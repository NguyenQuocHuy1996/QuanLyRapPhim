using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoaiDTO
    {
        public string TheLoai { get; set; }

        public TheLoaiDTO(string theLoai)
        {
            TheLoai = theLoai;
        }
    }
}
