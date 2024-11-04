using System.Drawing;

namespace HistogramEqualization;

public interface IImageHistogramEqualization
{
    int[,]? Red { get; set; }
    int[,]? Green { get; set; }
    int[,]? Blue { get; set; }
    Bitmap HistogramEqualization(Bitmap bitmap);
    int[] HistogramCal(int[,] counter);
}