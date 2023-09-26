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
    public partial class fNhapSanPham : Form
    {
        BindingSource DanhSachSanPham = new BindingSource();

        public fNhapSanPham()
        {
            InitializeComponent();
            load();
        }

        #region methods
        void load()
        {
            dtgvSanPham.DataSource = DanhSachSanPham;

            LoadDanhSachSanPham();
            LoadComboBoxNhaCungCap();
            LoadComboBoxTenSP();
        }

        void LoadDanhSachSanPham()
        {
            DanhSachSanPham.DataSource = SanPhamDAO.Instance.DanhSachNhapKho();
        }

        void LoadComboBoxNhaCungCap()
        {
            List<NhaCungCap> danhsachnhacungcap = NhaCungCapDAO.Instance.LayDanhSachNhaCungCap();
            cbNCC.DataSource = danhsachnhacungcap;
            cbNCC.DisplayMember = "TenNCC";
        }
        void LoadComboBoxTenSP()
        {
            List<SanPham> danhsachsanpham = SanPhamDAO.Instance.LayDanhSachSanPham();
            cbTenSP.DataSource = danhsachsanpham;
            cbTenSP.DisplayMember = "TenSP";
        }
        #endregion

        private void btnNhapSP_Click(object sender, EventArgs e)
        {
            int idSP = (cbTenSP.SelectedItem as SanPham).IDSP;
            float soluongSP = Convert.ToInt32(txtSoLuongSP.Text);
            int nccSP = (cbNCC.SelectedItem as NhaCungCap).IDNCC;

            if (KhoDAO.Instance.InsertKho(idSP, soluongSP, nccSP))
            {
                SanPhamDAO.Instance.NhapSanPham(idSP, soluongSP);
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }

            load();
        }

        private void dtpkNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = KhoDAO.Instance.DanhSachNhapKhoTheoNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
        }

        private void dtpkNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = KhoDAO.Instance.DanhSachNhapKhoTheoNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
        }
    }
}
