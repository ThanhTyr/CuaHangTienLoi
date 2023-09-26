using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class HoaDon
    {
        public HoaDon(int idHD, DateTime? ngayBan, int tinhTrang, float tongTien)
        {
            this.IDHD = idHD;
            this.NgayBan = ngayBan;
            this.TinhTrang = tinhTrang;
            this.TongTien = tongTien;
        }

        public HoaDon(DataRow row)
        {
            this.IDHD = (int)row["idHD"];
            this.NgayBan = (DateTime?)row["ngayBan"];
            this.TinhTrang = (int)row["tinhTrang"];
            this.TongTien = (float)Convert.ToDouble(row["tongTien"].ToString());
        }

        private int iDHD;
        private DateTime? ngayBan;
        private int tinhTrang;
        private float tongTien;

        public int IDHD { get => iDHD; set => iDHD = value; }
        public DateTime? NgayBan { get => ngayBan; set => ngayBan = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
