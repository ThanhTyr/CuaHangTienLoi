using DACS2_QLCHTL.DAO;
using DACS2_QLCHTL.DTO;
using DACS2_QLCHTL.GUI;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS2_QLCHTL
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form CurrentChildForm;

        private DangNhap dangNhapTK;
        public DangNhap DangNhapTK
        {
            get => dangNhapTK;
            set { dangNhapTK = value; ChangeAccount(dangNhapTK.LoaiTK); }
        }

        public MainForm(DangNhap acc)
        {
            InitializeComponent();
            this.DangNhapTK = acc;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ThongBaoSanPhamSapHet();
        }

        void ThongBaoSanPhamSapHet()
        {
            int SPsaphet = SanPhamDAO.Instance.ThongBaoSanPhamSapHet();
            if (SPsaphet != -1)
            {
                MessageBox.Show("Có sản phẩm sắp hết hàng \n Đề nghị bạn nhập thêm sản phẩm!!!","Thông Báo");
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(160, 32, 240);
            public static Color color8 = Color.FromArgb(0, 255, 0);
            public static Color color9 = Color.FromArgb(255, 48, 48);
        }

        //Methods
        void ChangeAccount(int loaiTK)
        {
            icbtnThietLap.Enabled = loaiTK == 1;
            icbtnGiamGia.Enabled = loaiTK == 1;
            lblTenNhanVien.Text = "" + dangNhapTK.TaiKhoan + "";
            lblMaNhanVien.Text = "" + DangNhapTK.IDNV + "";
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(37, 36, 81);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currenBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Black;
            }
        }

        private void DisableButton()
        {
            if(currenBtn != null)
            {
                currenBtn.BackColor = Color.SteelBlue;
                currenBtn.ForeColor = Color.Black;
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = Color.Black;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if(CurrentChildForm != null)
            {
                //Open only Form
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(ChildForm);
            panelDeskTop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblTitleChildForm.Text = ChildForm.Text;
        }

        private void icbtnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fBanHang(dangNhapTK));
        }

        private void icbtnDonHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new fDonHang());
        }

        private void icbtnNhapKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new fNhapKho());
        }

        private void icbtnTonKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fTonKho());
        }

        private void icbtnGiamGia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new fGiamGia());
        }

        private void icbtnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new fThongKe());
        }

        private void icbtnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new fSanPham());
        }

        private void icbtnThietLap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new fThietLap());
        }

        private void icbtnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CurrentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
