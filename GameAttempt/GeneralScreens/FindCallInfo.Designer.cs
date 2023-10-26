namespace GameAttempt.GeneralScreens
{
    partial class FindCallInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCallInfo));
            this.InfoAreaInfo_btn = new System.Windows.Forms.Button();
            this.idenAreaInfo_lbl = new System.Windows.Forms.Label();
            this.IdenAdreaTitle_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // InfoAreaInfo_btn
            // 
            this.InfoAreaInfo_btn.BackColor = System.Drawing.Color.Transparent;
            this.InfoAreaInfo_btn.BackgroundImage = global::GameAttempt.Properties.Resources.red_X;
            this.InfoAreaInfo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoAreaInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoAreaInfo_btn.Location = new System.Drawing.Point(529, 77);
            this.InfoAreaInfo_btn.Name = "InfoAreaInfo_btn";
            this.InfoAreaInfo_btn.Size = new System.Drawing.Size(38, 39);
            this.InfoAreaInfo_btn.TabIndex = 4;
            this.InfoAreaInfo_btn.UseVisualStyleBackColor = false;
            this.InfoAreaInfo_btn.Click += new System.EventHandler(this.InfoAreaInfo_btn_Click);
            // 
            // idenAreaInfo_lbl
            // 
            this.idenAreaInfo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.idenAreaInfo_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idenAreaInfo_lbl.Location = new System.Drawing.Point(126, 139);
            this.idenAreaInfo_lbl.Name = "idenAreaInfo_lbl";
            this.idenAreaInfo_lbl.Size = new System.Drawing.Size(367, 265);
            this.idenAreaInfo_lbl.TabIndex = 6;
            this.idenAreaInfo_lbl.Text = resources.GetString("idenAreaInfo_lbl.Text");
            // 
            // IdenAdreaTitle_lbl
            // 
            this.IdenAdreaTitle_lbl.AutoSize = true;
            this.IdenAdreaTitle_lbl.BackColor = System.Drawing.Color.Transparent;
            this.IdenAdreaTitle_lbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdenAdreaTitle_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.IdenAdreaTitle_lbl.Location = new System.Drawing.Point(125, 79);
            this.IdenAdreaTitle_lbl.Name = "IdenAdreaTitle_lbl";
            this.IdenAdreaTitle_lbl.Size = new System.Drawing.Size(380, 29);
            this.IdenAdreaTitle_lbl.TabIndex = 5;
            this.IdenAdreaTitle_lbl.Text = "You have made it to the final level";
            this.IdenAdreaTitle_lbl.Click += new System.EventHandler(this.IdenAdreaTitle_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GameAttempt.Properties.Resources.witch1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(455, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 122);
            this.panel1.TabIndex = 7;
            // 
            // FindCallInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GameAttempt.Properties.Resources.PagesInfo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idenAreaInfo_lbl);
            this.Controls.Add(this.IdenAdreaTitle_lbl);
            this.Controls.Add(this.InfoAreaInfo_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindCallInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindCallInfo";
            this.Load += new System.EventHandler(this.FindCallInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoAreaInfo_btn;
        private System.Windows.Forms.Label idenAreaInfo_lbl;
        private System.Windows.Forms.Label IdenAdreaTitle_lbl;
        private System.Windows.Forms.Panel panel1;
    }
}