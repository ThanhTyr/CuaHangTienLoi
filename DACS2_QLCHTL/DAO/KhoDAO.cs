using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;

        public static KhoDAO Instance
        {
            get { if (instance == null) instance = new KhoDAO(); return instance; }
            private set => instance = value;
        }

        private KhoDAO() { }

        public DataTable LayDanhSachKho()
        {
            return DataProvider.Instance.Executequery("exec USP_LayDanhSachKho");
        }
        
        public DataTable TimKiemDanhSachKho(string name)
        {
            string query = string.Format("select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], sp.DonGia as [Giá Bán], sp.SoLuong as [Số Lượng], lsp.TenLSP as [Loại], dv.TenDV as [Đơn Vị] from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.DonVi as dv where sp.idLSP = lsp.idLSP and sp.idDV = dv.idDV and sp.TenSP like N'%{0}%'", name);
            return DataProvider.Instance.Executequery(query);
        }

        public bool InsertKho(int idSP, float soluongSP, int nccSP)
        {
            string query = string.Format("insert dbo.Kho (idSP, idNCC, SoLuong)values ({0}, {1}, {2})", idSP, nccSP, soluongSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool UpdateKho(int idKho, float soluongSP, int nccSP)
        {
            string query = string.Format("update dbo.Kho set SoLuong = {1}, idNCC = {2} where idK = N'{0}'", idKho, soluongSP, nccSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool DeleteKho(int idKho)
        {
            string query = string.Format("Delete Kho where idK = N'{0}'", idKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int KiemTraDanhSachKhoByIDNCC(int idNCC)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM Kho WHERE idNCC = " + idNCC + "");

            if (data.Rows.Count > 0)
            {
                Kho kho = new Kho(data.Rows[0]);
                return kho.IDK;
            }

            return -1;
        }
        public void DeleteKhoByIDNCC(int idNCC)
        {
            DataTable data = DataProvider.Instance.Executequery("Delete Kho where idNCC = " + idNCC);
        }
        public void DeleteKhoByIDSP(int idSP)
        {
            DataTable data = DataProvider.Instance.Executequery("Delete Kho where idSP = " + idSP);
        }

        public DataTable DanhSachNhapKhoTheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return DataProvider.Instance.Executequery("exec USP_DanhSachNhapKhoTheoNgay @ngayBD , @ngayKT", new object[] { ngayBD, ngayKT });
        }
    }
}
