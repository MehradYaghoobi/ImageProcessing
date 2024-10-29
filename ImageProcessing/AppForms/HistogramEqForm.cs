using ImageProcessing.Algorithms;
using ImageProcessing.Config;

namespace ImageProcessing.AppForms
{
    public partial class HistogramEqForm : Form
    {
        public HistogramEqForm(Bitmap bmp)
        {
            InitializeComponent();

            HistogramEqualization hisEq = new(bmp);
            hisEq.ColorSeparator();
            picEq.Image = bmp;

            ChartConfig.ChartAddPoints(chtRed, chtGreen, chtBlue,
                hisEq.HistogramCal(hisEq.Red), hisEq.HistogramCal(hisEq.Green), hisEq.HistogramCal(hisEq.Blue));

        }
    }
}
