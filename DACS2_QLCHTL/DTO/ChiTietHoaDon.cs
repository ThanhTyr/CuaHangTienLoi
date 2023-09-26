using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DACS2_QLCHTL.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int iDCTHD, int iDHD, int iDSP, float soLuong)
        {
            this.IDCTHD = iDCTHD;
            this.IDHD = iDHD;
            this.IDSP = iDSP;
            this.SoLuong = soLuong;
        }

        public ChiTietHoaDon(DataRow row)
        {
            this.IDCTHD = (int)row["idCTHD"];
            this.IDHD = (int)row["idHD"];
            this.IDSP = (int)row["idSP"];
            this.SoLuong = (float)Convert.ToDouble(row["SoLuong"].ToString());
        }

        private int iDCTHD;
        private int iDHD;
        private int iDSP;
        private float soLuong;

        public int IDCTHD { get => iDCTHD; set => iDCTHD = value; }
        public int IDHD { get => iDHD; set => iDHD = value; }
        public int IDSP { get => iDSP; set => iDSP = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
    }
}
