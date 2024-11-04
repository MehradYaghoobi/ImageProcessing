using ImageProcessing.Config;


namespace ImageProcessing.AppForms
{
    public partial class MainForm : Form
    {
        private readonly Managers.ServiceManager _serviceManager;
        public MainForm(Managers.ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            InitializeComponent();
            MainConfig.AlgorithmSet(ref cboAlgo);
            MainConfig.DisableAction(ref cboAlgo, ref BtnStart);
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
            Form form;
            Bitmap bmp = new(picOrginal.Image);
            switch (cboAlgo.SelectedItem?.ToString())
            {
                case "GrayScale":
                    form = new GrayScaleForm(bmp)
                    {
                        ImageGrayScaleService = _serviceManager.ImageGrayScaleService
                    };
                    form.Show();
                    break;

                case "Histogram":
                    form = new HistogramForm(bmp)
                    {
                        ImageHistogramService = _serviceManager.ImageHistogramService
                    };
                    form.Show();
                    break;


                case "HistogramEqualization":
                    form = new HistogramEqForm(bmp)
                    {
                        HisEqualizationService = _serviceManager.ImageHistogramEqualizationService
                    };
                    form.Show();
                    break;


                case "Negative":
                    form = new NegativeForm(bmp)
                    {
                        ImageNegativeService = _serviceManager.ImageNegativeService
                    };
                    form.Show();
                    break;


                case "Thresholding":
                    form = new ThresholdingForm(bmp)
                    {
                        ImageThresholdingService = _serviceManager.ImageThresholdingService
                    };
                    form.Show();
                    break;

                case "SpatialFiltering":
                    form = new SpatialFiltering(bmp)
                    {
                        ImageSpatialFilteringService = _serviceManager.ImageSpatialFilteringService
                    };
                    form.Show();
                    break;
            }
        }

        private void cboAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAlgo.SelectedItem.ToString() == "Thresholding" ||
                cboAlgo.SelectedItem.ToString() == "SpatialFiltering") BtnStart.Text = "Config";
            else BtnStart.Text = "Start";
        }
    }
}
