using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            private set => instance = value;
        }

        private NhaCungCapDAO() { }

        public List<NhaCungCap> LayDanhSachNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();

            string query = "SELECT * FROM NhaCungCap";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaCungCap nhacungcap = new NhaCungCap(item);
                list.Add(nhacungcap);
            }

            return list;
        }
        public bool InsertNhaCungCap(string tenNCC, string sdtNCC, string diachiNCC)
        {
            string query = string.Format("insert dbo.NhaCungCap (TenNCC, SDTNCC, DiaChiNCC) values (N'{0}', {1}, N'{2}')", tenNCC, sdtNCC, diachiNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateNhaCungCap(int idNCC, string tenNCC, string sdtNCC, string diachiNCC)
        {
            string query = string.Format("update dbo.NhaCungCap set TenNCC = N'{1}', SDTNCC = {2}, DiaChiNCC = N'{3}' where idNCC = N'{0}'", idNCC, tenNCC, sdtNCC, diachiNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteNhaCungCap(int idNCC)
        {
            string query = string.Format("Delete NhaCungCap where idNCC = N'{0}'", idNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
