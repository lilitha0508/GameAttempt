namespace GameAttempt.Start
{
    partial class LoadingScreen
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
            this.loadingScreenUC1 = new GameAttempt.Components.LoadingScreenUC();
            this.SuspendLayout();
            // 
            // loadingScreenUC1
            // 
            this.loadingScreenUC1.BackColor = System.Drawing.Color.Black;
            this.loadingScreenUC1.Location = new System.Drawing.Point(-29, -40);
            this.loadingScreenUC1.Name = "loadingScreenUC1";
            this.loadingScreenUC1.Size = new System.Drawing.Size(665, 494);
            this.loadingScreenUC1.TabIndex = 0;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.loadingScreenUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.LoadingScreenUC loadingScreenUC1;
    }
}