namespace GameAttempt.Start
{
    partial class GameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptions));
            this.gameOptionsUC1 = new GameAttempt.Components.GameOptionsUC();
            this.SuspendLayout();
            // 
            // gameOptionsUC1
            // 
            this.gameOptionsUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameOptionsUC1.BackgroundImage")));
            this.gameOptionsUC1.Location = new System.Drawing.Point(-3, -4);
            this.gameOptionsUC1.Name = "gameOptionsUC1";
            this.gameOptionsUC1.Size = new System.Drawing.Size(450, 536);
            this.gameOptionsUC1.TabIndex = 0;
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 516);
            this.Controls.Add(this.gameOptionsUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOptions";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOptions_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.GameOptionsUC gameOptionsUC1;
    }
}