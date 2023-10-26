namespace GameAttempt.GeneralScreens
{
    partial class WinningScreen
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
            this.winningScreenUC1 = new GameAttempt.Components.WinningScreenUC();
            this.SuspendLayout();
            // 
            // winningScreenUC1
            // 
            this.winningScreenUC1.BackColor = System.Drawing.Color.Transparent;
            this.winningScreenUC1.Location = new System.Drawing.Point(-60, -41);
            this.winningScreenUC1.Name = "winningScreenUC1";
            this.winningScreenUC1.Size = new System.Drawing.Size(810, 458);
            this.winningScreenUC1.TabIndex = 0;
            // 
            // WinningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winningScreenUC1);
            this.Name = "WinningScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinningScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.WinningScreenUC winningScreenUC1;
    }
}