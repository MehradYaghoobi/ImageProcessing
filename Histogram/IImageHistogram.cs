using System.Drawing;

namespace Histogram;

public interface IImageHistogram
{
    int[] RedHis { get; }
    int[] GreenHis { get; }
    int[] BlueHis { get; }
    Bitmap[] HistogramBuilder(Bitmap bitmap);
}