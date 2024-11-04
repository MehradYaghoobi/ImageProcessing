using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramEqualization
{
    public class ImageHistogramEqualization : IImageHistogramEqualization
    {
        public int[,]? Red { get; set; }
        public int[,]? Green { get; set; }
        public int[,]? Blue { get; set; }
        private int _width;
        private int _height;

        public Bitmap HistogramEqualization(Bitmap bitmap)
        {
            _width = bitmap.Width;
            _height = bitmap.Height;

            Red = new int[_width, _height];
            Green = new int[_width, _height];
            Blue = new int[_width, _height];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    Color Pixel = bitmap.GetPixel(i, j);
                    Red[i, j] = Pixel.R;
                    Green[i, j] = Pixel.G;
                    Blue[i, j] = Pixel.B;
                }
            }

            HistogramEqMethod(Red);
            HistogramEqMethod(Green);
            HistogramEqMethod(Blue);

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(Red[i, j], Green[i, j], Blue[i, j]));
                }
            }

            return bitmap;
        }

        public int[,] HistogramEqMethod(int[,] pixel)
        {
            double pixelCount = _width * _height;
            int[] pixelCounter = new int[256];
            double[] pdf = new double[256];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    pixelCounter[pixel[i, j]]++;
                }
            }

            for (int i = 0; i < pixelCounter.Length; i++)
            {
                pdf[i] = (pixelCounter[i] / pixelCount);
            }

            for (int i = 1; i < pdf.Length; i++)
            {
                pdf[i] += pdf[i - 1];
            }

            for (int i = 0; i < pdf.Length; i++)
            {
                pdf[i] = (int)Math.Round(pdf[i] * 255, MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    pixel[i, j] = (int)pdf[pixel[i, j]];
                }
            }

            return pixel;
        }

        public int[] HistogramCal(int[,] counter)
        {
            int[] his = new int[256];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
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
