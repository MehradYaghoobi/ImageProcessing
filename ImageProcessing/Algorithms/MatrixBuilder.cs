namespace ImageProcessing.Algorithms
{
    public class MatrixBuilder
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        public float[,] Data { get; set; }
        public string MatrixType { get; set; }

        public MatrixBuilder(int rows, int cols, string matrixType)
        {
            Rows = rows;
            Cols = cols;
            MatrixType = matrixType;
            Data = new float[rows, cols];
        }

        public bool IsOddDimension()
        {
            return Rows % 2 != 0 && Cols % 2 != 0;
        }

        public void GenerateMatrix(TableLayoutPanel matrixPanel)
        {
            matrixPanel.Controls.Clear();
            matrixPanel.RowCount = Rows;
            matrixPanel.ColumnCount = Cols;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    var cell = new TextBox { Width = 50, Height = 20, Margin = new Padding(1) };
                    bool isEnabled = true;
                    if ((MatrixType == "Lower Triangular" && j > i) ||
                        (MatrixType == "Upper Triangular" && j < i) ||
                        (MatrixType == "Diagonal" && j != i) ||
                        (MatrixType == "Symmetric" && j < i))
                    {
                        isEnabled = false;
                        cell.Text = "0";
                    }

                    cell.Enabled = isEnabled;
                    matrixPanel.Controls.Add(cell, j, i);
                }
            }
        }

        public void PopulateMatrix(TableLayoutPanel matrixPanel)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    var cell = (TextBox)matrixPanel.GetControlFromPosition(j, i)!;
                    Data[i, j] = float.Parse(cell.Text);
                    if (MatrixType == "Symmetric" && j > i)
                    {
                        var symmetricCell = (TextBox)matrixPanel.GetControlFromPosition(i, j);
                        symmetricCell.Text = cell.Text;
                    }
                }
            }
        }

        public int[,] ConvertTableLayoutPanelToMatrix(TableLayoutPanel panel)
        {
            int rows = panel.RowCount;
            int cols = panel.ColumnCount;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var cell = panel.GetControlFromPosition(j, i) as TextBox;
                    if (cell != null && int.TryParse(cell.Text, out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}