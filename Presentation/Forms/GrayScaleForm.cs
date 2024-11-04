using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrayScale;
using Telerik.WinControls;

namespace Presentation.Forms
{
    public partial class GrayScaleForm : Telerik.WinControls.UI.RadForm
    {
        public IImageGrayScale ImageGrayScaleService { get; set; }

        public GrayScaleForm(Bitmap bmp)
        {
            InitializeComponent();
            PicGrayScale.Image = ImageGrayScaleService.GrayScaleProcessor(bmp);
        }


    }
}
