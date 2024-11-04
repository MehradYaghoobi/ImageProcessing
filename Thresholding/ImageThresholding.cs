using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thresholding
{
    public class ImageThresholding : IImageThresholding
    {
        public Bitmap[] ColorThresholding(Bitmap bitmap, int limitedRed, int limitedGreen, int limitedBlue)
        {
            int Width = bitmap.Width;
            int Height = bitmap.Height;

            int gray;
            int[,] red = new int[Width, Height];
            int[,] green = new int[Width, Height];
            int[,] blue = new int[Width, Height];
            Bitmap graybmp = new Bitmap(Width, Height);
            Bitmap rgbbmp = new Bitmap(Width, Height);

            int limitedGray = (int)(limitedRed * 0.299 + limitedGreen * 0.587 + limitedBlue * 0.114);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color Pixel = bitmap.GetPixel(i, j);
                    red[i, j] = Pixel.R;
                    green[i, j] = Pixel.G;
                    blue[i, j] = Pixel.B;
                    gray = (int)(Pixel.R * 0.299 + Pixel.G * 0.587 + Pixel.B * 0.114);

                    if (gray > limitedGray) gray = 255;
                    else gray = 0;

                    if (red[i, j] > limitedRed) red[i, j] = 255;
                    else red[i, j] = 0;

                    if (green[i, j] > limitedGreen) green[i, j] = 255;
                    else green[i, j] = 0;

                    if (blue[i, j] > limitedBlue) blue[i, j] = 255;
                    else blue[i, j] = 0;

                    rgbbmp.SetPixel(i, j, Color.FromArgb(red[i, j], green[i, j], blue[i, j]));
                    graybmp.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            return new Bitmap[] { rgbbmp, graybmp };
        }
    }
}
