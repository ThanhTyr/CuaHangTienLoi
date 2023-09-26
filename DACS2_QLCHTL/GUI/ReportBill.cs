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
    public partial class ReportBill : Form
    {
        public ReportBill()
        {
            InitializeComponent();
        }

        private void ReportBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangTienLoiDataSet1.USP_HoaDonCuaKhachHang' table. You can move, or remove it, as needed.
            this.uSP_HoaDonCuaKhachHangTableAdapter.Fill(this.quanLyCuaHangTienLoiDataSet1.USP_HoaDonCuaKhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
