using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS2_QLCHTL.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
            private set => instance = value;
        }

        private ChiTietHoaDonDAO() { }

        public void ThemChiTietHoaDon(int idHD, int idSP, int soluong)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_ThemChiTietHoaDon @idHD , @idSP , @soluong", new object[] { idHD, idSP, soluong });
        }
        public void DeleteChiTietHoaDonByIDHD(int idHD)
        {
            DataTable data = DataProvider.Instance.Executequery("Delete ChiTietHoaDon where idHD = " + idHD);
        }

        public void DeleteChiTietHoaDonByIDSP(int idSP)
        {
            DataTable data = DataProvider.Instance.Executequery("Delete ChiTietHoaDon where idSP = " + idSP);
        }
    }
}
