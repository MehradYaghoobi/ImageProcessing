using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Histogram;
using Telerik.WinControls;

namespace Presentation.Forms
{
    public partial class HistogramForm : Telerik.WinControls.UI.RadForm
    {
        public IImageHistogram ImageHistogram { get; set; }
        public HistogramForm(Bitmap bmp)
        {
            InitializeComponent();
        }
    }
}
