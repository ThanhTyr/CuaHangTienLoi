using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace DACS2_QLCHTL.GUI
{
    public partial class fBarcode : Form
    {
        public delegate void TruyenChoCha(string text);
        public TruyenChoCha truyendata;

        public fBarcode()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picBarcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void fBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void timerBarcode_Tick(object sender, EventArgs e)
        {
            if (picBarcode.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)picBarcode.Image);
                if (result != null)
                {
                    txtMaBarcode.Text = result.ToString();
                    timerBarcode.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                }
            }
        }

        private void txtMaBarcode_TextChanged(object sender, EventArgs e)
        {
            if (truyendata != null)
            {
                truyendata(txtMaBarcode.Text);
            }
            this.Close();
        }

        private void fBarcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = 0;


            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timerBarcode.Start();
        }
    }
}
