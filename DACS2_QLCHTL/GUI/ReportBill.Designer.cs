
namespace DACS2_QLCHTL.GUI
{
    partial class ReportBill
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPHoaDonCuaKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangTienLoiDataSet1 = new DACS2_QLCHTL.QuanLyCuaHangTienLoiDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_HoaDonCuaKhachHangTableAdapter = new DACS2_QLCHTL.QuanLyCuaHangTienLoiDataSet1TableAdapters.USP_HoaDonCuaKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonCuaKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangTienLoiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPHoaDonCuaKhachHangBindingSource
            // 
            this.uSPHoaDonCuaKhachHangBindingSource.DataMember = "USP_HoaDonCuaKhachHang";
            this.uSPHoaDonCuaKhachHangBindingSource.DataSource = this.quanLyCuaHangTienLoiDataSet1;
            // 
            // quanLyCuaHangTienLoiDataSet1
            // 
            this.quanLyCuaHangTienLoiDataSet1.DataSetName = "QuanLyCuaHangTienLoiDataSet1";
            this.quanLyCuaHangTienLoiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSBill";
            reportDataSource1.Value = this.uSPHoaDonCuaKhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DACS2_QLCHTL.GUI.ReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(625, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_HoaDonCuaKhachHangTableAdapter
            // 
            this.uSP_HoaDonCuaKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 348);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBill";
            this.Text = "ReportBill";
            this.Load += new System.EventHandler(this.ReportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonCuaKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangTienLoiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyCuaHangTienLoiDataSet1 quanLyCuaHangTienLoiDataSet1;
        private System.Windows.Forms.BindingSource uSPHoaDonCuaKhachHangBindingSource;
        private QuanLyCuaHangTienLoiDataSet1TableAdapters.USP_HoaDonCuaKhachHangTableAdapter uSP_HoaDonCuaKhachHangTableAdapter;
    }
}