using DACS2_QLCHTL.DAO;
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
    public partial class fTonKho : Form
    {
        BindingSource DanhSachTonKho = new BindingSource();

        public fTonKho()
        {
            InitializeComponent();
            dtgvTonKho.DataSource = DanhSachTonKho;
            LoadDanhSachTonKho();
            TimTenSanPhamTrongTonKho();
        }

        void LoadDanhSachTonKho()
        {
            DanhSachTonKho.DataSource = SanPhamDAO.Instance.LayDanhSachSanPhamSapHet();
        }

        private void TimTenSanPhamTrongTonKho()
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

            txtTimKiemTonKho.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiemTonKho.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiemTonKho.AutoCompleteCustomSource = auto;
        }

        private void dtgvTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luudt;
            luudt = e.RowIndex;
            txtIDSPTonKho.Text = dtgvTonKho.Rows[luudt].Cells[0].Value.ToString();
            txtTenSPTonKho.Text = dtgvTonKho.Rows[luudt].Cells[1].Value.ToString();
            txtGiaTonKho.Text = dtgvTonKho.Rows[luudt].Cells[2].Value.ToString();
            txtSoLuongTonKho.Text = dtgvTonKho.Rows[luudt].Cells[3].Value.ToString();
            txtLoaiSPTonKho.Text = dtgvTonKho.Rows[luudt].Cells[4].Value.ToString();
            txtDonViSPTonKho.Text = dtgvTonKho.Rows[luudt].Cells[5].Value.ToString();
        }

        private void txtTimKiemTonKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DanhSachTonKho.DataSource = SanPhamDAO.Instance.TimKiemDanhSachSanPhamSapHet(txtTimKiemTonKho.Text);
            }
        }
    }
}
