using ImageProcessing.Config;


namespace ImageProcessing.AppForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainConfig.AlgorithmSet(ref cboAlgo);
            MainConfig.DisableAction(ref cboAlgo, ref BtnStart, ref BtnConfig);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            MainConfig.ImageImprot(ref openFileDialog, ref picOrginal);
            MainConfig.EnableAction(ref cboAlgo, ref BtnStart);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new(picOrginal.Image);
            switch (cboAlgo.SelectedIndex)
            {
                case 0:
                    GrayScaleForm gsf = new(bmp);
                    gsf.Show();
                    break;

                case 1:
                    HistogramForm hisF = new(bmp);
                    hisF.Show();
                    break;


                case 2:
                    HistogramEqForm hisEq = new(bmp);
                    hisEq.Show();
                    break;


                case 3:
                    NegativeForm neg = new(bmp);
                    neg.Show();
                    break;


                case 4:
                    ThresholdingForm threshold = new(bmp);
                    threshold.Show();
                    break;
            }
        }
    }
}
