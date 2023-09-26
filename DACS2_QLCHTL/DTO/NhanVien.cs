using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DTO
{
    public class NhanVien
    {
        public NhanVien(int idNV, string tenNV, DateTime? ngaysinhNV, string diachiNV, string sdtNV, string chucvu)
        {
            this.IDNV = idNV;
            this.TenNV = tenNV;
            this.NgaySinhNV = ngaysinhNV;
            this.DiaChiNV = diachiNV;
            this.SDTNV = sdtNV;
            this.ChucVu = chucvu;
        }

        public NhanVien(DataRow row)
        {
            this.IDNV = (int)row["idNV"];
            this.TenNV = row["TenNV"].ToString();
            this.NgaySinhNV = (DateTime?)row["NgaySinhNV"];
            this.DiaChiNV = row["DiaChiNV"].ToString();
            this.SDTNV = row["SDTNV"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
        }

        private int iDNV;
        private string tenNV;
        private DateTime? ngaySinhNV;
        private string diaChiNV;
        private string sDTNV;
        private string chucVu;

        public int IDNV { get => iDNV; set => iDNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime? NgaySinhNV { get => ngaySinhNV; set => ngaySinhNV = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public string SDTNV { get => sDTNV; set => sDTNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
