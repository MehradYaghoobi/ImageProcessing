
namespace ImageProcessing.Algorithms
{
    public class HistogramEqualization(Bitmap bitmap) : GeneralParameters
    {
        public int[,] Red { get; set; } = new int[bitmap.Width, bitmap.Height];
        public int[,] Green { get; set; } = new int[bitmap.Width, bitmap.Height];
        public int[,] Blue { get; set; } = new int[bitmap.Width, bitmap.Height];
        public void ColorSeparator()
        {
            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Pixel = bitmap.GetPixel(i, j);
                    Red[i, j] = Pixel.R;
                    Green[i, j] = Pixel.G;
                    Blue[i, j] = Pixel.B;
                }
            }


            HistogramEq(Red);
            HistogramEq(Green);
            HistogramEq(Blue);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(Red[i, j], Green[i, j], Blue[i, j]));
                }
            }
        }

        public int[,] HistogramEq(int[,] pixel)
        {
            //IEnumerable<int> allValues = Red.Cast<int>();
            //int Max = allValues.Max();

            double pixelCount = Width * Height;

            // Max+1 => 256
            int[] pixelCounter = new int[256];
            double[] pdf = new double[256];

            //فراوانی شدت شماره های رنک 0 تا 255
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    pixelCounter[pixel[i, j]]++;
                }
            }


            //Nk / N or No.of pixel/ sum
            for (int i = 0; i < pixelCounter.Length; i++)
            {
                pdf[i] = (pixelCounter[i] / pixelCount);
            }

            //مجموع احتمالات قبلی تا خودش که در نهایت حاصل جمع همه باید 1 شود
            for (int i = 1; i < pdf.Length; i++)
            {
                pdf[i] += pdf[i - 1];
            }

            //حاصل ضرب فراوانی احتمال در بیشترین شدت رنک، رند شده
            // Max => 255
            for (int i = 0; i < pdf.Length; i++)
            {
                pdf[i] = (int)Math.Round(pdf[i] * 255, MidpointRounding.AwayFromZero);
            }

            //جایکذاری شدت جدید رنک در پیکسل هایی که شدت قبلی را داشته اند
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    pixel[i, j] = (int)pdf[pixel[i, j]];
                }
            }

            return pixel;
        }


        public int[] HistogramCal(int[,] counter)
        {
            int[] his = new int[256];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (counter[i, j] > 255) counter[i, j] = 255;

                    if (counter[i, j] < 0) counter[i, j] = 0;

                    his[counter[i, j]]++;

                }
            }
            return his;
        }

    }
}
