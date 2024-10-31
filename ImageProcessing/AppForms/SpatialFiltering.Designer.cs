namespace ImageProcessing.AppForms
{
    partial class SpatialFiltering
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
            TxtWidth = new TextBox();
            TxtHeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CboMatrix = new ComboBox();
            BtnGenerate = new Button();
            BtnStart = new Button();
            PicExport = new PictureBox();
            cboMethod = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicExport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtWidth
            // 
            TxtWidth.Location = new Point(58, 20);
            TxtWidth.MaxLength = 3;
            TxtWidth.Name = "TxtWidth";
            TxtWidth.Size = new Size(60, 23);
            TxtWidth.TabIndex = 0;
            TxtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtHeight
            // 
            TxtHeight.Location = new Point(58, 58);
            TxtHeight.MaxLength = 3;
            TxtHeight.Name = "TxtHeight";
            TxtHeight.Size = new Size(60, 23);
            TxtHeight.TabIndex = 1;
            TxtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Height";
            // 
            // CboMatrix
            // 
            CboMatrix.FormattingEnabled = true;
            CboMatrix.Location = new Point(13, 100);
            CboMatrix.Name = "CboMatrix";
            CboMatrix.Size = new Size(105, 23);
            CboMatrix.TabIndex = 4;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(13, 187);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(105, 23);
            BtnGenerate.TabIndex = 5;
            BtnGenerate.Text = "Gererate";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(13, 225);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(105, 23);
            BtnStart.TabIndex = 6;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // PicExport
            // 
            PicExport.Location = new Point(212, 12);
            PicExport.Name = "PicExport";
            PicExport.Size = new Size(400, 400);
            PicExport.SizeMode = PictureBoxSizeMode.Zoom;
            PicExport.TabIndex = 7;
            PicExport.TabStop = false;
            // 
            // cboMethod
            // 
            cboMethod.FormattingEnabled = true;
            cboMethod.Location = new Point(13, 144);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(105, 23);
            cboMethod.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // SpatialFiltering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 480);
            Controls.Add(pictureBox1);
            Controls.Add(cboMethod);
            Controls.Add(PicExport);
            Controls.Add(BtnStart);
            Controls.Add(BtnGenerate);
            Controls.Add(CboMatrix);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtHeight);
            Controls.Add(TxtWidth);
            Name = "SpatialFiltering";
            RightToLeft = RightToLeft.No;
            Text = "SpatialFiltering";
            ((System.ComponentModel.ISupportInitialize)PicExport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtWidth;
        private TextBox TxtHeight;
        private Label label1;
        private Label label2;
        private ComboBox CboMatrix;
        private Button BtnGenerate;
        private Button BtnStart;
        private PictureBox PicExport;
        private ComboBox cboMethod;
        private PictureBox pictureBox1;
    }
}