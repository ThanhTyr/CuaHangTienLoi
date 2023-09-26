using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap(int idNCC, string tenNCC, string sdtNCC, string diachiNCC)
        {
            this.IDNCC = idNCC;
            this.TenNCC = tenNCC;
            this.SDTNCC = sdtNCC;
            this.DiaChiNCC = diachiNCC;
        }

        public NhaCungCap(DataRow row)
        {
            this.IDNCC = (int)row["idNCC"];
            this.TenNCC = row["TenNCC"].ToString();
            this.SDTNCC = row["SDTNCC"].ToString();
            this.DiaChiNCC = row["DiaChiNCC"].ToString();
        }

        private int iDNCC;
        private string tenNCC;
        private string sDTNCC;
        private string diaChiNCC;

        public int IDNCC { get => iDNCC; set => iDNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string SDTNCC { get => sDTNCC; set => sDTNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
    }
}
