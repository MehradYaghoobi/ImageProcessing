using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialFiltering
{
    public class ImageSpatialFiltering : IImageSpatialFiltering
    {
        public Bitmap MedianFilterProcessor(Bitmap bitmap, int filterCols, int filterRows)
        {
            int Width = bitmap.Width;
            int Height = bitmap.Height;
            Bitmap filteredImage = new Bitmap(Width, Height);
            int filterRowOffset = filterRows / 2;
            int filterColOffset = filterCols / 2;
            for (int x = filterColOffset; x < Width - filterColOffset; x++)
            {
                for (int y = filterRowOffset; y < Height - filterRowOffset; y++)
                {
                    int[] redValues = new int[filterRows * filterCols];
                    int[] greenValues = new int[filterRows * filterCols];
                    int[] blueValues = new int[filterRows * filterCols];
                    int k = 0;
                    for (int i = -filterRowOffset; i <= filterRowOffset; i++)
                    {
                        for (int j = -filterColOffset; j <= filterColOffset; j++)
                        {

                            Color pixelColor = bitmap.GetPixel(x + j, y + i);
                            redValues[k] = pixelColor.R;
                            greenValues[k] = pixelColor.G;
                            blueValues[k] = pixelColor.B;
                            k++;
                            
                        }
                    }

                    CustomSort(redValues, k);
                    CustomSort(greenValues, k);
                    CustomSort(blueValues, k);

                    int medianRed = redValues[k / 2];
                    int medianGreen = greenValues[k / 2];
                    int medianBlue = blueValues[k / 2];

                    filteredImage.SetPixel(x, y, Color.FromArgb(medianRed, medianGreen, medianBlue));
                }
            }

            return filteredImage;
        }

        public Bitmap SharpenSpatialFilteringProcessor(Bitmap bitmap, int[,] filterMatrix)
        {
            int Width = bitmap.Width;
            int Height = bitmap.Height;
            Bitmap filteredImage = new Bitmap(Width, Height);
            int filterRows = filterMatrix.GetLength(0);
            int filterCols = filterMatrix.GetLength(1);
            int filterRowOffset = filterRows / 2;
            int filterColOffset = filterCols / 2;
            for (int x = filterColOffset; x < Width - filterColOffset; x++)
            {
                for (int y = filterRowOffset; y < Height - filterRowOffset; y++)
                {
                    int red = 0, green = 0, blue = 0;
                    for (int i = -filterRowOffset; i <= filterRowOffset; i++)
                    {
                        for (int j = -filterColOffset; j <= filterColOffset; j++)
                        {
                            Color pixelColor = bitmap.GetPixel(x + j, y + i);
                            int filterValue = filterMatrix[i + filterRowOffset, j + filterColOffset];
                            red += pixelColor.R * filterValue;
                            green += pixelColor.G * filterValue;
                            blue += pixelColor.B * filterValue;
                        }
                    }

                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    filteredImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return filteredImage;
        }

        private void CustomSort(int[] values, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        (values[j], values[j + 1]) = (values[j + 1], values[j]);
                    }
                }
            }
        }
    }
}