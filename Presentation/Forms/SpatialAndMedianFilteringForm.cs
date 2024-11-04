using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpatialFiltering;
using Telerik.WinControls;

namespace Presentation.Forms
{
    public partial class SpatialAndMedianFilteringForm : Telerik.WinControls.UI.RadForm
    {
        public IImageSpatialFiltering ImageSpatialFiltering { get; set; }
        public SpatialAndMedianFilteringForm(Bitmap bmp)
        {
            InitializeComponent();
        }
    }
}
