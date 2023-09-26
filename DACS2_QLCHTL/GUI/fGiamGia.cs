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
    public partial class fGiamGia : Form
    {
        BindingSource DanhSachSanPham = new BindingSource();
        BindingSource DanhSachGiamGia = new BindingSource();

        public fGiamGia()
        {
            InitializeComponent();
            load();
        }

        #region methods
        void load()
        {
            dtgvSanPhamChonGiamGia.DataSource = DanhSachSanPham;
            dtgvSanPhamSauGiamGia.DataSource = DanhSachGiamGia;

            LoadDanhSachSanPham();
            LoadDanhSachGiamGia();
        }

        void LoadDanhSachSanPham()
        {
            DanhSachSanPham.DataSource = SanPhamDAO.Instance.LayDanhSachSanPhamChonGiamGia();
        }

        void LoadDanhSachGiamGia()
        {
            DanhSachGiamGia.DataSource = GiamGiaDAO.Instance.LayDanhSachGiamGia();
        }
        #endregion

        #region event
        private void dtgvSanPhamChonGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDGiamGia.Text = "";
                txtPhanTramGiamGia.Text = "0";
                this.dtpkNgayKTGiamGia.Value = DateTime.Now;

                int luudt;
                luudt = e.RowIndex;
                txtIDSPGiamGia.Text = dtgvSanPhamChonGiamGia.Rows[luudt].Cells[0].Value.ToString();
                txtTenSPGiamGia.Text = dtgvSanPhamChonGiamGia.Rows[luudt].Cells[1].Value.ToString();
                txtLoaiGiamGia.Text = dtgvSanPhamChonGiamGia.Rows[luudt].Cells[2].Value.ToString();
                txtGiaGoc.Text = dtgvSanPhamChonGiamGia.Rows[luudt].Cells[3].Value.ToString();
                txtGiaSauGiamGia.Text = txtGiaGoc.Text;
            }
            catch
            {

            }
        }

        private void dtgvSanPhamSauGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luudt;
                luudt = e.RowIndex;
                txtIDGiamGia.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[0].Value.ToString();
                txtIDSPGiamGia.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[1].Value.ToString();
                txtTenSPGiamGia.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[2].Value.ToString();
                txtLoaiGiamGia.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[3].Value.ToString();
                txtGiaGoc.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[4].Value.ToString();
                txtPhanTramGiamGia.Text = dtgvSanPhamSauGiamGia.Rows[luudt].Cells[5].Value.ToString();
                dtpkNgayKTGiamGia.Value = Convert.ToDateTime(dtgvSanPhamSauGiamGia.Rows[luudt].Cells[6].Value.ToString());

                int PhamTramGiamGia = Convert.ToInt32(txtPhanTramGiamGia.Text);
                double GiaGoc = Convert.ToDouble(txtGiaGoc.Text);
                double GiaSauKhiGiam = GiaGoc - (GiaGoc / 100) * PhamTramGiamGia;
                txtGiaSauGiamGia.Text = GiaSauKhiGiam.ToString();
            }
            catch
            {

            }
        }

        private void btnThemGiamGia_Click(object sender, EventArgs e)
        {
            int idSP = Convert.ToInt32(txtIDSPGiamGia.Text);
            float phantramgiamgia = Convert.ToInt32(txtPhanTramGiamGia.Text);
            string ngayKT = dtpkNgayKTGiamGia.Value.ToString("MM/dd/yyyy");

            if (GiamGiaDAO.Instance.InsertGiamGia(idSP, phantramgiamgia, ngayKT))
            {
                MessageBox.Show("Thêm giảm giá thành công");
            }
            else
            {
                MessageBox.Show("Thêm giảm giá thất bại");
            }

            load();
        }

        private void btnXoaGiamGia_Click(object sender, EventArgs e)
        {
            int idGG = Convert.ToInt32(txtIDGiamGia.Text);

            if (GiamGiaDAO.Instance.DeleteGiamGia(idGG))
            {
                MessageBox.Show("Xóa giảm giá thành công");
            }
            else
            {
                MessageBox.Show("Xóa giảm giá thất bại");
            }
            load();
        }

        private void btnSuaGiamGia_Click(object sender, EventArgs e)
        {
            int idGG = Convert.ToInt32(txtIDGiamGia.Text);
            int idSP = Convert.ToInt32(txtIDSPGiamGia.Text);
            float phantramgiamgia = Convert.ToInt32(txtPhanTramGiamGia.Text);
            string ngayKT = dtpkNgayKTGiamGia.Value.ToString("MM/dd/yyyy");

            if (GiamGiaDAO.Instance.UpdateGiamGia(idGG, idSP, phantramgiamgia, ngayKT))
            {
                MessageBox.Show("Sửa giảm giá thành công");
            }
            else
            {
                MessageBox.Show("Sửa giảm giá thất bại");
            }
            load();
        }
        #endregion
    }
}
