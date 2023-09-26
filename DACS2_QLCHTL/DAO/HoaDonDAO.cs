using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set => instance = value;
        }

        private HoaDonDAO() { }

        public DataTable DanhSachHoaDonTheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return DataProvider.Instance.Executequery("exec USP_DanhSachHoaDonTheoNgay @ngayBD , @ngayKT", new object[] { ngayBD, ngayKT });
        }

        public int LayDanhSachHoaDonChuaThanhToan(int idKH)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM HoaDon WHERE idKH = " + idKH + " AND TinhTrang = 0");

            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.IDHD;
            }

            return -1;
        }

        public void ThemHoaDon(int idKH, int idNV)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_ThemHoaDon @idNV , @idKH", new object[] { idKH, idNV });
        }

        public int LayMaxHoaDon()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idHD) FROM dbo.HoaDon");
        }

        public void ThanhToan(int idHD, float thanhtoan)
        {
            string query = "UPDATE dbo.HoaDon SET TinhTrang = 1, TongTien = '" + thanhtoan + "' WHERE idHD = " + idHD;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool DeleteHoaDonByIDNV(int idNV)
        {
            ChiTietHoaDonDAO.Instance.DeleteChiTietHoaDonByIDHD(HoaDonDAO.instance.LayIDHoaDonByIDNV(idNV));

            string query = string.Format("Delete HoaDon where idNV = N'{0}'", idNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public int LayIDHoaDonByIDNV(int idNV)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT idHD FROM dbo.HoaDon where idNV =" + idNV);
        }
        public int LayIDHoaDonByIDKH(int idKH)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT idHD FROM dbo.HoaDon where idKH =" + idKH);
        }

        public int KiemTraDanhSachHoaDonByIDNV(int idNV)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM HoaDon WHERE idNV = " + idNV + "");

            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.IDHD;
            }

            return -1;
        }
        public int KiemTraDanhSachHoaDonByIDKH(int idKH)
        {
            DataTable data = DataProvider.Instance.Executequery("SELECT * FROM HoaDon WHERE idKH = " + idKH + "");

            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.IDHD;
            }

            return -1;
        }
        public bool DeleteHoaDonByIDKH(int idKH)
        {
            ChiTietHoaDonDAO.Instance.DeleteChiTietHoaDonByIDHD(HoaDonDAO.instance.LayIDHoaDonByIDKH(idKH));

            string query = string.Format("Delete HoaDon where idKH = N'{0}'", idKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public DataTable DanhSachTongTienTheoThang()
        {
            return DataProvider.Instance.Executequery("Select month(hd.NgayBan) as 'Thang', Sum(hd.TongTien) as 'DoanhThu' From HoaDon as hd Group by month(hd.NgayBan)");
        }

        public DataTable DanhSachHoanDonThang(int month, int year)
        {
            return DataProvider.Instance.Executequery("select COUNT(hd.idHD) as soHD from HoaDon as hd where month(hd.NgayBan) = '" + month+"' and year(hd.NgayBan) = "+ year);
        }

        public DataTable DanhSachHoaDonHomNay(int today, int month, int year)
        {
            return DataProvider.Instance.Executequery("select COUNT(hd.idHD) as soHDtoday from HoaDon as hd where day(hd.NgayBan) = '"+ today+"' and month(hd.NgayBan) = '"+ month+"' and year(hd.NgayBan) = "+year);
        }

        public DataTable DanhSachDoanhSoThang(int month, int year)
        {
            return DataProvider.Instance.Executequery("select sum(hd.TongTien) as DoanhSo from HoaDon as hd where MONTH(hd.NgayBan) = '"+ month+"' and YEAR(hd.NgayBan) = " + year);
        }

        public DataTable DanhSachDoanhSoHomNay(int today, int month, int year)
        {
            return DataProvider.Instance.Executequery("select sum(hd.TongTien) as DoanhSo from HoaDon as hd where MONTH(hd.NgayBan) = '" + month+"' and YEAR(hd.NgayBan) = '"+year+"' and DAY(hd.NgayBan) = " + today);
        }
    }
}
