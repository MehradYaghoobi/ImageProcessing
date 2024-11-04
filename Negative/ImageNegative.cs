using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative
{
    public class ImageNegative : IImageNegative
    {
        public Bitmap NegativeBuilder(Bitmap bitmap)
        {
            byte gray;
            int Width = (short)bitmap.Width;
            int Height = (short)bitmap.Height;
            Color Pixel;

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
