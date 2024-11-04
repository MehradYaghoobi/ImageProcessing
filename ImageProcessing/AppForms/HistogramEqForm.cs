using Histogram;
using HistogramEqualization;
using ImageProcessing.Algorithms;
using ImageProcessing.Config;

namespace ImageProcessing.AppForms
{
    public partial class HistogramEqForm : Form
    {
        public IImageHistogramEqualization HisEqualizationService { get; set; }
        private Bitmap bitmap;
        public HistogramEqForm(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            //HistogramEqualization hisEq = new(bmp);
            //hisEq.ColorSeparator();
            //picEq.Image = bmp;

            //ChartConfig.ChartAddPoints(chtRed, chtGreen, chtBlue,
            //    hisEq.HistogramCal(hisEq.Red), hisEq.HistogramCal(hisEq.Green), hisEq.HistogramCal(hisEq.Blue));

        }

        private void HistogramEqForm_Load(object sender, EventArgs e)
        {
            picEq.Image = HisEqualizationService.HistogramEqualization(bitmap);

            ChartConfig.ChartAddPoints(chtRed, chtGreen, chtBlue,
                HisEqualizationService.HistogramCal(HisEqualizationService.Red),
                HisEqualizationService.HistogramCal(HisEqualizationService.Green),
                HisEqualizationService.HistogramCal(HisEqualizationService.Blue));

        }
    }
}
