using ImageProcessing.Algorithms;

namespace ImageProcessing.AppForms
{
    public partial class SpatialFiltering : Form
    {
        public Bitmap Bmp;
        public TableLayoutPanel matrixPanel;
        public MatrixBuilder currentMatrix;
        public SpatialFiltering(Bitmap bmp)
        {
            InitializeComponent();
            Bmp = bmp;
            CboMatrix.Items.AddRange(new string[] { "Normal", "Lower Triangular", "Upper Triangular", "Diagonal", "Symmetric" });
            cboMethod.Items.AddRange(new string[] { "Median", "Sharpen" });

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
            currentMatrix.PopulateMatrix(matrixPanel);
            
            Algorithms.SpatialFiltering spatialFiltering = new(Bmp);
            if (cboMethod.Text == "Median")
            {
                PicExport.Image = spatialFiltering.SpatialFilteringMedianBuilder(matrixPanel);
            }
            else if (cboMethod.Text == "Sharpen")
            {
                PicExport.Image = spatialFiltering.SharprnSpatialFilteringBuilder(matrixPanel);
            }

            matrixPanel.Hide();
            pictureBox1.Hide();
            PicExport.Show();
            
        }

    }

}