namespace ImageProcessing.AppForms
{
    partial class ThresholdingForm
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
            picRBG = new PictureBox();
            picGray = new PictureBox();
            TrbRed = new TrackBar();
            TrbGreen = new TrackBar();
            TrbBlue = new TrackBar();
            TxtRed = new TextBox();
            TxtGreen = new TextBox();
            TxtBlue = new TextBox();
            BtnRun = new Button();
            ((System.ComponentModel.ISupportInitialize)picRBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbBlue).BeginInit();
            SuspendLayout();
            // 
            // picRBG
            // 
            picRBG.Location = new Point(12, 12);
            picRBG.Name = "picRBG";
            picRBG.Size = new Size(300, 300);
            picRBG.SizeMode = PictureBoxSizeMode.Zoom;
            picRBG.TabIndex = 0;
            picRBG.TabStop = false;
            // 
            // picGray
            // 
            picGray.Location = new Point(318, 12);
            picGray.Name = "picGray";
            picGray.Size = new Size(300, 300);
            picGray.SizeMode = PictureBoxSizeMode.Zoom;
            picGray.TabIndex = 1;
            picGray.TabStop = false;
            // 
            // TrbRed
            // 
            TrbRed.Location = new Point(624, 46);
            TrbRed.Maximum = 255;
            TrbRed.Minimum = 1;
            TrbRed.Name = "TrbRed";
            TrbRed.Size = new Size(131, 45);
            TrbRed.TabIndex = 2;
            TrbRed.Value = 1;
            TrbRed.Scroll += TrbRed_Scroll;
            // 
            // TrbGreen
            // 
            TrbGreen.Location = new Point(624, 124);
            TrbGreen.Maximum = 255;
            TrbGreen.Minimum = 1;
            TrbGreen.Name = "TrbGreen";
            TrbGreen.Size = new Size(131, 45);
            TrbGreen.TabIndex = 3;
            TrbGreen.Value = 1;
            TrbGreen.Scroll += TrbGreen_Scroll;
            // 
            // TrbBlue
            // 
            TrbBlue.Location = new Point(624, 198);
            TrbBlue.Maximum = 255;
            TrbBlue.Minimum = 1;
            TrbBlue.Name = "TrbBlue";
            TrbBlue.Size = new Size(131, 45);
            TrbBlue.TabIndex = 4;
            TrbBlue.Value = 1;
            TrbBlue.Scroll += TrbBlue_Scroll;
            // 
            // TxtRed
            // 
            TxtRed.BorderStyle = BorderStyle.None;
            TxtRed.Location = new Point(674, 79);
            TxtRed.MaxLength = 3;
            TxtRed.Name = "TxtRed";
            TxtRed.PlaceholderText = "Red";
            TxtRed.Size = new Size(35, 16);
            TxtRed.TabIndex = 5;
            TxtRed.TextAlign = HorizontalAlignment.Center;
            TxtRed.TextChanged += TxtRed_TextChanged;
            TxtRed.KeyPress += TxtRed_KeyPress;
            // 
            // TxtGreen
            // 
            TxtGreen.BorderStyle = BorderStyle.None;
            TxtGreen.Location = new Point(674, 156);
            TxtGreen.MaxLength = 3;
            TxtGreen.Name = "TxtGreen";
            TxtGreen.PlaceholderText = "Green";
            TxtGreen.Size = new Size(35, 16);
            TxtGreen.TabIndex = 6;
            TxtGreen.TextAlign = HorizontalAlignment.Center;
            TxtGreen.TextChanged += TxtGreen_TextChanged;
            TxtGreen.KeyPress += TxtGreen_KeyPress;
            // 
            // TxtBlue
            // 
            TxtBlue.BorderStyle = BorderStyle.None;
            TxtBlue.Location = new Point(674, 230);
            TxtBlue.MaxLength = 3;
            TxtBlue.Name = "TxtBlue";
            TxtBlue.PlaceholderText = "Blue";
            TxtBlue.Size = new Size(35, 16);
            TxtBlue.TabIndex = 7;
            TxtBlue.TextAlign = HorizontalAlignment.Center;
            TxtBlue.TextChanged += TxtBlue_TextChanged;
            TxtBlue.KeyPress += TxtBlue_KeyPress;
            // 
            // BtnRun
            // 
            BtnRun.Location = new Point(639, 270);
            BtnRun.Name = "BtnRun";
            BtnRun.Size = new Size(100, 30);
            BtnRun.TabIndex = 8;
            BtnRun.Text = "Run";
            BtnRun.UseVisualStyleBackColor = true;
            BtnRun.Click += BtnRun_Click;
            // 
            // ThresholdingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 326);
            Controls.Add(BtnRun);
            Controls.Add(TxtBlue);
            Controls.Add(TxtGreen);
            Controls.Add(TxtRed);
            Controls.Add(TrbBlue);
            Controls.Add(TrbGreen);
            Controls.Add(TrbRed);
            Controls.Add(picGray);
            Controls.Add(picRBG);
            Name = "ThresholdingForm";
            Text = "ThresholdingForm";
            ((System.ComponentModel.ISupportInitialize)picRBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRBG;
        private PictureBox picGray;
        private TrackBar TrbRed;
        private TrackBar TrbGreen;
        private TrackBar TrbBlue;
        private TextBox TxtRed;
        private TextBox TxtGreen;
        private TextBox TxtBlue;
        private Button BtnRun;
    }
}