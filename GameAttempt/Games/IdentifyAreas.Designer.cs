namespace GameAttempt.Games
{
    partial class IdentifyAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyAreas));
            this.identifyAreaUC1 = new GameAttempt.Components.IdentifyAreaUC();
            this.SuspendLayout();
            // 
            // identifyAreaUC1
            // 
            this.identifyAreaUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("identifyAreaUC1.BackgroundImage")));
            this.identifyAreaUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.identifyAreaUC1.Location = new System.Drawing.Point(0, -1);
            this.identifyAreaUC1.Name = "identifyAreaUC1";
            this.identifyAreaUC1.Size = new System.Drawing.Size(1439, 980);
            this.identifyAreaUC1.TabIndex = 0;
            // 
            // IdentifyAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 952);
            this.Controls.Add(this.identifyAreaUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdentifyAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdentifyAreas";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.IdentifyAreaUC identifyAreaUC1;
    }
}