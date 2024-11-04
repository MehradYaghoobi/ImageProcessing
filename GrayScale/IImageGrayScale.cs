using System.Drawing;

namespace GrayScale;

public interface IImageGrayScale
{
    Bitmap GrayScaleProcessor(Bitmap bitmap);
}