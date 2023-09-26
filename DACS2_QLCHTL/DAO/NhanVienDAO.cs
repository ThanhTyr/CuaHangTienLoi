using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set => instance = value;
        }

        private NhanVienDAO() { }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "SELECT * FROM NhanVien";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }

            return list;
        }
        public bool InsertNhanVien(string tenNV, string sdtNV, string diachiNV, string chucvuNV, string ngaysinhNV)
        {
            string query = string.Format("insert dbo.NhanVien (TenNV, NgaySinhNV, DiaChiNV, SDTNV, ChucVu)values (N'{0}', '{1}', N'{2}', {3}, N'{4}')", tenNV, ngaysinhNV, diachiNV, sdtNV, chucvuNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateNhanVien(int idNV, string tenNV, string sdtNV, string diachiNV, string chucvuNV, string ngaysinhNV)
        {
            string query = string.Format("update dbo.NhanVien set TenNV = N'{1}', NgaySinhNV = '{2}', DiaChiNV = N'{3}', SDTNV = {4}, ChucVu = N'{5}' where idNV = N'{0}'", idNV, tenNV, ngaysinhNV, diachiNV, sdtNV, chucvuNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteNhanVien(int idNV)
        {
            string query = string.Format("Delete NhanVien where idNV = N'{0}'", idNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
