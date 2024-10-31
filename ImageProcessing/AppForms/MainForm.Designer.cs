namespace ImageProcessing.AppForms
{
    partial class MainForm
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
            picOrginal = new PictureBox();
            lblOrginal = new Label();
            BtnExit = new Button();
            BtnImport = new Button();
            BtnStart = new Button();
            cboAlgo = new ComboBox();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picOrginal).BeginInit();
            SuspendLayout();
            // 
            // picOrginal
            // 
            picOrginal.BackColor = Color.Gray;
            picOrginal.Location = new Point(0, 0);
            picOrginal.Margin = new Padding(5);
            picOrginal.Name = "picOrginal";
            picOrginal.Size = new Size(300, 300);
            picOrginal.SizeMode = PictureBoxSizeMode.Zoom;
            picOrginal.TabIndex = 0;
            picOrginal.TabStop = false;
            // 
            // lblOrginal
            // 
            lblOrginal.AutoSize = true;
            lblOrginal.Location = new Point(12, 305);
            lblOrginal.Name = "lblOrginal";
            lblOrginal.Size = new Size(46, 15);
            lblOrginal.TabIndex = 1;
            lblOrginal.Text = "Orginal";
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(329, 290);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(100, 30);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnImport
            // 
            BtnImport.Location = new Point(329, 27);
            BtnImport.Name = "BtnImport";
            BtnImport.Size = new Size(100, 30);
            BtnImport.TabIndex = 3;
            BtnImport.Text = "Import";
            BtnImport.UseVisualStyleBackColor = true;
            BtnImport.Click += BtnImport_Click;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(329, 152);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(100, 30);
            BtnStart.TabIndex = 5;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // cboAlgo
            // 
            cboAlgo.FormattingEnabled = true;
            cboAlgo.Location = new Point(308, 90);
            cboAlgo.Name = "cboAlgo";
            cboAlgo.Size = new Size(141, 23);
            cboAlgo.TabIndex = 6;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(458, 342);
            Controls.Add(cboAlgo);
            Controls.Add(BtnStart);
            Controls.Add(BtnImport);
            Controls.Add(BtnExit);
            Controls.Add(lblOrginal);
            Controls.Add(picOrginal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)picOrginal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOrginal;
        private Label lblOrginal;
        private Button BtnExit;
        private Button BtnImport;
        private Button BtnStart;
        private ComboBox cboAlgo;
        private OpenFileDialog openFileDialog;
    }
}