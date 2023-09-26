using DACS2_QLCHTL.DAO;
using DACS2_QLCHTL.DTO;
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
    public partial class fBanHang : Form
    {
        BindingSource DanhSachSanPhamDeBan = new BindingSource();
        BindingSource SanPhamBangMaVach = new BindingSource();
        BindingSource GiamGiaBangMaVach = new BindingSource();
        BindingSource LoaiBangMaVach = new BindingSource();

        private DangNhap dangNhapTK;
        public DangNhap DangNhapTK
        {
            get => dangNhapTK;
            set { dangNhapTK = value; ChangeAccount(dangNhapTK.LoaiTK); }
        }

        public fBanHang(DangNhap acc)
        {
            InitializeComponent();
            this.DangNhapTK = acc;
            load();
        }

        #region Method
        void load()
        {
            dtgvGioHang.DataSource = DanhSachSanPhamDeBan;
            LoadDanhSachSanPhamDeBan();
            TimSDTKhachHang();
            TimTenSanPham();
        }

        void ChangeAccount(int loaiTK)
        {
            txtIDNV.Text = "" + DangNhapTK.IDNV + "";
        }

        void ShowGioHang(int idKH)
        {
            lsvGioHang.Items.Clear();
            List<GioHang> danhsachchitiethoadon = GioHangDAO.Instance.DanhSachGioHangTheoIDHoaDon(idKH);
            float tongtien = 0;

            foreach (GioHang item in danhsachchitiethoadon)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenSP.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.PhamTramGiamGia.ToString());
                lsvItem.SubItems.Add(item.TongTien.ToString());
                tongtien += item.TongTien;
                lsvGioHang.Items.Add(lsvItem);
            }
            txtTongTienHD.Text = tongtien.ToString();
            int PhamTramGiamGia = Convert.ToInt32(txtGiamGiaHD.Text);
            double GiaSauKhiGiam = tongtien - (tongtien / 100) * PhamTramGiamGia;
            txtThanhToanHD.Text = GiaSauKhiGiam.ToString();
        }

        private void TimSDTKhachHang()
        {
            List<KhachHang> danhsachkhachhang = KhachHangDAO.Instance.LayDanhSachKhachHang();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (KhachHang item in danhsachkhachhang)
            {
                auto.Add(item.SDTKH.ToString());
            }

            txtSDTKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSDTKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSDTKH.AutoCompleteCustomSource = auto;
        }

        private void TimTenSanPham()
        {
            List<SanPham> danhsachsanpham = SanPhamDAO.Instance.LayDanhSachSanPham();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (SanPham item in danhsachsanpham)
            {
                auto.Add(item.TenSP.ToString());
            }

            txtTimKiemSanPham.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiemSanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiemSanPham.AutoCompleteCustomSource = auto;
        }

        void LoadIDSPTheoMaVach()
        {
            try
            {
                txtTenSP.DataBindings.Clear();
                txtGiaSP.DataBindings.Clear();
                txtLoaiSP.DataBindings.Clear();
                txtGiamGiaSP.DataBindings.Clear();

                SanPhamBangMaVach.DataSource = SanPhamDAO.Instance.TimSanPhamBangMaVachTheoIDSP(txtIDSP.Text);
                GiamGiaBangMaVach.DataSource = GiamGiaDAO.Instance.TimSanPhamBangMaVachTheoIDSP(txtIDSP.Text);
                LoaiBangMaVach.DataSource = LoaiDAO.Instance.TimSanPhamTheoMaVachBangIDSP(txtIDSP.Text);

                txtTenSP.DataBindings.Add(new Binding("Text", SanPhamBangMaVach.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
                txtGiaSP.DataBindings.Add(new Binding("Text", SanPhamBangMaVach.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
                txtLoaiSP.DataBindings.Add(new Binding("Text", LoaiBangMaVach.DataSource, "TenLSP", true, DataSourceUpdateMode.Never));
                txtGiamGiaSP.DataBindings.Add(new Binding("Text", GiamGiaBangMaVach.DataSource, "PhanTramGiamGia", true, DataSourceUpdateMode.Never));

                int PhamTramGiamGia = Convert.ToInt32(txtGiamGiaSP.Text);
                double GiaGoc = Convert.ToDouble(txtGiaSP.Text);
                double GiaSauKhiGiam = GiaGoc - (GiaGoc / 100) * PhamTramGiamGia;
                txtThanhTienSP.Text = GiaSauKhiGiam.ToString();
            }
            catch { }
        }

        void LoadDanhSachSanPhamDeBan()
        {
            DanhSachSanPhamDeBan.DataSource = GiamGiaDAO.Instance.LayDanhSachSanPhamDeBan();
        }

        private void loadData(string data)
        {
            txtIDSP.Text = "";
            txtIDSP.Text = data;
        }

        public void clear() { }

        void cleartextSanPham()
        {
            txtLoaiSP.Text = "";
            txtGiaSP.Text = "";
            txtTenSP.Text = "";
            txtThanhTienSP.Text = "";
            txtGiamGiaSP.Text = "";
        }

        void cleartextKhachHang()
        {
            txtIDKH.Text = "0";
            txtTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtEmailKH.Text = "";
        }
        #endregion

        #region Event
        private void dtgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luudt;
                luudt = e.RowIndex;
                txtIDSP.Text = dtgvGioHang.Rows[luudt].Cells[0].Value.ToString();
                txtTenSP.Text = dtgvGioHang.Rows[luudt].Cells[1].Value.ToString();
                txtLoaiSP.Text = dtgvGioHang.Rows[luudt].Cells[2].Value.ToString();
                txtGiaSP.Text = dtgvGioHang.Rows[luudt].Cells[3].Value.ToString();
                txtGiamGiaSP.Text = dtgvGioHang.Rows[luudt].Cells[4].Value.ToString();

                int PhamTramGiamGia = Convert.ToInt32(txtGiamGiaSP.Text);
                double GiaGoc = Convert.ToDouble(txtGiaSP.Text);
                double GiaSauKhiGiam = GiaGoc - (GiaGoc / 100) * PhamTramGiamGia;
                txtThanhTienSP.Text = GiaSauKhiGiam.ToString();
            }
            catch
            {

            }
        }

        private void txtTimKiemSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DanhSachSanPhamDeBan.DataSource = GiamGiaDAO.Instance.TimKiemDanhSachSanPhamDeBan(txtTimKiemSanPham.Text);
            }
        }

        private void txtSDTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cleartextKhachHang();
                    List<KhachHang> thongtinKH = KhachHangDAO.Instance.TimKhachHangBangSDT(txtSDTKH.Text);
                    foreach (KhachHang item in thongtinKH)
                    {
                        txtTenKH.Text = item.TenKH;
                        txtDiaChiKH.Text = item.DiaChiKH;
                        txtEmailKH.Text = item.EmailKH;
                        txtIDKH.Text = item.IDKH.ToString();
                    }
                    ShowGioHang(Convert.ToInt32(txtIDKH.Text));
                }
                catch
                {
                    MessageBox.Show("Có Lỗi");
                }
            }
        }

        private void btnQuetMaBarcode_Click(object sender, EventArgs e)
        {
            fBarcode f = new fBarcode();
            f.truyendata = new fBarcode.TruyenChoCha(loadData);
            f.ShowDialog();
        }

        private void txtIDSP_TextChanged(object sender, EventArgs e)
        {
            cleartextSanPham();
            LoadIDSPTheoMaVach();
        }

        private void txtGiamGiaHD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int PhamTramGiamGia = Convert.ToInt32(txtGiamGiaHD.Text);
                    double GiaGoc = Convert.ToDouble(txtTongTienHD.Text);
                    double GiaSauKhiGiam = GiaGoc - (GiaGoc / 100) * PhamTramGiamGia;
                    txtThanhToanHD.Text = GiaSauKhiGiam.ToString();
                }
            }
            catch
            {

            }
        }

        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
            int idHoaDon = HoaDonDAO.Instance.LayDanhSachHoaDonChuaThanhToan(Convert.ToInt32(txtIDKH.Text));
            int idKH = KhachHangDAO.Instance.KiemTraDanhSachKhachHang(Convert.ToInt32(txtIDKH.Text));
            int idKhachHang = Convert.ToInt32(txtIDKH.Text);
            int idSanPham = Convert.ToInt32(txtIDSP.Text);
            int giamgia = Convert.ToInt32(txtGiamGiaSP.Text);
            int idNhanVien = Convert.ToInt32(txtIDNV.Text);
            int soluong = (int)nmSoLuongSP.Value;

            if (txtSDTKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!!!", "Thông Báo");
            }
            else if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!!!", "Thông Báo");
            }
            else if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!!!", "Thông Báo");
            }
            else
            {
                if (idKH == -1)
                {
                    KhachHangDAO.Instance.ThemKhachHang(txtTenKH.Text, txtSDTKH.Text, txtDiaChiKH.Text, txtEmailKH.Text);
                    int idkh = KhachHangDAO.Instance.LayMaxKhachHang();
                    txtIDKH.Text = idkh.ToString();
                    HoaDonDAO.Instance.ThemHoaDon(KhachHangDAO.Instance.LayMaxKhachHang(), idNhanVien);
                    ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(HoaDonDAO.Instance.LayMaxHoaDon(), idSanPham, soluong);
                    TimSDTKhachHang();
                    ShowGioHang(Convert.ToInt32(txtIDKH.Text));
                }
                else if (idHoaDon == -1)
                {
                    HoaDonDAO.Instance.ThemHoaDon(idKhachHang, idNhanVien);
                    ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(HoaDonDAO.Instance.LayMaxHoaDon(), idSanPham, soluong);
                    ShowGioHang(Convert.ToInt32(txtIDKH.Text));
                }
                else
                {
                    ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(HoaDonDAO.Instance.LayMaxHoaDon(), idSanPham, soluong);
                    ShowGioHang(Convert.ToInt32(txtIDKH.Text));
                }
            }
        }

        private void txtIDKH_TextChanged(object sender, EventArgs e)
        {
            ShowGioHang(Convert.ToInt32(txtIDKH.Text));
        }

        private void btnThanhToanHD_Click_1(object sender, EventArgs e)
        {
            int idHoaDon = HoaDonDAO.Instance.LayDanhSachHoaDonChuaThanhToan(Convert.ToInt32(txtIDKH.Text));

            if (idHoaDon != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn cho Khách Hàng: {0}\n Tổng tiền là: {1}", txtTenKH.Text, txtThanhToanHD.Text), "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    HoaDonDAO.Instance.ThanhToan(idHoaDon, Convert.ToInt32(txtThanhToanHD.Text));
                    SanPhamDAO.Instance.CapNhapSoLuongSanPham(HoaDonDAO.Instance.LayMaxHoaDon());
                    ReportBill f = new ReportBill();
                    f.ShowDialog();
                    ShowGioHang(Convert.ToInt32(txtIDKH.Text));
                }
            }
        }
        #endregion
    }
}
