using ImageProcessing.Algorithms;

namespace ImageProcessing.AppForms
{
    public partial class GrayScaleForm : Form
    {
         
        public GrayScaleForm(Bitmap bmp)
        {
            InitializeComponent();
            GrayScale gs = new(bmp);
            picGrayScale.Image = gs.GrayScaleBuilder();
        }
    }
}
