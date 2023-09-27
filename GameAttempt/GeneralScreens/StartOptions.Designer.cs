namespace GameAttempt
{
    partial class StartOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartOptions));
            this.startOptionsUC2 = new GameAttempt.Components.StartOptionsUC();
            this.startOptionsUC1 = new GameAttempt.Components.StartOptionsUC();
            this.SuspendLayout();
            // 
            // startOptionsUC2
            // 
            this.startOptionsUC2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startOptionsUC2.BackgroundImage")));
            this.startOptionsUC2.Location = new System.Drawing.Point(-2, -5);
            this.startOptionsUC2.Name = "startOptionsUC2";
            this.startOptionsUC2.Size = new System.Drawing.Size(450, 545);
            this.startOptionsUC2.TabIndex = 0;
            // 
            // startOptionsUC1
            // 
            this.startOptionsUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startOptionsUC1.BackgroundImage")));
            this.startOptionsUC1.Location = new System.Drawing.Point(-4, 0);
            this.startOptionsUC1.Name = "startOptionsUC1";
            this.startOptionsUC1.Size = new System.Drawing.Size(450, 539);
            this.startOptionsUC1.TabIndex = 0;
            // 
            // StartOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 538);
            this.ControlBox = false;
            this.Controls.Add(this.startOptionsUC2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.StartOptionsUC startOptionsUC1;
        private Components.StartOptionsUC startOptionsUC2;
    }
}