﻿namespace ImageProcessing.Config
{
    public class MainConfig
    {
        public enum Algorithm
        {
            GrayScale, Histogram, HistogramEqualization, Negative, Thresholding, SpatialFiltering
        }

        public static void ImageImprot(ref OpenFileDialog file, ref PictureBox pic)
        {

            file.Title = "Select a Picture";
            file.Filter = "Image Files (*.bmp, *.gif, *.jpg, *.png)|*.bmp; *.gif*;*.jpg;,*.png;";
            file.InitialDirectory = "C:";

            DialogResult dialogResult = file.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                file.AddExtension = true;
                file.CheckFileExists = true;
                file.CheckPathExists = true;
                pic.Image = Image.FromFile(file.FileName);
            }
        }

        public static void EnableAction(ref ComboBox cbo, ref Button btn)
        {
            cbo.Enabled = true;
            btn.Enabled = true;
        }

        public static void DisableAction(ref ComboBox cbo, ref Button btn1)
        {
            cbo.Enabled = false;
            btn1.Enabled = false;
        }

        public static void AlgorithmSet(ref ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(Algorithm));
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
