using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DACS2_QLCHTL.DTO
{
    public class DonVi
    {
        public DonVi(int idDV, string tenDV)
        {
            this.IDDV = idDV;
            this.TenDV = tenDV;

        }

        public DonVi(DataRow row)
        {
            this.IDDV = (int)row["idDV"];
            this.TenDV = row["TenDV"].ToString();

        }

        private int iDDV;
        private string tenDV;

        public int IDDV { get => iDDV; set => iDDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
    }
}
