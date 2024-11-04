namespace Presentation.Forms
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
            PicOrginal = new Telerik.WinControls.UI.RadPictureBox();
            DdlAlgorithms = new Telerik.WinControls.UI.RadDropDownList();
            BtnImport = new Telerik.WinControls.UI.RadButton();
            BtnStart = new Telerik.WinControls.UI.RadButton();
            lblConfig = new Telerik.WinControls.UI.RadLabel();
            OpenFileDialog = new Telerik.WinControls.UI.RadOpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PicOrginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DdlAlgorithms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // PicOrginal
            // 
            PicOrginal.Location = new System.Drawing.Point(194, 12);
            PicOrginal.Name = "PicOrginal";
            PicOrginal.Size = new System.Drawing.Size(250, 250);
            PicOrginal.TabIndex = 0;
            // 
            // DdlAlgorithms
            // 
            DdlAlgorithms.DropDownAnimationEnabled = true;
            DdlAlgorithms.Location = new System.Drawing.Point(12, 83);
            DdlAlgorithms.Name = "DdlAlgorithms";
            DdlAlgorithms.Size = new System.Drawing.Size(176, 24);
            DdlAlgorithms.TabIndex = 1;
            DdlAlgorithms.SelectedIndexChanged += DdlAlgorithms_SelectedIndexChanged;
            // 
            // BtnImport
            // 
            BtnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnImport.Location = new System.Drawing.Point(12, 21);
            BtnImport.Name = "BtnImport";
            BtnImport.Size = new System.Drawing.Size(176, 24);
            BtnImport.TabIndex = 2;
            BtnImport.Text = "Import";
            BtnImport.Click += BtnImport_Click;
            // 
            // BtnStart
            // 
            BtnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnStart.Location = new System.Drawing.Point(12, 202);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new System.Drawing.Size(176, 24);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "Start";
            BtnStart.Click += BtnStart_Click;
            // 
            // lblConfig
            // 
            lblConfig.Location = new System.Drawing.Point(12, 244);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new System.Drawing.Size(55, 18);
            lblConfig.TabIndex = 4;
            lblConfig.Text = "radLabel1";
            // 
            // MainForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(494, 276);
            Controls.Add(lblConfig);
            Controls.Add(BtnStart);
            Controls.Add(BtnImport);
            Controls.Add(DdlAlgorithms);
            Controls.Add(PicOrginal);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)PicOrginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)DdlAlgorithms).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadPictureBox PicOrginal;
        private Telerik.WinControls.UI.RadDropDownList DdlAlgorithms;
        private Telerik.WinControls.UI.RadButton BtnImport;
        private Telerik.WinControls.UI.RadButton BtnStart;
        private Telerik.WinControls.UI.RadLabel lblConfig;
        private Telerik.WinControls.UI.RadOpenFileDialog OpenFileDialog;
    }
}
