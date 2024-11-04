using ImageProcessing.Algorithms;
using SpatialFiltering;
using System.Windows.Forms;

namespace ImageProcessing.AppForms
{
    public partial class SpatialFiltering : Form
    {
        public IImageSpatialFiltering ImageSpatialFilteringService { get; set; }
        public Bitmap bitmap;
        public TableLayoutPanel matrixPanel;
        public MatrixBuilder currentMatrix;
        public SpatialFiltering(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            CboMatrix.Items.AddRange(new string[] { "Normal", "Lower Triangular", "Upper Triangular", "Diagonal", "Symmetric" });
            cboMethod.Items.AddRange(new string[] { "Median", "Spatial" });

            matrixPanel = new TableLayoutPanel { Left = 140, Top = 10, Width = 760, Height = 400, AutoSize = true };
            this.Controls.Add(matrixPanel);
            PicExport.Hide();

        }


        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            PicExport.Hide();
            int rows = int.Parse(TxtWidth.Text);
            int cols = int.Parse(TxtWidth.Text);
            string matrixType = CboMatrix.SelectedItem.ToString();

            currentMatrix = new MatrixBuilder(rows, cols, matrixType);

            if (!currentMatrix.IsOddDimension())
            {
                MessageBox.Show("The number of rows and columns must be odd.");
                return;
            }

            currentMatrix.GenerateMatrix(matrixPanel);
            pictureBox1.Image = Image.FromFile(@"Images\5-5Sharp.png");

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            
            if (cboMethod.Text == "Median")
            {
                int numberOfRows = int.Parse(TxtHeight.Text.ToString());
                int numberOfColumns = int.Parse(TxtWidth.Text.ToString());
                PicExport.Image = ImageSpatialFilteringService.MedianFilterProcessor(bitmap, numberOfColumns,numberOfRows);
            }
            else if (cboMethod.Text == "Spatial")
            {
                currentMatrix.PopulateMatrix(matrixPanel);
                int[,] matrix = currentMatrix.ConvertTableLayoutPanelToMatrix(matrixPanel);
                PicExport.Image = ImageSpatialFilteringService.SharpenSpatialFilteringProcessor(bitmap, matrix);
            }

            matrixPanel.Hide();
            pictureBox1.Hide();
            PicExport.Show();

        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMethod.SelectedItem.ToString() == "Median")
            {
                BtnGenerate.Enabled = false;
                CboMatrix.Enabled = false;
            }
            else
            {
                BtnGenerate.Enabled = true;
                CboMatrix.Enabled = true;
            }
        }
    }

}