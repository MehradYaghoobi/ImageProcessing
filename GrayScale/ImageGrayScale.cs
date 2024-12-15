using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace GrayScale
{
    public class ImageGrayScale : IImageGrayScale
    {
        //public Bitmap GrayScaleProcessor(Bitmap bitmap)
        //{

        //    // ایجاد یک نمونه از Stopwatch برای اندازه‌گیری زمان
        //    Stopwatch stopwatch = new Stopwatch();

        //    // شروع زمان‌سنجی
        //    stopwatch.Start();

        //    byte gray;
        //    int Width = bitmap.Width;
        //    int Height = bitmap.Height;
        //    Color Pixel;

        //    for (int i = 0; i < Width; i++)
        //    {
        //        for (int j = 0; j < Height; j++)
        //        {
        //            Pixel = bitmap.GetPixel(i, j);
        //            gray = (byte)(Pixel.R * 0.299 + Pixel.G * 0.587 + Pixel.B * 0.114);
        //            bitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
        //        }
        //    }

        //    // توقف زمان‌سنجی
        //    stopwatch.Stop();

        //    // نمایش زمان طی شده
        //    Debug.WriteLine($"Time taken for processing: {stopwatch.ElapsedMilliseconds} ms");

        //    return bitmap;
        //}

        public Bitmap GrayScaleProcessor(Bitmap bitmap)
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


            // Lock image bits
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);

            // Get the pointer to the image's raw data
            IntPtr ptr = bitmapData.Scan0;

            // Calculate stride (the number of bytes in a row of the image)
            int stride = bitmapData.Stride;

            // For 32bpp ARGB
            int bytesPerPixel = 4; // ARGB format (4 bytes per pixel)

            // Create a buffer for pixel data
            byte[] pixels = new byte[stride * Height];
            Marshal.Copy(ptr, pixels, 0, pixels.Length);

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

                    // Calculate the grayscale value
                    byte gray = (byte)(r * 0.299 + g * 0.587 + b * 0.114);

                    // Set the grayscale value to all channels (R, G, B), keep Alpha as is
                    pixels[pixelIndex + 2] = gray;
                    pixels[pixelIndex + 1] = gray;
                    pixels[pixelIndex] = gray;
                }
            }

            // Copy the modified pixel data back to the bitmap
            Marshal.Copy(pixels, 0, ptr, pixels.Length);

            // Unlock the bits
            bitmap.UnlockBits(bitmapData);

            // توقف زمان‌سنجی
            stopwatch.Stop();

            // نمایش زمان طی شده
            Debug.WriteLine($"Time taken for processing: {stopwatch.ElapsedMilliseconds} ms");

            return bitmap;
        }



    }
}
