
namespace ImageProcessing.Algorithms
{
    public class Histogram(Bitmap bitmap) : GeneralParameters
    {
        public int[] RedHis { get; set; } = new int[256];
        public int[] GreenHis { get; set; } = new int[256];
        public int[] BlueHis { get; set; } = new int[256];
        public Bitmap[] HistogramBuilder()
        {
            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;

            Bitmap bmpRed = new(Width, Height);
            Bitmap bmpGreen = new(Width, Height);
            Bitmap bmpBlue = new(Width, Height);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Pixel = bitmap.GetPixel(i, j);
                    bmpRed.SetPixel(i, j, Color.FromArgb(Pixel.R, 0, 0));
                    bmpGreen.SetPixel(i, j, Color.FromArgb(0, Pixel.G, 0));
                    bmpBlue.SetPixel(i, j, Color.FromArgb(0, 0, Pixel.B));
                    RedHis[Pixel.R]++;
                    GreenHis[Pixel.G]++;
                    BlueHis[Pixel.B]++;
                }
            }

            return [bmpRed, bmpGreen, bmpBlue];
        }

    }
}
