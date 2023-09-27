namespace GameAttempt.GeneralScreens
{
    partial class StoryLine
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
            this.storyLineUC1 = new GameAttempt.Components.StoryLineUC();
            this.SuspendLayout();
            // 
            // storyLineUC1
            // 
            this.storyLineUC1.Location = new System.Drawing.Point(0, 0);
            this.storyLineUC1.Name = "storyLineUC1";
            this.storyLineUC1.Size = new System.Drawing.Size(1004, 601);
            this.storyLineUC1.TabIndex = 0;
            // 
            // StoryLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 601);
            this.ControlBox = false;
            this.Controls.Add(this.storyLineUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoryLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoryLine";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.StoryLineUC storyLineUC1;
    }
}