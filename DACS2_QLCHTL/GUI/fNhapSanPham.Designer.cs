
namespace DACS2_QLCHTL.GUI
{
    partial class fNhapSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayBD = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dtpkNgayKT);
            this.panel6.Controls.Add(this.dtpkNgayBD);
            this.panel6.Location = new System.Drawing.Point(15, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(564, 37);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = ">>>";
            // 
            // dtpkNgayKT
            // 
            this.dtpkNgayKT.Location = new System.Drawing.Point(300, 14);
            this.dtpkNgayKT.Name = "dtpkNgayKT";
            this.dtpkNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgayKT.TabIndex = 1;
            this.dtpkNgayKT.ValueChanged += new System.EventHandler(this.dtpkNgayKT_ValueChanged);
            // 
            // dtpkNgayBD
            // 
            this.dtpkNgayBD.Location = new System.Drawing.Point(50, 14);
            this.dtpkNgayBD.Name = "dtpkNgayBD";
            this.dtpkNgayBD.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgayBD.TabIndex = 0;
            this.dtpkNgayBD.ValueChanged += new System.EventHandler(this.dtpkNgayBD_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.btnNhapSP);
            this.panel3.Location = new System.Drawing.Point(15, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 180);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpkNgayNhap);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(107, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 28);
            this.panel5.TabIndex = 16;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(145, 4);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(203, 20);
            this.dtpkNgayNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày nhập:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbNCC);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(107, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 28);
            this.panel4.TabIndex = 15;
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(145, 3);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(203, 21);
            this.cbNCC.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhà Cung Cấp:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtSoLuongSP);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Location = new System.Drawing.Point(107, 38);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(351, 28);
            this.panel12.TabIndex = 12;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Location = new System.Drawing.Point(145, 3);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(203, 20);
            this.txtSoLuongSP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbTenSP);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(107, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(351, 27);
            this.panel10.TabIndex = 10;
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(145, 3);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(203, 21);
            this.cbTenSP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // btnNhapSP
            // 
            this.btnNhapSP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNhapSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSP.ForeColor = System.Drawing.Color.White;
            this.btnNhapSP.Location = new System.Drawing.Point(199, 140);
            this.btnNhapSP.Name = "btnNhapSP";
            this.btnNhapSP.Size = new System.Drawing.Size(164, 37);
            this.btnNhapSP.TabIndex = 0;
            this.btnNhapSP.Text = "Nhập thêm sản phẩm";
            this.btnNhapSP.UseVisualStyleBackColor = false;
            this.btnNhapSP.Click += new System.EventHandler(this.btnNhapSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvSanPham);
            this.panel2.Location = new System.Drawing.Point(15, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 209);
            this.panel2.TabIndex = 0;
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.Size = new System.Drawing.Size(558, 203);
            this.dtgvSanPham.TabIndex = 0;
            // 
            // fNhapSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fNhapSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNhapSanPham";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNhapSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkNgayKT;
        private System.Windows.Forms.DateTimePicker dtpkNgayBD;
    }
}