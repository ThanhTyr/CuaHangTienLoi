
namespace DACS2_QLCHTL
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.icbtnThietLap = new FontAwesome.Sharp.IconButton();
            this.icbtnDangXuat = new FontAwesome.Sharp.IconButton();
            this.icbtnSanPham = new FontAwesome.Sharp.IconButton();
            this.icbtnThongKe = new FontAwesome.Sharp.IconButton();
            this.icbtnGiamGia = new FontAwesome.Sharp.IconButton();
            this.icbtnTonKho = new FontAwesome.Sharp.IconButton();
            this.icbtnNhapKho = new FontAwesome.Sharp.IconButton();
            this.icbtnDonHang = new FontAwesome.Sharp.IconButton();
            this.icbtnBanHang = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShaDow = new System.Windows.Forms.Panel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.icbtnThietLap);
            this.panelMenu.Controls.Add(this.icbtnDangXuat);
            this.panelMenu.Controls.Add(this.icbtnSanPham);
            this.panelMenu.Controls.Add(this.icbtnThongKe);
            this.panelMenu.Controls.Add(this.icbtnGiamGia);
            this.panelMenu.Controls.Add(this.icbtnTonKho);
            this.panelMenu.Controls.Add(this.icbtnNhapKho);
            this.panelMenu.Controls.Add(this.icbtnDonHang);
            this.panelMenu.Controls.Add(this.icbtnBanHang);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 677);
            this.panelMenu.TabIndex = 0;
            // 
            // icbtnThietLap
            // 
            this.icbtnThietLap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.icbtnThietLap.FlatAppearance.BorderSize = 0;
            this.icbtnThietLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnThietLap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnThietLap.ForeColor = System.Drawing.Color.Black;
            this.icbtnThietLap.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.icbtnThietLap.IconColor = System.Drawing.Color.Black;
            this.icbtnThietLap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnThietLap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnThietLap.Location = new System.Drawing.Point(0, 557);
            this.icbtnThietLap.Name = "icbtnThietLap";
            this.icbtnThietLap.Size = new System.Drawing.Size(200, 60);
            this.icbtnThietLap.TabIndex = 9;
            this.icbtnThietLap.Text = "Thiết Lập";
            this.icbtnThietLap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnThietLap.UseVisualStyleBackColor = true;
            this.icbtnThietLap.Click += new System.EventHandler(this.icbtnThietLap_Click);
            // 
            // icbtnDangXuat
            // 
            this.icbtnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.icbtnDangXuat.FlatAppearance.BorderSize = 0;
            this.icbtnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnDangXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.icbtnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.icbtnDangXuat.IconColor = System.Drawing.Color.Black;
            this.icbtnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnDangXuat.Location = new System.Drawing.Point(0, 617);
            this.icbtnDangXuat.Name = "icbtnDangXuat";
            this.icbtnDangXuat.Size = new System.Drawing.Size(200, 60);
            this.icbtnDangXuat.TabIndex = 8;
            this.icbtnDangXuat.Text = "Đăng Xuất";
            this.icbtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnDangXuat.UseVisualStyleBackColor = true;
            this.icbtnDangXuat.Click += new System.EventHandler(this.icbtnDangXuat_Click);
            // 
            // icbtnSanPham
            // 
            this.icbtnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnSanPham.FlatAppearance.BorderSize = 0;
            this.icbtnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnSanPham.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnSanPham.ForeColor = System.Drawing.Color.Black;
            this.icbtnSanPham.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.icbtnSanPham.IconColor = System.Drawing.Color.Black;
            this.icbtnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnSanPham.Location = new System.Drawing.Point(0, 460);
            this.icbtnSanPham.Name = "icbtnSanPham";
            this.icbtnSanPham.Size = new System.Drawing.Size(200, 60);
            this.icbtnSanPham.TabIndex = 7;
            this.icbtnSanPham.Text = "Sản Phẩm";
            this.icbtnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnSanPham.UseVisualStyleBackColor = true;
            this.icbtnSanPham.Click += new System.EventHandler(this.icbtnSanPham_Click);
            // 
            // icbtnThongKe
            // 
            this.icbtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnThongKe.FlatAppearance.BorderSize = 0;
            this.icbtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnThongKe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnThongKe.ForeColor = System.Drawing.Color.Black;
            this.icbtnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.icbtnThongKe.IconColor = System.Drawing.Color.Black;
            this.icbtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnThongKe.Location = new System.Drawing.Point(0, 400);
            this.icbtnThongKe.Name = "icbtnThongKe";
            this.icbtnThongKe.Size = new System.Drawing.Size(200, 60);
            this.icbtnThongKe.TabIndex = 6;
            this.icbtnThongKe.Text = "Thống Kê";
            this.icbtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnThongKe.UseVisualStyleBackColor = true;
            this.icbtnThongKe.Click += new System.EventHandler(this.icbtnThongKe_Click);
            // 
            // icbtnGiamGia
            // 
            this.icbtnGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnGiamGia.FlatAppearance.BorderSize = 0;
            this.icbtnGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnGiamGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnGiamGia.ForeColor = System.Drawing.Color.Black;
            this.icbtnGiamGia.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.icbtnGiamGia.IconColor = System.Drawing.Color.Black;
            this.icbtnGiamGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnGiamGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnGiamGia.Location = new System.Drawing.Point(0, 340);
            this.icbtnGiamGia.Name = "icbtnGiamGia";
            this.icbtnGiamGia.Size = new System.Drawing.Size(200, 60);
            this.icbtnGiamGia.TabIndex = 5;
            this.icbtnGiamGia.Text = "Giảm Giá";
            this.icbtnGiamGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnGiamGia.UseVisualStyleBackColor = true;
            this.icbtnGiamGia.Click += new System.EventHandler(this.icbtnGiamGia_Click);
            // 
            // icbtnTonKho
            // 
            this.icbtnTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnTonKho.FlatAppearance.BorderSize = 0;
            this.icbtnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnTonKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnTonKho.ForeColor = System.Drawing.Color.Black;
            this.icbtnTonKho.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.icbtnTonKho.IconColor = System.Drawing.Color.Black;
            this.icbtnTonKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnTonKho.Location = new System.Drawing.Point(0, 280);
            this.icbtnTonKho.Name = "icbtnTonKho";
            this.icbtnTonKho.Size = new System.Drawing.Size(200, 60);
            this.icbtnTonKho.TabIndex = 4;
            this.icbtnTonKho.Text = "Sản phẩm sắp hết";
            this.icbtnTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnTonKho.UseVisualStyleBackColor = true;
            this.icbtnTonKho.Click += new System.EventHandler(this.icbtnTonKho_Click);
            // 
            // icbtnNhapKho
            // 
            this.icbtnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnNhapKho.FlatAppearance.BorderSize = 0;
            this.icbtnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnNhapKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnNhapKho.ForeColor = System.Drawing.Color.Black;
            this.icbtnNhapKho.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.icbtnNhapKho.IconColor = System.Drawing.Color.Black;
            this.icbtnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnNhapKho.Location = new System.Drawing.Point(0, 220);
            this.icbtnNhapKho.Name = "icbtnNhapKho";
            this.icbtnNhapKho.Size = new System.Drawing.Size(200, 60);
            this.icbtnNhapKho.TabIndex = 3;
            this.icbtnNhapKho.Text = "Kho";
            this.icbtnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnNhapKho.UseVisualStyleBackColor = true;
            this.icbtnNhapKho.Click += new System.EventHandler(this.icbtnNhapKho_Click);
            // 
            // icbtnDonHang
            // 
            this.icbtnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnDonHang.FlatAppearance.BorderSize = 0;
            this.icbtnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnDonHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnDonHang.ForeColor = System.Drawing.Color.Black;
            this.icbtnDonHang.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.icbtnDonHang.IconColor = System.Drawing.Color.Black;
            this.icbtnDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnDonHang.Location = new System.Drawing.Point(0, 160);
            this.icbtnDonHang.Name = "icbtnDonHang";
            this.icbtnDonHang.Size = new System.Drawing.Size(200, 60);
            this.icbtnDonHang.TabIndex = 2;
            this.icbtnDonHang.Text = "Hóa đơn";
            this.icbtnDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnDonHang.UseVisualStyleBackColor = true;
            this.icbtnDonHang.Click += new System.EventHandler(this.icbtnDonHang_Click);
            // 
            // icbtnBanHang
            // 
            this.icbtnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtnBanHang.FlatAppearance.BorderSize = 0;
            this.icbtnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnBanHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnBanHang.ForeColor = System.Drawing.Color.Black;
            this.icbtnBanHang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.icbtnBanHang.IconColor = System.Drawing.Color.Black;
            this.icbtnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnBanHang.Location = new System.Drawing.Point(0, 100);
            this.icbtnBanHang.Name = "icbtnBanHang";
            this.icbtnBanHang.Size = new System.Drawing.Size(200, 60);
            this.icbtnBanHang.TabIndex = 1;
            this.icbtnBanHang.Text = "Bán Hàng";
            this.icbtnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnBanHang.UseVisualStyleBackColor = true;
            this.icbtnBanHang.Click += new System.EventHandler(this.icbtnBanHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleBar.Controls.Add(this.lblMaNhanVien);
            this.panelTitleBar.Controls.Add(this.lblTenNhanVien);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(872, 30);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(0, 19);
            this.lblMaNhanVien.TabIndex = 5;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(872, 9);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(0, 19);
            this.lblTenNhanVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản:";
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(69, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(38, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.SteelBlue;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(56, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShaDow
            // 
            this.panelShaDow.BackColor = System.Drawing.Color.SteelBlue;
            this.panelShaDow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShaDow.Location = new System.Drawing.Point(200, 75);
            this.panelShaDow.Name = "panelShaDow";
            this.panelShaDow.Size = new System.Drawing.Size(962, 9);
            this.panelShaDow.TabIndex = 2;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDeskTop.Controls.Add(this.pictureBox1);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(200, 84);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(962, 593);
            this.panelDeskTop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 677);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelShaDow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Tiện Lợi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDeskTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton icbtnThietLap;
        private FontAwesome.Sharp.IconButton icbtnDangXuat;
        private FontAwesome.Sharp.IconButton icbtnSanPham;
        private FontAwesome.Sharp.IconButton icbtnThongKe;
        private FontAwesome.Sharp.IconButton icbtnGiamGia;
        private FontAwesome.Sharp.IconButton icbtnTonKho;
        private FontAwesome.Sharp.IconButton icbtnNhapKho;
        private FontAwesome.Sharp.IconButton icbtnDonHang;
        private FontAwesome.Sharp.IconButton icbtnBanHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShaDow;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

