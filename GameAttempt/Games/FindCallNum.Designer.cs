namespace GameAttempt.Games
{
    partial class FindCallNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCallNum));
            this.findCallNumUC1 = new GameAttempt.Components.FindCallNumUC();
            this.SuspendLayout();
            // 
            // findCallNumUC1
            // 
            this.findCallNumUC1.BackColor = System.Drawing.Color.White;
            this.findCallNumUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findCallNumUC1.BackgroundImage")));
            this.findCallNumUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findCallNumUC1.Location = new System.Drawing.Point(-5, -2);
            this.findCallNumUC1.Name = "findCallNumUC1";
            this.findCallNumUC1.Size = new System.Drawing.Size(1319, 1022);
            this.findCallNumUC1.TabIndex = 0;
            // 
            // FindCallNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 1815);
            this.Controls.Add(this.findCallNumUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindCallNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindCallNum";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FindCallNumUC findCallNumUC1;
    }
}