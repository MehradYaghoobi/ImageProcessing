namespace ImageProcessing.Algorithms
{
    public class SpatialFiltering(Bitmap bitmap) : GeneralParameters
    {
        public Bitmap SpatialFilteringMedianBuilder(TableLayoutPanel filterPanel)
        {
            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;
            Bitmap filteredImage = new(Width, Height);

            int filterRows = filterPanel.RowCount;
            int filterCols = filterPanel.ColumnCount;
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
                            int filterValue = GetFilterValue(filterPanel, i + filterRowOffset, j + filterColOffset);
                            if (filterValue != 0) // Only consider non-zero filter values
                            {
                                Color pixelColor = bitmap.GetPixel(x + j, y + i);
                                redValues[k] = pixelColor.R;
                                greenValues[k] = pixelColor.G;
                                blueValues[k] = pixelColor.B;
                                k++;
                            }
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

        public Bitmap SharprnSpatialFilteringBuilder(TableLayoutPanel filterPanel)
        {
            Width = (short)bitmap.Width;
            Height = (short)bitmap.Height;
            Bitmap filteredImage = new(Width, Height);

            int filterRows = filterPanel.RowCount;
            int filterCols = filterPanel.ColumnCount;
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
                            Color pixelColor = bitmap.GetPixel(x + i, y + j);
                            int filterValue = GetFilterValue(filterPanel, j + filterRowOffset, i + filterColOffset);

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

        private int GetFilterValue(TableLayoutPanel filterPanel, int row, int col)
        {
            var cell = filterPanel.GetControlFromPosition(col, row) as TextBox;
            return int.TryParse(cell?.Text, out int value) ? value : 0;
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
