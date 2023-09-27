namespace GameAttempt.Components
{
    partial class StartOptionsUC
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
            this.panOpt = new System.Windows.Forms.Panel();
            this.btnSound = new System.Windows.Forms.PictureBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnExit = new ePOSOne.btnProduct.Button_WOC();
            this.btnOptStart = new ePOSOne.btnProduct.Button_WOC();
            this.btnOpStart = new ePOSOne.btnProduct.Button_WOC();
            this.panOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panOpt
            // 
            this.panOpt.BackColor = System.Drawing.Color.Transparent;
            this.panOpt.BackgroundImage = global::GameAttempt.Properties.Resources.option_menu;
            this.panOpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panOpt.Controls.Add(this.btnSound);
            this.panOpt.Controls.Add(this.tbVolume);
            this.panOpt.Location = new System.Drawing.Point(44, 46);
            this.panOpt.Name = "panOpt";
            this.panOpt.Size = new System.Drawing.Size(343, 401);
            this.panOpt.TabIndex = 0;
            // 
            // btnSound
            // 
            this.btnSound.Image = global::GameAttempt.Properties.Resources.sound_on;
            this.btnSound.Location = new System.Drawing.Point(142, 260);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(50, 50);
            this.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSound.TabIndex = 1;
            this.btnSound.TabStop = false;
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbVolume.Location = new System.Drawing.Point(88, 160);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(162, 69);
            this.tbVolume.TabIndex = 0;
            this.tbVolume.Value = 50;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(0, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(100, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptStart
            // 
            this.btnOptStart.BackColor = System.Drawing.Color.Transparent;
            this.btnOptStart.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.btnOptStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptStart.BorderColor = System.Drawing.Color.Transparent;
            this.btnOptStart.ButtonColor = System.Drawing.Color.Yellow;
            this.btnOptStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptStart.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptStart.Location = new System.Drawing.Point(349, 469);
            this.btnOptStart.Name = "btnOptStart";
            this.btnOptStart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnOptStart.OnHoverButtonColor = System.Drawing.Color.SaddleBrown;
            this.btnOptStart.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOptStart.Size = new System.Drawing.Size(98, 54);
            this.btnOptStart.TabIndex = 1;
            this.btnOptStart.Text = "START";
            this.btnOptStart.TextColor = System.Drawing.Color.Black;
            this.btnOptStart.UseVisualStyleBackColor = false;
            this.btnOptStart.Click += new System.EventHandler(this.btnOptStart_Click);
            // 
            // btnOpStart
            // 
            this.btnOpStart.BackColor = System.Drawing.Color.Black;
            this.btnOpStart.BorderColor = System.Drawing.Color.Transparent;
            this.btnOpStart.ButtonColor = System.Drawing.Color.Yellow;
            this.btnOpStart.FlatAppearance.BorderSize = 0;
            this.btnOpStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpStart.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpStart.Location = new System.Drawing.Point(364, 476);
            this.btnOpStart.Name = "btnOpStart";
            this.btnOpStart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnOpStart.OnHoverButtonColor = System.Drawing.Color.Sienna;
            this.btnOpStart.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOpStart.Size = new System.Drawing.Size(83, 48);
            this.btnOpStart.TabIndex = 13;
            this.btnOpStart.Text = "START";
            this.btnOpStart.TextColor = System.Drawing.Color.Black;
            this.btnOpStart.UseVisualStyleBackColor = false;
            // 
            // StartOptionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptStart);
            this.Controls.Add(this.panOpt);
            this.Name = "StartOptionsUC";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.StartOptionsUC_Load);
            this.panOpt.ResumeLayout(false);
            this.panOpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOpt;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.PictureBox btnSound;
        private ePOSOne.btnProduct.Button_WOC btnOpStart;
        private ePOSOne.btnProduct.Button_WOC btnOptStart;
        private ePOSOne.btnProduct.Button_WOC btnExit;
    }
}
