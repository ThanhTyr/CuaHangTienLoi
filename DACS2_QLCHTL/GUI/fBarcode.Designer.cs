
namespace DACS2_QLCHTL.GUI
{
    partial class fBarcode
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.txtMaBarcode = new System.Windows.Forms.TextBox();
            this.timerBarcode = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // picBarcode
            // 
            this.picBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBarcode.Location = new System.Drawing.Point(12, 39);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(356, 220);
            this.picBarcode.TabIndex = 5;
            this.picBarcode.TabStop = false;
            // 
            // txtMaBarcode
            // 
            this.txtMaBarcode.Location = new System.Drawing.Point(116, 270);
            this.txtMaBarcode.Name = "txtMaBarcode";
            this.txtMaBarcode.ReadOnly = true;
            this.txtMaBarcode.Size = new System.Drawing.Size(171, 20);
            this.txtMaBarcode.TabIndex = 4;
            this.txtMaBarcode.TextChanged += new System.EventHandler(this.txtMaBarcode_TextChanged);
            // 
            // timerBarcode
            // 
            this.timerBarcode.Tick += new System.EventHandler(this.timerBarcode_Tick);
            // 
            // fBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 297);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.txtMaBarcode);
            this.Name = "fBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fBarcode_FormClosing);
            this.Load += new System.EventHandler(this.fBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.TextBox txtMaBarcode;
        private System.Windows.Forms.Timer timerBarcode;
    }
}