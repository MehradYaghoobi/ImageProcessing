namespace Presentation.Forms
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
            PicGrayScale = new Telerik.WinControls.UI.RadPictureBox();
            ((System.ComponentModel.ISupportInitialize)PicGrayScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // PicGrayScale
            // 
            PicGrayScale.Location = new System.Drawing.Point(12, 12);
            PicGrayScale.Name = "PicGrayScale";
            PicGrayScale.Size = new System.Drawing.Size(300, 300);
            PicGrayScale.TabIndex = 0;
            // 
            // GrayScaleForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(338, 293);
            Controls.Add(PicGrayScale);
            Name = "GrayScaleForm";
            Text = "GrayScaleForm";
            ((System.ComponentModel.ISupportInitialize)PicGrayScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadPictureBox PicGrayScale;
    }
}
