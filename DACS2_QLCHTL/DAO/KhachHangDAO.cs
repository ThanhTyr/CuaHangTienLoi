using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set => instance = value;
        }

        private KhachHangDAO() { }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "SELECT * FROM KhachHang";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang khachhang = new KhachHang(item);
                list.Add(khachhang);
            }

            return list;
        }

        public List<KhachHang> TimKhachHangBangSDT(string sdt)
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = string.Format("SELECT * FROM KhachHang where SDTKH = {0}", sdt);

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang khachhang = new KhachHang(item);
                list.Add(khachhang);
            }

            return list;
        }

        public void ThemKhachHang(string tenKH, string sdtKH, string diachiKH, string emailKH)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_ThemKhachHang @tenKH , @sdtKH , @diachiKH , @emailKH", new object[] { tenKH, sdtKH, diachiKH, emailKH });
        }

        public int LayMaxKhachHang()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idKH) FROM dbo.KhachHang");
        }

        public int KiemTraDanhSachKhachHang(int idKH)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM KhachHang WHERE idKH = " + idKH + "");

            if (data.Rows.Count > 0)
            {
                KhachHang khachhang = new KhachHang(data.Rows[0]);
                return khachhang.IDKH;
            }

            return -1;
        }
        public bool InsertKhachHang(string tenKH, string sdtKH, string diachiKH, string emailKH)
        {
            string query = string.Format("insert dbo.KhachHang (TenKH, SDTKH, DiaChiKH, EmailKH)values (N'{0}', {1}, N'{2}', N'{3}')", tenKH, sdtKH, diachiKH, emailKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateKhachHang(int idKH, string tenKH, string sdtKH, string diachiKH, string emailKH)
        {
            string query = string.Format("update dbo.KhachHang set TenKH = N'{1}', SDTKH = {2}, DiaChiKH = N'{3}', EmailKH = N'{4}' where idKH = N'{0}'", idKH, tenKH, sdtKH, diachiKH, emailKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteKhachHang(int idKH)
        {
            string query = string.Format("Delete KhachHang where idKH = N'{0}'", idKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
