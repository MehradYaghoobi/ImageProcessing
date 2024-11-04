using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Thresholding;

namespace Presentation.Forms
{
    public partial class ThresholdingForm : Telerik.WinControls.UI.RadForm
    {
        public IImageThresholding ImageThresholding { get; set; }
        public ThresholdingForm(Bitmap bmp)
        {
            InitializeComponent();
        }
    }
}
