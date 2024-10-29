
namespace ImageProcessing.Algorithms
{
    public class Negative(Bitmap bitmap) : GeneralParameters
    {

        public Bitmap NegativeBuilder()
        {

            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Pixel = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, Color.FromArgb(255 - Pixel.R, 255 - Pixel.G, 255 - Pixel.B));
                }
            }
            return bitmap;
        }
    }
}
