using System.Drawing;

namespace Negative;

public interface IImageNegative
{
    Bitmap NegativeBuilder(Bitmap bitmap);
}