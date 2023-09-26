using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DACS2_QLCHTL.DTO
{
    public class GiamGia
    {
        public GiamGia(int iDGG, float phanTramGiamGia, DateTime? ngayKT)
        {
            this.IDGG = iDGG;
            this.PhanTramGiamGia = phanTramGiamGia;
            this.NgayKT = ngayKT;
        }

        public GiamGia(DataRow row)
        {
            this.IDGG = (int)row["idGG"];
            this.PhanTramGiamGia = (float)Convert.ToDouble(row["PhanTramGiamGia"].ToString());

            var ngayKTTemp = row["NgayKT"];
            if (ngayKTTemp.ToString() != "")
            {
                this.NgayKT = (DateTime?)ngayKTTemp;
            }
        }

        private int iDGG;
        private float phanTramGiamGia;
        private DateTime? ngayKT;

        public int IDGG { get => iDGG; set => iDGG = value; }
        public float PhanTramGiamGia { get => phanTramGiamGia; set => phanTramGiamGia = value; }
        public DateTime? NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
