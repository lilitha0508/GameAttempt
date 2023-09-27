namespace GameAttempt.Games
{
    partial class ReplacingBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplacingBooks));
            this.replacingBooksUC1 = new GameAttempt.Components.ReplacingBooksUC();
            this.SuspendLayout();
            // 
            // replacingBooksUC1
            // 
            this.replacingBooksUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replacingBooksUC1.BackgroundImage")));
            this.replacingBooksUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replacingBooksUC1.Location = new System.Drawing.Point(0, 0);
            this.replacingBooksUC1.Name = "replacingBooksUC1";
            this.replacingBooksUC1.Size = new System.Drawing.Size(1157, 715);
            this.replacingBooksUC1.TabIndex = 0;
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 715);
            this.Controls.Add(this.replacingBooksUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplacingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacingBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ReplacingBooksUC replacingBooksUC1;
    }
}