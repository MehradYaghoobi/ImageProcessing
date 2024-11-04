using System.Drawing;
using System.Drawing.Imaging;

namespace Histogram;

public class ImageHistogram : IImageHistogram
{
    public int[] RedHis { get; private set; } = new int[256];
    public int[] GreenHis { get; private set; } = new int[256];
    public int[] BlueHis { get; private set; } = new int[256];
    public Bitmap[] HistogramBuilder(Bitmap bitmap)
    {
        byte gray;
        int width = (short)bitmap.Width;
        int height = (short)bitmap.Height;
        Color pixel;

        Bitmap bmpRed = new(width, height);
        Bitmap bmpGreen = new(width, height);
        Bitmap bmpBlue = new(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                pixel = bitmap.GetPixel(i, j);
                bmpRed.SetPixel(i, j, Color.FromArgb(pixel.R, 0, 0));
                bmpGreen.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0));
                bmpBlue.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B));
                RedHis[pixel.R]++;
                GreenHis[pixel.G]++;
                BlueHis[pixel.B]++;
            }
        }

        return [bmpRed, bmpGreen, bmpBlue];
    }
}