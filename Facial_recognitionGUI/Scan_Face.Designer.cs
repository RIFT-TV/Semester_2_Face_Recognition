namespace Facial_recognitionGUI
{
    partial class Scan_Face_Page
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
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Button35 = new System.Windows.Forms.Button();
            this.Button48 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // picCamera (camera preview area)
            //
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(163, 163, 163);
            this.picCamera.Location = new System.Drawing.Point(90, 30);
            this.picCamera.Size = new System.Drawing.Size(460, 260);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamera.TabIndex = 0;
            //
            // Label28 (Position your face in the frame)
            //
            this.Label28.AutoSize = false;
            this.Label28.Size = new System.Drawing.Size(640, 26);
            this.Label28.Location = new System.Drawing.Point(0, 296);
            this.Label28.Text = "Position your face in the frame";
            this.Label28.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Label28.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label28.TabIndex = 1;
            //
            // Button35 (Capture)
            //
            this.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button35.FlatAppearance.BorderSize = 0;
            this.Button35.BackColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button35.ForeColor = System.Drawing.Color.White;
            this.Button35.Font = new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.Button35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button35.Size = new System.Drawing.Size(290, 44);
            this.Button35.Location = new System.Drawing.Point(175, 336);
            this.Button35.Text = "Capture";
            this.Button35.UseVisualStyleBackColor = false;
            this.Button35.TabIndex = 2;
            this.Button35.Click += new System.EventHandler(this.Button35_Click);
            //
            // Button48 (Cancel)
            //
            this.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button48.FlatAppearance.BorderSize = 1;
            this.Button48.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button48.BackColor = System.Drawing.Color.White;
            this.Button48.ForeColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.Button48.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Button48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button48.Size = new System.Drawing.Size(180, 42);
            this.Button48.Location = new System.Drawing.Point(230, 390);
            this.Button48.Text = "Cancel";
            this.Button48.UseVisualStyleBackColor = false;
            this.Button48.TabIndex = 3;
            this.Button48.Click += new System.EventHandler(this.Button48_Click);
            //
            // Scan_Face_Page
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceID - Scan Face";
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this.Button35);
            this.Controls.Add(this.Button48);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Label Label28;
        private System.Windows.Forms.Button Button35;
        private System.Windows.Forms.Button Button48;
    }
}
