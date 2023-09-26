using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    class DangNhapDAO
    {
        private static DangNhapDAO instance;

        internal static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return instance; }
            private set => instance = value;
        }

        private DangNhapDAO() { }

        public bool Login(string taiKhoan, string matKhau)
        {
            string query = "USP_DangNhap @taiKhoan , @matKhau";
            DataTable result = DataProvider.Instance.Executequery(query, new object[] { taiKhoan, matKhau });
            return result.Rows.Count > 0;
        }

        public DangNhap DangNhapBangTaiKhoan(string taiKhoan)
        {
            DataTable data = DataProvider.Instance.Executequery("select * from dangNhap where taiKhoan = N'" + taiKhoan + "'");

            foreach (DataRow item in data.Rows)
            {
                return new DangNhap(item);
            }

            return null;
        }

        public bool CapNhatTaiKhoan(string taiKhoan, string matKhau, string matKhauMoi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_CapNhatTaiKhoan @taiKhoan , @matKhau , @matKhauMoi ", new object[] { taiKhoan, matKhau, matKhauMoi });

            return result > 0;

        }

        public DataTable LayDanhSachTaiKhoan()
        {
            return DataProvider.Instance.Executequery("select dn.TaiKhoan, dn.LoaiTK, nv.TenNV from dbo.DangNhap as dn, NhanVien as nv where dn.idNV = nv.idNV");
        }
        public bool ResetMatKhau(string taikhoan)
        {
            string query = string.Format("update DangNhap set MatKhau = N'0' where TaiKhoan = N'{0}'", taikhoan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertTaiKhoan(string taikhoan, int idNV, int loai)
        {
            string query = string.Format("insert dbo.DangNhap (TaiKhoan, idNV, LoaiTK )values (N'{0}', N'{1}', {2})", taikhoan, idNV, loai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateTaiKhoan(string taiKhoan, int idnv, int loai)
        {
            string query = string.Format("update dbo.DangNhap set idNV = N'{1}', LoaiTK = {2} where TaiKhoan = N'{0}'", taiKhoan, idnv, loai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteTaiKhoan(string taikhoan)
        {
            string query = string.Format("Delete DangNhap where TaiKhoan = N'{0}'", taikhoan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool DeleteTaiKhoanByIDNV(int idNV)
        {
            string query = string.Format("Delete DangNhap where idNV = N'{0}'", idNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int KiemTraDanhSachTaiKhoanByIDNV(int idNV)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM DangNhap WHERE idNV = " + idNV + "");

            if (data.Rows.Count > 0)
            {
                DangNhap dangnhap = new DangNhap(data.Rows[0]);
                return dangnhap.IDNV;
            }

            return -1;
        }
    }
}
