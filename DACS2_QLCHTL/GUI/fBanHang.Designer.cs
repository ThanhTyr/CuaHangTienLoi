
namespace DACS2_QLCHTL.GUI
{
    partial class fBanHang
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimKiemSanPham = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvGioHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThanhToanHD = new System.Windows.Forms.Button();
            this.txtThanhToanHD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiamGiaHD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTienHD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuetMaBarcode = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtThanhTienSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiamGiaSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nmSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvGioHang = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongSP)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIDNV);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.txtTimKiemSanPham);
            this.panel6.Location = new System.Drawing.Point(444, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 30);
            this.panel6.TabIndex = 13;
            // 
            // txtIDNV
            // 
            this.txtIDNV.Location = new System.Drawing.Point(444, 4);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.ReadOnly = true;
            this.txtIDNV.Size = new System.Drawing.Size(40, 20);
            this.txtIDNV.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(332, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "ID Nhân Viên:";
            // 
            // txtTimKiemSanPham
            // 
            this.txtTimKiemSanPham.Location = new System.Drawing.Point(4, 4);
            this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            this.txtTimKiemSanPham.Size = new System.Drawing.Size(322, 20);
            this.txtTimKiemSanPham.TabIndex = 0;
            this.txtTimKiemSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemSanPham_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvGioHang);
            this.panel5.Location = new System.Drawing.Point(12, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 379);
            this.panel5.TabIndex = 12;
            // 
            // dtgvGioHang
            // 
            this.dtgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGioHang.Location = new System.Drawing.Point(4, 4);
            this.dtgvGioHang.Name = "dtgvGioHang";
            this.dtgvGioHang.Size = new System.Drawing.Size(419, 372);
            this.dtgvGioHang.TabIndex = 0;
            this.dtgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGioHang_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btnThanhToanHD);
            this.panel4.Controls.Add(this.txtThanhToanHD);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtGiamGiaHD);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtTongTienHD);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(729, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 130);
            this.panel4.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(142, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 14);
            this.label16.TabIndex = 22;
            this.label16.Text = "%";
            // 
            // btnThanhToanHD
            // 
            this.btnThanhToanHD.BackColor = System.Drawing.Color.White;
            this.btnThanhToanHD.Location = new System.Drawing.Point(94, 81);
            this.btnThanhToanHD.Name = "btnThanhToanHD";
            this.btnThanhToanHD.Size = new System.Drawing.Size(105, 43);
            this.btnThanhToanHD.TabIndex = 21;
            this.btnThanhToanHD.Text = "Thanh Toán";
            this.btnThanhToanHD.UseVisualStyleBackColor = false;
            this.btnThanhToanHD.Click += new System.EventHandler(this.btnThanhToanHD_Click_1);
            // 
            // txtThanhToanHD
            // 
            this.txtThanhToanHD.Location = new System.Drawing.Point(94, 55);
            this.txtThanhToanHD.Name = "txtThanhToanHD";
            this.txtThanhToanHD.ReadOnly = true;
            this.txtThanhToanHD.Size = new System.Drawing.Size(105, 20);
            this.txtThanhToanHD.TabIndex = 7;
            this.txtThanhToanHD.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Thanh Toán";
            // 
            // txtGiamGiaHD
            // 
            this.txtGiamGiaHD.Location = new System.Drawing.Point(94, 33);
            this.txtGiamGiaHD.Name = "txtGiamGiaHD";
            this.txtGiamGiaHD.Size = new System.Drawing.Size(42, 20);
            this.txtGiamGiaHD.TabIndex = 5;
            this.txtGiamGiaHD.Text = "0";
            this.txtGiamGiaHD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiamGiaHD_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Giảm Giá";
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.Location = new System.Drawing.Point(94, 10);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.ReadOnly = true;
            this.txtTongTienHD.Size = new System.Drawing.Size(105, 20);
            this.txtTongTienHD.TabIndex = 3;
            this.txtTongTienHD.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tổng Tiền";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIDKH);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtEmailKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(444, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 130);
            this.panel1.TabIndex = 8;
            // 
            // txtIDKH
            // 
            this.txtIDKH.Location = new System.Drawing.Point(122, 104);
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.ReadOnly = true;
            this.txtIDKH.Size = new System.Drawing.Size(91, 20);
            this.txtIDKH.TabIndex = 17;
            this.txtIDKH.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Mã Khác Hàng";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Location = new System.Drawing.Point(122, 78);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(145, 20);
            this.txtEmailKH.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(122, 3);
            this.txtSDTKH.MaxLength = 10;
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(145, 20);
            this.txtSDTKH.TabIndex = 7;
            this.txtSDTKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDTKH_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(122, 52);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(145, 20);
            this.txtDiaChiKH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(122, 29);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(145, 20);
            this.txtTenKH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuetMaBarcode);
            this.panel2.Controls.Add(this.btnThemSP);
            this.panel2.Controls.Add(this.txtThanhTienSP);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtGiamGiaSP);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nmSoLuongSP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtGiaSP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIDSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtLoaiSP);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 137);
            this.panel2.TabIndex = 10;
            // 
            // btnQuetMaBarcode
            // 
            this.btnQuetMaBarcode.BackColor = System.Drawing.Color.White;
            this.btnQuetMaBarcode.Location = new System.Drawing.Point(332, 4);
            this.btnQuetMaBarcode.Name = "btnQuetMaBarcode";
            this.btnQuetMaBarcode.Size = new System.Drawing.Size(91, 29);
            this.btnQuetMaBarcode.TabIndex = 24;
            this.btnQuetMaBarcode.Text = "Quét Mã";
            this.btnQuetMaBarcode.UseVisualStyleBackColor = false;
            this.btnQuetMaBarcode.Click += new System.EventHandler(this.btnQuetMaBarcode_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(309, 86);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(114, 43);
            this.btnThemSP.TabIndex = 20;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click_1);
            // 
            // txtThanhTienSP
            // 
            this.txtThanhTienSP.Location = new System.Drawing.Point(122, 112);
            this.txtThanhTienSP.Name = "txtThanhTienSP";
            this.txtThanhTienSP.ReadOnly = true;
            this.txtThanhTienSP.Size = new System.Drawing.Size(169, 20);
            this.txtThanhTienSP.TabIndex = 23;
            this.txtThanhTienSP.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Thành Tiền";
            // 
            // txtGiamGiaSP
            // 
            this.txtGiamGiaSP.Location = new System.Drawing.Point(122, 86);
            this.txtGiamGiaSP.Name = "txtGiamGiaSP";
            this.txtGiamGiaSP.ReadOnly = true;
            this.txtGiamGiaSP.Size = new System.Drawing.Size(169, 20);
            this.txtGiamGiaSP.TabIndex = 21;
            this.txtGiamGiaSP.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Giảm Giá";
            // 
            // nmSoLuongSP
            // 
            this.nmSoLuongSP.Location = new System.Drawing.Point(332, 61);
            this.nmSoLuongSP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSoLuongSP.Name = "nmSoLuongSP";
            this.nmSoLuongSP.Size = new System.Drawing.Size(91, 20);
            this.nmSoLuongSP.TabIndex = 3;
            this.nmSoLuongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSoLuongSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số Lượng";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(122, 60);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.ReadOnly = true;
            this.txtGiaSP.Size = new System.Drawing.Size(91, 20);
            this.txtGiaSP.TabIndex = 17;
            this.txtGiaSP.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá";
            // 
            // txtIDSP
            // 
            this.txtIDSP.Location = new System.Drawing.Point(332, 35);
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.ReadOnly = true;
            this.txtIDSP.Size = new System.Drawing.Size(91, 20);
            this.txtIDSP.TabIndex = 15;
            this.txtIDSP.Text = "0";
            this.txtIDSP.TextChanged += new System.EventHandler(this.txtIDSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(122, 34);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.ReadOnly = true;
            this.txtLoaiSP.Size = new System.Drawing.Size(91, 20);
            this.txtLoaiSP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Loại";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(122, 12);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(169, 20);
            this.txtTenSP.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên Sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvGioHang);
            this.panel3.Location = new System.Drawing.Point(444, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 357);
            this.panel3.TabIndex = 9;
            // 
            // lsvGioHang
            // 
            this.lsvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvGioHang.GridLines = true;
            this.lsvGioHang.HideSelection = false;
            this.lsvGioHang.Location = new System.Drawing.Point(4, 4);
            this.lsvGioHang.Name = "lsvGioHang";
            this.lsvGioHang.Size = new System.Drawing.Size(480, 350);
            this.lsvGioHang.TabIndex = 0;
            this.lsvGioHang.UseCompatibleStateImageBehavior = false;
            this.lsvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Sản Phẩm";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn Giá";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giảm Giá";
            this.columnHeader9.Width = 89;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tổng Tiền";
            this.columnHeader10.Width = 111;
            // 
            // fBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "fBanHang";
            this.Text = "Bán Hàng";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongSP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTimKiemSanPham;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvGioHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThanhToanHD;
        private System.Windows.Forms.TextBox txtThanhToanHD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiamGiaHD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTienHD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuetMaBarcode;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtThanhTienSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiamGiaSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmSoLuongSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvGioHang;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}