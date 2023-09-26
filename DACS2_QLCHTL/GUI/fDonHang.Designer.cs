
namespace DACS2_QLCHTL.GUI
{
    partial class fDonHang
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.dtpkNgayKTThongKe = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayBDThongKe = new System.Windows.Forms.DateTimePicker();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dtgvThongKe);
            this.panel15.Location = new System.Drawing.Point(12, 57);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(922, 485);
            this.panel15.TabIndex = 7;
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Location = new System.Drawing.Point(4, 4);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.Size = new System.Drawing.Size(915, 478);
            this.dtgvThongKe.TabIndex = 0;
            this.dtgvThongKe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongKe_CellDoubleClick);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label33);
            this.panel18.Controls.Add(this.label32);
            this.panel18.Controls.Add(this.btnXemThongKe);
            this.panel18.Controls.Add(this.dtpkNgayKTThongKe);
            this.panel18.Controls.Add(this.dtpkNgayBDThongKe);
            this.panel18.Location = new System.Drawing.Point(12, 12);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(922, 39);
            this.panel18.TabIndex = 6;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(325, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 19);
            this.label33.TabIndex = 14;
            this.label33.Text = "Ngày Kết Thúc:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(110, 19);
            this.label32.TabIndex = 13;
            this.label32.Text = "Ngày Bắt Đầu:";
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.BackColor = System.Drawing.Color.White;
            this.btnXemThongKe.Location = new System.Drawing.Point(785, 5);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(134, 30);
            this.btnXemThongKe.TabIndex = 4;
            this.btnXemThongKe.Text = "Thống kê";
            this.btnXemThongKe.UseVisualStyleBackColor = false;
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // dtpkNgayKTThongKe
            // 
            this.dtpkNgayKTThongKe.Location = new System.Drawing.Point(447, 8);
            this.dtpkNgayKTThongKe.Name = "dtpkNgayKTThongKe";
            this.dtpkNgayKTThongKe.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgayKTThongKe.TabIndex = 1;
            // 
            // dtpkNgayBDThongKe
            // 
            this.dtpkNgayBDThongKe.Location = new System.Drawing.Point(119, 8);
            this.dtpkNgayBDThongKe.Name = "dtpkNgayBDThongKe";
            this.dtpkNgayBDThongKe.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgayBDThongKe.TabIndex = 0;
            // 
            // fDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel18);
            this.Name = "fDonHang";
            this.Text = "Đơn Hàng";
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.DateTimePicker dtpkNgayKTThongKe;
        private System.Windows.Forms.DateTimePicker dtpkNgayBDThongKe;
    }
}