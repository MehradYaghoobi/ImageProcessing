using ImageProcessing.Algorithms;

namespace ImageProcessing.AppForms
{
    public partial class NegativeForm : Form
    {
        public NegativeForm(Bitmap bmp)
        {
            InitializeComponent();

            Negative neg = new(bmp);
            neg.NegativeBuilder();
            picNegative.Image = bmp;
        }
    }
}
