using Histogram;
using ImageProcessing.Algorithms;
using ImageProcessing.Config;

namespace ImageProcessing.AppForms
{
    public partial class HistogramForm : Form
    {
        public IImageHistogram ImageHistogramService { get; set; }
        private Bitmap bitmap;
        public HistogramForm(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            Bitmap[] bitmaps = ImageHistogramService.HistogramBuilder(bitmap);
            picRed.Image = bitmaps[0];
            picBlue.Image = bitmaps[1];
            picGreen.Image = bitmaps[2];
            ChartConfig.ChartAddPoints(chtRed, chtGreen, chtBlue,
                ImageHistogramService.RedHis, ImageHistogramService.GreenHis, ImageHistogramService.BlueHis);

        }
    }
}
