namespace GameAttempt.Components
{
    partial class LoadingScreenUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreenUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpLoading = new AxWMPLib.AxWindowsMediaPlayer();
            this.panLoadingBar = new System.Windows.Forms.Panel();
            this.lblLoadingPertge = new System.Windows.Forms.Label();
            this.timrLoadingBar = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoading)).BeginInit();
            this.panLoadingBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoadingPertge);
            this.panel1.Controls.Add(this.wmpLoading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 455);
            this.panel1.TabIndex = 0;
            // 
            // wmpLoading
            // 
            this.wmpLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpLoading.Enabled = true;
            this.wmpLoading.Location = new System.Drawing.Point(0, 0);
            this.wmpLoading.Name = "wmpLoading";
            this.wmpLoading.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLoading.OcxState")));
            this.wmpLoading.Size = new System.Drawing.Size(702, 455);
            this.wmpLoading.TabIndex = 0;
            // 
            // panLoadingBar
            // 
            this.panLoadingBar.Controls.Add(this.pbLoading);
            this.panLoadingBar.Location = new System.Drawing.Point(87, 461);
            this.panLoadingBar.Name = "panLoadingBar";
            this.panLoadingBar.Size = new System.Drawing.Size(512, 32);
            this.panLoadingBar.TabIndex = 1;
            // 
            // lblLoadingPertge
            // 
            this.lblLoadingPertge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadingPertge.AutoSize = true;
            this.lblLoadingPertge.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingPertge.Font = new System.Drawing.Font("Snap ITC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingPertge.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoadingPertge.Location = new System.Drawing.Point(321, 429);
            this.lblLoadingPertge.Name = "lblLoadingPertge";
            this.lblLoadingPertge.Size = new System.Drawing.Size(63, 29);
            this.lblLoadingPertge.TabIndex = 0;
            this.lblLoadingPertge.Text = "0 %";
            this.lblLoadingPertge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timrLoadingBar
            // 
            this.timrLoadingBar.Interval = 240;
            this.timrLoadingBar.Tick += new System.EventHandler(this.timrLoadingBar_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.ForeColor = System.Drawing.Color.Peru;
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(512, 29);
            this.pbLoading.TabIndex = 0;
            // 
            // LoadingScreenUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panLoadingBar);
            this.Controls.Add(this.panel1);
            this.Name = "LoadingScreenUC";
            this.Size = new System.Drawing.Size(700, 494);
            this.Load += new System.EventHandler(this.LoadingScreenUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoading)).EndInit();
            this.panLoadingBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmpLoading;
        private System.Windows.Forms.Panel panLoadingBar;
        private System.Windows.Forms.Label lblLoadingPertge;
        private System.Windows.Forms.Timer timrLoadingBar;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}
