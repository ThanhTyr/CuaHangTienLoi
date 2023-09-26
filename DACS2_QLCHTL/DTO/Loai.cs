using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class Loai
    {
        public Loai(int idLSP, string tenLSP)
        {
            this.IDLSP = idLSP;
            this.TenLSP = tenLSP;

        }

        public Loai(DataRow row)
        {
            this.IDLSP = (int)row["idLSP"];
            this.TenLSP = row["TenLSP"].ToString();

        }

        private int iDLSP;
        private string tenLSP;

        public int IDLSP { get => iDLSP; set => iDLSP = value; }
        public string TenLSP { get => tenLSP; set => tenLSP = value; }
    }
}
