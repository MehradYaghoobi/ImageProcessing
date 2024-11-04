using System.Drawing;

namespace Thresholding;

public interface IImageThresholding
{
    Bitmap[] ColorThresholding(Bitmap bitmap, int limitedRed, int limitedGreen, int limitedBlue);
}