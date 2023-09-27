namespace GameAttempt.Components
{
    partial class StoryLineUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoryLineUC));
            this.wmpStoryLine = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSkipStory = new System.Windows.Forms.Button();
            this.tmrStoryLine = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpStoryLine)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpStoryLine
            // 
            this.wmpStoryLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpStoryLine.Enabled = true;
            this.wmpStoryLine.Location = new System.Drawing.Point(0, 0);
            this.wmpStoryLine.Name = "wmpStoryLine";
            this.wmpStoryLine.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpStoryLine.OcxState")));
            this.wmpStoryLine.Size = new System.Drawing.Size(1004, 601);
            this.wmpStoryLine.TabIndex = 0;
            // 
            // btnSkipStory
            // 
            this.btnSkipStory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSkipStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipStory.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipStory.ForeColor = System.Drawing.Color.Black;
            this.btnSkipStory.Location = new System.Drawing.Point(888, 3);
            this.btnSkipStory.Name = "btnSkipStory";
            this.btnSkipStory.Size = new System.Drawing.Size(98, 45);
            this.btnSkipStory.TabIndex = 1;
            this.btnSkipStory.Text = "Skip";
            this.btnSkipStory.UseVisualStyleBackColor = false;
            this.btnSkipStory.Click += new System.EventHandler(this.btnSkipStory_Click);
            // 
            // tmrStoryLine
            // 
            this.tmrStoryLine.Tick += new System.EventHandler(this.tmrStoryLine_Tick);
            // 
            // StoryLineUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSkipStory);
            this.Controls.Add(this.wmpStoryLine);
            this.Name = "StoryLineUC";
            this.Size = new System.Drawing.Size(1004, 601);
            this.Load += new System.EventHandler(this.StoryLineUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpStoryLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpStoryLine;
        private System.Windows.Forms.Button btnSkipStory;
        private System.Windows.Forms.Timer tmrStoryLine;
    }
}
