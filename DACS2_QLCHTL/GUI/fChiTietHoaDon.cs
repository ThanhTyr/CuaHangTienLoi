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
    public partial class fChiTietHoaDon : Form
    {
        public fChiTietHoaDon()
        {
            InitializeComponent();
            
        }
        void LoadDanhSachChiTietHoaDonDuocChon(int idHD)
        {
            dtgvCTHD.DataSource = GioHangDAO.Instance.DanhSachChiTietHoaDonDuocCHon(idHD);
        }

        private void txtIDhoadon_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachChiTietHoaDonDuocChon(Convert.ToInt32(txtIDhoadon.Text));
        }
    }
}
