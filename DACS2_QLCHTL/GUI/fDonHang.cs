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
    public partial class fDonHang : Form
    {
        public fDonHang()
        {
            InitializeComponent();
        }

        void LoadDanhSachHoaDonTheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            dtgvThongKe.DataSource = HoaDonDAO.Instance.DanhSachHoaDonTheoNgay(ngayBD, ngayKT);
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDonTheoNgay(dtpkNgayBDThongKe.Value, dtpkNgayKTThongKe.Value);
        }

        private void dtgvThongKe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fChiTietHoaDon f = new fChiTietHoaDon();
            f.txtIDhoadon.Text = this.dtgvThongKe.CurrentRow.Cells[0].Value.ToString();
            f.txttennhanvien.Text = this.dtgvThongKe.CurrentRow.Cells[1].Value.ToString();
            f.txttenkhachhang.Text = this.dtgvThongKe.CurrentRow.Cells[2].Value.ToString();
            f.txttongtien.Text = this.dtgvThongKe.CurrentRow.Cells[3].Value.ToString();
            f.txtngayban.Text = this.dtgvThongKe.CurrentRow.Cells[4].Value.ToString();
            f.ShowDialog();
        }
    }
}
