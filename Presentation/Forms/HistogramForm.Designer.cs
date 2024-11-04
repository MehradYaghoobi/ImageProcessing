namespace Presentation.Forms
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
            Telerik.WinControls.UI.CartesianArea cartesianArea4 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            PicRed = new Telerik.WinControls.UI.RadPictureBox();
            PicGreen = new Telerik.WinControls.UI.RadPictureBox();
            radPictureBox3 = new Telerik.WinControls.UI.RadPictureBox();
            RedChart = new Telerik.WinControls.UI.RadChartView();
            GreenChart = new Telerik.WinControls.UI.RadChartView();
            BlueChart = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)PicRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // PicRed
            // 
            PicRed.Location = new System.Drawing.Point(12, 12);
            PicRed.Name = "PicRed";
            PicRed.Size = new System.Drawing.Size(311, 272);
            PicRed.TabIndex = 0;
            // 
            // PicGreen
            // 
            PicGreen.Location = new System.Drawing.Point(656, 95);
            PicGreen.Name = "PicGreen";
            PicGreen.Size = new System.Drawing.Size(100, 100);
            PicGreen.TabIndex = 1;
            // 
            // radPictureBox3
            // 
            radPictureBox3.Location = new System.Drawing.Point(877, 130);
            radPictureBox3.Name = "radPictureBox3";
            radPictureBox3.Size = new System.Drawing.Size(100, 100);
            radPictureBox3.TabIndex = 2;
            // 
            // RedChart
            // 
            RedChart.AreaDesign = cartesianArea4;
            RedChart.Location = new System.Drawing.Point(12, 305);
            RedChart.Name = "RedChart";
            RedChart.ShowGrid = false;
            RedChart.Size = new System.Drawing.Size(300, 200);
            RedChart.TabIndex = 3;
            // 
            // GreenChart
            // 
            GreenChart.AreaDesign = cartesianArea1;
            GreenChart.Location = new System.Drawing.Point(375, 305);
            GreenChart.Name = "GreenChart";
            GreenChart.ShowGrid = false;
            GreenChart.Size = new System.Drawing.Size(300, 200);
            GreenChart.TabIndex = 4;
            // 
            // BlueChart
            // 
            BlueChart.AreaDesign = cartesianArea2;
            BlueChart.Location = new System.Drawing.Point(724, 305);
            BlueChart.Name = "BlueChart";
            BlueChart.ShowGrid = false;
            BlueChart.Size = new System.Drawing.Size(300, 200);
            BlueChart.TabIndex = 5;
            // 
            // HistogramForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1213, 505);
            Controls.Add(BlueChart);
            Controls.Add(GreenChart);
            Controls.Add(RedChart);
            Controls.Add(radPictureBox3);
            Controls.Add(PicGreen);
            Controls.Add(PicRed);
            Name = "HistogramForm";
            Text = "HistogramForm";
            ((System.ComponentModel.ISupportInitialize)PicRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadPictureBox PicRed;
        private Telerik.WinControls.UI.RadPictureBox PicGreen;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox3;
        private Telerik.WinControls.UI.RadChartView RedChart;
        private Telerik.WinControls.UI.RadChartView GreenChart;
        private Telerik.WinControls.UI.RadChartView BlueChart;
    }
}
