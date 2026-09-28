namespace Facial_recognitionGUI
{
    partial class Intro_page
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.Button59 = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblFullNameHeading = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.lblEmailHeading = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(250, 400);
            this.pnlLeft.TabIndex = 0;
            //
            // Button59 (Back)
            //
            this.Button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button59.FlatAppearance.BorderSize = 0;
            this.Button59.BackColor = System.Drawing.Color.Transparent;
            this.Button59.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.Button59.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Button59.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button59.Size = new System.Drawing.Size(80, 32);
            this.Button59.Location = new System.Drawing.Point(12, 12);
            this.Button59.Text = "Back";
            this.Button59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button59.UseVisualStyleBackColor = false;
            this.Button59.TabIndex = 0;
            this.Button59.Click += new System.EventHandler(this.Button59_Click);
            //
            // picLogo
            //
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.Location = new System.Drawing.Point(60, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.TabIndex = 1;
            //
            // Label28 (greeting — set to "Hello, <name>!" in code)
            //
            this.Label28.AutoSize = false;
            this.Label28.Size = new System.Drawing.Size(250, 34);
            this.Label28.Location = new System.Drawing.Point(0, 215);
            this.Label28.Text = "Hello!";
            this.Label28.Font = new System.Drawing.Font("Segoe UI", 15.75F,
                System.Drawing.FontStyle.Bold);
            this.Label28.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.Label28.BackColor = System.Drawing.Color.Transparent;
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label28.TabIndex = 2;
            //
            // Label10 (subtitle)
            //
            this.Label10.AutoSize = false;
            this.Label10.Size = new System.Drawing.Size(250, 24);
            this.Label10.Location = new System.Drawing.Point(0, 253);
            this.Label10.Text = "Welcome to your FaceID account";
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label10.TabIndex = 3;
            //
            // pnlRight
            //
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Location = new System.Drawing.Point(250, 0);
            this.pnlRight.Size = new System.Drawing.Size(390, 400);
            this.pnlRight.TabIndex = 1;
            //
            // lblFullNameHeading
            //
            this.lblFullNameHeading.AutoSize = false;
            this.lblFullNameHeading.Size = new System.Drawing.Size(300, 20);
            this.lblFullNameHeading.Location = new System.Drawing.Point(45, 80);
            this.lblFullNameHeading.Text = "Full Name";
            this.lblFullNameHeading.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                System.Drawing.FontStyle.Bold);
            this.lblFullNameHeading.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblFullNameHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullNameHeading.TabIndex = 4;
            //
            // Label57 (the user's full name — set in code)
            //
            this.Label57.AutoSize = false;
            this.Label57.Size = new System.Drawing.Size(300, 36);
            this.Label57.Location = new System.Drawing.Point(45, 104);
            this.Label57.Text = "—";
            this.Label57.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Label57.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.Label57.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label57.TabIndex = 5;
            //
            // lblEmailHeading
            //
            this.lblEmailHeading.AutoSize = false;
            this.lblEmailHeading.Size = new System.Drawing.Size(300, 20);
            this.lblEmailHeading.Location = new System.Drawing.Point(45, 160);
            this.lblEmailHeading.Text = "Email Address";
            this.lblEmailHeading.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                System.Drawing.FontStyle.Bold);
            this.lblEmailHeading.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblEmailHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailHeading.TabIndex = 6;
            //
            // Label58 (the user's email — set in code)
            //
            this.Label58.AutoSize = false;
            this.Label58.Size = new System.Drawing.Size(300, 36);
            this.Label58.Location = new System.Drawing.Point(45, 184);
            this.Label58.Text = "—";
            this.Label58.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Label58.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.Label58.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label58.TabIndex = 7;
            //
            // Intro_page
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceID - Home";
            this.pnlLeft.Controls.Add(this.Button59);
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.Label28);
            this.pnlLeft.Controls.Add(this.Label10);
            this.pnlRight.Controls.Add(this.lblFullNameHeading);
            this.pnlRight.Controls.Add(this.Label57);
            this.pnlRight.Controls.Add(this.lblEmailHeading);
            this.pnlRight.Controls.Add(this.Label58);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button Button59;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label Label28;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblFullNameHeading;
        private System.Windows.Forms.Label Label57;
        private System.Windows.Forms.Label lblEmailHeading;
        private System.Windows.Forms.Label Label58;
    }
}
