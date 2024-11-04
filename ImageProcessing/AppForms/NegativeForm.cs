using ImageProcessing.Algorithms;
using Negative;

namespace ImageProcessing.AppForms
{
    public partial class NegativeForm : Form
    {
        public IImageNegative ImageNegativeService { get; set; }
        private Bitmap bitmap;
        public NegativeForm(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            //Negative neg = new(bmp);
            //neg.NegativeBuilder();
            //picNegative.Image = bmp;
        }

        private void NegativeForm_Load(object sender, EventArgs e)
        {
            picNegative.Image = ImageNegativeService.NegativeBuilder(bitmap);
        }
    }
}
