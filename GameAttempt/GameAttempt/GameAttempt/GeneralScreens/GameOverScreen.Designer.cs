namespace GameAttempt.GeneralScreens
{
    partial class GameOverScreen
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
            this.gameOverUC1 = new GameAttempt.Components.GameOverUC();
            this.SuspendLayout();
            // 
            // gameOverUC1
            // 
            this.gameOverUC1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameOverUC1.Location = new System.Drawing.Point(-1, -4);
            this.gameOverUC1.Name = "gameOverUC1";
            this.gameOverUC1.Size = new System.Drawing.Size(741, 399);
            this.gameOverUC1.TabIndex = 0;
            this.gameOverUC1.Load += new System.EventHandler(this.gameOverUC1_Load);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 395);
            this.ControlBox = false;
            this.Controls.Add(this.gameOverUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.GameOverUC gameOverUC1;
    }
}