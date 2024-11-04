using System.Drawing;

namespace SpatialFiltering;

public interface IImageSpatialFiltering
{
    Bitmap MedianFilterProcessor(Bitmap bitmap, int filterCols, int filterRows);

    Bitmap SharpenSpatialFilteringProcessor(Bitmap bitmap, int[,] filterArray);
}