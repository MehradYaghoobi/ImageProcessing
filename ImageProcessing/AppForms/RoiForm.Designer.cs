namespace ImageProcessing.AppForms
{
    partial class RoiForm
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
            picROI = new PictureBox();
            btnClear = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picROI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picROI
            // 
            picROI.BackColor = Color.White;
            picROI.Location = new Point(14, 14);
            picROI.Margin = new Padding(5);
            picROI.Name = "picROI";
            picROI.Size = new Size(500, 500);
            picROI.SizeMode = PictureBoxSizeMode.StretchImage;
            picROI.TabIndex = 1;
            picROI.TabStop = false;
            picROI.MouseDown += picROI_MouseDown;
            picROI.MouseMove += picROI_MouseMove;
            picROI.MouseUp += picROI_MouseUp;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(14, 522);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(95, 522);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(524, 14);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // RoiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 557);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(picROI);
            Name = "RoiForm";
            Text = "RoiForm";
            ((System.ComponentModel.ISupportInitialize)picROI).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picROI;
        private Button btnClear;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}