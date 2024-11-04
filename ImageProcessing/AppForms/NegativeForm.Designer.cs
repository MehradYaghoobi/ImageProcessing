namespace ImageProcessing.AppForms
{
    partial class NegativeForm
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
            picNegative = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picNegative).BeginInit();
            SuspendLayout();
            // 
            // picNegative
            // 
            picNegative.Location = new Point(12, 12);
            picNegative.Name = "picNegative";
            picNegative.Size = new Size(300, 300);
            picNegative.SizeMode = PictureBoxSizeMode.Zoom;
            picNegative.TabIndex = 0;
            picNegative.TabStop = false;
            // 
            // NegativeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 324);
            Controls.Add(picNegative);
            Name = "NegativeForm";
            Text = "NegativeForm";
            Load += NegativeForm_Load;
            ((System.ComponentModel.ISupportInitialize)picNegative).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picNegative;
    }
}