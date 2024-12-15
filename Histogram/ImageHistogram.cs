using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Histogram;

public class ImageHistogram : IImageHistogram
{
    public int[] RedHis { get; private set; } = new int[256];
    public int[] GreenHis { get; private set; } = new int[256];
    public int[] BlueHis { get; private set; } = new int[256];

    public Bitmap[] HistogramBuilder(Bitmap bitmap)
    {

        // ایجاد یک نمونه از Stopwatch برای اندازه‌گیری زمان
        Stopwatch stopwatch = new Stopwatch();

        // شروع زمان‌سنجی
        stopwatch.Start();

        // تبدیل تصویر به فرمت 32bppArgb برای یکپارچگی در پردازش
        if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
        {
            bitmap = new Bitmap(bitmap, new Size(bitmap.Width, bitmap.Height));
        }

        int Width = bitmap.Width;
        int Height = bitmap.Height;

        Bitmap bmpRed = new(bitmap);
        Bitmap bmpGreen = new(bitmap);
        Bitmap bmpBlue = new(bitmap);

        // Lock image bits
        Rectangle rect = new Rectangle(0, 0, Width, Height);
        Rectangle rectR = new Rectangle(0, 0, Width, Height);
        Rectangle rectG = new Rectangle(0, 0, Width, Height);
        Rectangle rectB = new Rectangle(0, 0, Width, Height);

        BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
        BitmapData bitmapDataR = bmpRed.LockBits(rectR, ImageLockMode.ReadWrite, bmpRed.PixelFormat);
        BitmapData bitmapDataG = bmpGreen.LockBits(rectG, ImageLockMode.ReadWrite, bmpGreen.PixelFormat);
        BitmapData bitmapDataB = bmpBlue.LockBits(rectB, ImageLockMode.ReadWrite, bmpBlue.PixelFormat);

        // Get the pointer to the image's raw data
        IntPtr ptr = bitmapData.Scan0;
        IntPtr ptrR = bitmapDataR.Scan0;
        IntPtr ptrG = bitmapDataG.Scan0;
        IntPtr ptrB = bitmapDataB.Scan0;

        // Calculate stride (the number of bytes in a row of the image)
        int stride = bitmapData.Stride;

        // For 32bpp ARGB
        int bytesPerPixel = 4; // ARGB format (4 bytes per pixel)

        // Create a buffer for pixel data
        byte[] pixels = new byte[stride * Height];
        byte[] pixelsR = new byte[stride * Height];
        byte[] pixelsG = new byte[stride * Height];
        byte[] pixelsB = new byte[stride * Height];
        Marshal.Copy(ptr, pixels, 0, pixels.Length);
        Marshal.Copy(ptrR, pixelsR, 0, pixelsR.Length);
        Marshal.Copy(ptrG, pixelsG, 0, pixelsG.Length);
        Marshal.Copy(ptrB, pixelsB, 0, pixelsB.Length);

        // Process the pixels
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                // Get the index of the pixel in the array
                int pixelIndex = (y * stride) + (x * bytesPerPixel);

                // Extract ARGB values
                byte a = pixels[pixelIndex + 3]; // Alpha
                byte r = pixels[pixelIndex + 2]; // Red
                byte g = pixels[pixelIndex + 1]; // Green
                byte b = pixels[pixelIndex];     // Blue

                // Set the grayscale value to all channels (R, G, B), keep Alpha as is
                pixelsR[pixelIndex + 2] = r;  //Red
                pixelsR[pixelIndex + 1] = 0;  //Green
                pixelsR[pixelIndex] = 0;      //Blue

                pixelsG[pixelIndex + 2] = 0;  //Red
                pixelsG[pixelIndex + 1] = g;  //Green
                pixelsG[pixelIndex] = 0;      //Blue

                pixelsB[pixelIndex + 2] = 0;  //Red
                pixelsB[pixelIndex + 1] = 0;  //Green
                pixelsB[pixelIndex] = b;      //Blue


                RedHis[r]++;
                GreenHis[g]++;
                BlueHis[b]++;
            }
        }

        // Copy the modified pixel data back to the bitmap
        Marshal.Copy(pixels, 0, ptr, pixels.Length);
        Marshal.Copy(pixelsR, 0, ptrR, pixelsR.Length);
        Marshal.Copy(pixelsG, 0, ptrG, pixelsG.Length);
        Marshal.Copy(pixelsB, 0, ptrB, pixelsB.Length);

        // Unlock the bits
        bitmap.UnlockBits(bitmapData);
        bmpRed.UnlockBits(bitmapDataR);
        bmpGreen.UnlockBits(bitmapDataG);
        bmpBlue.UnlockBits(bitmapDataB);

        // توقف زمان‌سنجی
        stopwatch.Stop();

        // نمایش زمان طی شده
        Debug.WriteLine($"Time taken for processing: {stopwatch.ElapsedMilliseconds} ms");

        return [bmpRed, bmpGreen, bmpBlue];
    }
}