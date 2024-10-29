using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessing.Config
{
    public class ChartConfig
    {
        public static void ChartAddPoints(Chart red, Chart green, Chart blue, int[] redItems, int[] greenItems, int[] blueItems)
        {
            for (int i = 0; i < 256; i++)
            {
                red.Series["Red"].Points.AddXY(i + 1, redItems[i]);
                green.Series["Green"].Points.AddXY(i + 1, greenItems[i]);
                blue.Series["Blue"].Points.AddXY(i + 1, blueItems[i]);
            }
        }
    }
}
