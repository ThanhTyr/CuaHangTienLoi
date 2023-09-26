using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DACS2_QLCHTL.DTO
{
    public class GioHang
    {
        public GioHang(string tenSP, float donGia, float soLuong, float tongTien, float phamTramGiamGia)
        {
            this.TenSP = tenSP;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.TongTien = tongTien;
            this.PhamTramGiamGia = phamTramGiamGia;
        }

        public GioHang(DataRow row)
        {
            this.TenSP = row["TenSP"].ToString();
            this.DonGia = (float)Convert.ToDouble(row["DonGia"].ToString());
            this.SoLuong = (float)Convert.ToDouble(row["SoLuong"].ToString());
            this.TongTien = (float)Convert.ToDouble(row["TongTien"].ToString());
            this.PhamTramGiamGia = (float)Convert.ToDouble(row["PhanTramGiamGia"].ToString());
        }

        private string tenSP;
        private float donGia;
        private float soLuong;
        private float tongTien;
        private float phamTramGiamGia;

        public string TenSP { get => tenSP; set => tenSP = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float PhamTramGiamGia { get => phamTramGiamGia; set => phamTramGiamGia = value; }
    }
}
