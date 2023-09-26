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

    public partial class fSanPham : Form
    {
        BindingSource DanhSachNhaCungCap = new BindingSource();
        BindingSource DanhSachLoai = new BindingSource();
        BindingSource DanhSachDonVi = new BindingSource();

        public fSanPham()
        {
            InitializeComponent(); ;
            load();
        }

        #region methods
        void load()
        {
            dtgvDonVi.DataSource = DanhSachDonVi;
            dtgvLoai.DataSource = DanhSachLoai;
            dtgvNhaCungCap.DataSource = DanhSachNhaCungCap;

            LoadDanhSachLoai();
            LoadDanhSachDonVi();
            LoadDanhSachNhaCungCap();

            ThemDonViBinding();
            ThemLoaiBinding();
            ThemNhaCungCapBinding();
        }

        void ThemDonViBinding()
        {
            txtIDDonVi.DataBindings.Add(new Binding("Text", dtgvDonVi.DataSource, "idDV", true, DataSourceUpdateMode.Never));
            txtTenDonVi.DataBindings.Add(new Binding("Text", dtgvDonVi.DataSource, "TenDV", true, DataSourceUpdateMode.Never));
        }

        void ThemLoaiBinding()
        {
            txtIDLoai.DataBindings.Add(new Binding("Text", dtgvLoai.DataSource, "idLSP", true, DataSourceUpdateMode.Never));
            txtTenLoai.DataBindings.Add(new Binding("Text", dtgvLoai.DataSource, "TenLSP", true, DataSourceUpdateMode.Never));
        }

        void ThemNhaCungCapBinding()
        {
            txtIDNCC.DataBindings.Add(new Binding("Text", dtgvNhaCungCap.DataSource, "idNCC", true, DataSourceUpdateMode.Never));
            txtTenNCC.DataBindings.Add(new Binding("Text", dtgvNhaCungCap.DataSource, "TenNCC", true, DataSourceUpdateMode.Never));
            txtDiaChiNCC.DataBindings.Add(new Binding("Text", dtgvNhaCungCap.DataSource, "DiaChiNCC", true, DataSourceUpdateMode.Never));
            txtSDTNCC.DataBindings.Add(new Binding("Text", dtgvNhaCungCap.DataSource, "SDTNCC", true, DataSourceUpdateMode.Never));
        }

        void LoadDanhSachDonVi()
        {
            DanhSachDonVi.DataSource = DonViDAO.Instance.LayDanhSachDonVi();
        }

        void LoadDanhSachLoai()
        {
            DanhSachLoai.DataSource = LoaiDAO.Instance.LayDanhSachLoai();
        }

        void LoadDanhSachNhaCungCap()
        {
            DanhSachNhaCungCap.DataSource = NhaCungCapDAO.Instance.LayDanhSachNhaCungCap();
        }
        #endregion

        #region Event
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text;
            string sdtNCC = txtSDTNCC.Text;
            string diachiNCC = txtDiaChiNCC.Text;

            if (NhaCungCapDAO.Instance.InsertNhaCungCap(tenNCC, sdtNCC, diachiNCC))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại");
            }

            load();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int idNCC = Convert.ToInt32(txtIDNCC.Text);
            int idkho = KhoDAO.Instance.KiemTraDanhSachKhoByIDNCC(idNCC);

            if (idkho == -1)
            {
                if (NhaCungCapDAO.Instance.DeleteNhaCungCap(idNCC))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }

            }
            else
            {
                KhoDAO.Instance.DeleteKhoByIDNCC(idNCC);
                if (NhaCungCapDAO.Instance.DeleteNhaCungCap(idNCC))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }

            }
            load();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            int idNCC = Convert.ToInt32(txtIDNCC.Text);
            string tenNCC = txtTenNCC.Text;
            string sdtNCC = txtSDTNCC.Text;
            string diachiNCC = txtDiaChiNCC.Text;

            if (NhaCungCapDAO.Instance.UpdateNhaCungCap(idNCC, tenNCC, sdtNCC, diachiNCC))
            {
                MessageBox.Show("Sửa nhà cung cấp thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhà cung cấp thất bại");
            }

            load();
        }

        private void btnThemDonVi_Click(object sender, EventArgs e)
        {
            string tenDV = txtTenDonVi.Text;

            if (DonViDAO.Instance.InsertDonVi(tenDV))
            {
                MessageBox.Show("Thêm đơn vị thành công");
            }
            else
            {
                MessageBox.Show("Thêm đơn vị thất bại");
            }

            load();
        }

        private void btnSuaDonVi_Click(object sender, EventArgs e)
        {
            int idDV = Convert.ToInt32(txtIDDonVi.Text);
            string tenDV = txtTenDonVi.Text;

            if (DonViDAO.Instance.UpdateDonVi(idDV, tenDV))
            {
                MessageBox.Show("Sửa đơn vị thành công");
            }
            else
            {
                MessageBox.Show("Sửa đơn vị thất bại");
            }

            load();
        }

        private void btnXoaDonVi_Click(object sender, EventArgs e)
        {
            int idDV = Convert.ToInt32(txtIDDonVi.Text);
            int idSP = SanPhamDAO.Instance.KiemTraDanhSachSanPhamByIDDV(idDV);

            if (idSP == -1)
            {
                if (DonViDAO.Instance.DeleteDonVi(idDV))
                {
                    MessageBox.Show("Xóa đơn vị thành công");
                }
                else
                {
                    MessageBox.Show("Xóa đơn vị thất bại");
                }

            }
            else
            {
                SanPhamDAO.Instance.DeleteSanPhamByIDDV(idDV);
                if (DonViDAO.Instance.DeleteDonVi(idDV))
                {
                    MessageBox.Show("Xóa đơn vị thành công");
                }
                else
                {
                    MessageBox.Show("Xóa đơn vị thất bại");
                }

            }
            load();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text;

            if (LoaiDAO.Instance.InsertLoai(tenLoai))
            {
                MessageBox.Show("Thêm loại thành công");
            }
            else
            {
                MessageBox.Show("Thêm loại thất bại");
            }

            load();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            int idLoai = Convert.ToInt32(txtIDLoai.Text);
            string tenLoai = txtTenLoai.Text;

            if (LoaiDAO.Instance.UpdateLoai(idLoai, tenLoai))
            {
                MessageBox.Show("Sửa loại thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại thất bại");
            }

            load();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            int idLoai = Convert.ToInt32(txtIDLoai.Text);
            int idSP = SanPhamDAO.Instance.KiemTraDanhSachSanPhamByIDLoai(idLoai);

            if (idSP == -1)
            {
                if (LoaiDAO.Instance.DeleteLoai(idLoai))
                {
                    MessageBox.Show("Xóa loại thành công");
                }
                else
                {
                    MessageBox.Show("Xóa loại thất bại");
                }

            }
            else
            {
                SanPhamDAO.Instance.DeleteSanPhamByIDLoai(idLoai);
                if (LoaiDAO.Instance.DeleteLoai(idLoai))
                {
                    MessageBox.Show("Xóa loại thành công");
                }
                else
                {
                    MessageBox.Show("Xóa loại thất bại");
                }

            }
            load();
        }
        #endregion
    }
}
