namespace GameAttempt.GeneralScreens
{
    partial class IdenAreaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdenAreaInfo));
            this.IdenAdreaTitle_lbl = new System.Windows.Forms.Label();
            this.idenAreaInfo_lbl = new System.Windows.Forms.Label();
            this.idenAreaInfroWarn_lbl = new System.Windows.Forms.Label();
            this.InfoAreaInfo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdenAdreaTitle_lbl
            // 
            this.IdenAdreaTitle_lbl.AutoSize = true;
            this.IdenAdreaTitle_lbl.BackColor = System.Drawing.Color.Transparent;
            this.IdenAdreaTitle_lbl.Font = new System.Drawing.Font("Snap ITC", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdenAdreaTitle_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.IdenAdreaTitle_lbl.Location = new System.Drawing.Point(242, 40);
            this.IdenAdreaTitle_lbl.Name = "IdenAdreaTitle_lbl";
            this.IdenAdreaTitle_lbl.Size = new System.Drawing.Size(338, 29);
            this.IdenAdreaTitle_lbl.TabIndex = 0;
            this.IdenAdreaTitle_lbl.Text = "Welcome to Identify Area";
            // 
            // idenAreaInfo_lbl
            // 
            this.idenAreaInfo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.idenAreaInfo_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idenAreaInfo_lbl.Location = new System.Drawing.Point(120, 93);
            this.idenAreaInfo_lbl.Name = "idenAreaInfo_lbl";
            this.idenAreaInfo_lbl.Size = new System.Drawing.Size(262, 265);
            this.idenAreaInfo_lbl.TabIndex = 1;
            this.idenAreaInfo_lbl.Text = resources.GetString("idenAreaInfo_lbl.Text");
            // 
            // idenAreaInfroWarn_lbl
            // 
            this.idenAreaInfroWarn_lbl.BackColor = System.Drawing.Color.Transparent;
            this.idenAreaInfroWarn_lbl.Font = new System.Drawing.Font("Ravie", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idenAreaInfroWarn_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idenAreaInfroWarn_lbl.Location = new System.Drawing.Point(439, 93);
            this.idenAreaInfroWarn_lbl.Name = "idenAreaInfroWarn_lbl";
            this.idenAreaInfroWarn_lbl.Size = new System.Drawing.Size(244, 265);
            this.idenAreaInfroWarn_lbl.TabIndex = 2;
            this.idenAreaInfroWarn_lbl.Text = "You only have 2 Attempts, \r\nAND remember the witch is still after you so be QUICK" +
    " but precise\r\n\r\n      GOOD LUCK";
            // 
            // InfoAreaInfo_btn
            // 
            this.InfoAreaInfo_btn.BackColor = System.Drawing.Color.Transparent;
            this.InfoAreaInfo_btn.BackgroundImage = global::GameAttempt.Properties.Resources.red_X;
            this.InfoAreaInfo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoAreaInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoAreaInfo_btn.Location = new System.Drawing.Point(687, 38);
            this.InfoAreaInfo_btn.Name = "InfoAreaInfo_btn";
            this.InfoAreaInfo_btn.Size = new System.Drawing.Size(38, 39);
            this.InfoAreaInfo_btn.TabIndex = 3;
            this.InfoAreaInfo_btn.UseVisualStyleBackColor = false;
            this.InfoAreaInfo_btn.Click += new System.EventHandler(this.InfoAreaInfo_btn_Click);
            // 
            // IdenAreaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::GameAttempt.Properties.Resources.openBooktrans;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoAreaInfo_btn);
            this.Controls.Add(this.idenAreaInfroWarn_lbl);
            this.Controls.Add(this.idenAreaInfo_lbl);
            this.Controls.Add(this.IdenAdreaTitle_lbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdenAreaInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdenAreaInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdenAdreaTitle_lbl;
        private System.Windows.Forms.Label idenAreaInfo_lbl;
        private System.Windows.Forms.Label idenAreaInfroWarn_lbl;
        private System.Windows.Forms.Button InfoAreaInfo_btn;
    }
}