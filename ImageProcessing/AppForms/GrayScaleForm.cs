using GrayScale;
using ImageProcessing.Algorithms;

namespace ImageProcessing.AppForms
{
    public partial class GrayScaleForm : Form
    {
        public IImageGrayScale ImageGrayScaleService { get; set; }
        private Bitmap bitmap;
        public GrayScaleForm(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
        }

        private void GrayScaleForm_Load(object sender, EventArgs e)
        { 
            picGrayScale.Image = ImageGrayScaleService.GrayScaleProcessor(bitmap);
        }
    }
}
