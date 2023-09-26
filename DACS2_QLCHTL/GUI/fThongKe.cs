using DACS2_QLCHTL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS2_QLCHTL.GUI
{
    public partial class fThongKe : Form
    {
        DateTime adatetime = new DateTime();
        BindingSource tongsoloai = new BindingSource();
        BindingSource tongsoluongSP = new BindingSource();
        BindingSource tongsoluongSPhomnay = new BindingSource();
        BindingSource tongsohd = new BindingSource();
        BindingSource tongsohdhomnay = new BindingSource();
        BindingSource doanhsothang = new BindingSource();
        BindingSource doanhsohomnay = new BindingSource();

        public fThongKe()
        {
            InitializeComponent();
            load();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            chartTongTien.DataSource = HoaDonDAO.Instance.DanhSachTongTienTheoThang();
            chartTongTien.Series["TongTien"].XValueMember = "Thang";
            chartTongTien.Series["TongTien"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartTongTien.Series["TongTien"].YValueMembers = "DoanhThu";
            chartTongTien.Series["TongTien"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
        #region Method
        void load()
        {
            Tongsoloai();
            TongsoluongSP();
            Tongsohd();
            Doanhso();
        }

        void Tongsoloai()
        {
            tongsoloai.DataSource = LoaiDAO.Instance.DanhSachTongSoLoaiSanPham();
            lblSoLSP.DataBindings.Add(new Binding("Text", tongsoloai, "SoLoaiSP"));
        }

        void TongsoluongSP()
        {
            adatetime = DateTime.Now;
            int today = Convert.ToInt32(adatetime.Day);
            int month = Convert.ToInt32(adatetime.Month);
            int year = Convert.ToInt32(adatetime.Year);

            tongsoluongSP.DataSource = SanPhamDAO.Instance.DanhSachTongSanPham();
            lblSLSP.DataBindings.Add(new Binding("Text", tongsoluongSP, "SoLuong"));

            tongsoluongSPhomnay.DataSource = SanPhamDAO.Instance.DanhSachTongSanPhamgHomNay(today, month, year);
            lblNhapKhoHomNay.DataBindings.Add(new Binding("Text", tongsoluongSPhomnay, "SoLuong"));
        }

        void Tongsohd()
        {
            adatetime = DateTime.Now;
            int today = Convert.ToInt32(adatetime.Day);
            int month = Convert.ToInt32(adatetime.Month);
            int year = Convert.ToInt32(adatetime.Year);

            tongsohd.DataSource = HoaDonDAO.Instance.DanhSachHoanDonThang(month, year);
            lblHDThang.DataBindings.Add(new Binding("Text", tongsohd, "soHD"));

            tongsohdhomnay.DataSource = HoaDonDAO.Instance.DanhSachHoaDonHomNay(today, month, year);
            lblHDHomNay.DataBindings.Add(new Binding("Text", tongsohdhomnay, "soHDtoday"));
        }

        void Doanhso()
        {
            adatetime = DateTime.Now;
            int today = Convert.ToInt32(adatetime.Day);
            int month = Convert.ToInt32(adatetime.Month);
            int year = Convert.ToInt32(adatetime.Year);

            doanhsothang.DataSource = HoaDonDAO.Instance.DanhSachDoanhSoThang(month, year);
            lblDoanhSoThang.DataBindings.Add(new Binding("Text", doanhsothang, "DoanhSo"));

            doanhsohomnay.DataSource = HoaDonDAO.Instance.DanhSachDoanhSoHomNay(today, month, year);
            lblDoanhSoHomNay.DataBindings.Add(new Binding("Text", doanhsohomnay, "DoanhSo"));
        }
        #endregion
    }
}
