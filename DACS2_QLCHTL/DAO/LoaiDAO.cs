using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class LoaiDAO
    {
        private static LoaiDAO instance;

        public static LoaiDAO Instance
        {
            get { if (instance == null) instance = new LoaiDAO(); return instance; }
            private set => instance = value;
        }

        private LoaiDAO() { }

        public List<Loai> LayDanhSachLoai()
        {
            List<Loai> list = new List<Loai>();

            string query = "SELECT * FROM LoaiSanPham";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                Loai loai = new Loai(item);
                list.Add(loai);
            }

            return list;
        }

        public List<Loai> TimSanPhamTheoMaVachBangIDSP(string idsp)
        {
            List<Loai> list = new List<Loai>();

            string query = string.Format("SELECT l.idLSP, l.TenLSP FROM LoaiSanPham as l, SanPham as sp where sp.idLSP = l.idLSP and sp.idSP like '%{0}%'", idsp);

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                Loai loai = new Loai(item);
                list.Add(loai);
            }

            return list;
        }
        public bool InsertLoai(string tenLoai)
        {
            string query = string.Format("insert dbo.LoaiSanPham (TenLSP) values (N'{0}')", tenLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateLoai(int idLoai, string tenLoai)
        {
            string query = string.Format("update dbo.LoaiSanPham set TenLSP = N'{1}'where idLSP = N'{0}'", idLoai, tenLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteLoai(int idLoai)
        {
            string query = string.Format("Delete LoaiSanPham where idLSP = N'{0}'", idLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public DataTable DanhSachTongSoLoaiSanPham()
        {
            return DataProvider.Instance.Executequery("Select COUNT(lsp.idLSP) as SoLoaiSP from LoaiSanPham as lsp");
        }
    }
}
