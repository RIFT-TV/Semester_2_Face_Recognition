namespace Facial_recognitionGUI
{
    partial class Login_Page
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
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEye = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pOrLeft = new System.Windows.Forms.Panel();
            this.lblOr = new System.Windows.Forms.Label();
            this.pOrRight = new System.Windows.Forms.Panel();
            this.btnScanFace = new System.Windows.Forms.Button();
            this.lblForgot = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(250, 420);
            this.pnlLeft.TabIndex = 0;
            //
            // btnBack
            //
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // picLogo
            //
            this.picLogo.Size = new System.Drawing.Size(140, 140);
            this.picLogo.Location = new System.Drawing.Point(55, 88);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.TabIndex = 1;
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Size = new System.Drawing.Size(250, 34);
            this.lblWelcome.Location = new System.Drawing.Point(0, 243);
            this.lblWelcome.Text = "Welcome Back!";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F,
                System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.TabIndex = 2;
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Size = new System.Drawing.Size(250, 24);
            this.lblSubtitle.Location = new System.Drawing.Point(0, 280);
            this.lblSubtitle.Text = "Login to continue";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitle.TabIndex = 3;
            //
            // pnlRight
            //
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Location = new System.Drawing.Point(250, 0);
            this.pnlRight.Size = new System.Drawing.Size(390, 420);
            this.pnlRight.TabIndex = 1;
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = false;
            this.lblUsername.Size = new System.Drawing.Size(300, 20);
            this.lblUsername.Location = new System.Drawing.Point(45, 40);
            this.lblUsername.Text = "Username";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.TabIndex = 0;
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(45, 64);
            this.txtUsername.Size = new System.Drawing.Size(300, 36);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.PlaceholderText = "Enter your username";
            this.txtUsername.TabIndex = 1;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = false;
            this.lblPassword.Size = new System.Drawing.Size(300, 20);
            this.lblPassword.Location = new System.Drawing.Point(45, 118);
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.TabIndex = 2;
            //
            // txtPassword
            //
            this.txtPassword.AutoSize = false;
            this.txtPassword.Location = new System.Drawing.Point(45, 142);
            this.txtPassword.Size = new System.Drawing.Size(300, 36);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TabIndex = 3;
            //
            // btnEye (show/hide password)
            //
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.BackColor = System.Drawing.Color.White;
            this.btnEye.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.btnEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye.Size = new System.Drawing.Size(32, 26);
            this.btnEye.Location = new System.Drawing.Point(305, 147);
            this.btnEye.Text = "👁";
            this.btnEye.TabStop = false;
            this.btnEye.TabIndex = 4;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            //
            // btnLogin
            //
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Size = new System.Drawing.Size(300, 44);
            this.btnLogin.Location = new System.Drawing.Point(45, 198);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            //
            // pOrLeft / lblOr / pOrRight (divider)
            //
            this.pOrLeft.BackColor = System.Drawing.Color.FromArgb(218, 220, 224);
            this.pOrLeft.Location = new System.Drawing.Point(45, 261);
            this.pOrLeft.Size = new System.Drawing.Size(110, 1);
            this.lblOr.AutoSize = false;
            this.lblOr.Size = new System.Drawing.Size(80, 20);
            this.lblOr.Location = new System.Drawing.Point(155, 251);
            this.lblOr.Text = "OR";
            this.lblOr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOr.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblOr.BackColor = System.Drawing.Color.White;
            this.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pOrRight.BackColor = System.Drawing.Color.FromArgb(218, 220, 224);
            this.pOrRight.Location = new System.Drawing.Point(235, 261);
            this.pOrRight.Size = new System.Drawing.Size(110, 1);
            //
            // btnScanFace
            //
            this.btnScanFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanFace.FlatAppearance.BorderSize = 1;
            this.btnScanFace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.btnScanFace.BackColor = System.Drawing.Color.White;
            this.btnScanFace.ForeColor = System.Drawing.Color.FromArgb(47, 111, 237);
            this.btnScanFace.Font = new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.btnScanFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanFace.Size = new System.Drawing.Size(300, 44);
            this.btnScanFace.Location = new System.Drawing.Point(45, 291);
            this.btnScanFace.Text = "Scan Face";
            this.btnScanFace.UseVisualStyleBackColor = false;
            this.btnScanFace.TabIndex = 6;
            this.btnScanFace.Click += new System.EventHandler(this.btnScanFace_Click);
            //
            // lblForgot / lblSignUp
            //
            this.lblForgot.AutoSize = false;
            this.lblForgot.Size = new System.Drawing.Size(160, 24);
            this.lblForgot.Location = new System.Drawing.Point(45, 358);
            this.lblForgot.Text = "Forgot Password?";
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblForgot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.TabIndex = 7;
            this.lblSignUp.AutoSize = false;
            this.lblSignUp.Size = new System.Drawing.Size(160, 24);
            this.lblSignUp.Location = new System.Drawing.Point(185, 358);
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.TabIndex = 8;
            //
            // LoginForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AcceptButton = this.btnLogin;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceID - Login";
            this.pnlLeft.Controls.Add(this.btnBack);
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.lblWelcome);
            this.pnlLeft.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.btnEye);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.pOrLeft);
            this.pnlRight.Controls.Add(this.lblOr);
            this.pnlRight.Controls.Add(this.pOrRight);
            this.pnlRight.Controls.Add(this.btnScanFace);
            this.pnlRight.Controls.Add(this.lblForgot);
            this.pnlRight.Controls.Add(this.lblSignUp);
            this.btnEye.BringToFront(); // keeps the eye visible on top of the password box
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pOrLeft;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Panel pOrRight;
        private System.Windows.Forms.Button btnScanFace;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lblSignUp;
    }
}
