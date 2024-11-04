using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negative;
using Telerik.WinControls;

namespace Presentation.Forms
{
    public partial class NegativeForm : Telerik.WinControls.UI.RadForm
    {
        public IImageNegative ImageNegative { get; set; }
        public NegativeForm(Bitmap bmp)
        {
            InitializeComponent();
        }
    }
}
