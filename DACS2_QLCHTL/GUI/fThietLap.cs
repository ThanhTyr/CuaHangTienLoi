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
    public partial class fThietLap : Form
    {
        BindingSource DanhSachTaiKhoan = new BindingSource();
        BindingSource DanhSachNhanVien = new BindingSource();
        BindingSource DanhSachKhachHang = new BindingSource();

        public DangNhap dangNhapTK;
        public fThietLap()
        {
            InitializeComponent();
            load();
        }

        #region methods
        void load()
        {
            dtgvTaiKhoan.DataSource = DanhSachTaiKhoan;
            dtgvKhachHang.DataSource = DanhSachKhachHang;
            dtgvNhanVien.DataSource = DanhSachNhanVien;

            LoadTaiKhoan();
            LoadDanhSachKhachHang();
            LoadDanhSachNhanVien();

            ThemTaiKhoanBinding();
            ThemKhachHangBinding();
            ThemNhanVienBinding();
        }

        void ThemTaiKhoanBinding()
        {
            txtTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TaiKhoan", true, DataSourceUpdateMode.Never));
            nmLoaiTaiKhoan.DataBindings.Add(new Binding("Value", dtgvTaiKhoan.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
        }

        void ThemKhachHangBinding()
        {
            txtIDKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "idKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtSDTKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "SDTKH", true, DataSourceUpdateMode.Never));
            txtDiaChiKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "DiaChiKH", true, DataSourceUpdateMode.Never));
            txtEmailKH.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "EmailKH", true, DataSourceUpdateMode.Never));
        }

        void ThemNhanVienBinding()
        {
            txtIDNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "idNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txtSDTNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "SDTNV", true, DataSourceUpdateMode.Never));
            txtDiaChiNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "DiaChiNV", true, DataSourceUpdateMode.Never));
            cbChucVuNhanVien.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
            dtpkNgaySinhNV.DataBindings.Add("Text", dtgvNhanVien.DataSource, "NgaySinhNV", true, DataSourceUpdateMode.Never);
        }

        void LoadTaiKhoan()
        {
            DanhSachTaiKhoan.DataSource = DangNhapDAO.Instance.LayDanhSachTaiKhoan();
        }

        void LoadDanhSachNhanVien()
        {
            DanhSachNhanVien.DataSource = NhanVienDAO.Instance.LayDanhSachNhanVien();
        }

        void LoadDanhSachKhachHang()
        {
            DanhSachKhachHang.DataSource = KhachHangDAO.Instance.LayDanhSachKhachHang();
        }

        void ResetMatKhau(string taiKhoan)
        {
            if (DangNhapDAO.Instance.ResetMatKhau(taiKhoan))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        void AddTaiKhoan(string taiKhoan, int idNV, int loai)
        {
            if (DangNhapDAO.Instance.InsertTaiKhoan(taiKhoan, idNV, loai))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            load();
        }

        void DeleteTaiKhoan(string taiKhoan)
        {
            if (DangNhapDAO.Instance.DeleteTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            load();
        }

        void EditTaiKhoan(string taiKhoan, int idNV, int loai)
        {
            if (DangNhapDAO.Instance.UpdateTaiKhoan(taiKhoan, idNV, loai))
            {
                MessageBox.Show("Cật nhập tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cật nhập tài khoản thất bại");
            }

            load();
        }
        #endregion

        #region event

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luudt;
            luudt = e.RowIndex;
            cbxTenNhanVien.Text = dtgvTaiKhoan.Rows[luudt].Cells[2].Value.ToString();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            int idNV = (cbxTenNhanVien.SelectedItem as NhanVien).IDNV;
            int loai = Convert.ToInt32(nmLoaiTaiKhoan.Text);

            AddTaiKhoan(taiKhoan, idNV, loai);
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;

            DeleteTaiKhoan(taiKhoan);
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            int idNV = (cbxTenNhanVien.SelectedItem as NhanVien).IDNV;
            int loai = Convert.ToInt32(nmLoaiTaiKhoan.Text);

            EditTaiKhoan(taiKhoan, idNV, loai);
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;

            ResetMatKhau(taiKhoan);
        }
        #endregion

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text;
            string sdtNV = txtSDTNV.Text;
            string diachiNV = txtDiaChiNV.Text;
            string chucvuNV = cbChucVuNhanVien.Text;
            string ngaysinhNV = dtpkNgaySinhNV.Value.ToString("MM/dd/yyyy");

            if (NhanVienDAO.Instance.InsertNhanVien(tenNV, sdtNV, diachiNV, chucvuNV, ngaysinhNV))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }

            load();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int idNV = Convert.ToInt32(txtIDNV.Text);
            int idHD = HoaDonDAO.Instance.KiemTraDanhSachHoaDonByIDNV(idNV);
            int idTK = DangNhapDAO.Instance.KiemTraDanhSachTaiKhoanByIDNV(idNV);


            if (idTK == -1)
            {
                if (idHD == -1)
                {
                    if (NhanVienDAO.Instance.DeleteNhanVien(idNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
                    }
                }
                else
                {
                    HoaDonDAO.Instance.DeleteHoaDonByIDNV(idNV);
                    if (NhanVienDAO.Instance.DeleteNhanVien(idNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
                    }
                }
            }
            else if (idHD == -1)
            {
                DangNhapDAO.Instance.DeleteTaiKhoanByIDNV(idNV);
                if (NhanVienDAO.Instance.DeleteNhanVien(idNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
            else
            {
                DangNhapDAO.Instance.DeleteTaiKhoanByIDNV(idNV);
                HoaDonDAO.Instance.DeleteHoaDonByIDNV(idNV);
                if (NhanVienDAO.Instance.DeleteNhanVien(idNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }

            load();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int idNV = Convert.ToInt32(txtIDNV.Text);
            string tenNV = txtTenNV.Text;
            string sdtNV = txtSDTNV.Text;
            string diachiNV = txtDiaChiNV.Text;
            string chucvuNV = cbChucVuNhanVien.Text;
            string ngaysinhNV = dtpkNgaySinhNV.Value.ToString("MM/dd/yyyy");

            if (NhanVienDAO.Instance.UpdateNhanVien(idNV, tenNV, sdtNV, diachiNV, chucvuNV, ngaysinhNV))
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }

            load();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string sdtKH = txtSDTKH.Text;
            string diachiKH = txtDiaChiKH.Text;
            string emailKH = txtEmailKH.Text;

            if (KhachHangDAO.Instance.InsertKhachHang(tenKH, sdtKH, diachiKH, emailKH))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
            load();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int idKH = Convert.ToInt32(txtIDKH.Text);
            int idHD = HoaDonDAO.Instance.KiemTraDanhSachHoaDonByIDKH(idKH);

            if (idHD == -1)
            {
                if (KhachHangDAO.Instance.DeleteKhachHang(idKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
                }
            }
            else
            {
                HoaDonDAO.Instance.DeleteHoaDonByIDKH(idKH);
                if (KhachHangDAO.Instance.DeleteKhachHang(idKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
                }
            }

            load();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int idKH = Convert.ToInt32(txtIDKH.Text);
            string tenKH = txtTenKH.Text;
            string sdtKH = txtSDTKH.Text;
            string diachiKH = txtDiaChiKH.Text;
            string emailKH = txtEmailKH.Text;

            if (KhachHangDAO.Instance.UpdateKhachHang(idKH, tenKH, sdtKH, diachiKH, emailKH))
            {
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }

            load();
        }
    }
}
