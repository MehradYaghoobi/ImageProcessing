using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static Presentation.Managers;

namespace Presentation.Forms
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private readonly ServiceManager _serviceManager;
        public MainForm(ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;

            InitializeComponent();
            MainConfig.AlgorithmSet(ref DdlAlgorithms);
            MainConfig.DisableAction(ref DdlAlgorithms, ref BtnStart);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            MainConfig.ImageImprot(ref OpenFileDialog, ref PicOrginal);
            MainConfig.EnableAction(ref DdlAlgorithms, ref BtnStart);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new(PicOrginal.Image);
            RadForm form;
            switch (DdlAlgorithms.SelectedItem.Text)
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
                        ImageHistogram = _serviceManager.ImageHistogramService
                    };
                    form.Show();
                    break;


                case "HistogramEqualization":
                    form = new HistogramEqForm(bmp)
                    {
                        ImageHistogramEqualization = _serviceManager.ImageHistogramEqualizationService
                    };
                    form.Show();
                    break;


                case "Negative":
                    form = new NegativeForm(bmp)
                    {
                        ImageNegative = _serviceManager.ImageNegativeService
                    };
                    form.Show();
                    break;


                case "Thresholding":
                    form = new ThresholdingForm(bmp)
                    {
                        ImageThresholding = _serviceManager.ImageThresholdingService
                    };
                    form.Show();
                    break;

                case "SpatialFiltering":
                     form = new SpatialAndMedianFilteringForm(bmp)
                    {
                        ImageSpatialFiltering = _serviceManager.ImageSpatialFilteringService
                    };
                    form.Show();
                    break;
            }
        }

        private void DdlAlgorithms_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (DdlAlgorithms.SelectedItem.Text == "Thresholding" ||
                DdlAlgorithms.SelectedItem.Text == "SpatialFiltering") BtnStart.Text = "Config";
            else BtnStart.Text = "Start";
        }

    }
}
