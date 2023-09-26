
namespace DACS2_QLCHTL.GUI
{
    partial class fThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chartTongTien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHDThang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDoanhSoThang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSLSP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSoLSP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblHDHomNay = new System.Windows.Forms.Label();
            this.lblNhapKhoHomNay = new System.Windows.Forms.Label();
            this.lblDoanhSoHomNay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkBlue;
            this.panel4.Controls.Add(this.lblSoLSP);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(295, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 129);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepPink;
            this.panel5.Controls.Add(this.lblNhapKhoHomNay);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lblSLSP);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(23, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 129);
            this.panel5.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.lblDoanhSoHomNay);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblDoanhSoThang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(295, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 129);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.Controls.Add(this.lblHDHomNay);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lblHDThang);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(23, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 129);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chartTongTien);
            this.panel7.Location = new System.Drawing.Point(23, 291);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(911, 260);
            this.panel7.TabIndex = 11;
            // 
            // chartTongTien
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTongTien.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTongTien.Legends.Add(legend1);
            this.chartTongTien.Location = new System.Drawing.Point(3, 3);
            this.chartTongTien.Name = "chartTongTien";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TongTien";
            this.chartTongTien.Series.Add(series1);
            this.chartTongTien.Size = new System.Drawing.Size(905, 254);
            this.chartTongTien.TabIndex = 12;
            this.chartTongTien.Text = "Tổng Tiền";
            title1.Name = "Title1";
            title1.Text = "Tổng Tiền";
            this.chartTongTien.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn (Tháng)";
            // 
            // lblHDThang
            // 
            this.lblHDThang.AutoSize = true;
            this.lblHDThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDThang.ForeColor = System.Drawing.Color.White;
            this.lblHDThang.Location = new System.Drawing.Point(24, 48);
            this.lblHDThang.Name = "lblHDThang";
            this.lblHDThang.Size = new System.Drawing.Size(17, 19);
            this.lblHDThang.TabIndex = 1;
            this.lblHDThang.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hôm nay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hôm nay:";
            // 
            // lblDoanhSoThang
            // 
            this.lblDoanhSoThang.AutoSize = true;
            this.lblDoanhSoThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhSoThang.ForeColor = System.Drawing.Color.White;
            this.lblDoanhSoThang.Location = new System.Drawing.Point(40, 55);
            this.lblDoanhSoThang.Name = "lblDoanhSoThang";
            this.lblDoanhSoThang.Size = new System.Drawing.Size(17, 19);
            this.lblDoanhSoThang.TabIndex = 4;
            this.lblDoanhSoThang.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doanh số (Tháng)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nhập kho hôm nay:";
            // 
            // lblSLSP
            // 
            this.lblSLSP.AutoSize = true;
            this.lblSLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLSP.ForeColor = System.Drawing.Color.White;
            this.lblSLSP.Location = new System.Drawing.Point(25, 55);
            this.lblSLSP.Name = "lblSLSP";
            this.lblSLSP.Size = new System.Drawing.Size(17, 19);
            this.lblSLSP.TabIndex = 4;
            this.lblSLSP.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tổng số lượng sản phẩm";
            // 
            // lblSoLSP
            // 
            this.lblSoLSP.AutoSize = true;
            this.lblSoLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLSP.ForeColor = System.Drawing.Color.White;
            this.lblSoLSP.Location = new System.Drawing.Point(28, 55);
            this.lblSoLSP.Name = "lblSoLSP";
            this.lblSoLSP.Size = new System.Drawing.Size(17, 19);
            this.lblSoLSP.TabIndex = 4;
            this.lblSoLSP.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tổng loại sản phẩm";
            // 
            // lblHDHomNay
            // 
            this.lblHDHomNay.AutoSize = true;
            this.lblHDHomNay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDHomNay.ForeColor = System.Drawing.Color.White;
            this.lblHDHomNay.Location = new System.Drawing.Point(104, 80);
            this.lblHDHomNay.Name = "lblHDHomNay";
            this.lblHDHomNay.Size = new System.Drawing.Size(17, 19);
            this.lblHDHomNay.TabIndex = 3;
            this.lblHDHomNay.Text = "0";
            // 
            // lblNhapKhoHomNay
            // 
            this.lblNhapKhoHomNay.AutoSize = true;
            this.lblNhapKhoHomNay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapKhoHomNay.ForeColor = System.Drawing.Color.White;
            this.lblNhapKhoHomNay.Location = new System.Drawing.Point(170, 87);
            this.lblNhapKhoHomNay.Name = "lblNhapKhoHomNay";
            this.lblNhapKhoHomNay.Size = new System.Drawing.Size(17, 19);
            this.lblNhapKhoHomNay.TabIndex = 6;
            this.lblNhapKhoHomNay.Text = "0";
            // 
            // lblDoanhSoHomNay
            // 
            this.lblDoanhSoHomNay.AutoSize = true;
            this.lblDoanhSoHomNay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhSoHomNay.ForeColor = System.Drawing.Color.White;
            this.lblDoanhSoHomNay.Location = new System.Drawing.Point(120, 87);
            this.lblDoanhSoHomNay.Name = "lblDoanhSoHomNay";
            this.lblDoanhSoHomNay.Size = new System.Drawing.Size(17, 19);
            this.lblDoanhSoHomNay.TabIndex = 6;
            this.lblDoanhSoHomNay.Text = "0";
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.panel1);
            this.Name = "fThongKe";
            this.Text = "fThongKe";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTongTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTongTien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSoLSP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNhapKhoHomNay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSLSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDoanhSoHomNay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDoanhSoThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHDHomNay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHDThang;
        private System.Windows.Forms.Label label1;
    }
}