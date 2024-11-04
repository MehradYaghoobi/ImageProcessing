namespace ImageProcessing.AppForms
{
    partial class HistogramEqForm
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
            chtBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            picEq = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chtBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEq).BeginInit();
            SuspendLayout();
            // 
            // chtBlue
            // 
            chartArea1.Name = "ChartArea1";
            chtBlue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtBlue.Legends.Add(legend1);
            chtBlue.Location = new Point(724, 329);
            chtBlue.Name = "chtBlue";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Blue";
            chtBlue.Series.Add(series1);
            chtBlue.Size = new Size(350, 250);
            chtBlue.TabIndex = 11;
            chtBlue.Text = "chart3";
            // 
            // chtGreen
            // 
            chartArea2.Name = "ChartArea1";
            chtGreen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chtGreen.Legends.Add(legend2);
            chtGreen.Location = new Point(368, 329);
            chtGreen.Name = "chtGreen";
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            chtGreen.Series.Add(series2);
            chtGreen.Size = new Size(350, 250);
            chtGreen.TabIndex = 10;
            chtGreen.Text = "chart2";
            // 
            // chtRed
            // 
            chartArea3.Name = "ChartArea1";
            chtRed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chtRed.Legends.Add(legend3);
            chtRed.Location = new Point(12, 329);
            chtRed.Name = "chtRed";
            series3.ChartArea = "ChartArea1";
            series3.Color = Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Red";
            chtRed.Series.Add(series3);
            chtRed.Size = new Size(350, 250);
            chtRed.TabIndex = 9;
            chtRed.Text = "chart1";
            // 
            // picEq
            // 
            picEq.Location = new Point(396, 12);
            picEq.Name = "picEq";
            picEq.Size = new Size(300, 300);
            picEq.SizeMode = PictureBoxSizeMode.Zoom;
            picEq.TabIndex = 12;
            picEq.TabStop = false;
            // 
            // HistogramEqForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 594);
            Controls.Add(picEq);
            Controls.Add(chtBlue);
            Controls.Add(chtGreen);
            Controls.Add(chtRed);
            Name = "HistogramEqForm";
            Text = "HistogramEqForm";
            Load += HistogramEqForm_Load;
            ((System.ComponentModel.ISupportInitialize)chtBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEq).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRed;
        private PictureBox picEq;
    }
}