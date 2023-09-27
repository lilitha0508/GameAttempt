namespace GameAttempt.Components
{
    partial class GameOverUC
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
            this.lblGameOver = new System.Windows.Forms.Label();
            this.tmrGameOver = new System.Windows.Forms.Timer(this.components);
            this.btnGOvTryAgain = new System.Windows.Forms.Button();
            this.btnGOvExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Ravie", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Maroon;
            this.lblGameOver.Location = new System.Drawing.Point(146, 149);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(452, 69);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER";
            // 
            // tmrGameOver
            // 
            this.tmrGameOver.Tick += new System.EventHandler(this.tmrGameOver_Tick);
            // 
            // btnGOvTryAgain
            // 
            this.btnGOvTryAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnGOvTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGOvTryAgain.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGOvTryAgain.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGOvTryAgain.Location = new System.Drawing.Point(27, 341);
            this.btnGOvTryAgain.Name = "btnGOvTryAgain";
            this.btnGOvTryAgain.Size = new System.Drawing.Size(154, 44);
            this.btnGOvTryAgain.TabIndex = 1;
            this.btnGOvTryAgain.Text = "Try Again";
            this.btnGOvTryAgain.UseVisualStyleBackColor = false;
            this.btnGOvTryAgain.Click += new System.EventHandler(this.btnGOvTryAgain_Click);
            // 
            // btnGOvExit
            // 
            this.btnGOvExit.BackColor = System.Drawing.Color.Transparent;
            this.btnGOvExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGOvExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGOvExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGOvExit.Location = new System.Drawing.Point(563, 341);
            this.btnGOvExit.Name = "btnGOvExit";
            this.btnGOvExit.Size = new System.Drawing.Size(154, 44);
            this.btnGOvExit.TabIndex = 2;
            this.btnGOvExit.Text = "Exit";
            this.btnGOvExit.UseVisualStyleBackColor = false;
            this.btnGOvExit.Click += new System.EventHandler(this.btnGOvExit_Click);
            // 
            // GameOverUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnGOvExit);
            this.Controls.Add(this.btnGOvTryAgain);
            this.Controls.Add(this.lblGameOver);
            this.Name = "GameOverUC";
            this.Size = new System.Drawing.Size(741, 399);
            this.Load += new System.EventHandler(this.GameOverUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer tmrGameOver;
        private System.Windows.Forms.Button btnGOvTryAgain;
        private System.Windows.Forms.Button btnGOvExit;
    }
}
