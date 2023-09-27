namespace GameAttempt.Components
{
    partial class StartPageUS
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
            this.panStrtMen = new System.Windows.Forms.Panel();
            this.lblStrtTit = new System.Windows.Forms.Label();
            this.btnExit = new ePOSOne.btnProduct.Button_WOC();
            this.btnOpt = new ePOSOne.btnProduct.Button_WOC();
            this.btnStrt = new ePOSOne.btnProduct.Button_WOC();
            this.panStrtMen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panStrtMen
            // 
            this.panStrtMen.BackColor = System.Drawing.Color.Transparent;
            this.panStrtMen.Controls.Add(this.btnExit);
            this.panStrtMen.Controls.Add(this.btnOpt);
            this.panStrtMen.Controls.Add(this.btnStrt);
            this.panStrtMen.Controls.Add(this.lblStrtTit);
            this.panStrtMen.Location = new System.Drawing.Point(51, 44);
            this.panStrtMen.Name = "panStrtMen";
            this.panStrtMen.Size = new System.Drawing.Size(343, 401);
            this.panStrtMen.TabIndex = 0;
            // 
            // lblStrtTit
            // 
            this.lblStrtTit.AutoSize = true;
            this.lblStrtTit.BackColor = System.Drawing.Color.Transparent;
            this.lblStrtTit.Font = new System.Drawing.Font("Snap ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrtTit.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblStrtTit.Location = new System.Drawing.Point(15, 20);
            this.lblStrtTit.Name = "lblStrtTit";
            this.lblStrtTit.Size = new System.Drawing.Size(313, 42);
            this.lblStrtTit.TabIndex = 8;
            this.lblStrtTit.Text = "BOOK MASTER";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonColor = System.Drawing.Color.Brown;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(99, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Sienna;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(157, 48);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpt
            // 
            this.btnOpt.BackColor = System.Drawing.Color.Black;
            this.btnOpt.BorderColor = System.Drawing.Color.Transparent;
            this.btnOpt.ButtonColor = System.Drawing.Color.Brown;
            this.btnOpt.FlatAppearance.BorderSize = 0;
            this.btnOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpt.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpt.Location = new System.Drawing.Point(99, 209);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnOpt.OnHoverButtonColor = System.Drawing.Color.Sienna;
            this.btnOpt.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOpt.Size = new System.Drawing.Size(157, 48);
            this.btnOpt.TabIndex = 10;
            this.btnOpt.Text = "OPTIONS";
            this.btnOpt.TextColor = System.Drawing.Color.Black;
            this.btnOpt.UseVisualStyleBackColor = false;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // btnStrt
            // 
            this.btnStrt.BackColor = System.Drawing.Color.Black;
            this.btnStrt.BorderColor = System.Drawing.Color.Transparent;
            this.btnStrt.ButtonColor = System.Drawing.Color.Brown;
            this.btnStrt.FlatAppearance.BorderSize = 0;
            this.btnStrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrt.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrt.Location = new System.Drawing.Point(99, 126);
            this.btnStrt.Name = "btnStrt";
            this.btnStrt.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnStrt.OnHoverButtonColor = System.Drawing.Color.Sienna;
            this.btnStrt.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStrt.Size = new System.Drawing.Size(157, 48);
            this.btnStrt.TabIndex = 9;
            this.btnStrt.Text = "START";
            this.btnStrt.TextColor = System.Drawing.Color.Black;
            this.btnStrt.UseVisualStyleBackColor = false;
            this.btnStrt.Click += new System.EventHandler(this.btnStrt_Click);
            // 
            // StartPageUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameAttempt.Properties.Resources.startback1;
            this.Controls.Add(this.panStrtMen);
            this.Name = "StartPageUS";
            this.Size = new System.Drawing.Size(450, 500);
            this.Load += new System.EventHandler(this.StartPageUS_Load);
            this.panStrtMen.ResumeLayout(false);
            this.panStrtMen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panStrtMen;
        private ePOSOne.btnProduct.Button_WOC btnExit;
        private ePOSOne.btnProduct.Button_WOC btnOpt;
        private ePOSOne.btnProduct.Button_WOC btnStrt;
        private System.Windows.Forms.Label lblStrtTit;
    }
}
