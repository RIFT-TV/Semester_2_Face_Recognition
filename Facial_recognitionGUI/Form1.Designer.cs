namespace Facial_recognitionGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // picLogo
            //
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.Location = new System.Drawing.Point(215, 25);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Name = "picLogo";
            this.picLogo.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(560, 55);
            this.lblTitle.Location = new System.Drawing.Point(0, 160);
            this.lblTitle.Text = "FaceID";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 34F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TabIndex = 1;
            //
            // lblTagline
            //
            this.lblTagline.AutoSize = false;
            this.lblTagline.Size = new System.Drawing.Size(560, 30);
            this.lblTagline.Location = new System.Drawing.Point(0, 218);
            this.lblTagline.Text = "Secure. Fast. Simple.";
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.TabIndex = 2;
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = false;
            this.lblDescription.Size = new System.Drawing.Size(560, 45);
            this.lblDescription.Location = new System.Drawing.Point(0, 252);
            this.lblDescription.Text = "Use facial recognition to access\r\nyour account safely.";
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.TabIndex = 3;
            //
            // Button1 (Login)
            //
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.BackColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Size = new System.Drawing.Size(140, 46);
            this.Button1.Location = new System.Drawing.Point(130, 315);
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.TabIndex = 4;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            //
            // Button0 (Sign Up)
            //
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.FlatAppearance.BorderSize = 1;
            this.Button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button0.BackColor = System.Drawing.Color.White;
            this.Button0.ForeColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button0.Size = new System.Drawing.Size(140, 46);
            this.Button0.Location = new System.Drawing.Point(290, 315);
            this.Button0.Text = "Sign Up";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.TabIndex = 5;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceID - Home";
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button0);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button0;
    }
}
