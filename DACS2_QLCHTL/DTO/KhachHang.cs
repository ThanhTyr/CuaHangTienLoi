using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class KhachHang
    {
        public KhachHang(int idKH, string tenKH, string sdtKH, string diachiKH, string emailKH)
        {
            this.IDKH = idKH;
            this.TenKH = tenKH;
            this.SDTKH = sdtKH;
            this.DiaChiKH = diachiKH;
            this.EmailKH = emailKH;
        }

        public KhachHang(DataRow row)
        {
            this.IDKH = (int)row["idKH"];
            this.TenKH = row["TenKH"].ToString();
            this.SDTKH = row["SDTKH"].ToString();
            this.DiaChiKH = row["DiaChiKH"].ToString();
            this.EmailKH = row["EmailKH"].ToString();
        }

        private int iDKH;
        private string tenKH;
        private string sDTKH;
        private string diaChiKH;
        private string emailKH;

        public int IDKH { get => iDKH; set => iDKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDTKH { get => sDTKH; set => sDTKH = value; }
        public string DiaChiKH { get => diaChiKH; set => diaChiKH = value; }
        public string EmailKH { get => emailKH; set => emailKH = value; }
    }
}
