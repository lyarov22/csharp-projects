namespace meteo
{
    partial class splashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreenForm));
            this.splashScreenTitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonStart = new Guna.UI2.WinForms.Guna2Button();
            this.buttonExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // splashScreenTitleLabel
            // 
            this.splashScreenTitleLabel.AllowParentOverrides = false;
            this.splashScreenTitleLabel.AutoEllipsis = false;
            this.splashScreenTitleLabel.AutoSize = false;
            this.splashScreenTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.splashScreenTitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.splashScreenTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.splashScreenTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashScreenTitleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.splashScreenTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.splashScreenTitleLabel.Name = "splashScreenTitleLabel";
            this.splashScreenTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splashScreenTitleLabel.Size = new System.Drawing.Size(784, 146);
            this.splashScreenTitleLabel.TabIndex = 0;
            this.splashScreenTitleLabel.Text = "Meteo App 1.0";
            this.splashScreenTitleLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.splashScreenTitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(-42, -109);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // buttonStart
            // 
            this.buttonStart.AutoRoundedCorners = true;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BorderColor = System.Drawing.Color.Transparent;
            this.buttonStart.BorderRadius = 21;
            this.buttonStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(302, 350);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(180, 45);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseTransparentBackground = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoRoundedCorners = true;
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BorderColor = System.Drawing.Color.Transparent;
            this.buttonExit.BorderRadius = 21;
            this.buttonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(302, 418);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 45);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseTransparentBackground = true;
            // 
            // splashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::meteo.Properties.Resources.splashScreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.splashScreenTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "splashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meteo App 1.0";
            this.Load += new System.EventHandler(this.splashScreenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel splashScreenTitleLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button buttonStart;
        private Guna.UI2.WinForms.Guna2Button buttonExit;
    }
}

