﻿namespace ImageProcessing.AppForms
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
            ChkROI = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picOrginal).BeginInit();
            SuspendLayout();
            // 
            // picOrginal
            // 
            picOrginal.BackColor = Color.White;
            picOrginal.Location = new Point(200, 14);
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
            lblOrginal.Location = new Point(146, 299);
            lblOrginal.Name = "lblOrginal";
            lblOrginal.Size = new Size(46, 15);
            lblOrginal.TabIndex = 1;
            lblOrginal.Text = "Orginal";
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(12, 266);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(180, 30);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnImport
            // 
            BtnImport.Location = new Point(12, 31);
            BtnImport.Name = "BtnImport";
            BtnImport.Size = new Size(180, 30);
            BtnImport.TabIndex = 3;
            BtnImport.Text = "Import";
            BtnImport.UseVisualStyleBackColor = true;
            BtnImport.Click += BtnImport_Click;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(12, 200);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(180, 30);
            BtnStart.TabIndex = 5;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // cboAlgo
            // 
            cboAlgo.FormattingEnabled = true;
            cboAlgo.Location = new Point(12, 84);
            cboAlgo.Name = "cboAlgo";
            cboAlgo.Size = new Size(180, 23);
            cboAlgo.TabIndex = 6;
            cboAlgo.SelectedIndexChanged += cboAlgo_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // ChkROI
            // 
            ChkROI.AutoSize = true;
            ChkROI.Location = new Point(12, 113);
            ChkROI.Name = "ChkROI";
            ChkROI.Size = new Size(79, 19);
            ChkROI.TabIndex = 7;
            ChkROI.Text = "Select ROI";
            ChkROI.UseVisualStyleBackColor = true;
            ChkROI.CheckedChanged += ChkROI_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(514, 342);
            Controls.Add(ChkROI);
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
        private CheckBox ChkROI;
    }
}