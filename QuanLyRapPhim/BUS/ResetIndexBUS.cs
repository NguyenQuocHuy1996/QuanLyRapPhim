using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DTO;
using DAL;

namespace BUS
{
    public class ResetIndexBUS
    {
        public void ResetSTTBUS()
        {
            new ResetIndexDAL().ResetSTTDAL();
        }

        public void ResetSTTDKBUS(int so)
        {
            new ResetIndexDAL().ResetSTTDKDAL(so);
        }
    }
}
