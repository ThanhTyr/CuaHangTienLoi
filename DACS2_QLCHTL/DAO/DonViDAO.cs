using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class DonViDAO
    {
        private static DonViDAO instance;

        public static DonViDAO Instance
        {
            get { if (instance == null) instance = new DonViDAO(); return instance; }
            private set => instance = value;
        }

        private DonViDAO() { }

        public List<DonVi> LayDanhSachDonVi()
        {
            List<DonVi> list = new List<DonVi>();

            string query = "SELECT * FROM DonVi";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                DonVi donvi = new DonVi(item);
                list.Add(donvi);
            }

            return list;
        }
        public bool InsertDonVi(string tenDV)
        {
            string query = string.Format("insert dbo.DonVi (TenDV) values (N'{0}')", tenDV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateDonVi(int idDV, string tenDV)
        {
            string query = string.Format("update dbo.DonVi set TenDV = N'{1}'where idDV = N'{0}'", idDV, tenDV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteDonVi(int idDV)
        {
            string query = string.Format("Delete DonVi where idDV = N'{0}'", idDV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
