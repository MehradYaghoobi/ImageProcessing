
namespace ImageProcessing.Algorithms
{
    public class GrayScale(Bitmap bitmap) : GeneralParameters
    {
        public Bitmap GrayScaleBuilder()
        {
            short gray;
            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Pixel = bitmap.GetPixel(i, j);
                    gray = (byte)(Pixel.R * 0.299 + Pixel.G * 0.587 + Pixel.B * 0.114);
                    bitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            return bitmap;
        }
    }
}