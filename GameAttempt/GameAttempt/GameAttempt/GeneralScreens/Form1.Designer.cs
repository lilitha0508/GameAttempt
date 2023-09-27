namespace GameAttempt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startPageUS1 = new GameAttempt.Components.StartPageUS();
            this.SuspendLayout();
            // 
            // startPageUS1
            // 
            this.startPageUS1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startPageUS1.BackgroundImage")));
            this.startPageUS1.Location = new System.Drawing.Point(-1, 0);
            this.startPageUS1.Name = "startPageUS1";
            this.startPageUS1.Size = new System.Drawing.Size(450, 545);
            this.startPageUS1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 537);
            this.ControlBox = false;
            this.Controls.Add(this.startPageUS1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.StartPageUS startPageUS1;
    }
}

