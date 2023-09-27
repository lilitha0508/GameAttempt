namespace GameAttempt.Components
{
    partial class GameOptionsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptionsUC));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameTaskGO = new System.Windows.Forms.Label();
            this.btnStartGO = new ePOSOne.btnProduct.Button_WOC();
            this.pbGamePick = new System.Windows.Forms.PictureBox();
            this.pbLeftArrow = new System.Windows.Forms.PictureBox();
            this.pbRightArrow = new System.Windows.Forms.PictureBox();
            this.imlstGameTaskImages = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(53, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Game Task";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GameAttempt.Properties.Resources.book_border2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblGameTaskGO);
            this.panel1.Controls.Add(this.btnStartGO);
            this.panel1.Controls.Add(this.pbGamePick);
            this.panel1.Controls.Add(this.pbLeftArrow);
            this.panel1.Controls.Add(this.pbRightArrow);
            this.panel1.Location = new System.Drawing.Point(64, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 373);
            this.panel1.TabIndex = 1;
            // 
            // lblGameTaskGO
            // 
            this.lblGameTaskGO.AutoSize = true;
            this.lblGameTaskGO.Font = new System.Drawing.Font("Wide Latin", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTaskGO.ForeColor = System.Drawing.Color.Maroon;
            this.lblGameTaskGO.Location = new System.Drawing.Point(61, 252);
            this.lblGameTaskGO.Name = "lblGameTaskGO";
            this.lblGameTaskGO.Size = new System.Drawing.Size(205, 15);
            this.lblGameTaskGO.TabIndex = 4;
            this.lblGameTaskGO.Text = "Select Game Task";
            // 
            // btnStartGO
            // 
            this.btnStartGO.BackColor = System.Drawing.Color.Black;
            this.btnStartGO.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.btnStartGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGO.BorderColor = System.Drawing.Color.Transparent;
            this.btnStartGO.ButtonColor = System.Drawing.Color.Maroon;
            this.btnStartGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGO.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGO.Location = new System.Drawing.Point(103, 300);
            this.btnStartGO.Name = "btnStartGO";
            this.btnStartGO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStartGO.OnHoverButtonColor = System.Drawing.Color.SaddleBrown;
            this.btnStartGO.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStartGO.Size = new System.Drawing.Size(115, 41);
            this.btnStartGO.TabIndex = 3;
            this.btnStartGO.Text = "START";
            this.btnStartGO.TextColor = System.Drawing.Color.Black;
            this.btnStartGO.UseVisualStyleBackColor = false;
            this.btnStartGO.Click += new System.EventHandler(this.btnStartGO_Click);
            // 
            // pbGamePick
            // 
            this.pbGamePick.Image = global::GameAttempt.Properties.Resources.PickTask;
            this.pbGamePick.Location = new System.Drawing.Point(103, 138);
            this.pbGamePick.Name = "pbGamePick";
            this.pbGamePick.Size = new System.Drawing.Size(115, 87);
            this.pbGamePick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGamePick.TabIndex = 2;
            this.pbGamePick.TabStop = false;
            // 
            // pbLeftArrow
            // 
            this.pbLeftArrow.Image = global::GameAttempt.Properties.Resources.icons8_arrow_96_left;
            this.pbLeftArrow.Location = new System.Drawing.Point(23, 157);
            this.pbLeftArrow.Name = "pbLeftArrow";
            this.pbLeftArrow.Size = new System.Drawing.Size(62, 55);
            this.pbLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftArrow.TabIndex = 1;
            this.pbLeftArrow.TabStop = false;
            this.pbLeftArrow.Click += new System.EventHandler(this.pbLeftArrow_Click);
            // 
            // pbRightArrow
            // 
            this.pbRightArrow.Image = global::GameAttempt.Properties.Resources.icons8_arrow_96;
            this.pbRightArrow.Location = new System.Drawing.Point(236, 157);
            this.pbRightArrow.Name = "pbRightArrow";
            this.pbRightArrow.Size = new System.Drawing.Size(58, 55);
            this.pbRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightArrow.TabIndex = 0;
            this.pbRightArrow.TabStop = false;
            this.pbRightArrow.Click += new System.EventHandler(this.pbRightArrow_Click);
            // 
            // imlstGameTaskImages
            // 
            this.imlstGameTaskImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlstGameTaskImages.ImageStream")));
            this.imlstGameTaskImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imlstGameTaskImages.Images.SetKeyName(0, "book on shelf.png");
            this.imlstGameTaskImages.Images.SetKeyName(1, "book with numbers.png");
            this.imlstGameTaskImages.Images.SetKeyName(2, "book with flying letters.png");
            // 
            // GameOptionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "GameOptionsUC";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.GameOptionsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRightArrow;
        private System.Windows.Forms.PictureBox pbLeftArrow;
        private System.Windows.Forms.PictureBox pbGamePick;
        private ePOSOne.btnProduct.Button_WOC btnStartGO;
        private System.Windows.Forms.Label lblGameTaskGO;
        private System.Windows.Forms.ImageList imlstGameTaskImages;
    }
}
