using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class GiamGiaDAO
    {
        private static GiamGiaDAO instance;

        public static GiamGiaDAO Instance
        {
            get { if (instance == null) instance = new GiamGiaDAO(); return instance; }
            private set => instance = value;
        }

        private GiamGiaDAO() { }

        public DataTable LayDanhSachGiamGia()
        {
            return DataProvider.Instance.Executequery("exec USP_LayDanhSachGiamGia");
        }

        public DataTable LayDanhSachSanPhamDeBan()
        {
            return DataProvider.Instance.Executequery("select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], lsp.TenLSP as [Loại Sản Phẩm], sp.DonGia as [Giá], gg.PhanTramGiamGia as [Phần Trăm Giảm Giá] from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.GiamGia as gg where sp.idLSP = lsp.idLSP and gg.idSP = sp.idSP");
        }

        public DataTable TimKiemDanhSachSanPhamDeBan(string name)
        {
            string query = string.Format("select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], lsp.TenLSP as [Loại Sản Phẩm], sp.DonGia as [Giá], gg.PhanTramGiamGia as [Phần Trăm Giảm Giá] from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.GiamGia as gg where sp.idLSP = lsp.idLSP and gg.idSP = sp.idSP and sp.TenSP like N'%{0}%'", name);
            return DataProvider.Instance.Executequery(query);
        }
        public List<GiamGia> TimSanPhamBangMaVachTheoIDSP(string idSP)
        {
            List<GiamGia> list = new List<GiamGia>();

            string query = string.Format("SELECT * FROM GiamGia where idSP like '%{0}%'", idSP);

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                GiamGia giamgia = new GiamGia(item);
                list.Add(giamgia);
            }

            return list;
        }
        public bool InsertGiamGia(int idSP, float phantramsanpham, string ngayKT)
        {
            string query = string.Format("insert dbo.GiamGia (idSP, PhanTramGiamGia, NgayKT) values ({0}, {1}, '{2}')", idSP, phantramsanpham, ngayKT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool UpdateGiamGia(int idGG, int idSP, float phantramsanpham, string ngayKT)
        {
            string query = string.Format("update dbo.GiamGia set idSP = {1}, PhanTramGiamGia = {2}, NgayKT = '{3}' where idGG = N'{0}'", idGG, idSP, phantramsanpham, ngayKT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool DeleteGiamGia(int idGG)
        {
            string query = string.Format("Delete GiamGia where idGG = {0}", idGG);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public void DeleteGiamGiaByIDSP(int idSP)
        {
            DataTable data = DataProvider.Instance.Executequery("Delete GiamGia where idSP = " + idSP);
        }
    }
}
