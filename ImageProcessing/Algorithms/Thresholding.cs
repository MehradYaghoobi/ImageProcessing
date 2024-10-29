
namespace ImageProcessing.Algorithms
{
    public class Thresholding(Bitmap bitmap) : GeneralParameters
    {
        public Bitmap[] ColorThresholding(int limitedRed, int limitedGreen, int limitedBlue)
        {

            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;

            int gray;
            int[,] red, green, blue;
            red = new int[Width, Height];
            green = new int[Width, Height];
            blue = new int[Width, Height];
            Bitmap gbmp = new(Width, Height);
            Bitmap rgbbmp = new(Width, Height);

            int limitedGray = (int)(limitedRed * 0.299 + limitedGreen * 0.587 + limitedBlue * 0.114);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Pixel = bitmap.GetPixel(i, j);
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
                    gbmp.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            return [rgbbmp, gbmp];
        }
    }
}
