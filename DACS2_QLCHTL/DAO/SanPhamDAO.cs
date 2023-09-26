using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set => instance = value;
        }

        private SanPhamDAO() { }

        public DataTable LayDanhSachSanPhamChonGiamGia()
        {
            return DataProvider.Instance.Executequery("exec USP_LayDanhSachSanPhamChonGiamGia");
        }

        public List<SanPham> TimSanPhamBangMaVachTheoIDSP(string idSP)
        {
            List<SanPham> list = new List<SanPham>();

            string query = string.Format("SELECT * FROM SanPham where idSP like '%{0}%'", idSP);

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham(item);
                list.Add(sanpham);
            }

            return list;
        }

        public List<SanPham> LayDanhSachSanPhamTheoIDSP(int id)
        {
            List<SanPham> list = new List<SanPham>();

            string query = "SELECT * FROM SanPham WHERE idSP = " + id;

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham(item);
                list.Add(sanpham);
            }

            return list;
        }

        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> list = new List<SanPham>();

            string query = "SELECT * FROM SanPham";

            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham(item);
                list.Add(sanpham);
            }

            return list;
        }
        public bool InsertSanPham(string tenSP, float giabanSP, int loaiSP, int donviSP)
        {
            string query = string.Format("insert dbo.SanPham (TenSP, DonGia, idLSP, idDV)values (N'{0}', {1}, {2}, {3})", tenSP, giabanSP, loaiSP, donviSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool UpdateSanPham(int idSP, string tenSP, float giabanSP, int loaiSP, int donviSP, float soluong)
        {
            string query = string.Format("update dbo.SanPham set TenSP = N'{1}', DonGia = {2}, idLSP = {3}, idDV = {4}, SoLuong = {5} where idSP = N'{0}'", idSP, tenSP, giabanSP, loaiSP, donviSP, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int GetMaxIDSP()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(idSP) from dbo.SanPham");
            }
            catch
            {
                return 1;
            }
        }
        public int KiemTraDanhSachSanPhamByIDDV(int idDV)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM SanPham WHERE idDV = " + idDV + "");

            if (data.Rows.Count > 0)
            {
                SanPham sanpham = new SanPham(data.Rows[0]);
                return sanpham.IDSP;
            }

            return -1;
        }
        public bool DeleteSanPhamByIDDV(int idDV)
        {
            ChiTietHoaDonDAO.Instance.DeleteChiTietHoaDonByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDDonVi(idDV));
            KhoDAO.Instance.DeleteKhoByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDDonVi(idDV));
            GiamGiaDAO.Instance.DeleteGiamGiaByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDDonVi(idDV));

            string query = string.Format("Delete SanPham where idDV = N'{0}'", idDV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int KiemTraDanhSachSanPhamByIDLoai(int idLoai)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM SanPham WHERE idLSP = " + idLoai + "");

            if (data.Rows.Count > 0)
            {
                SanPham sanpham = new SanPham(data.Rows[0]);
                return sanpham.IDSP;
            }

            return -1;
        }
        public bool DeleteSanPhamByIDLoai(int idLoai)
        {
            ChiTietHoaDonDAO.Instance.DeleteChiTietHoaDonByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDLoai(idLoai));
            KhoDAO.Instance.DeleteKhoByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDLoai(idLoai));
            GiamGiaDAO.Instance.DeleteGiamGiaByIDSP(SanPhamDAO.Instance.LayIDSanPhamByIDLoai(idLoai));

            string query = string.Format("Delete SanPham where idLSP = N'{0}'", idLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int LayIDSanPhamByIDDonVi(int idDV)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT idSP FROM dbo.SanPham where idDV =" + idDV);
        }
        public int LayIDSanPhamByIDLoai(int idLoai)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT idSP FROM dbo.SanPham where idLSP =" + idLoai);
        }
        public bool DeleteSanPham(int idSP)
        {
            string query = string.Format("Delete SanPham where idSP = N'{0}'", idSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public DataTable DanhSachNhapKho()
        {
            return DataProvider.Instance.Executequery("select k.idK as [Kho], sp.TenSP as [Tên Sản Phẩm], ncc.TenNCC as [Nhà Cung Cấp], k.SoLuong as [Số lượng], k.NgayNhap as [Ngày Nhập] from Kho as k, SanPham as sp, NhaCungCap as ncc where k.idSP = sp.idSP and k.idNCC = ncc.idNCC");
        }
        public DataTable DanhSachTongSanPham()
        {
            return DataProvider.Instance.Executequery("select sum(sp.SoLuong) as SoLuong from SanPham as sp");
        }

        public DataTable DanhSachTongSanPhamgHomNay(int today, int month, int year)
        {
           return DataProvider.Instance.Executequery("select sum(k.SoLuong) as SoLuong from Kho as k where year(k.NgayNhap) = '"+ year+"' and month(k.NgayNhap) = '"+month +"' and day(k.NgayNhap) = "+today);
        }

        public DataTable LayDanhSachSanPhamSapHet()
        {
            return DataProvider.Instance.Executequery("select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], sp.DonGia as [Giá Bán], sp.SoLuong as [Số Lượng], lsp.TenLSP as [Loại], dv.TenDV as [Đơn Vị] from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.DonVi as dv where sp.idLSP = lsp.idLSP and sp.idDV = dv.idDV and sp.SoLuong <= 100");
        }

        public DataTable TimKiemDanhSachSanPhamSapHet(string name)
        {
            string query = string.Format("select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], sp.DonGia as [Giá Bán], sp.SoLuong as [Số Lượng], lsp.TenLSP as [Loại], dv.TenDV as [Đơn Vị] from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.DonVi as dv where sp.idLSP = lsp.idLSP and sp.idDV = dv.idDV and sp.TenSP = N'{0}' and sp.SoLuong <= 100", name);
            return DataProvider.Instance.Executequery(query);
        }

        public void CapNhapSoLuongSanPham(int idHD)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_CapNhatSoLuongKho @idHD", new object[] { idHD });
        }

        public bool NhapSanPham(int idSP, float soluong)
        {
            string query = string.Format("update dbo.SanPham set SoLuong = SoLuong + {1} where idSP = N'{0}'", idSP, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int ThongBaoSanPhamSapHet()
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM SanPham WHERE SoLuong <= 100");

            if (data.Rows.Count > 0)
            {
                SanPham sanpham = new SanPham(data.Rows[0]);
                return sanpham.IDSP;
            }

            return -1;
        }
    }
}
