using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DACS2_QLCHTL.DTO
{
    public class DangNhap
    {
        public DangNhap(string taiKhoan, int loaiTK, int idNV, string matKhau = null)
        {
            this.TaiKhoan = taiKhoan;
            this.LoaiTK = loaiTK;
            this.MatKhau = matKhau;
            this.IDNV = idNV;
        }

        public DangNhap(DataRow row)
        {
            this.TaiKhoan = row["taiKhoan"].ToString();
            this.LoaiTK = (int)row["loaiTK"];
            this.MatKhau = row["matKhau"].ToString();
            this.IDNV = (int)row["idNV"];
        }

        private string taiKhoan;
        private string matKhau;
        private int loaiTK;
        private int iDNV;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public int IDNV { get => iDNV; set => iDNV = value; }
    }
}
