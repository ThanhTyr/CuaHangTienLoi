using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class GioHangDAO
    {
        private static GioHangDAO instance;

        public static GioHangDAO Instance
        {
            get { if (instance == null) instance = new GioHangDAO(); return instance; }
            private set => instance = value;
        }

        private GioHangDAO() { }

        public List<GioHang> DanhSachGioHangTheoIDHoaDon(int idKH)
        {
            List<GioHang> danhsachgiohang = new List<GioHang>();

            string query = string.Format("SELECT sp.TenSP, sp.DonGia, cthd.SoLuong, gg.PhanTramGiamGia, ((sp.DonGia*cthd.SoLuong) - ((sp.DonGia*cthd.SoLuong) / 100) * gg.PhanTramGiamGia) as TongTien FROM dbo.ChiTietHoaDon AS cthd, dbo.HoaDon AS hd, dbo.SanPham AS sp, dbo.GiamGia as gg WHERE cthd.idHD = hd.idHD AND cthd.idSP = sp.idSP and gg.idSP = sp.idSP AND hd.idKH = '{0}' and TinhTrang = 0", idKH);
            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow item in data.Rows)
            {
                GioHang giohang = new GioHang(item);
                danhsachgiohang.Add(giohang);
            }

            return danhsachgiohang;
        }

        public DataTable DanhSachChiTietHoaDonDuocCHon(int idHD)
        {
            string query = string.Format("SELECT sp.TenSP as [Tên sản phẩm], sp.DonGia as [Giá sản phẩm], cthd.SoLuong as [Số lượng sản phẩm], gg.PhanTramGiamGia as [Phần trăm giảm giá], ((sp.DonGia*cthd.SoLuong) - ((sp.DonGia*cthd.SoLuong) / 100) * gg.PhanTramGiamGia) as [Tổng Tiền] FROM dbo.ChiTietHoaDon AS cthd, dbo.HoaDon AS hd, dbo.SanPham AS sp, dbo.GiamGia as gg WHERE cthd.idHD = hd.idHD AND cthd.idSP = sp.idSP and gg.idSP = sp.idSP AND hd.idHD = {0}", idHD);
            return DataProvider.Instance.Executequery(query);
        }
    }
}
