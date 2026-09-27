using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Facial_recognitionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load embedded image (Method 1)
            var asm = Assembly.GetExecutingAssembly();
            using (var s = asm.GetManifestResourceStream("Facial_recognitionGUI.faceid_logo.png"))
            {
                if (s != null)
                    picLogo.Image = Image.FromStream(s);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            login.Show();
            this.Hide();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Sign_up_Page Signup = new Sign_up_Page();
            Signup.Show();
            this.Hide();
        }
    }
}
