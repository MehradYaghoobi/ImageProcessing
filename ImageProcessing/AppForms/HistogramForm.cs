using ImageProcessing.Algorithms;
using ImageProcessing.Config;

namespace ImageProcessing.AppForms
{
    public partial class HistogramForm : Form
    {
        public HistogramForm(Bitmap bmp)
        {
            InitializeComponent();
            Bitmap[] bitmaps;
            Histogram his = new(bmp);
            bitmaps = his.HistogramBuilder();

            picRed.Image = bitmaps[0];
            picBlue.Image = bitmaps[1];
            picGreen.Image = bitmaps[2];

            ChartConfig.ChartAddPoints(chtRed, chtGreen, chtBlue,
                his.RedHis, his.GreenHis, his.BlueHis);
        }
    }
}
