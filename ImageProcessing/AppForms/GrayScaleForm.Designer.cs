namespace ImageProcessing.AppForms
{
    partial class GrayScaleForm
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
            picGrayScale = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGrayScale).BeginInit();
            SuspendLayout();
            // 
            // picGrayScale
            // 
            picGrayScale.Location = new Point(12, 12);
            picGrayScale.Name = "picGrayScale";
            picGrayScale.Size = new Size(300, 300);
            picGrayScale.SizeMode = PictureBoxSizeMode.Zoom;
            picGrayScale.TabIndex = 0;
            picGrayScale.TabStop = false;
            // 
            // GrayScaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 321);
            Controls.Add(picGrayScale);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "GrayScaleForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrayScale";
            ((System.ComponentModel.ISupportInitialize)picGrayScale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGrayScale;
    }
}