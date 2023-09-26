using DACS2_QLCHTL.DAO;
using DACS2_QLCHTL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS2_QLCHTL.GUI
{
    public partial class fNhapKho : Form
    {
        BindingSource DanhSachKho = new BindingSource();
        BindingSource DanhSachSanPham = new BindingSource();

        public fNhapKho()
        {
            InitializeComponent();
            load();
        }

        #region methods
        void load()
        {
            dtgvKho.DataSource = DanhSachKho;

            LoadDanhSachKho();
            LoadComboBoxLoai();
            LoadComboBoxDonVi();

            TimTenSanPhamTrongKho();
        }

        void LoadDanhSachKho()
        {
            DanhSachKho.DataSource = KhoDAO.Instance.LayDanhSachKho();
        }

        void LoadComboBoxLoai()
        {
            List<Loai> danhsachloai = LoaiDAO.Instance.LayDanhSachLoai();
            cbLoaiSPKho.DataSource = danhsachloai;
            cbLoaiSPKho.DisplayMember = "TenLSP";
        }

        void LoadComboBoxDonVi()
        {
            List<DonVi> danhsachdonvi = DonViDAO.Instance.LayDanhSachDonVi();
            cbDonViSPKho.DataSource = danhsachdonvi;
            cbDonViSPKho.DisplayMember = "TenDV";
        }

        private void TimTenSanPhamTrongKho()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HDE0RU2\THANHTY;Initial Catalog=QuanLyCuaHangTienLoi;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select TenSP from SanPham";
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                auto.Add(dr.GetString(0));
            }

            txtTimKiemKho.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiemKho.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiemKho.AutoCompleteCustomSource = auto;
        }
        #endregion

        #region event
        #endregion

        private void dtgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luudt;
                luudt = e.RowIndex;
                txtIDSPK.Text = dtgvKho.Rows[luudt].Cells[0].Value.ToString();
                txtTenSPKho.Text = dtgvKho.Rows[luudt].Cells[1].Value.ToString();
                txtGiaKho.Text = dtgvKho.Rows[luudt].Cells[2].Value.ToString();
                txtSoLuongSPKho.Text = dtgvKho.Rows[luudt].Cells[3].Value.ToString();
                cbLoaiSPKho.Text = dtgvKho.Rows[luudt].Cells[4].Value.ToString();
                cbDonViSPKho.Text = dtgvKho.Rows[luudt].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtTimKiemKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DanhSachKho.DataSource = KhoDAO.Instance.TimKiemDanhSachKho(txtTimKiemKho.Text);
            }
        }

        private void txtIDSPK_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtIDSPK.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw br = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picBarcodeSanPham.Image = br.Draw(barcode, 80);
            }
            catch
            {

            }
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            int idSP = Convert.ToInt32(txtIDSPK.Text);
            if (SanPhamDAO.Instance.DeleteSanPham(idSP))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }

            load();
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            int idSP = Convert.ToInt32(txtIDSPK.Text);
            string tenSP = txtTenSPKho.Text;
            float giabanSP = Convert.ToInt32(txtGiaKho.Text);
            float soluongSP = Convert.ToInt32(txtSoLuongSPKho.Text);
            int loaiSP = (cbLoaiSPKho.SelectedItem as Loai).IDLSP;
            int donviSP = (cbDonViSPKho.SelectedItem as DonVi).IDDV;
            if (SanPhamDAO.Instance.UpdateSanPham(idSP, tenSP, giabanSP, loaiSP, donviSP, soluongSP))
            {
                MessageBox.Show("Sửa sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }

            load();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSPKho.Text;
            float giabanSP = Convert.ToInt32(txtGiaKho.Text);
            int loaiSP = (cbLoaiSPKho.SelectedItem as Loai).IDLSP;
            int donviSP = (cbDonViSPKho.SelectedItem as DonVi).IDDV;
            if (SanPhamDAO.Instance.InsertSanPham(tenSP, giabanSP, loaiSP, donviSP))
            {
                MessageBox.Show("Thêm sản phẩm vào kho thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm vào kho thất bại");
            }

            load();
        }

        private void txtTimKiemKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            fNhapSanPham f = new fNhapSanPham();
            f.ShowDialog();
        }
    }
}
