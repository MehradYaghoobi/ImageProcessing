using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HistogramEqualization;
using Telerik.WinControls;

namespace Presentation.Forms
{
    public partial class HistogramEqForm : Telerik.WinControls.UI.RadForm
    {
        public IImageHistogramEqualization ImageHistogramEqualization { get; set; }
        public HistogramEqForm(Bitmap bmp)
        {
            InitializeComponent();
        }
    }
}
