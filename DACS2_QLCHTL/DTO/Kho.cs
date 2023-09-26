using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class Kho
    {
        public Kho(int idK, DateTime? ngayNhap, float soLuong)
        {
            this.IDK = idK;
            this.NgayNhap = ngayNhap;
            this.SoLuong = soLuong;
        }

        public Kho(DataRow row)
        {
            this.IDK = (int)row["idK"];
            this.NgayNhap = (DateTime?)row["NgayNhap"];
            this.SoLuong = (float)Convert.ToDouble(row["SoLuong"].ToString());
        }

        private int iDK;
        private DateTime? ngayNhap;
        private float soLuong;

        public int IDK { get => iDK; set => iDK = value; }
        public DateTime? NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
    }
}

