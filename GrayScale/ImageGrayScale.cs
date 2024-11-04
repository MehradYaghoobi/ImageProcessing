using System.Drawing;

namespace GrayScale
{
    public class ImageGrayScale : IImageGrayScale
    {

        public Bitmap GrayScaleProcessor(Bitmap bitmap)
    {
        byte gray;
        int Width = bitmap.Width;
        int Height = bitmap.Height;
        Color Pixel;

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
