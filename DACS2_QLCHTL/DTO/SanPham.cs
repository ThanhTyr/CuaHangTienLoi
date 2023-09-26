using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class SanPham
    {
        public SanPham(int idSP, string tenSP, float donGia, float soLuong)
        {
            this.IDSP = idSP;
            this.TenSP = tenSP;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public SanPham(DataRow row)
        {
            this.IDSP = (int)row["idSP"];
            this.TenSP = row["TenSP"].ToString();
            this.DonGia = (float)Convert.ToDouble(row["DonGia"].ToString());
            this.SoLuong = (float)Convert.ToDouble(row["SoLuong"].ToString());
        }

        private int iDSP;
        private string tenSP;
        private float donGia;
        private float soLuong;

        public int IDSP { get => iDSP; set => iDSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
    }
}
