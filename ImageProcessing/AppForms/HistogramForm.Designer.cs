namespace ImageProcessing.AppForms
{
    partial class HistogramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            picRed = new PictureBox();
            picGreen = new PictureBox();
            picBlue = new PictureBox();
            chtRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)picRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtBlue).BeginInit();
            SuspendLayout();
            // 
            // picRed
            // 
            picRed.Location = new Point(12, 12);
            picRed.Name = "picRed";
            picRed.Size = new Size(300, 300);
            picRed.SizeMode = PictureBoxSizeMode.Zoom;
            picRed.TabIndex = 0;
            picRed.TabStop = false;
            // 
            // picGreen
            // 
            picGreen.Location = new Point(405, 12);
            picGreen.Name = "picGreen";
            picGreen.Size = new Size(300, 300);
            picGreen.SizeMode = PictureBoxSizeMode.Zoom;
            picGreen.TabIndex = 1;
            picGreen.TabStop = false;
            // 
            // picBlue
            // 
            picBlue.Location = new Point(784, 12);
            picBlue.Name = "picBlue";
            picBlue.Size = new Size(300, 300);
            picBlue.SizeMode = PictureBoxSizeMode.Zoom;
            picBlue.TabIndex = 2;
            picBlue.TabStop = false;
            // 
            // chtRed
            // 
            chartArea1.Name = "ChartArea1";
            chtRed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtRed.Legends.Add(legend1);
            chtRed.Location = new Point(12, 329);
            chtRed.Name = "chtRed";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            chtRed.Series.Add(series1);
            chtRed.Size = new Size(350, 250);
            chtRed.TabIndex = 3;
            chtRed.Text = "chart1";
            // 
            // chtGreen
            // 
            chartArea2.Name = "ChartArea1";
            chtGreen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chtGreen.Legends.Add(legend2);
            chtGreen.Location = new Point(373, 329);
            chtGreen.Name = "chtGreen";
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            chtGreen.Series.Add(series2);
            chtGreen.Size = new Size(350, 250);
            chtGreen.TabIndex = 4;
            chtGreen.Text = "chart2";
            // 
            // chtBlue
            // 
            chartArea3.Name = "ChartArea1";
            chtBlue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chtBlue.Legends.Add(legend3);
            chtBlue.Location = new Point(734, 329);
            chtBlue.Name = "chtBlue";
            series3.ChartArea = "ChartArea1";
            series3.Color = Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            chtBlue.Series.Add(series3);
            chtBlue.Size = new Size(350, 250);
            chtBlue.TabIndex = 5;
            chtBlue.Text = "chart3";
            // 
            // HistogramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 585);
            Controls.Add(chtBlue);
            Controls.Add(chtGreen);
            Controls.Add(chtRed);
            Controls.Add(picBlue);
            Controls.Add(picGreen);
            Controls.Add(picRed);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "HistogramForm";
            ShowIcon = false;
            Text = "HistogramForm";
            Load += HistogramForm_Load;
            ((System.ComponentModel.ISupportInitialize)picRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtBlue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picRed;
        private PictureBox picGreen;
        private PictureBox picBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBlue;
    }
}