using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Presentation;

public class MainConfig
{
    public enum Algorithm
    {
        GrayScale, Histogram, HistogramEqualization, Negative, Thresholding, SpatialFiltering
    }

    public static void ImageImprot(ref RadOpenFileDialog file, ref RadPictureBox pic)
    {

        file.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png;";

        if (file.ShowDialog() == DialogResult.OK)
        {
            pic.Image = Image.FromFile(file.FileName);
        }
    }

    public static void EnableAction(ref RadDropDownList cbo, ref RadButton btn)
    {
        cbo.Enabled = true;
        btn.Enabled = true;
    }

    public static void DisableAction(ref RadDropDownList cbo, ref RadButton btn1)
    {
        cbo.Enabled = false;
        btn1.Enabled = false;
    }

    public static void AlgorithmSet(ref RadDropDownList cbo)
    {
        cbo.DataSource = Enum.GetValues(typeof(Algorithm));
        cbo.DropDownStyle = RadDropDownStyle.DropDownList;
    }


}