using ImageProcessing.Algorithms;

namespace ImageProcessing.AppForms
{
    public partial class ThresholdingForm : Form
    {
        public Bitmap Bmp;
        public ThresholdingForm(Bitmap bmp)
        {
            InitializeComponent();
            Bmp = bmp;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Bitmap[] bmpExport;
            Thresholding thresh = new(Bmp);
            bmpExport = thresh.ColorThresholding(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
            picRBG.Image = bmpExport[0];
            picGray.Image = bmpExport[1];

        }

        //----------------------------------------------------------------------------------------

        private void TrbRed_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrbRed.Value.ToString();
        }

        private void TrbGreen_Scroll(object sender, EventArgs e)
        {
            TxtGreen.Text = TrbGreen.Value.ToString();
        }

        private void TrbBlue_Scroll(object sender, EventArgs e)
        {
            TxtBlue.Text = TrbBlue.Value.ToString();
        }

        private void TxtRed_TextChanged(object sender, EventArgs e)
        {
            TrbRed.Value = int.Parse(TxtRed.Text);
        }

        private void TxtGreen_TextChanged(object sender, EventArgs e)
        {
            TrbGreen.Value = int.Parse(TxtGreen.Text);
        }

        private void TxtBlue_TextChanged(object sender, EventArgs e)
        {
            TrbBlue.Value = int.Parse(TxtBlue.Text);
        }

        private void TxtRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void TxtGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void TxtBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }


    }
}
