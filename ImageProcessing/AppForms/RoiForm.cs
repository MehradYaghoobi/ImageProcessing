using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ImageProcessing.AppForms
{
    public partial class RoiForm : Form
    {
        private Point _startPoint;
        private bool _isDrawing;
        private Bitmap _originalBitmap;
        private Bitmap _editBitmap;
        private Bitmap _maskBitmap;
        private Graphics _originalGraphics;
        private Graphics _maskGraphics;
        private List<Point> _polygonPoints = new List<Point>(); // ذخیره نقاط پلی‌گون

        public RoiForm(Image image)
        {
            InitializeComponent();

            _originalBitmap = new Bitmap(image);
            _editBitmap = new Bitmap(image);
            _maskBitmap = new Bitmap(image.Width, image.Height);
            _originalGraphics = Graphics.FromImage(_originalBitmap);
            _maskGraphics = Graphics.FromImage(_maskBitmap);

            _maskGraphics.Clear(Color.White); // پس‌زمینه سفید برای ماسک
            DisplayScaledImage(); // نمایش تصویر مقیاس‌شده در PictureBox

            pictureBox1.Image = _maskBitmap; // ماسک در pictureBox1
            picROI.Image = image; // تصویر اصلی در picROI
        }

        private void DisplayScaledImage()
        {
            // مقیاس کردن تصویر به اندازه مناسب برای نمایش در PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap scaledBitmap = new Bitmap(_originalBitmap, new Size(width, height));

            // نمایش تصویر مقیاس‌شده در PictureBox
            pictureBox1.Image = scaledBitmap;
        }

        private void picROI_MouseDown(object sender, MouseEventArgs e)
        {
            // محاسبه نسبت مقیاس بین تصویر واقعی و نمایش مقیاس‌شده
            float scaleX = (float)_originalBitmap.Width / pictureBox1.Width;
            float scaleY = (float)_originalBitmap.Height / pictureBox1.Height;

            // تبدیل مختصات موس به مختصات واقعی تصویر
            _startPoint = new Point((int)(e.X * scaleX), (int)(e.Y * scaleY));
            _isDrawing = true;

            // پاک کردن لیست نقاط (برای شروع رسم جدید)
            _polygonPoints.Clear();
            _polygonPoints.Add(_startPoint); // اضافه کردن نقطه اولیه

            // دیباگ: نمایش مختصات شروع
            Console.WriteLine("Start Point: " + _startPoint);
        }

        private void picROI_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                // محاسبه نسبت مقیاس بین تصویر واقعی و نمایش مقیاس‌شده
                float scaleX = (float)_originalBitmap.Width / pictureBox1.Width;
                float scaleY = (float)_originalBitmap.Height / pictureBox1.Height;

                // تبدیل مختصات موس به مختصات واقعی تصویر
                int realX = (int)(e.X * scaleX);
                int realY = (int)(e.Y * scaleY);

                // رسم خط در تصویر مقیاس‌شده (و سپس هماهنگ کردن با مختصات واقعی تصویر)
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    _originalGraphics.DrawLine(pen, _startPoint, new Point(realX, realY));
                    _maskGraphics.DrawLine(pen, _startPoint, new Point(realX, realY));
                }

                _startPoint = new Point(realX, realY);
                _polygonPoints.Add(_startPoint); // اضافه کردن نقطه جدید به لیست

                // دیباگ: نمایش مختصات فعلی
                Console.WriteLine("Current Point: " + new Point(realX, realY));

                pictureBox1.Invalidate(); // به روز رسانی تصویر
            }
        }

        private void picROI_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;

            // دیباگ: نمایش تعداد نقاط
            Console.WriteLine("Number of Points: " + _polygonPoints.Count);

            // پس از پایان رسم، تبدیل نقاط به پلی‌گون و پر کردن داخل آن با رنگ قرمز
            using (Graphics g = Graphics.FromImage(_maskBitmap))
            {
                if (_polygonPoints.Count > 2)
                {
                    // پر کردن داخل پلی‌گون با رنگ قرمز
                    g.FillPolygon(Brushes.Red, _polygonPoints.ToArray());

                    // دیباگ: نمایش پیغام پس از پر کردن
                    Console.WriteLine("Polygon Filled with Red.");
                }
            }

            pictureBox1.Image = _maskBitmap; // به روز رسانی تصویر
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // پاک کردن ماسک و شروع دوباره از ابتدا
            _maskGraphics.Clear(Color.White); // پس‌زمینه سفید برای ماسک
            _polygonPoints.Clear(); // پاک کردن لیست نقاط
            pictureBox1.Image = _maskBitmap; // به روز رسانی تصویر
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _editBitmap = ApplyMaskAndExtractPixels(_editBitmap, _maskBitmap);

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _editBitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

            pictureBox1.Image = _editBitmap; // به روز رسانی تصویر

            if (this.Owner is MainForm mainForm)
            {
                mainForm.SetExtractedImage(_editBitmap);
            }

            MessageBox.Show("تصویر بخوبی جایگزین شد می توانید از این صفحه خارج شوید.");
        }

        private Bitmap ApplyMaskAndExtractPixels(Bitmap originalBitmap, Bitmap maskBitmap)
        {

            // ایجاد یک نمونه از Stopwatch برای اندازه‌گیری زمان
            Stopwatch stopwatch = new Stopwatch();

            // شروع زمان‌سنجی
            stopwatch.Start();

            int Counter = 0;
            if (originalBitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                originalBitmap = new Bitmap(originalBitmap, new Size(originalBitmap.Width, originalBitmap.Height));
            }

            if (maskBitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                maskBitmap = new Bitmap(maskBitmap, new Size(maskBitmap.Width, maskBitmap.Height));
            }

            int Width = originalBitmap.Width;
            int Height = originalBitmap.Height;


            // Lock image bits
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            BitmapData bitmapData = originalBitmap.LockBits(rect, ImageLockMode.ReadWrite, originalBitmap.PixelFormat);

            Rectangle rectMask = new Rectangle(0, 0, Width, Height);
            BitmapData bitmapDataMask = maskBitmap.LockBits(rectMask, ImageLockMode.ReadWrite, maskBitmap.PixelFormat);

            // Get the pointer to the image's raw data
            IntPtr ptr = bitmapData.Scan0;
            IntPtr ptrMask = bitmapDataMask.Scan0;

            // Calculate stride (the number of bytes in a row of the image)
            int stride = bitmapData.Stride;

            // For 32bpp ARGB
            int bytesPerPixel = 4; // ARGB format (4 bytes per pixel)

            // Create a buffer for pixel data
            byte[] pixels = new byte[stride * Height];
            byte[] pixelsMask = new byte[stride * Height];
            Marshal.Copy(ptr, pixels, 0, pixels.Length);
            Marshal.Copy(ptrMask, pixelsMask, 0, pixels.Length);

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    // Get the index of the pixel in the array
                    int pixelIndex = (y * stride) + (x * bytesPerPixel);

                    // Extract ARGB values
                    byte r = pixelsMask[pixelIndex + 2]; // Red
                    byte g = pixelsMask[pixelIndex + 1]; // Green
                    byte b = pixelsMask[pixelIndex];     // Blue

                    if (r == 255 && g == 255 && b == 255)
                    {
                        pixels[pixelIndex + 2] = 0;
                        pixels[pixelIndex + 1] = 0;
                        pixels[pixelIndex] = 0;
                    }
                    else
                    {
                        Counter++;
                    }

                }
            }

            Marshal.Copy(pixels, 0, ptr, pixels.Length);
            Marshal.Copy(pixelsMask, 0, ptrMask, pixelsMask.Length);

            // Unlock the bits
            originalBitmap.UnlockBits(bitmapData);
            maskBitmap.UnlockBits(bitmapDataMask);

            // توقف زمان‌سنجی
            stopwatch.Stop();

            // نمایش زمان طی شده
            Debug.WriteLine($"Time taken for processing: {stopwatch.ElapsedMilliseconds} ms");

            return originalBitmap;
        }
    }
}